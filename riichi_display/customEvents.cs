﻿using System;
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

    public class WindowDisplayUpdateEvent : EventArgs { }
}
