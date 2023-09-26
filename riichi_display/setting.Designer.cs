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
            this.windIndicator = new System.Windows.Forms.Button();
            this.openFolder = new System.Windows.Forms.Button();
            this.newShortCut = new System.Windows.Forms.Button();
            this.nameFont = new System.Windows.Forms.Button();
            this.pointFont = new System.Windows.Forms.Button();
            this.addupFont = new System.Windows.Forms.Button();
            this.teamFont = new System.Windows.Forms.Button();
            this.fontBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearGamelog = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.riichiDisplay = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // hideTeam
            // 
            this.hideTeam.AutoSize = true;
            this.hideTeam.Location = new System.Drawing.Point(21, 51);
            this.hideTeam.Margin = new System.Windows.Forms.Padding(2);
            this.hideTeam.Name = "hideTeam";
            this.hideTeam.Size = new System.Drawing.Size(118, 24);
            this.hideTeam.TabIndex = 48;
            this.hideTeam.Text = "关闭/启用团队名称";
            this.hideTeam.UseMnemonic = false;
            this.hideTeam.UseVisualStyleBackColor = true;
            this.hideTeam.Click += new System.EventHandler(this.hideTeam_Click);
            // 
            // windSwitch
            // 
            this.windSwitch.AutoSize = true;
            this.windSwitch.Location = new System.Drawing.Point(21, 79);
            this.windSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.windSwitch.Name = "windSwitch";
            this.windSwitch.Size = new System.Drawing.Size(118, 24);
            this.windSwitch.TabIndex = 49;
            this.windSwitch.Text = "场风切换";
            this.windSwitch.UseMnemonic = false;
            this.windSwitch.UseVisualStyleBackColor = true;
            this.windSwitch.Click += new System.EventHandler(this.button1_Click);
            // 
            // windIndicator
            // 
            this.windIndicator.AutoSize = true;
            this.windIndicator.Location = new System.Drawing.Point(21, 23);
            this.windIndicator.Margin = new System.Windows.Forms.Padding(2);
            this.windIndicator.Name = "windIndicator";
            this.windIndicator.Size = new System.Drawing.Size(118, 24);
            this.windIndicator.TabIndex = 50;
            this.windIndicator.Text = "关闭/启用场风指示";
            this.windIndicator.UseMnemonic = false;
            this.windIndicator.UseVisualStyleBackColor = true;
            // 
            // openFolder
            // 
            this.openFolder.AutoSize = true;
            this.openFolder.Location = new System.Drawing.Point(27, 51);
            this.openFolder.Margin = new System.Windows.Forms.Padding(2);
            this.openFolder.Name = "openFolder";
            this.openFolder.Size = new System.Drawing.Size(118, 24);
            this.openFolder.TabIndex = 51;
            this.openFolder.Text = "打开Gamelog文件夹";
            this.openFolder.UseMnemonic = false;
            this.openFolder.UseVisualStyleBackColor = true;
            this.openFolder.Click += new System.EventHandler(this.openFolder_Click);
            // 
            // newShortCut
            // 
            this.newShortCut.AutoSize = true;
            this.newShortCut.Location = new System.Drawing.Point(27, 23);
            this.newShortCut.Margin = new System.Windows.Forms.Padding(2);
            this.newShortCut.Name = "newShortCut";
            this.newShortCut.Size = new System.Drawing.Size(118, 24);
            this.newShortCut.TabIndex = 52;
            this.newShortCut.Text = "创建桌面快捷方式";
            this.newShortCut.UseMnemonic = false;
            this.newShortCut.UseVisualStyleBackColor = true;
            // 
            // nameFont
            // 
            this.nameFont.AutoSize = true;
            this.nameFont.Location = new System.Drawing.Point(209, 35);
            this.nameFont.Margin = new System.Windows.Forms.Padding(2);
            this.nameFont.Name = "nameFont";
            this.nameFont.Size = new System.Drawing.Size(118, 24);
            this.nameFont.TabIndex = 53;
            this.nameFont.Text = "名称字体设置";
            this.nameFont.UseMnemonic = false;
            this.nameFont.UseVisualStyleBackColor = true;
            // 
            // pointFont
            // 
            this.pointFont.AutoSize = true;
            this.pointFont.Location = new System.Drawing.Point(209, 63);
            this.pointFont.Margin = new System.Windows.Forms.Padding(2);
            this.pointFont.Name = "pointFont";
            this.pointFont.Size = new System.Drawing.Size(118, 24);
            this.pointFont.TabIndex = 54;
            this.pointFont.Text = "点数字体设置";
            this.pointFont.UseMnemonic = false;
            this.pointFont.UseVisualStyleBackColor = true;
            // 
            // addupFont
            // 
            this.addupFont.AutoSize = true;
            this.addupFont.Location = new System.Drawing.Point(209, 91);
            this.addupFont.Margin = new System.Windows.Forms.Padding(2);
            this.addupFont.Name = "addupFont";
            this.addupFont.Size = new System.Drawing.Size(118, 24);
            this.addupFont.TabIndex = 55;
            this.addupFont.Text = "得点字体设置";
            this.addupFont.UseMnemonic = false;
            this.addupFont.UseVisualStyleBackColor = true;
            // 
            // teamFont
            // 
            this.teamFont.AutoSize = true;
            this.teamFont.Location = new System.Drawing.Point(209, 119);
            this.teamFont.Margin = new System.Windows.Forms.Padding(2);
            this.teamFont.Name = "teamFont";
            this.teamFont.Size = new System.Drawing.Size(118, 24);
            this.teamFont.TabIndex = 56;
            this.teamFont.Text = "团队字体设置";
            this.teamFont.UseMnemonic = false;
            this.teamFont.UseVisualStyleBackColor = true;
            // 
            // fontBox
            // 
            this.fontBox.Location = new System.Drawing.Point(185, 12);
            this.fontBox.Name = "fontBox";
            this.fontBox.Size = new System.Drawing.Size(167, 146);
            this.fontBox.TabIndex = 57;
            this.fontBox.TabStop = false;
            this.fontBox.Text = "字体设置";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearGamelog);
            this.groupBox1.Controls.Add(this.newShortCut);
            this.groupBox1.Controls.Add(this.openFolder);
            this.groupBox1.Location = new System.Drawing.Point(358, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 146);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件管理";
            // 
            // clearGamelog
            // 
            this.clearGamelog.AutoSize = true;
            this.clearGamelog.Location = new System.Drawing.Point(27, 79);
            this.clearGamelog.Margin = new System.Windows.Forms.Padding(2);
            this.clearGamelog.Name = "clearGamelog";
            this.clearGamelog.Size = new System.Drawing.Size(138, 24);
            this.clearGamelog.TabIndex = 53;
            this.clearGamelog.Text = "清理Gamelog记录TODO";
            this.clearGamelog.UseMnemonic = false;
            this.clearGamelog.UseVisualStyleBackColor = true;
            this.clearGamelog.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.riichiDisplay);
            this.groupBox2.Controls.Add(this.hideTeam);
            this.groupBox2.Controls.Add(this.windSwitch);
            this.groupBox2.Controls.Add(this.windIndicator);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 146);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "显示设置";
            // 
            // riichiDisplay
            // 
            this.riichiDisplay.AutoSize = true;
            this.riichiDisplay.Location = new System.Drawing.Point(21, 107);
            this.riichiDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.riichiDisplay.Name = "riichiDisplay";
            this.riichiDisplay.Size = new System.Drawing.Size(120, 24);
            this.riichiDisplay.TabIndex = 51;
            this.riichiDisplay.Text = "立直显示切换TODO";
            this.riichiDisplay.UseMnemonic = false;
            this.riichiDisplay.UseVisualStyleBackColor = true;
            this.riichiDisplay.Visible = false;
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 169);
            this.Controls.Add(this.teamFont);
            this.Controls.Add(this.addupFont);
            this.Controls.Add(this.pointFont);
            this.Controls.Add(this.nameFont);
            this.Controls.Add(this.fontBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "setting";
            this.Text = "setting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hideTeam;
        private System.Windows.Forms.Button windSwitch;
        public System.Windows.Forms.Button windIndicator;
        private System.Windows.Forms.Button openFolder;
        public System.Windows.Forms.Button newShortCut;
        public System.Windows.Forms.Button nameFont;
        public System.Windows.Forms.Button pointFont;
        public System.Windows.Forms.Button addupFont;
        public System.Windows.Forms.Button teamFont;
        private System.Windows.Forms.GroupBox fontBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearGamelog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button riichiDisplay;
    }
}