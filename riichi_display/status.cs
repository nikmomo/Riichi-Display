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
    // Define a partial class 'status' which extends 'Form'
    public partial class status : Form
    {
        // Declare an Image array to store the list of Dora indicators
        Image[] doraList;

        // Default constructor for the 'status' class
        public status()
        {
            // Call the InitializeComponent method from the designer file
            InitializeComponent();

            // Initialize doraList with image resources
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


        // Method to update the status of Kyutaku and Combo 
        // based on the 'StatusUpdateEvent'
        public void StatusUpdate(object sender, StatusUpdateEvent e)
        {
            // update the 'kyutaku' and 'combo' text fields
            kyutaku.Text = e.Kyutaku.ToString();
            combo.Text = e.Combo.ToString();
        }

        // Method to update the round text based on the 'RoundUpdateEvent'
        public void RoundUpdate(object sender, RoundUpdateEvent e)
        {
            // Update the 'round' text field
            round.Text = e.Round;
        }

        // Method to update the dora indicators based on the 'DoraUpdateEvent'
        public void DoraUpdate(object sender, DoraUpdateEvent e)
        {
            // Find the relevant control based on the dora number
            var control = this.Controls.Find("dora" + e.DoraNumber, true).FirstOrDefault();

            // If the control is not found, throw an exception
            if (control == null)
            {
                throw new Exception("Error @DoraUpdate, control not found! Index: " + e.DoraNumber);
            }

            // If the index of the dora is 0, make the control invisible
            if (e.Index == 0)
            {
                control.Visible = false;
            }
            else
            {
                // If the index is not 0, make the control visible and update 
                // its background image to the corresponding dora image
                control.Visible = true;
                control.BackgroundImage = doraList[e.Index];
            }
        }

    }
}