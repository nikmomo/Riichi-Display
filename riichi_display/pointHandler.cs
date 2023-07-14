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
        private int Kyutaku {
            get { return kyutaku; }
            set
            {
                kyutaku = value;
                StatusUpdateEvent?.Invoke(this, new StatusUpdateEvent(Kyutaku, Combo)); // status display update event
            }
        }
        private int Combo { 
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

        // Calculate the total point when oyatsumo, return the point that requires to pay by everyone
        // point - The base point.
        public int Oyatsumo(int point)
        {
            var result = point / 3;
            if (result % 100 != 0)
                result += 100;
            finalAddup = (ToThousand(result) + Combo * 100) * 3;
            return ToThousand(result) + Combo * 100;
        }

        // Calculate the total points for both oya and ko when kotsumo.
        // point - The base point.
        public (int oya, int ko) Kotsumo(int point)
        {
            var oyaResult = point / 2;
            var koResult = oyaResult / 2;
            if (oyaResult % 100 != 0)
                oyaResult += 100;
            if (koResult % 100 != 0)
                koResult += 100;
            finalAddup = ToThousand(oyaResult) + (Combo * 300) + 
                ToThousand(koResult) * 2 + Kyutaku * 1000;
            return (ToThousand(oyaResult) + Combo * 100, ToThousand(koResult) + Combo * 100);
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

    }
}
