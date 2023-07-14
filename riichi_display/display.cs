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
        // Initialize a timer with a 5-second interval
        private readonly Timer timer = new Timer { Interval = 5000 };

        public display()
        {
            InitializeComponent();

            // Define an event handler for the timer's Tick event
            timer.Tick += (s, e) =>
            {
                ClearAddupControls();
                // Stop the timer to prevent it from ticking again
                timer.Stop();
                // Dispose the timer
                timer.Dispose();
            };
        }

        public void RiichiSwitch(object sender, RiichiDisplayEvent e)
        {
            UpdateControlVisibility("riichi" + e.Index, e.Show);
        }

        public void AddupUpdate(object sender, AddupDisplayEvent e)
        {
            if (e.Index == 42)
            {
                timer.Start();
            }
            else if (e.Point != 0)
            {
                UpdateAddupControl("addup" + e.Index, e.Point);
                timer.Start();
            }
        }

        private void UpdateControlVisibility(string controlName, bool isVisible)
        {
            Control control = this.Controls.Find(controlName, true).FirstOrDefault();

            if (control != null)
            {
                control.Visible = isVisible;
            }
            else
            {
                throw new Exception($"Control with name {controlName} not found!");
            }
        }

        private void UpdateAddupControl(string controlName, int point)
        {
            Control control = this.Controls.Find(controlName, true).FirstOrDefault();

            if (control != null)
            {
                control.ForeColor = point < 0 ? Color.DarkRed : Color.White;
                control.Text = (point < 0 ? "" : "+") + point.ToString();
                control.Visible = true;
            }
            else
            {
                throw new Exception($"Control with name {controlName} not found!");
            }
        }

        private void ClearAddupControls()
        {
            addup0.Visible = false;
            addup1.Visible = false;
            addup2.Visible = false;
            addup3.Visible = false;
        }
    }
}
