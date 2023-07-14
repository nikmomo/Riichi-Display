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

using riichi_display.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace riichi_display
{
    public partial class status : Form
    {
        Image[] doraList; 
        public status()
        {
            InitializeComponent();
            doraList = new Image[]{
            null,
            Properties.Resources.s1,
            Properties.Resources.s2,
            Properties.Resources.s3,
            Properties.Resources.s4,
            Properties.Resources.s5,
            Properties.Resources.s6,
            Properties.Resources.s7,
            Properties.Resources.s8,
            Properties.Resources.s9,
            Properties.Resources.m1,
            Properties.Resources.m2,
            Properties.Resources.m3,
            Properties.Resources.m4,
            Properties.Resources.m5,
            Properties.Resources.m6,
            Properties.Resources.m7,
            Properties.Resources.m8,
            Properties.Resources.m9,
            Properties.Resources.p1,
            Properties.Resources.p2,
            Properties.Resources.p3,
            Properties.Resources.p4,
            Properties.Resources.p5,
            Properties.Resources.p6,
            Properties.Resources.p7,
            Properties.Resources.p8,
            Properties.Resources.p9,
            Properties.Resources.ze,
            Properties.Resources.zs,
            Properties.Resources.zw,
            Properties.Resources.zn,
            Properties.Resources.zwh,
            Properties.Resources.zg,
            Properties.Resources.zr
            };
        }

        public void StatusUpdate(object sender, StatusUpdateEvent e)
        {
            kyutaku.Text = e.Kyutaku.ToString();
            combo.Text = e.Combo.ToString();
        }

        public void RoundUpdate(object sender, RoundUpdateEvent e)
        {
            round.Text = e.Round;
        }

        public void DoraUpdate(object sender, DoraUpdateEvent e)
        {
            var control = this.Controls.Find("dora" + e.DoraNumber, true).FirstOrDefault();
            if (control == null) 
            {
                throw new Exception("Error @DoraUpdate, control not found! Index: " + e.DoraNumber);
            }
            if (e.Index == 0)
            {
                control.Visible = false;
            }
            else
            {
                control.Visible = true;
                control.BackgroundImage = doraList[e.Index];
            }
        }
    }
}
