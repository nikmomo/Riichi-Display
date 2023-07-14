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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace riichi_display
{
    public partial class display : Form
    {
        public display()
        {
            InitializeComponent();
        }
        
        public void RiichiSwitch(object sender, RiichiDisplayEvent e)
        {
            Control control = this.Controls.Find("riichi" + e.Index, true).FirstOrDefault() as System.Windows.Forms.Control;
            control.Visible = e.Show;
        }

        public void AddupUpdate(object sender, AddupDisplayEvent e)
        {
            if (e.Index == 42) // 42 means clear instruction sent
            {
                ClearAddupControlsAfterDelay();
            }
            else if (e.Point == 0)
            {
                return;
            }
            else // update the target addup
            {
                Control control = this.Controls.Find("addup" + e.Index, true).FirstOrDefault() as System.Windows.Forms.Control;
                control.Text = e.Point.ToString();
                if (e.Point < 0)
                {
                    control.ForeColor = Color.DarkRed;
                    control.Text = e.Point.ToString();
                }
                else
                {
                    control.ForeColor = Color.White;
                    control.Text = '+' + e.Point.ToString();
                }
                control.Visible = true;
                
                ClearAddupControlsAfterDelay();
            }
        }

        private void ClearAddupControlsAfterDelay()
        {
            Timer timer = new Timer();
            timer.Interval = 5000; // 5 seconds

            timer.Tick += (s, e) =>
            {
                addup0.Visible = false;
                addup1.Visible = false;
                addup2.Visible = false;
                addup3.Visible = false;
                ((Timer)s).Stop(); // Stop the timer to prevent it from ticking again
            };

            timer.Start();
        }

    }
}
