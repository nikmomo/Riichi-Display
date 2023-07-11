namespace riichi_display
{
    partial class status
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.changgong = new System.Windows.Forms.PictureBox();
            baopai = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changgong)).BeginInit();
            this.SuspendLayout();
            // 
            // baopai
            // 
            baopai.AutoSize = true;
            baopai.BackColor = System.Drawing.Color.Transparent;
            baopai.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            baopai.ForeColor = System.Drawing.SystemColors.ControlLight;
            baopai.Location = new System.Drawing.Point(327, 16);
            baopai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            baopai.Name = "baopai";
            baopai.Size = new System.Drawing.Size(35, 60);
            baopai.TabIndex = 7;
            baopai.Text = "宝\r\n牌";
            baopai.Visible = false;
            // 
            // round
            // 
            this.round.AutoSize = true;
            this.round.BackColor = System.Drawing.Color.Transparent;
            this.round.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round.ForeColor = System.Drawing.SystemColors.Control;
            this.round.Location = new System.Drawing.Point(14, 7);
            this.round.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.round.Name = "round";
            this.round.Size = new System.Drawing.Size(200, 75);
            this.round.TabIndex = 0;
            this.round.Text = "東一局";
            // 
            // kyutaku
            // 
            this.kyutaku.AutoSize = true;
            this.kyutaku.BackColor = System.Drawing.Color.Transparent;
            this.kyutaku.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kyutaku.ForeColor = System.Drawing.SystemColors.Control;
            this.kyutaku.Location = new System.Drawing.Point(293, 16);
            this.kyutaku.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kyutaku.Name = "kyutaku";
            this.kyutaku.Size = new System.Drawing.Size(26, 30);
            this.kyutaku.TabIndex = 3;
            this.kyutaku.Text = "0";
            // 
            // combo
            // 
            this.combo.AutoSize = true;
            this.combo.BackColor = System.Drawing.Color.Transparent;
            this.combo.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo.ForeColor = System.Drawing.SystemColors.Control;
            this.combo.Location = new System.Drawing.Point(293, 44);
            this.combo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(26, 30);
            this.combo.TabIndex = 4;
            this.combo.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::riichi_display.Properties.Resources.questionmark;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(357, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 67);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::riichi_display.Properties.Resources.combo_short;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(222, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 17);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // changgong
            // 
            this.changgong.BackColor = System.Drawing.Color.Transparent;
            this.changgong.BackgroundImage = global::riichi_display.Properties.Resources.riichiStick_short;
            this.changgong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.changgong.Location = new System.Drawing.Point(222, 20);
            this.changgong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.changgong.Name = "changgong";
            this.changgong.Size = new System.Drawing.Size(67, 17);
            this.changgong.TabIndex = 5;
            this.changgong.TabStop = false;
            // 
            // status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(439, 86);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(baopai);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.changgong);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.kyutaku);
            this.Controls.Add(this.round);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "status";
            this.Text = "游戏状态";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changgong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label round;
        private System.Windows.Forms.Label kyutaku;
        private System.Windows.Forms.Label combo;
        private System.Windows.Forms.PictureBox changgong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}