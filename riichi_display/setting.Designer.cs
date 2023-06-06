
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
            this.hideTeam = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(150, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 30);
            this.button1.TabIndex = 49;
            this.button1.Text = "场风切换";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 143);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hideTeam);
            this.Name = "setting";
            this.Text = "setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hideTeam;
        private System.Windows.Forms.Button button1;
    }
}