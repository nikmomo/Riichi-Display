/*
This file is part of Riichi Mahjong Livestreaming Display System.

Riichi Mahjong Livestreaming Display System is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Riichi Mahjong Livestreaming Display System is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Riichi Mahjong Livestreaming Display System.  If not, see <https://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riichi_display
{ 
    // The pointHandler class is used to handle point calculations.
    public class PointHandler
    {
        // Declare the fields for the class.
        private int kyutaku;
        private int combo;
        private int finalAddup; // Final adding up point to the player
        private int tenpai; // Number of tenpai players
        public event EventHandler<StatusUpdateEvent> StatusUpdateEvent;

        // Default constructor initializing kyutaku and combo to zero.
        public PointHandler()
        {
            kyutaku = 0;
            combo = 0;
            finalAddup = 0;
            tenpai = 0;
        }

        // Public properties for kyutaku and combo.
        public int Kyutaku {
            get { return kyutaku; }
            set
            {
                kyutaku = value;
                StatusUpdateEvent?.Invoke(this, new StatusUpdateEvent(Kyutaku, Combo)); // status display update event
            }
        }
        public int Combo { 
            get { return combo; } 
            set { 
                combo = value;
                StatusUpdateEvent?.Invoke(this, new StatusUpdateEvent(Kyutaku, Combo)); // status display update event
            } }
        public int Tenpai { get { return tenpai; } set { tenpai = value;  } }
        public int FinalAddup { get {
                var result = finalAddup;
                finalAddup = 0;
                return result; 
            }}

        // Calculate the total point when ron.
        // point - The base point.
        public int Ron(int point)
        {
            finalAddup = point + Kyutaku * 1000 + Combo * 300;
            return point + Combo * 300;
        }

        // Reset combo and kyutaku to zero.
        public void Reset() { Combo = 0; Kyutaku = 0; finalAddup = 0; tenpai = 0; }

        public int CalculatePoint(int hanIndex, int fuIndex, bool isDealer)
        {
            double result = 0;
            if (fuIndex > 11 || fuIndex < 0) // If fu is out of range then just return
                return 0;
            // Calculate point based on the formula
            if (hanIndex < 4 ) 
            {
                int[] fuList = { 20, 25, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120 };
                int baseRate = isDealer ? 6 : 4; // set the base rate for the formula, oya is 6, ko is 4
                result = baseRate * fuList[fuIndex] * Math.Pow(2, hanIndex + 3); // +3 because hanIndex starts from 0, +1 to the correct han +2 is in formula
                result = result > 8000 ? 8000 : result; // when they are larger than 8000, it equals to mangan
            }
            else
            {
                result = hanIndex == 4 ? 8000 : // handling the 5+ han
                         hanIndex == 5 ? 12000 :
                         hanIndex == 6 ? 16000 :
                         hanIndex == 7 ? 24000 :
                         hanIndex == 8 ? 32000 :
                         hanIndex == 9 ? 64000 :
                         hanIndex == 10 ? 96000 :
                         hanIndex == 11 ? 128000 :
                         hanIndex == 12 ? 160000 :
                         hanIndex == 13 ? 192000 : 0;
                result *= isDealer ? 1.5 : 1; // If it's dealer, * 1.5
            }

            return ToThousand(roundUp((int)result));
        }

        // Calculate the total point when oyatsumo, return the point that requires to pay by everyone
        // point - The base point.
        public int Oyatsumo(int point)
        {
            var result = ToThousand(roundUp(point / 3));
            finalAddup = (result + Combo * 100) * 3 + Kyutaku * 1000;
            return result + Combo * 100;
        }

        // Calculate the total points for both oya and ko when kotsumo.
        // point - The base point.
        public (int oya, int ko) Kotsumo(int point)
        {
            var oyaResult = ToThousand(roundUp(point / 2));
            var koResult = ToThousand(roundUp(point / 4));
            finalAddup = oyaResult + (Combo * 300) + 
               koResult * 2 + Kyutaku * 1000;
            return (oyaResult + Combo * 100, koResult + Combo * 100);
        }

        // Round up to the next 100
        private int roundUp(int value) 
        {
            int result = value % 100 != 0 ? value + 100 : value;
            return result;
        }

        // Increase combo by one.
        public void AddCombo() 
        { 
            Combo++;
        }

        // Increase kyutaku by one.
        public void AddKyutaku() 
        { 
            Kyutaku++; 
        }

        public int getKyutaku() { return Kyutaku; }

        public int getCombo() { return Combo; }

        public void setKyutaku(int value) 
        { 
            Kyutaku = value;
        }

        public void setCombo(int value) 
        { 
            Combo = value;
        }

        // Rounds a value down to the nearest thousand.
        // value - The value to round down.
        private int ToThousand(int value)
        {
            var result = value / 100;
            return result * 100;
        }
        public void clearRiichi() 
        { 
            Kyutaku = 0;
        }

        public void SendStatusUpdateEvent()
        {
            StatusUpdateEvent?.Invoke(this, new StatusUpdateEvent(Kyutaku, Combo));
        }

        public (int, int) GetTenpaiAddup()
        {
            // Determine the point exchange based on the number of players in Tenpai
            var receive = (Tenpai == 1) ? 3000 :
                          (Tenpai == 2) ? 1500 :
                          (Tenpai == 3) ? 1000 : 0;
            var pay = (Tenpai == 1) ? 1000 :
                      (Tenpai == 2) ? 1500 :
                      (Tenpai == 3) ? 3000 : 0;
            Console.WriteLine("Receive:" + receive + ", Pay: " + pay + ", tenapi: " + Tenpai);
            return (receive, pay);
        }
    }
}
