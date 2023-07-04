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
            this.round = new System.Windows.Forms.Label();
            this.changgong = new System.Windows.Forms.Label();
            this.benchang = new System.Windows.Forms.Label();
            this.kyutaku = new System.Windows.Forms.Label();
            this.combo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // round
            // 
            this.round.AutoSize = true;
            this.round.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round.ForeColor = System.Drawing.SystemColors.Control;
            this.round.Location = new System.Drawing.Point(21, 19);
            this.round.Name = "round";
            this.round.Size = new System.Drawing.Size(299, 112);
            this.round.TabIndex = 0;
            this.round.Text = "東一局";
            // 
            // changgong
            // 
            this.changgong.AutoSize = true;
            this.changgong.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changgong.ForeColor = System.Drawing.SystemColors.Control;
            this.changgong.Location = new System.Drawing.Point(326, 37);
            this.changgong.Name = "changgong";
            this.changgong.Size = new System.Drawing.Size(114, 41);
            this.changgong.TabIndex = 1;
            this.changgong.Text = "场供：";
            // 
            // benchang
            // 
            this.benchang.AutoSize = true;
            this.benchang.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benchang.ForeColor = System.Drawing.SystemColors.Control;
            this.benchang.Location = new System.Drawing.Point(326, 78);
            this.benchang.Name = "benchang";
            this.benchang.Size = new System.Drawing.Size(114, 41);
            this.benchang.TabIndex = 2;
            this.benchang.Text = "本场：";
            // 
            // kyutaku
            // 
            this.kyutaku.AutoSize = true;
            this.kyutaku.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kyutaku.ForeColor = System.Drawing.SystemColors.Control;
            this.kyutaku.Location = new System.Drawing.Point(419, 37);
            this.kyutaku.Name = "kyutaku";
            this.kyutaku.Size = new System.Drawing.Size(37, 41);
            this.kyutaku.TabIndex = 3;
            this.kyutaku.Text = "0";
            // 
            // combo
            // 
            this.combo.AutoSize = true;
            this.combo.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo.ForeColor = System.Drawing.SystemColors.Control;
            this.combo.Location = new System.Drawing.Point(419, 78);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(37, 41);
            this.combo.TabIndex = 4;
            this.combo.Text = "0";
            // 
            // status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(488, 157);
            this.ControlBox = false;
            this.Controls.Add(this.combo);
            this.Controls.Add(this.kyutaku);
            this.Controls.Add(this.benchang);
            this.Controls.Add(this.changgong);
            this.Controls.Add(this.round);
            this.Name = "status";
            this.Text = "游戏状态";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label round;
        private System.Windows.Forms.Label changgong;
        private System.Windows.Forms.Label benchang;
        private System.Windows.Forms.Label kyutaku;
        private System.Windows.Forms.Label combo;
    }
}