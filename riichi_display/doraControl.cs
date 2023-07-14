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
    public partial class doraControl : Form
    {
        public event EventHandler<DoraUpdateEvent> DoraUpdateEvent;
        public doraControl()
        {
            InitializeComponent();
            foreach (Control control in this.Controls)
            {
                if (control.Tag != null && control.Tag.ToString() == "dora")
                {
                    ComboBox comboBox = control as ComboBox;
                    comboBox.SelectedIndexChanged += dora_SelectedIndexChanged;
                }
            }
        }

        private void dora_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox box = sender as ComboBox;
            int index = determinePlayer(box.Name);
            Console.WriteLine(box.Name + ", current selection: " + box.SelectedIndex);
            DoraUpdateEvent?.Invoke(sender, new DoraUpdateEvent(index, box.SelectedIndex)); // send dora update event
        }

        private int determinePlayer(string name)
        {
            int index = int.Parse(name[name.Length - 1].ToString());
            return index;
        }

        public void reset_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control.Tag != null && control.Tag.ToString() == "dora")
                {
                    ComboBox box = control as ComboBox;
                    box.SelectedIndex = 0;
                    int index = determinePlayer(box.Name);
                    DoraUpdateEvent?.Invoke(sender, new DoraUpdateEvent(index, box.SelectedIndex)); // send dora update event
                }
            }
        }
    }
}
