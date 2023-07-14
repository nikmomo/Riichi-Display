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

namespace riichi_display
{
    partial class setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setting));
            this.hideTeam = new System.Windows.Forms.Button();
            this.windSwitch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hideTeam
            // 
            this.hideTeam.AutoSize = true;
            this.hideTeam.Location = new System.Drawing.Point(150, 33);
            this.hideTeam.Name = "hideTeam";
            this.hideTeam.Size = new System.Drawing.Size(151, 30);
            this.hideTeam.TabIndex = 48;
            this.hideTeam.Text = "关闭/启用团队名称";
            this.hideTeam.UseMnemonic = false;
            this.hideTeam.UseVisualStyleBackColor = true;
            this.hideTeam.Click += new System.EventHandler(this.hideTeam_Click);
            // 
            // windSwitch
            // 
            this.windSwitch.AutoSize = true;
            this.windSwitch.Location = new System.Drawing.Point(150, 78);
            this.windSwitch.Name = "windSwitch";
            this.windSwitch.Size = new System.Drawing.Size(151, 30);
            this.windSwitch.TabIndex = 49;
            this.windSwitch.Text = "场风切换";
            this.windSwitch.UseMnemonic = false;
            this.windSwitch.UseVisualStyleBackColor = true;
            this.windSwitch.Click += new System.EventHandler(this.button1_Click);
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 143);
            this.Controls.Add(this.windSwitch);
            this.Controls.Add(this.hideTeam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "setting";
            this.Text = "setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hideTeam;
        private System.Windows.Forms.Button windSwitch;
    }
}