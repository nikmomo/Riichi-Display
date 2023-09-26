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
using System.Drawing;

namespace riichi_display
{
    // Empty event used for team control
    public class TeamControlEvent : EventArgs { }

    // Event used to change wind (player turn) in game
    public class WindChangeEvent : EventArgs
    {
        public WindChangeEvent() { }
        public WindChangeEvent(int signal) { Signal = signal; }
        // Signal property to control wind change direction or reset
        public int Signal { get; private set; }
    }

    // Base event used for updating various displays
    public class DisplayUpdateEvent : EventArgs
    {
        public DisplayUpdateEvent() { }
        public DisplayUpdateEvent(string tag) { Tag = tag; }
        // Tag property to differentiate display types
        public string Tag { get; private set; }
    }

    // Event to trigger point calculation
    public class PointCalculateEvent : EventArgs 
    {
        public PointCalculateEvent() { Value = ""; }
        public PointCalculateEvent(string value) { Value = value; }
        // Tag property to differentiate display types
        public string Value { get; private set; }
    }

    // Event for updating main form display
    public class FormDisplayUpdateEvent : DisplayUpdateEvent { }

    // Event for updating secondary display window
    public class DisplayWindowUpdateEvent : DisplayUpdateEvent
    {
        public DisplayWindowUpdateEvent(string tag) : base(tag)
        {
        }
    }

    // Event for updating add-up point display
    public class AddupDisplayEvent : EventArgs
    {
        public AddupDisplayEvent() { Index = 42; } // Default value to signal reset
        public AddupDisplayEvent(int index, int point)
        {
            this.Index = index;
            this.Point = point;
        }

        // Index of player whose add-up points are to be displayed
        public int Index { get; private set; }

        // Point value to be displayed
        public int Point { get; private set; }
    }

    // Event for showing or hiding Riichi stick display
    public class RiichiDisplayEvent : EventArgs
    {
        public RiichiDisplayEvent(int index, bool show)
        {
            this.Index = index;
            this.Show = show;
        }

        // Index of player for whom the display is affected
        public int Index { get; private set; }

        // Show or hide the Riichi stick
        public bool Show { get; private set; }
    }

    // Event to update game status displays (Kyutaku and Combo)
    public class StatusUpdateEvent : EventArgs
    {
        public StatusUpdateEvent(int kyutaku, int combo)
        {
            Kyutaku = kyutaku;
            Combo = combo;
        }

        // Number of sticks in the Kyutaku
        public int Kyutaku { get; private set; }

        // Combo count (number of consecutive hands won by the dealer)
        public int Combo { get; private set; }
    }

    // Event to update round display
    public class RoundUpdateEvent : EventArgs
    {
        public RoundUpdateEvent(string round)
        {
            Round = round;
        }
        // Current round of the game
        public string Round { get; private set; }
    }

    // Event to update Dora display
    public class DoraUpdateEvent : EventArgs
    {
        public DoraUpdateEvent(int doraNumber, int index)
        {
            DoraNumber = doraNumber;
            Index = index;
        }

        // Default constructor sets DoraNumber and Index to 42 to signal reset
        public DoraUpdateEvent()
        {
            DoraNumber = 42;
            Index = 42;
        }

        // Current Dora indicator number
        public int DoraNumber { get; private set; }

        // Index of player for whom the Dora indicator is displayed
        public int Index { get; private set; }
    }
    public enum FontType
    {
        NAME,
        TEAM,
        POINT,
        ADDUP,
        NONE
    };
    // Font Update Event that updaing the fonts 
    public class FontUpdateEvent : EventArgs
    {
        public FontUpdateEvent(FontType type, Font font)
        {
            Type = type;
            Font = font;
        }
        // contain the font type
        public FontType Type { get; private set; }
        public Font Font { get; private set; }
    }
}