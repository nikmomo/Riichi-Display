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
        private int Kyutaku { get { return kyutaku; }}
        private int Combo { get { return combo; } }
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
        public void Reset() { combo = 0; kyutaku = 0; finalAddup = 0; tenpai = 0; }

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
        public void AddCombo() { combo++; }

        // Increase kyutaku by one.
        public void AddKyutaku() { kyutaku++; }

        public int getKyutaku() { return kyutaku; }

        public int getCombo() { return combo; }

        public void setKyutaku(int value) 
        { 
            kyutaku = value;
            StatusUpdateEvent?.Invoke(this, new StatusUpdateEvent(Kyutaku, Combo)); // status display update event
        }

        public void setCombo(int value) 
        { 
            combo = value;
            StatusUpdateEvent?.Invoke(this, new StatusUpdateEvent(Kyutaku, Combo)); // status display update event
        }

        // Rounds a value down to the nearest thousand.
        // value - The value to round down.
        private int ToThousand(int value)
        {
            var result = value / 100;
            return result * 100;
        }
        public void clearRiichi() { kyutaku = 0; }

    }
}
