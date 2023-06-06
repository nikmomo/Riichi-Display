namespace riichi_display
{
    partial class display
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
            this.team1Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // team1Name
            // 
            this.team1Name.AutoSize = true;
            this.team1Name.Location = new System.Drawing.Point(304, 283);
            this.team1Name.Name = "team1Name";
            this.team1Name.Size = new System.Drawing.Size(51, 20);
            this.team1Name.TabIndex = 0;
            this.team1Name.Text = "label1";
            // 
            // display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1898, 344);
            this.Controls.Add(this.team1Name);
            this.Name = "display";
            this.Text = "显示系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label team1Name;
    }
}