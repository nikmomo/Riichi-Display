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
    partial class statusBar
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
            System.Windows.Forms.Label baopai;
            this.round = new System.Windows.Forms.Label();
            this.kyutaku = new System.Windows.Forms.Label();
            this.combo = new System.Windows.Forms.Label();
            this.dora0 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.changgong = new System.Windows.Forms.PictureBox();
            this.dora1 = new System.Windows.Forms.PictureBox();
            this.dora2 = new System.Windows.Forms.PictureBox();
            this.dora3 = new System.Windows.Forms.PictureBox();
            this.dora4 = new System.Windows.Forms.PictureBox();
            baopai = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dora0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changgong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dora1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dora2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dora3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dora4)).BeginInit();
            this.SuspendLayout();
            // 
            // baopai
            // 
            baopai.AutoSize = true;
            baopai.BackColor = System.Drawing.Color.Transparent;
            baopai.Font = new System.Drawing.Font("微软雅黑", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            baopai.ForeColor = System.Drawing.Color.White;
            baopai.Location = new System.Drawing.Point(702, 37);
            baopai.Name = "baopai";
            baopai.Size = new System.Drawing.Size(82, 138);
            baopai.TabIndex = 7;
            baopai.Text = "宝\r\n牌";
            // 
            // round
            // 
            this.round.AutoSize = true;
            this.round.BackColor = System.Drawing.Color.Transparent;
            this.round.Font = new System.Drawing.Font("微软雅黑", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round.ForeColor = System.Drawing.SystemColors.Control;
            this.round.Location = new System.Drawing.Point(16, 20);
            this.round.Name = "round";
            this.round.Size = new System.Drawing.Size(427, 159);
            this.round.TabIndex = 0;
            this.round.Text = "東一局";
            // 
            // kyutaku
            // 
            this.kyutaku.AutoSize = true;
            this.kyutaku.BackColor = System.Drawing.Color.Transparent;
            this.kyutaku.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kyutaku.ForeColor = System.Drawing.Color.White;
            this.kyutaku.Location = new System.Drawing.Point(627, 50);
            this.kyutaku.Name = "kyutaku";
            this.kyutaku.Size = new System.Drawing.Size(47, 52);
            this.kyutaku.TabIndex = 3;
            this.kyutaku.Text = "0";
            // 
            // combo
            // 
            this.combo.AutoSize = true;
            this.combo.BackColor = System.Drawing.Color.Transparent;
            this.combo.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combo.ForeColor = System.Drawing.Color.White;
            this.combo.Location = new System.Drawing.Point(627, 117);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(47, 52);
            this.combo.TabIndex = 4;
            this.combo.Text = "0";
            // 
            // dora0
            // 
            this.dora0.BackColor = System.Drawing.Color.Transparent;
            this.dora0.BackgroundImage = global::riichi_display.Properties.Resources.questionmark;
            this.dora0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dora0.Location = new System.Drawing.Point(790, 31);
            this.dora0.Name = "dora0";
            this.dora0.Size = new System.Drawing.Size(114, 162);
            this.dora0.TabIndex = 8;
            this.dora0.TabStop = false;
            this.dora0.Tag = "dora";
            this.dora0.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::riichi_display.Properties.Resources.combo_short;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(440, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 57);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // changgong
            // 
            this.changgong.BackColor = System.Drawing.Color.Transparent;
            this.changgong.BackgroundImage = global::riichi_display.Properties.Resources.riichiStick_short;
            this.changgong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.changgong.Location = new System.Drawing.Point(440, 50);
            this.changgong.Name = "changgong";
            this.changgong.Size = new System.Drawing.Size(182, 57);
            this.changgong.TabIndex = 5;
            this.changgong.TabStop = false;
            // 
            // dora1
            // 
            this.dora1.BackColor = System.Drawing.Color.Transparent;
            this.dora1.BackgroundImage = global::riichi_display.Properties.Resources.questionmark;
            this.dora1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dora1.Location = new System.Drawing.Point(910, 31);
            this.dora1.Name = "dora1";
            this.dora1.Size = new System.Drawing.Size(114, 162);
            this.dora1.TabIndex = 9;
            this.dora1.TabStop = false;
            this.dora1.Tag = "dora";
            this.dora1.Visible = false;
            // 
            // dora2
            // 
            this.dora2.BackColor = System.Drawing.Color.Transparent;
            this.dora2.BackgroundImage = global::riichi_display.Properties.Resources.questionmark;
            this.dora2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dora2.Location = new System.Drawing.Point(1030, 31);
            this.dora2.Name = "dora2";
            this.dora2.Size = new System.Drawing.Size(114, 162);
            this.dora2.TabIndex = 10;
            this.dora2.TabStop = false;
            this.dora2.Tag = "dora";
            this.dora2.Visible = false;
            // 
            // dora3
            // 
            this.dora3.BackColor = System.Drawing.Color.Transparent;
            this.dora3.BackgroundImage = global::riichi_display.Properties.Resources.questionmark;
            this.dora3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dora3.Location = new System.Drawing.Point(1150, 31);
            this.dora3.Name = "dora3";
            this.dora3.Size = new System.Drawing.Size(114, 162);
            this.dora3.TabIndex = 11;
            this.dora3.TabStop = false;
            this.dora3.Tag = "dora";
            this.dora3.Visible = false;
            // 
            // dora4
            // 
            this.dora4.BackColor = System.Drawing.Color.Transparent;
            this.dora4.BackgroundImage = global::riichi_display.Properties.Resources.questionmark;
            this.dora4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dora4.Location = new System.Drawing.Point(1270, 31);
            this.dora4.Name = "dora4";
            this.dora4.Size = new System.Drawing.Size(114, 162);
            this.dora4.TabIndex = 12;
            this.dora4.TabStop = false;
            this.dora4.Tag = "dora";
            this.dora4.Visible = false;
            // 
            // status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1410, 212);
            this.ControlBox = false;
            this.Controls.Add(this.dora4);
            this.Controls.Add(this.dora3);
            this.Controls.Add(this.dora2);
            this.Controls.Add(this.dora1);
            this.Controls.Add(this.dora0);
            this.Controls.Add(baopai);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.changgong);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.kyutaku);
            this.Controls.Add(this.round);
            this.DoubleBuffered = true;
            this.Name = "status";
            this.Text = "游戏状态";
            ((System.ComponentModel.ISupportInitialize)(this.dora0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changgong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dora1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dora2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dora3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dora4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label round;
        private System.Windows.Forms.Label kyutaku;
        private System.Windows.Forms.Label combo;
        private System.Windows.Forms.PictureBox changgong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox dora0;
        private System.Windows.Forms.PictureBox dora1;
        private System.Windows.Forms.PictureBox dora2;
        private System.Windows.Forms.PictureBox dora3;
        private System.Windows.Forms.PictureBox dora4;
    }
}