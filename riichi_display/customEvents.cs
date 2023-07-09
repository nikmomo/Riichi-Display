using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riichi_display
{
    public class TeamControlEvent : EventArgs { }

    public class WindChangeEvent : EventArgs { }

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
}
