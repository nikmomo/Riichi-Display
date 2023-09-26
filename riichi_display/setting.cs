﻿/*
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
using System.IO;
using System.Diagnostics;
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
        public event EventHandler<FontUpdateEvent> OnFontUpdate;

        private FontType selectedType = FontType.NONE;
        private Font fontName { get; set; }
        private Font fontTeam { get; set; }
        private Font fontPoint { get; set; }
        private Font fontAddup { get; set; }

        public setting()//mainForm form, display displayform)
        {
            InitializeComponent();
            nameFont.Click += fontSetting_Clicked;
            pointFont.Click += fontSetting_Clicked;
            addupFont.Click += fontSetting_Clicked;
            teamFont.Click += fontSetting_Clicked;
        }

        private void hideTeam_Click(object sender, EventArgs e)
        {
            teamCtrlEvent?.Invoke(this, new TeamControlEvent());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindChgeEvent?.Invoke(this, new WindChangeEvent());
        }

        private void openFolder_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Process.Start("explorer.exe", Path.Combine(path, "RiichiLogs"));
        }

        // When any font button is clicked, handle the font setting
        private void fontSetting_Clicked(object sender, EventArgs e)
        {
            FontDialog fontEdit = new FontDialog();
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            switch (button.Name)
            {
                case "nameFont":
                    selectedType = FontType.NAME;
                    fontEdit.Font = fontName;
                    break;
                case "pointFont":
                    selectedType = FontType.POINT;
                    fontEdit.Font = fontPoint;
                    break;
                case "addupFont":
                    selectedType = FontType.ADDUP;
                    fontEdit.Font = fontAddup;
                    break;
                case "teamFont":
                    selectedType = FontType.TEAM;
                    fontEdit.Font = fontTeam;
                    break;
                default:
                    selectedType = FontType.NONE;
                    break;
            }

            // Send the updated font
            if (fontEdit.ShowDialog() == DialogResult.OK)
            {
                OnFontUpdate?.Invoke(this, new FontUpdateEvent(selectedType, fontEdit.Font));
            }
            switch (button.Name)
            {
                case "nameFont":
                    fontName = fontEdit.Font;
                    break;
                case "pointFont":
                    fontPoint = fontEdit.Font;
                    break;
                case "addupFont":
                    fontAddup = fontEdit.Font;
                    break;
                case "teamFont":
                    fontTeam = fontEdit.Font;
                    break;
                default:
                    selectedType = FontType.NONE;
                    break;
            }

        }

        public void OnStart(displayStatus memory)
        {
            fontName = memory.fontName;
            fontTeam = memory.fontTeam;
            fontPoint = memory.fontPoint;
            fontAddup = memory.fontAddup;

        }
    }
}
