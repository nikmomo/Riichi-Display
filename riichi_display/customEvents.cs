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
        public AddupDisplayEvent(int index, int point)
        {
            this.Index = index;
            this.Point = point;
        }

        public int Index { get; private set; }

        public int Point { get; private set; }
    }
}
