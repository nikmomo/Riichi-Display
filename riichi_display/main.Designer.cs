namespace riichi_display
{
    partial class main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.p1name = new System.Windows.Forms.TextBox();
            this.p2name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // p1name
            // 
            this.p1name.AcceptsReturn = true;
            this.p1name.AcceptsTab = true;
            this.p1name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.p1name.Location = new System.Drawing.Point(71, 54);
            this.p1name.MaxLength = 20;
            this.p1name.Name = "p1name";
            this.p1name.ReadOnly = true;
            this.p1name.Size = new System.Drawing.Size(100, 26);
            this.p1name.TabIndex = 0;
            this.p1name.Text = "PLAYER1";
            this.p1name.WordWrap = false;
            // Handling get / lose focus events
            this.p1name.DoubleClick += new System.EventHandler(this.NameGetFocus);
            this.p1name.GotFocus += new System.EventHandler(this.NameGetFocus);
            this.p1name.LostFocus += new System.EventHandler(this.NameLoseFocus);
            // 
            // p2name
            // 
            this.p2name.AcceptsReturn = true;
            this.p2name.AcceptsTab = true;
            this.p2name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.p2name.Location = new System.Drawing.Point(234, 54);
            this.p2name.MaxLength = 20;
            this.p2name.Name = "p2name";
            this.p2name.ReadOnly = true;
            this.p2name.Size = new System.Drawing.Size(100, 26);
            this.p2name.TabIndex = 1;
            this.p2name.Text = "PLAYER2";
            this.p2name.WordWrap = false;
            this.p2name.DoubleClick += new System.EventHandler(this.NameGetFocus);
            this.p2name.GotFocus += new System.EventHandler(this.NameGetFocus);
            this.p2name.LostFocus += new System.EventHandler(this.NameLoseFocus);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 442);
            this.Controls.Add(this.p2name);
            this.Controls.Add(this.p1name);
            this.Name = "main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox p1name;
        private System.Windows.Forms.TextBox p2name;
    }
}

