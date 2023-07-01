using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riichi_display
{
    public class TeamControlEvent : EventArgs { }

    public class WindChangeEvent : EventArgs { }

    public class DisplayUpdateEvent : EventArgs { }

    public class PointCalculateEvent : EventArgs { }

    public class FormDisplayUpdateEvent : EventArgs { }

    public class DisplayWindowUpdateEvent : EventArgs { }

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
