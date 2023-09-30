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
            this.hideTeam.Location = new System.Drawing.Point(32, 79);
            this.hideTeam.Name = "hideTeam";
            this.hideTeam.Size = new System.Drawing.Size(177, 37);
            this.hideTeam.TabIndex = 48;
            this.hideTeam.Text = "关闭/启用团队名称";
            this.hideTeam.UseMnemonic = false;
            this.hideTeam.UseVisualStyleBackColor = true;
            this.hideTeam.Click += new System.EventHandler(this.hideTeam_Click);
            // 
            // windSwitch
            // 
            this.windSwitch.AutoSize = true;
            this.windSwitch.Location = new System.Drawing.Point(32, 122);
            this.windSwitch.Name = "windSwitch";
            this.windSwitch.Size = new System.Drawing.Size(177, 37);
            this.windSwitch.TabIndex = 49;
            this.windSwitch.Text = "场风切换";
            this.windSwitch.UseMnemonic = false;
            this.windSwitch.UseVisualStyleBackColor = true;
            this.windSwitch.Click += new System.EventHandler(this.button1_Click);
            // 
            // windIndicator
            // 
            this.windIndicator.AutoSize = true;
            this.windIndicator.Location = new System.Drawing.Point(32, 35);
            this.windIndicator.Name = "windIndicator";
            this.windIndicator.Size = new System.Drawing.Size(177, 38);
            this.windIndicator.TabIndex = 50;
            this.windIndicator.Text = "关闭/启用场风指示";
            this.windIndicator.UseMnemonic = false;
            this.windIndicator.UseVisualStyleBackColor = true;
            // 
            // openFolder
            // 
            this.openFolder.AutoSize = true;
            this.openFolder.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFolder.Location = new System.Drawing.Point(30, 79);
            this.openFolder.Name = "openFolder";
            this.openFolder.Size = new System.Drawing.Size(193, 37);
            this.openFolder.TabIndex = 51;
            this.openFolder.Text = "打开Gamelog文件夹";
            this.openFolder.UseMnemonic = false;
            this.openFolder.UseVisualStyleBackColor = true;
            this.openFolder.Click += new System.EventHandler(this.openFolder_Click);
            // 
            // newShortCut
            // 
            this.newShortCut.AutoSize = true;
            this.newShortCut.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newShortCut.Location = new System.Drawing.Point(30, 36);
            this.newShortCut.Name = "newShortCut";
            this.newShortCut.Size = new System.Drawing.Size(193, 37);
            this.newShortCut.TabIndex = 52;
            this.newShortCut.Text = "创建桌面快捷方式";
            this.newShortCut.UseMnemonic = false;
            this.newShortCut.UseVisualStyleBackColor = true;
            // 
            // nameFont
            // 
            this.nameFont.AutoSize = true;
            this.nameFont.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameFont.Location = new System.Drawing.Point(314, 54);
            this.nameFont.Name = "nameFont";
            this.nameFont.Size = new System.Drawing.Size(177, 37);
            this.nameFont.TabIndex = 53;
            this.nameFont.Text = "名称字体设置";
            this.nameFont.UseMnemonic = false;
            this.nameFont.UseVisualStyleBackColor = true;
            // 
            // pointFont
            // 
            this.pointFont.AutoSize = true;
            this.pointFont.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointFont.Location = new System.Drawing.Point(314, 97);
            this.pointFont.Name = "pointFont";
            this.pointFont.Size = new System.Drawing.Size(177, 37);
            this.pointFont.TabIndex = 54;
            this.pointFont.Text = "点数字体设置";
            this.pointFont.UseMnemonic = false;
            this.pointFont.UseVisualStyleBackColor = true;
            // 
            // addupFont
            // 
            this.addupFont.AutoSize = true;
            this.addupFont.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addupFont.Location = new System.Drawing.Point(314, 140);
            this.addupFont.Name = "addupFont";
            this.addupFont.Size = new System.Drawing.Size(177, 37);
            this.addupFont.TabIndex = 55;
            this.addupFont.Text = "得点字体设置";
            this.addupFont.UseMnemonic = false;
            this.addupFont.UseVisualStyleBackColor = true;
            // 
            // teamFont
            // 
            this.teamFont.AutoSize = true;
            this.teamFont.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamFont.Location = new System.Drawing.Point(314, 183);
            this.teamFont.Name = "teamFont";
            this.teamFont.Size = new System.Drawing.Size(177, 37);
            this.teamFont.TabIndex = 56;
            this.teamFont.Text = "团队字体设置";
            this.teamFont.UseMnemonic = false;
            this.teamFont.UseVisualStyleBackColor = true;
            // 
            // fontBox
            // 
            this.fontBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontBox.Location = new System.Drawing.Point(278, 18);
            this.fontBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fontBox.Name = "fontBox";
            this.fontBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fontBox.Size = new System.Drawing.Size(250, 225);
            this.fontBox.TabIndex = 57;
            this.fontBox.TabStop = false;
            this.fontBox.Text = "字体设置";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearGamelog);
            this.groupBox1.Controls.Add(this.newShortCut);
            this.groupBox1.Controls.Add(this.openFolder);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(537, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(250, 225);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件管理";
            // 
            // clearGamelog
            // 
            this.clearGamelog.AutoSize = true;
            this.clearGamelog.Location = new System.Drawing.Point(30, 122);
            this.clearGamelog.Name = "clearGamelog";
            this.clearGamelog.Size = new System.Drawing.Size(200, 37);
            this.clearGamelog.TabIndex = 53;
            this.clearGamelog.Text = "清理Gamelog记录TODO";
            this.clearGamelog.UseMnemonic = false;
            this.clearGamelog.UseVisualStyleBackColor = true;
            this.clearGamelog.Visible = false;
            this.clearGamelog.Click += new System.EventHandler(this.clearGamelog_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.riichiDisplay);
            this.groupBox2.Controls.Add(this.hideTeam);
            this.groupBox2.Controls.Add(this.windSwitch);
            this.groupBox2.Controls.Add(this.windIndicator);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(250, 225);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "显示设置";
            // 
            // riichiDisplay
            // 
            this.riichiDisplay.AutoSize = true;
            this.riichiDisplay.Location = new System.Drawing.Point(32, 165);
            this.riichiDisplay.Name = "riichiDisplay";
            this.riichiDisplay.Size = new System.Drawing.Size(177, 37);
            this.riichiDisplay.TabIndex = 51;
            this.riichiDisplay.Text = "立直显示切换TODO";
            this.riichiDisplay.UseMnemonic = false;
            this.riichiDisplay.UseVisualStyleBackColor = true;
            this.riichiDisplay.Visible = false;
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 260);
            this.Controls.Add(this.teamFont);
            this.Controls.Add(this.addupFont);
            this.Controls.Add(this.pointFont);
            this.Controls.Add(this.nameFont);
            this.Controls.Add(this.fontBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "setting";
            this.Text = "设置";
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