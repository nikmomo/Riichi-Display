namespace riichi_display
{
    partial class mainForm
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
            this.p3name = new System.Windows.Forms.TextBox();
            this.p4name = new System.Windows.Forms.TextBox();
            this.namelock = new System.Windows.Forms.Button();
            this.teamlock = new System.Windows.Forms.Button();
            this.team4name = new System.Windows.Forms.TextBox();
            this.team3name = new System.Windows.Forms.TextBox();
            this.team2name = new System.Windows.Forms.TextBox();
            this.team1name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.teamLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pointLock = new System.Windows.Forms.Button();
            this.p4point = new System.Windows.Forms.TextBox();
            this.p3point = new System.Windows.Forms.TextBox();
            this.p2point = new System.Windows.Forms.TextBox();
            this.p1point = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ptDiff4 = new System.Windows.Forms.TextBox();
            this.ptDiff3 = new System.Windows.Forms.TextBox();
            this.ptDiff2 = new System.Windows.Forms.TextBox();
            this.ptDiff1 = new System.Windows.Forms.TextBox();
            this.p1riichi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pointgroup = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.showDisplay = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.draw = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.riichisticks = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.playerList = new System.Windows.Forms.ComboBox();
            this.ron4 = new System.Windows.Forms.Button();
            this.tsumo4 = new System.Windows.Forms.Button();
            this.ron3 = new System.Windows.Forms.Button();
            this.ron2 = new System.Windows.Forms.Button();
            this.tsumo3 = new System.Windows.Forms.Button();
            this.tsumo2 = new System.Windows.Forms.Button();
            this.ron1 = new System.Windows.Forms.Button();
            this.tsumo1 = new System.Windows.Forms.Button();
            this.oya4 = new System.Windows.Forms.Button();
            this.oya3 = new System.Windows.Forms.Button();
            this.oya2 = new System.Windows.Forms.Button();
            this.oya1 = new System.Windows.Forms.Button();
            this.pointgroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // p1name
            // 
            this.p1name.AcceptsReturn = true;
            this.p1name.AcceptsTab = true;
            this.p1name.BackColor = System.Drawing.SystemColors.Window;
            this.p1name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.p1name.Location = new System.Drawing.Point(146, 122);
            this.p1name.MaxLength = 20;
            this.p1name.Name = "p1name";
            this.p1name.ReadOnly = true;
            this.p1name.Size = new System.Drawing.Size(100, 26);
            this.p1name.TabIndex = 0;
            this.p1name.Tag = "playerName";
            this.p1name.Text = "PLAYER1";
            this.p1name.WordWrap = false;
            this.p1name.GotFocus += new System.EventHandler(this.textboxGetFocus);
            this.p1name.LostFocus += new System.EventHandler(this.textboxLoseFocus);
            // 
            // p2name
            // 
            this.p2name.AcceptsReturn = true;
            this.p2name.AcceptsTab = true;
            this.p2name.BackColor = System.Drawing.SystemColors.Window;
            this.p2name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.p2name.Location = new System.Drawing.Point(284, 122);
            this.p2name.MaxLength = 20;
            this.p2name.Name = "p2name";
            this.p2name.ReadOnly = true;
            this.p2name.Size = new System.Drawing.Size(100, 26);
            this.p2name.TabIndex = 1;
            this.p2name.Tag = "playerName";
            this.p2name.Text = "PLAYER2";
            this.p2name.WordWrap = false;
            this.p2name.GotFocus += new System.EventHandler(this.textboxGetFocus);
            this.p2name.LostFocus += new System.EventHandler(this.textboxLoseFocus);
            // 
            // p3name
            // 
            this.p3name.AcceptsReturn = true;
            this.p3name.AcceptsTab = true;
            this.p3name.BackColor = System.Drawing.SystemColors.Window;
            this.p3name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.p3name.Location = new System.Drawing.Point(422, 122);
            this.p3name.MaxLength = 20;
            this.p3name.Name = "p3name";
            this.p3name.ReadOnly = true;
            this.p3name.Size = new System.Drawing.Size(100, 26);
            this.p3name.TabIndex = 2;
            this.p3name.Tag = "playerName";
            this.p3name.Text = "PLAYER3";
            this.p3name.WordWrap = false;
            this.p3name.GotFocus += new System.EventHandler(this.textboxGetFocus);
            this.p3name.LostFocus += new System.EventHandler(this.textboxLoseFocus);
            // 
            // p4name
            // 
            this.p4name.AcceptsReturn = true;
            this.p4name.AcceptsTab = true;
            this.p4name.BackColor = System.Drawing.SystemColors.Window;
            this.p4name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.p4name.Location = new System.Drawing.Point(565, 122);
            this.p4name.MaxLength = 20;
            this.p4name.Name = "p4name";
            this.p4name.ReadOnly = true;
            this.p4name.Size = new System.Drawing.Size(100, 26);
            this.p4name.TabIndex = 3;
            this.p4name.Tag = "playerName";
            this.p4name.Text = "PLAYER4";
            this.p4name.WordWrap = false;
            this.p4name.GotFocus += new System.EventHandler(this.textboxGetFocus);
            this.p4name.LostFocus += new System.EventHandler(this.textboxLoseFocus);
            // 
            // namelock
            // 
            this.namelock.AutoSize = true;
            this.namelock.BackgroundImage = global::riichi_display.Properties.Resources.unlock;
            this.namelock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.namelock.Location = new System.Drawing.Point(696, 125);
            this.namelock.Name = "namelock";
            this.namelock.Size = new System.Drawing.Size(27, 27);
            this.namelock.TabIndex = 4;
            this.namelock.UseMnemonic = false;
            this.namelock.UseVisualStyleBackColor = true;
            this.namelock.Click += new System.EventHandler(this.namelock_Click);
            // 
            // teamlock
            // 
            this.teamlock.AutoSize = true;
            this.teamlock.BackgroundImage = global::riichi_display.Properties.Resources._lock;
            this.teamlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.teamlock.Location = new System.Drawing.Point(696, 73);
            this.teamlock.MaximumSize = new System.Drawing.Size(34, 34);
            this.teamlock.Name = "teamlock";
            this.teamlock.Size = new System.Drawing.Size(27, 27);
            this.teamlock.TabIndex = 9;
            this.teamlock.UseMnemonic = false;
            this.teamlock.UseVisualStyleBackColor = true;
            this.teamlock.Visible = false;
            this.teamlock.Click += new System.EventHandler(this.teamlock_Click);
            // 
            // team4name
            // 
            this.team4name.AcceptsReturn = true;
            this.team4name.AcceptsTab = true;
            this.team4name.BackColor = System.Drawing.SystemColors.Window;
            this.team4name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.team4name.Enabled = false;
            this.team4name.Location = new System.Drawing.Point(565, 74);
            this.team4name.MaxLength = 20;
            this.team4name.Name = "team4name";
            this.team4name.ReadOnly = true;
            this.team4name.Size = new System.Drawing.Size(100, 26);
            this.team4name.TabIndex = 8;
            this.team4name.Text = "TEAM4";
            this.team4name.Visible = false;
            this.team4name.WordWrap = false;
            this.team4name.GotFocus += new System.EventHandler(this.textboxGetFocus);
            this.team4name.LostFocus += new System.EventHandler(this.textboxLoseFocus);
            // 
            // team3name
            // 
            this.team3name.AcceptsReturn = true;
            this.team3name.AcceptsTab = true;
            this.team3name.BackColor = System.Drawing.SystemColors.Window;
            this.team3name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.team3name.Enabled = false;
            this.team3name.Location = new System.Drawing.Point(422, 74);
            this.team3name.MaxLength = 20;
            this.team3name.Name = "team3name";
            this.team3name.ReadOnly = true;
            this.team3name.Size = new System.Drawing.Size(100, 26);
            this.team3name.TabIndex = 7;
            this.team3name.Text = "TEAM3";
            this.team3name.Visible = false;
            this.team3name.WordWrap = false;
            this.team3name.GotFocus += new System.EventHandler(this.textboxGetFocus);
            this.team3name.LostFocus += new System.EventHandler(this.textboxLoseFocus);
            // 
            // team2name
            // 
            this.team2name.AcceptsReturn = true;
            this.team2name.AcceptsTab = true;
            this.team2name.BackColor = System.Drawing.SystemColors.Window;
            this.team2name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.team2name.Enabled = false;
            this.team2name.Location = new System.Drawing.Point(284, 74);
            this.team2name.MaxLength = 20;
            this.team2name.Name = "team2name";
            this.team2name.ReadOnly = true;
            this.team2name.Size = new System.Drawing.Size(100, 26);
            this.team2name.TabIndex = 6;
            this.team2name.Text = "TEAM2";
            this.team2name.Visible = false;
            this.team2name.WordWrap = false;
            this.team2name.GotFocus += new System.EventHandler(this.textboxGetFocus);
            this.team2name.LostFocus += new System.EventHandler(this.textboxLoseFocus);
            // 
            // team1name
            // 
            this.team1name.AcceptsReturn = true;
            this.team1name.AcceptsTab = true;
            this.team1name.BackColor = System.Drawing.SystemColors.Window;
            this.team1name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.team1name.Enabled = false;
            this.team1name.Location = new System.Drawing.Point(146, 74);
            this.team1name.MaxLength = 20;
            this.team1name.Name = "team1name";
            this.team1name.ReadOnly = true;
            this.team1name.Size = new System.Drawing.Size(100, 26);
            this.team1name.TabIndex = 5;
            this.team1name.Text = "TEAM1";
            this.team1name.Visible = false;
            this.team1name.WordWrap = false;
            this.team1name.GotFocus += new System.EventHandler(this.textboxGetFocus);
            this.team1name.LostFocus += new System.EventHandler(this.textboxLoseFocus);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "名字";
            // 
            // teamLabel
            // 
            this.teamLabel.AutoSize = true;
            this.teamLabel.Location = new System.Drawing.Point(57, 77);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(57, 20);
            this.teamLabel.TabIndex = 11;
            this.teamLabel.Text = "团队名";
            this.teamLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "点数";
            // 
            // pointLock
            // 
            this.pointLock.AutoSize = true;
            this.pointLock.BackgroundImage = global::riichi_display.Properties.Resources.unlock;
            this.pointLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pointLock.Location = new System.Drawing.Point(684, 43);
            this.pointLock.Name = "pointLock";
            this.pointLock.Size = new System.Drawing.Size(27, 27);
            this.pointLock.TabIndex = 16;
            this.pointLock.UseMnemonic = false;
            this.pointLock.UseVisualStyleBackColor = true;
            this.pointLock.Click += new System.EventHandler(this.pointlock_Click);
            // 
            // p4point
            // 
            this.p4point.AcceptsReturn = true;
            this.p4point.AcceptsTab = true;
            this.p4point.BackColor = System.Drawing.SystemColors.Window;
            this.p4point.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.p4point.Location = new System.Drawing.Point(565, 203);
            this.p4point.MaxLength = 20;
            this.p4point.Name = "p4point";
            this.p4point.ReadOnly = true;
            this.p4point.Size = new System.Drawing.Size(100, 26);
            this.p4point.TabIndex = 15;
            this.p4point.Text = "25000";
            this.p4point.WordWrap = false;
            this.p4point.GotFocus += new System.EventHandler(this.textboxGetFocus);
            this.p4point.LostFocus += new System.EventHandler(this.textboxLoseFocus);
            // 
            // p3point
            // 
            this.p3point.AcceptsReturn = true;
            this.p3point.AcceptsTab = true;
            this.p3point.BackColor = System.Drawing.SystemColors.Window;
            this.p3point.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.p3point.Location = new System.Drawing.Point(422, 203);
            this.p3point.MaxLength = 20;
            this.p3point.Name = "p3point";
            this.p3point.ReadOnly = true;
            this.p3point.Size = new System.Drawing.Size(100, 26);
            this.p3point.TabIndex = 14;
            this.p3point.Text = "25000";
            this.p3point.WordWrap = false;
            this.p3point.GotFocus += new System.EventHandler(this.textboxGetFocus);
            this.p3point.LostFocus += new System.EventHandler(this.textboxLoseFocus);
            // 
            // p2point
            // 
            this.p2point.AcceptsReturn = true;
            this.p2point.AcceptsTab = true;
            this.p2point.BackColor = System.Drawing.SystemColors.Window;
            this.p2point.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.p2point.Location = new System.Drawing.Point(284, 203);
            this.p2point.MaxLength = 20;
            this.p2point.Name = "p2point";
            this.p2point.ReadOnly = true;
            this.p2point.Size = new System.Drawing.Size(100, 26);
            this.p2point.TabIndex = 13;
            this.p2point.Text = "25000";
            this.p2point.WordWrap = false;
            this.p2point.GotFocus += new System.EventHandler(this.textboxGetFocus);
            this.p2point.LostFocus += new System.EventHandler(this.textboxLoseFocus);
            // 
            // p1point
            // 
            this.p1point.AcceptsReturn = true;
            this.p1point.AcceptsTab = true;
            this.p1point.BackColor = System.Drawing.SystemColors.Window;
            this.p1point.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.p1point.Location = new System.Drawing.Point(146, 203);
            this.p1point.MaxLength = 20;
            this.p1point.Name = "p1point";
            this.p1point.ReadOnly = true;
            this.p1point.Size = new System.Drawing.Size(100, 26);
            this.p1point.TabIndex = 12;
            this.p1point.Text = "25000";
            this.p1point.WordWrap = false;
            this.p1point.GotFocus += new System.EventHandler(this.textboxGetFocus);
            this.p1point.LostFocus += new System.EventHandler(this.textboxLoseFocus);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 40);
            this.label4.TabIndex = 23;
            this.label4.Text = "得点\n（不计场供/连庄）";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(696, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 30);
            this.button2.TabIndex = 22;
            this.button2.Text = "提交";
            this.button2.UseMnemonic = false;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ptDiff4
            // 
            this.ptDiff4.AcceptsReturn = true;
            this.ptDiff4.AcceptsTab = true;
            this.ptDiff4.BackColor = System.Drawing.SystemColors.Window;
            this.ptDiff4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ptDiff4.Location = new System.Drawing.Point(565, 331);
            this.ptDiff4.MaxLength = 20;
            this.ptDiff4.Name = "ptDiff4";
            this.ptDiff4.ReadOnly = true;
            this.ptDiff4.Size = new System.Drawing.Size(100, 26);
            this.ptDiff4.TabIndex = 21;
            this.ptDiff4.Text = "0";
            this.ptDiff4.WordWrap = false;
            // 
            // ptDiff3
            // 
            this.ptDiff3.AcceptsReturn = true;
            this.ptDiff3.AcceptsTab = true;
            this.ptDiff3.BackColor = System.Drawing.SystemColors.Window;
            this.ptDiff3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ptDiff3.Location = new System.Drawing.Point(422, 331);
            this.ptDiff3.MaxLength = 20;
            this.ptDiff3.Name = "ptDiff3";
            this.ptDiff3.ReadOnly = true;
            this.ptDiff3.Size = new System.Drawing.Size(100, 26);
            this.ptDiff3.TabIndex = 20;
            this.ptDiff3.Text = "0";
            this.ptDiff3.WordWrap = false;
            // 
            // ptDiff2
            // 
            this.ptDiff2.AcceptsReturn = true;
            this.ptDiff2.AcceptsTab = true;
            this.ptDiff2.BackColor = System.Drawing.SystemColors.Window;
            this.ptDiff2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ptDiff2.Location = new System.Drawing.Point(284, 331);
            this.ptDiff2.MaxLength = 20;
            this.ptDiff2.Name = "ptDiff2";
            this.ptDiff2.ReadOnly = true;
            this.ptDiff2.Size = new System.Drawing.Size(100, 26);
            this.ptDiff2.TabIndex = 19;
            this.ptDiff2.Text = "0";
            this.ptDiff2.WordWrap = false;
            // 
            // ptDiff1
            // 
            this.ptDiff1.AcceptsReturn = true;
            this.ptDiff1.AcceptsTab = true;
            this.ptDiff1.BackColor = System.Drawing.SystemColors.Window;
            this.ptDiff1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ptDiff1.Location = new System.Drawing.Point(146, 331);
            this.ptDiff1.MaxLength = 20;
            this.ptDiff1.Name = "ptDiff1";
            this.ptDiff1.ReadOnly = true;
            this.ptDiff1.Size = new System.Drawing.Size(100, 26);
            this.ptDiff1.TabIndex = 18;
            this.ptDiff1.Text = "0";
            this.ptDiff1.WordWrap = false;
            // 
            // p1riichi
            // 
            this.p1riichi.AutoSize = true;
            this.p1riichi.Location = new System.Drawing.Point(146, 81);
            this.p1riichi.Name = "p1riichi";
            this.p1riichi.Size = new System.Drawing.Size(75, 30);
            this.p1riichi.TabIndex = 24;
            this.p1riichi.Text = "立直";
            this.p1riichi.UseMnemonic = false;
            this.p1riichi.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(286, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 25;
            this.button1.Text = "立直";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(422, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 26;
            this.button3.Text = "立直";
            this.button3.UseMnemonic = false;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(566, 81);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 30);
            this.button4.TabIndex = 27;
            this.button4.Text = "立直";
            this.button4.UseMnemonic = false;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pointgroup
            // 
            this.pointgroup.Controls.Add(this.button8);
            this.pointgroup.Controls.Add(this.showDisplay);
            this.pointgroup.Controls.Add(this.button7);
            this.pointgroup.Controls.Add(this.button6);
            this.pointgroup.Controls.Add(this.draw);
            this.pointgroup.Controls.Add(this.label5);
            this.pointgroup.Controls.Add(this.riichisticks);
            this.pointgroup.Controls.Add(this.textBox1);
            this.pointgroup.Controls.Add(this.textBox2);
            this.pointgroup.Controls.Add(this.playerList);
            this.pointgroup.Controls.Add(this.pointLock);
            this.pointgroup.Controls.Add(this.ron4);
            this.pointgroup.Controls.Add(this.tsumo4);
            this.pointgroup.Controls.Add(this.ron3);
            this.pointgroup.Controls.Add(this.ron2);
            this.pointgroup.Controls.Add(this.label4);
            this.pointgroup.Controls.Add(this.button4);
            this.pointgroup.Controls.Add(this.tsumo3);
            this.pointgroup.Controls.Add(this.button3);
            this.pointgroup.Controls.Add(this.tsumo2);
            this.pointgroup.Controls.Add(this.button1);
            this.pointgroup.Controls.Add(this.ron1);
            this.pointgroup.Controls.Add(this.p1riichi);
            this.pointgroup.Controls.Add(this.tsumo1);
            this.pointgroup.Location = new System.Drawing.Point(12, 160);
            this.pointgroup.Name = "pointgroup";
            this.pointgroup.Size = new System.Drawing.Size(809, 267);
            this.pointgroup.TabIndex = 28;
            this.pointgroup.TabStop = false;
            this.pointgroup.Text = "点数控制区";
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.BackgroundImage = global::riichi_display.Properties.Resources.unlock;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.Location = new System.Drawing.Point(262, 221);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(27, 27);
            this.button8.TabIndex = 48;
            this.button8.UseMnemonic = false;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // showDisplay
            // 
            this.showDisplay.AutoSize = true;
            this.showDisplay.Location = new System.Drawing.Point(387, 215);
            this.showDisplay.Name = "showDisplay";
            this.showDisplay.Size = new System.Drawing.Size(83, 30);
            this.showDisplay.TabIndex = 47;
            this.showDisplay.Text = "显示界面";
            this.showDisplay.UseMnemonic = false;
            this.showDisplay.UseVisualStyleBackColor = true;
            this.showDisplay.Click += new System.EventHandler(this.showDisplay_Click);
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.Location = new System.Drawing.Point(492, 215);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 30);
            this.button7.TabIndex = 44;
            this.button7.Text = "其他设置";
            this.button7.UseMnemonic = false;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Location = new System.Drawing.Point(697, 215);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 30);
            this.button6.TabIndex = 43;
            this.button6.Text = "重置游戏";
            this.button6.UseMnemonic = false;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // draw
            // 
            this.draw.AutoSize = true;
            this.draw.Location = new System.Drawing.Point(601, 215);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(75, 30);
            this.draw.TabIndex = 42;
            this.draw.Text = "流局";
            this.draw.UseMnemonic = false;
            this.draw.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "连庄";
            // 
            // riichisticks
            // 
            this.riichisticks.AutoSize = true;
            this.riichisticks.Location = new System.Drawing.Point(29, 225);
            this.riichisticks.Name = "riichisticks";
            this.riichisticks.Size = new System.Drawing.Size(73, 20);
            this.riichisticks.TabIndex = 40;
            this.riichisticks.Text = "当前场供";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(214, 219);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(32, 26);
            this.textBox1.TabIndex = 34;
            this.textBox1.Text = "0";
            this.textBox1.WordWrap = false;
            // 
            // textBox2
            // 
            this.textBox2.AcceptsReturn = true;
            this.textBox2.AcceptsTab = true;
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Location = new System.Drawing.Point(108, 222);
            this.textBox2.MaxLength = 20;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(36, 26);
            this.textBox2.TabIndex = 33;
            this.textBox2.Text = "0";
            this.textBox2.WordWrap = false;
            // 
            // playerList
            // 
            this.playerList.FormattingEnabled = true;
            this.playerList.Items.AddRange(new object[] {
            "PLAYER1",
            "PLAYER2",
            "PLAYER3",
            "PLAYER4",
            "三家"});
            this.playerList.Location = new System.Drawing.Point(684, 123);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(96, 28);
            this.playerList.TabIndex = 39;
            // 
            // ron4
            // 
            this.ron4.AutoSize = true;
            this.ron4.Location = new System.Drawing.Point(601, 123);
            this.ron4.Name = "ron4";
            this.ron4.Size = new System.Drawing.Size(52, 30);
            this.ron4.TabIndex = 38;
            this.ron4.Text = "荣和";
            this.ron4.UseMnemonic = false;
            this.ron4.UseVisualStyleBackColor = true;
            // 
            // tsumo4
            // 
            this.tsumo4.AutoSize = true;
            this.tsumo4.Location = new System.Drawing.Point(553, 123);
            this.tsumo4.Name = "tsumo4";
            this.tsumo4.Size = new System.Drawing.Size(52, 30);
            this.tsumo4.TabIndex = 37;
            this.tsumo4.Text = "自摸";
            this.tsumo4.UseMnemonic = false;
            this.tsumo4.UseVisualStyleBackColor = true;
            // 
            // ron3
            // 
            this.ron3.AutoSize = true;
            this.ron3.Location = new System.Drawing.Point(458, 123);
            this.ron3.Name = "ron3";
            this.ron3.Size = new System.Drawing.Size(52, 30);
            this.ron3.TabIndex = 36;
            this.ron3.Text = "荣和";
            this.ron3.UseMnemonic = false;
            this.ron3.UseVisualStyleBackColor = true;
            // 
            // ron2
            // 
            this.ron2.AutoSize = true;
            this.ron2.Location = new System.Drawing.Point(320, 123);
            this.ron2.Name = "ron2";
            this.ron2.Size = new System.Drawing.Size(52, 30);
            this.ron2.TabIndex = 36;
            this.ron2.Text = "荣和";
            this.ron2.UseMnemonic = false;
            this.ron2.UseVisualStyleBackColor = true;
            // 
            // tsumo3
            // 
            this.tsumo3.AutoSize = true;
            this.tsumo3.Location = new System.Drawing.Point(410, 123);
            this.tsumo3.Name = "tsumo3";
            this.tsumo3.Size = new System.Drawing.Size(52, 30);
            this.tsumo3.TabIndex = 35;
            this.tsumo3.Text = "自摸";
            this.tsumo3.UseMnemonic = false;
            this.tsumo3.UseVisualStyleBackColor = true;
            // 
            // tsumo2
            // 
            this.tsumo2.AutoSize = true;
            this.tsumo2.Location = new System.Drawing.Point(272, 123);
            this.tsumo2.Name = "tsumo2";
            this.tsumo2.Size = new System.Drawing.Size(52, 30);
            this.tsumo2.TabIndex = 35;
            this.tsumo2.Text = "自摸";
            this.tsumo2.UseMnemonic = false;
            this.tsumo2.UseVisualStyleBackColor = true;
            // 
            // ron1
            // 
            this.ron1.AutoSize = true;
            this.ron1.Location = new System.Drawing.Point(182, 123);
            this.ron1.Name = "ron1";
            this.ron1.Size = new System.Drawing.Size(52, 30);
            this.ron1.TabIndex = 34;
            this.ron1.Text = "荣和";
            this.ron1.UseMnemonic = false;
            this.ron1.UseVisualStyleBackColor = true;
            // 
            // tsumo1
            // 
            this.tsumo1.AutoSize = true;
            this.tsumo1.Location = new System.Drawing.Point(134, 123);
            this.tsumo1.Name = "tsumo1";
            this.tsumo1.Size = new System.Drawing.Size(52, 30);
            this.tsumo1.TabIndex = 33;
            this.tsumo1.Text = "自摸";
            this.tsumo1.UseMnemonic = false;
            this.tsumo1.UseVisualStyleBackColor = true;
            // 
            // oya4
            // 
            this.oya4.AutoSize = true;
            this.oya4.Location = new System.Drawing.Point(592, 26);
            this.oya4.Name = "oya4";
            this.oya4.Size = new System.Drawing.Size(35, 35);
            this.oya4.TabIndex = 32;
            this.oya4.Tag = "seat";
            this.oya4.Text = "子";
            this.oya4.UseMnemonic = false;
            this.oya4.UseVisualStyleBackColor = true;
            // 
            // oya3
            // 
            this.oya3.AutoSize = true;
            this.oya3.Location = new System.Drawing.Point(447, 26);
            this.oya3.Name = "oya3";
            this.oya3.Size = new System.Drawing.Size(35, 35);
            this.oya3.TabIndex = 31;
            this.oya3.Tag = "seat";
            this.oya3.Text = "子";
            this.oya3.UseMnemonic = false;
            this.oya3.UseVisualStyleBackColor = true;
            // 
            // oya2
            // 
            this.oya2.AutoSize = true;
            this.oya2.Location = new System.Drawing.Point(309, 26);
            this.oya2.Name = "oya2";
            this.oya2.Size = new System.Drawing.Size(35, 35);
            this.oya2.TabIndex = 30;
            this.oya2.Tag = "seat";
            this.oya2.Text = "子";
            this.oya2.UseMnemonic = false;
            this.oya2.UseVisualStyleBackColor = true;
            // 
            // oya1
            // 
            this.oya1.AutoSize = true;
            this.oya1.BackColor = System.Drawing.Color.DarkOrange;
            this.oya1.Location = new System.Drawing.Point(173, 26);
            this.oya1.Name = "oya1";
            this.oya1.Size = new System.Drawing.Size(35, 35);
            this.oya1.TabIndex = 29;
            this.oya1.Tag = "seat";
            this.oya1.Text = "親";
            this.oya1.UseMnemonic = false;
            this.oya1.UseVisualStyleBackColor = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 444);
            this.Controls.Add(this.oya4);
            this.Controls.Add(this.oya3);
            this.Controls.Add(this.oya2);
            this.Controls.Add(this.oya1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ptDiff4);
            this.Controls.Add(this.ptDiff3);
            this.Controls.Add(this.ptDiff2);
            this.Controls.Add(this.ptDiff1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.p4point);
            this.Controls.Add(this.p3point);
            this.Controls.Add(this.p2point);
            this.Controls.Add(this.p1point);
            this.Controls.Add(this.teamLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teamlock);
            this.Controls.Add(this.team4name);
            this.Controls.Add(this.team3name);
            this.Controls.Add(this.team2name);
            this.Controls.Add(this.team1name);
            this.Controls.Add(this.namelock);
            this.Controls.Add(this.p4name);
            this.Controls.Add(this.p3name);
            this.Controls.Add(this.p2name);
            this.Controls.Add(this.p1name);
            this.Controls.Add(this.pointgroup);
            this.Name = "mainForm";
            this.Text = "洛神雀庄直播点数显示系统";
            this.pointgroup.ResumeLayout(false);
            this.pointgroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox p1name;
        public System.Windows.Forms.TextBox p2name;
        public System.Windows.Forms.TextBox p3name;
        public System.Windows.Forms.TextBox p4name;
        private System.Windows.Forms.Button namelock;
        private System.Windows.Forms.Button teamlock;
        public System.Windows.Forms.TextBox team4name;
        public System.Windows.Forms.TextBox team3name;
        public System.Windows.Forms.TextBox team2name;
        public System.Windows.Forms.TextBox team1name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pointLock;
        public System.Windows.Forms.TextBox p4point;
        public System.Windows.Forms.TextBox p3point;
        public System.Windows.Forms.TextBox p2point;
        public System.Windows.Forms.TextBox p1point;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ptDiff4;
        private System.Windows.Forms.TextBox ptDiff3;
        private System.Windows.Forms.TextBox ptDiff2;
        private System.Windows.Forms.TextBox ptDiff1;
        private System.Windows.Forms.Button p1riichi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox pointgroup;
        private System.Windows.Forms.Button oya4;
        private System.Windows.Forms.Button oya3;
        private System.Windows.Forms.Button oya2;
        private System.Windows.Forms.Button oya1;
        private System.Windows.Forms.Button ron4;
        private System.Windows.Forms.Button tsumo4;
        private System.Windows.Forms.Button ron3;
        private System.Windows.Forms.Button ron2;
        private System.Windows.Forms.Button tsumo3;
        private System.Windows.Forms.Button tsumo2;
        private System.Windows.Forms.Button ron1;
        private System.Windows.Forms.Button tsumo1;
        private System.Windows.Forms.ComboBox playerList;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label riichisticks;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button showDisplay;
        private System.Windows.Forms.Button button8;
    }
}

