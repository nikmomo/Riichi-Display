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
    public class TeamControlEvent : EventArgs { }

    public class WindChangeEvent : EventArgs 
    {
        public WindChangeEvent() { }
        public WindChangeEvent(int signal) { Signal = signal; }
        public int Signal { get; private set; }
    }

    public class DisplayUpdateEvent : EventArgs 
    {
        public DisplayUpdateEvent() { }
        public DisplayUpdateEvent(string tag) { Tag = tag; }
        public string Tag { get; private set; }
    }

    public class PointCalculateEvent : EventArgs { }

    public class FormDisplayUpdateEvent : DisplayUpdateEvent { }

    public class DisplayWindowUpdateEvent : DisplayUpdateEvent
    {
        public DisplayWindowUpdateEvent(string tag) : base(tag)
        {
        }
    }

    public class AddupDisplayEvent : EventArgs
    {
        public AddupDisplayEvent() { Index = 42; }
        public AddupDisplayEvent(int index, int point)
        {
            this.Index = index;
            this.Point = point;
        }

        public int Index { get; private set; }

        public int Point { get; private set; }
    }

    public class RiichiDisplayEvent : EventArgs
    {
        public RiichiDisplayEvent(int index, bool show)
        {
            this.Index = index;
            this.Show = show;
        }

        public int Index { get; private set; }
        public bool Show { get; private set; }
    }

    public class StatusUpdateEvent : EventArgs 
    {
        public StatusUpdateEvent(int kyutaku, int combo) 
        { 
            Kyutaku = kyutaku;
            Combo = combo;
        }
        public int Kyutaku { get; private set; }
        public int Combo { get; private set; }
    }

    public class RoundUpdateEvent : EventArgs
    {
        public RoundUpdateEvent(string round)
        {
            Round = round;
        }
        public string Round { get; private set; }
    }

    public class DoraUpdateEvent : EventArgs
    {
        public DoraUpdateEvent(int doraNumber, int index)
        {
            DoraNumber = doraNumber;
            Index = index;
        }
        public DoraUpdateEvent()
        {
            DoraNumber = 42;
            Index = 42;
        }
        public int DoraNumber { get; private set; }
        public int Index { get; private set; }
    }
}
