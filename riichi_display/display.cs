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

        private displayStatus stat = new displayStatus();
        //private bool riichiPosition = true; // Track if riichi stick is horinzontal or not, true as yes
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

        public void OnFontUpdate(object sender, FontUpdateEvent e)
        {
            UpdateFont(e.Type, e.Font);
        }

        private void UpdateFont(FontType type, Font font)
        {
            string tagToFind = null;
            switch (type)
            {
                case FontType.NAME:
                    tagToFind = "name";
                    stat.fontName = font;
                    break;
                case FontType.TEAM:
                    tagToFind = "team";
                    stat.fontTeam = font;
                    break;
                case FontType.POINT:
                    tagToFind = "point";
                    stat.fontPoint = font;
                    break;
                case FontType.ADDUP:
                    tagToFind = "addup";
                    stat.fontAddup = font;
                    break;
                default:
                    return;

            }
            foreach (Control control in Controls)
            {
                if (control.Tag != null && control.Tag.ToString() == tagToFind)
                {
                    control.Font = font;
                }
            }
        }


        //public void OnRiichiPoistionUpdate(object sender, EventArgs e)
        //{
        //    riichiPosition = !riichiPosition;
        //    UpdateRiichiPosition();
        //}

        //private void UpdateRiichiPosition()
        //{
        //    int xGap = 474;
        //    int yPos = riichiPosition ? 98 : 131;
        //    foreach (Control control in Controls)
        //    {
        //        if (control.Tag != null && control.Tag.ToString() == "riichi")
        //        {
        //            int index = getIndexOfControl(control.Name);
        //            if (riichiPosition)
        //            {
        //                control.Location = new Point(226 + index * xGap, yPos);
        //                control.Size = new Size(163, 18);
        //                control.BackgroundImage = riichi_display.Properties.Resources.riichiStick;
        //            }
        //            else
        //            {
        //                control.Location = new Point(445 + index * xGap, yPos);
        //                control.Size = new Size(20, 128);
        //                control.BackgroundImage = riichi_display.Properties.Resources.riichiStick_90degree;
        //            }
        //        }
        //    }
        //}


        public displayStatus OnClose()
        {
            stat.windIndicatorVisual = wind.Visible;
            stat.teamVisual = team0.Visible;
            //stat.RiichiPostion = riichiPosition;
            return stat;
        }

        public void OnStart(displayStatus memory)
        {
            stat = memory;
            OnFontUpdate(this, new FontUpdateEvent(FontType.NAME, stat.fontName));
            OnFontUpdate(this, new FontUpdateEvent(FontType.TEAM, stat.fontTeam));
            OnFontUpdate(this, new FontUpdateEvent(FontType.POINT, stat.fontPoint));
            OnFontUpdate(this, new FontUpdateEvent(FontType.ADDUP, stat.fontAddup));
            wind.Visible = stat.windIndicatorVisual;
            team0.Visible = stat.teamVisual;
            team1.Visible = stat.teamVisual;
            team2.Visible = stat.teamVisual;
            team3.Visible = stat.teamVisual;
            //riichiPosition = stat.RiichiPostion;
            //UpdateRiichiPosition();
        }

        private int getIndexOfControl(string name)
        {
            // Determine the player index based on the name
            int index = int.Parse(name[name.Length - 1].ToString());
            if (index > 3)
                throw new Exception("Invalid Index @getIndexOfControl!");
            return index;
        }
    }
}
