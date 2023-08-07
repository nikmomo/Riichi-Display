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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace riichi_display
{
    public partial class setting : Form
    {
        public event EventHandler<TeamControlEvent> teamCtrlEvent;
        public event EventHandler<WindChangeEvent> WindChgeEvent;

        private settingHandler Set;
        // TODO: Memorize the setting toggles, right now it's a bit conflicts with the toggles in main,
        //       thinkig to set the setting handler in main.cs instead of here
        private class settingHandler // Use for memorize the setting
        {
            bool teamEnabled { get; set; }
            bool windEnabled { get; set; }
        }
        public setting()//mainForm form, display displayform)
        {
            InitializeComponent();
            Set = new settingHandler();
        }

        private void hideTeam_Click(object sender, EventArgs e)
        {
            teamCtrlEvent?.Invoke(this, new TeamControlEvent());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindChgeEvent?.Invoke(this, new WindChangeEvent());
        }
    }
}
