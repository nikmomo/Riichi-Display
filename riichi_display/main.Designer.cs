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
            System.Windows.Forms.GroupBox pointgroup;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.label7 = new System.Windows.Forms.Label();
            this.pointGain = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ptDiff3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ptDiff2 = new System.Windows.Forms.TextBox();
            this.playerList = new System.Windows.Forms.ComboBox();
            this.ron3 = new System.Windows.Forms.Button();
            this.ptDiff1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.p3riichi = new System.Windows.Forms.Button();
            this.ptDiff0 = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.tsumo3 = new System.Windows.Forms.Button();
            this.tsumo2 = new System.Windows.Forms.Button();
            this.ron2 = new System.Windows.Forms.Button();
            this.ron1 = new System.Windows.Forms.Button();
            this.tsumo1 = new System.Windows.Forms.Button();
            this.ron0 = new System.Windows.Forms.Button();
            this.p2riichi = new System.Windows.Forms.Button();
            this.tsumo0 = new System.Windows.Forms.Button();
            this.p4riichi = new System.Windows.Forms.Button();
            this.gameStatusLock = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.riichisticks = new System.Windows.Forms.Label();
            this.combo = new System.Windows.Forms.TextBox();
            this.kyutaku = new System.Windows.Forms.TextBox();
            this.p1riichi = new System.Windows.Forms.Button();
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
            this.showDisplay = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.draw = new System.Windows.Forms.Button();
            this.oya4 = new System.Windows.Forms.Button();
            this.oya3 = new System.Windows.Forms.Button();
            this.oya2 = new System.Windows.Forms.Button();
            this.oya1 = new System.Windows.Forms.Button();
            pointgroup = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // pointgroup
            // 
            pointgroup.CausesValidation = false;
            pointgroup.Location = new System.Drawing.Point(12, 199);
            pointgroup.Name = "pointgroup";
            pointgroup.Size = new System.Drawing.Size(809, 27);
            pointgroup.TabIndex = 28;
            pointgroup.TabStop = false;
            pointgroup.Text = "点数控制区";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(574, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "（确认最终得点无误后按提交）";
            // 
            // pointGain
            // 
            this.pointGain.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.pointGain.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pointGain.BackColor = System.Drawing.SystemColors.Window;
            this.pointGain.Items.AddRange(new object[] {
            "1000",
            "1300",
            "1500",
            "1600",
            "2000",
            "2400",
            "2600",
            "2900",
            "3200",
            "3900",
            "4800",
            "5200",
            "5800",
            "6400",
            "7700",
            "8000",
            "9600",
            "11600",
            "12000",
            "16000",
            "18000",
            "24000",
            "32000",
            "36000",
            "48000",
            "64000",
            "96000"});
            this.pointGain.Location = new System.Drawing.Point(468, 316);
            this.pointGain.MaxLength = 20;
            this.pointGain.Name = "pointGain";
            this.pointGain.Size = new System.Drawing.Size(100, 28);
            this.pointGain.TabIndex = 49;
            this.pointGain.Text = "0";
            this.pointGain.SelectedIndexChanged += new System.EventHandler(this.pointGain_LoseFocus);
            this.pointGain.DropDownClosed += new System.EventHandler(this.pointGain_LoseFocus);
            this.pointGain.TextChanged += new System.EventHandler(this.pointGain_LoseFocus);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "得点 (不包含场供/连庄)：";
            // 
            // ptDiff3
            // 
            this.ptDiff3.AcceptsReturn = true;
            this.ptDiff3.AcceptsTab = true;
            this.ptDiff3.BackColor = System.Drawing.SystemColors.Window;
            this.ptDiff3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ptDiff3.Location = new System.Drawing.Point(564, 357);
            this.ptDiff3.MaxLength = 20;
            this.ptDiff3.Name = "ptDiff3";
            this.ptDiff3.ReadOnly = true;
            this.ptDiff3.Size = new System.Drawing.Size(100, 26);
            this.ptDiff3.TabIndex = 21;
            this.ptDiff3.Tag = "addup";
            this.ptDiff3.Text = "0";
            this.ptDiff3.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "放铳者：";
            // 
            // ptDiff2
            // 
            this.ptDiff2.AcceptsReturn = true;
            this.ptDiff2.AcceptsTab = true;
            this.ptDiff2.BackColor = System.Drawing.SystemColors.Window;
            this.ptDiff2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ptDiff2.Location = new System.Drawing.Point(421, 357);
            this.ptDiff2.MaxLength = 20;
            this.ptDiff2.Name = "ptDiff2";
            this.ptDiff2.ReadOnly = true;
            this.ptDiff2.Size = new System.Drawing.Size(100, 26);
            this.ptDiff2.TabIndex = 20;
            this.ptDiff2.Tag = "addup";
            this.ptDiff2.Text = "0";
            this.ptDiff2.WordWrap = false;
            // 
            // playerList
            // 
            this.playerList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.playerList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.playerList.FormattingEnabled = true;
            this.playerList.Items.AddRange(new object[] {
            "三家",
            "PLAYER1",
            "PLAYER2",
            "PLAYER3",
            "PLAYER4"});
            this.playerList.Location = new System.Drawing.Point(120, 316);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(125, 28);
            this.playerList.TabIndex = 39;
            // 
            // ron3
            // 
            this.ron3.AutoSize = true;
            this.ron3.Location = new System.Drawing.Point(617, 276);
            this.ron3.Name = "ron3";
            this.ron3.Size = new System.Drawing.Size(52, 30);
            this.ron3.TabIndex = 38;
            this.ron3.Tag = "ron";
            this.ron3.Text = "荣和";
            this.ron3.UseMnemonic = false;
            this.ron3.UseVisualStyleBackColor = true;
            // 
            // ptDiff1
            // 
            this.ptDiff1.AcceptsReturn = true;
            this.ptDiff1.AcceptsTab = true;
            this.ptDiff1.BackColor = System.Drawing.SystemColors.Window;
            this.ptDiff1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ptDiff1.Location = new System.Drawing.Point(283, 357);
            this.ptDiff1.MaxLength = 20;
            this.ptDiff1.Name = "ptDiff1";
            this.ptDiff1.ReadOnly = true;
            this.ptDiff1.Size = new System.Drawing.Size(100, 26);
            this.ptDiff1.TabIndex = 19;
            this.ptDiff1.Tag = "addup";
            this.ptDiff1.Text = "0";
            this.ptDiff1.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "最终得点\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // p3riichi
            // 
            this.p3riichi.AutoSize = true;
            this.p3riichi.Location = new System.Drawing.Point(434, 234);
            this.p3riichi.Name = "p3riichi";
            this.p3riichi.Size = new System.Drawing.Size(75, 30);
            this.p3riichi.TabIndex = 26;
            this.p3riichi.Tag = "riichi";
            this.p3riichi.Text = "立直";
            this.p3riichi.UseMnemonic = false;
            this.p3riichi.UseVisualStyleBackColor = true;
            // 
            // ptDiff0
            // 
            this.ptDiff0.AcceptsReturn = true;
            this.ptDiff0.AcceptsTab = true;
            this.ptDiff0.BackColor = System.Drawing.SystemColors.Window;
            this.ptDiff0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ptDiff0.Location = new System.Drawing.Point(145, 357);
            this.ptDiff0.MaxLength = 20;
            this.ptDiff0.Name = "ptDiff0";
            this.ptDiff0.ReadOnly = true;
            this.ptDiff0.Size = new System.Drawing.Size(100, 26);
            this.ptDiff0.TabIndex = 18;
            this.ptDiff0.Tag = "addup";
            this.ptDiff0.Text = "0";
            this.ptDiff0.WordWrap = false;
            // 
            // submit
            // 
            this.submit.AutoSize = true;
            this.submit.Location = new System.Drawing.Point(695, 355);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(96, 30);
            this.submit.TabIndex = 22;
            this.submit.Text = "提交";
            this.submit.UseMnemonic = false;
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // tsumo3
            // 
            this.tsumo3.AutoSize = true;
            this.tsumo3.Location = new System.Drawing.Point(559, 276);
            this.tsumo3.Name = "tsumo3";
            this.tsumo3.Size = new System.Drawing.Size(52, 30);
            this.tsumo3.TabIndex = 37;
            this.tsumo3.Tag = "tsumo";
            this.tsumo3.Text = "自摸";
            this.tsumo3.UseMnemonic = false;
            this.tsumo3.UseVisualStyleBackColor = true;
            // 
            // tsumo2
            // 
            this.tsumo2.AutoSize = true;
            this.tsumo2.Location = new System.Drawing.Point(416, 276);
            this.tsumo2.Name = "tsumo2";
            this.tsumo2.Size = new System.Drawing.Size(52, 30);
            this.tsumo2.TabIndex = 35;
            this.tsumo2.Tag = "tsumo";
            this.tsumo2.Text = "自摸";
            this.tsumo2.UseMnemonic = false;
            this.tsumo2.UseVisualStyleBackColor = true;
            // 
            // ron2
            // 
            this.ron2.AutoSize = true;
            this.ron2.Location = new System.Drawing.Point(474, 276);
            this.ron2.Name = "ron2";
            this.ron2.Size = new System.Drawing.Size(52, 30);
            this.ron2.TabIndex = 36;
            this.ron2.Tag = "ron";
            this.ron2.Text = "荣和";
            this.ron2.UseMnemonic = false;
            this.ron2.UseVisualStyleBackColor = true;
            // 
            // ron1
            // 
            this.ron1.AutoSize = true;
            this.ron1.Location = new System.Drawing.Point(336, 276);
            this.ron1.Name = "ron1";
            this.ron1.Size = new System.Drawing.Size(52, 30);
            this.ron1.TabIndex = 36;
            this.ron1.Tag = "ron";
            this.ron1.Text = "荣和";
            this.ron1.UseMnemonic = false;
            this.ron1.UseVisualStyleBackColor = true;
            // 
            // tsumo1
            // 
            this.tsumo1.AutoSize = true;
            this.tsumo1.Location = new System.Drawing.Point(278, 276);
            this.tsumo1.Name = "tsumo1";
            this.tsumo1.Size = new System.Drawing.Size(52, 30);
            this.tsumo1.TabIndex = 35;
            this.tsumo1.Tag = "tsumo";
            this.tsumo1.Text = "自摸";
            this.tsumo1.UseMnemonic = false;
            this.tsumo1.UseVisualStyleBackColor = true;
            // 
            // ron0
            // 
            this.ron0.AutoSize = true;
            this.ron0.Location = new System.Drawing.Point(198, 276);
            this.ron0.Name = "ron0";
            this.ron0.Size = new System.Drawing.Size(52, 30);
            this.ron0.TabIndex = 34;
            this.ron0.Tag = "ron";
            this.ron0.Text = "荣和";
            this.ron0.UseMnemonic = false;
            this.ron0.UseVisualStyleBackColor = true;
            // 
            // p2riichi
            // 
            this.p2riichi.AutoSize = true;
            this.p2riichi.Location = new System.Drawing.Point(294, 234);
            this.p2riichi.Name = "p2riichi";
            this.p2riichi.Size = new System.Drawing.Size(75, 30);
            this.p2riichi.TabIndex = 25;
            this.p2riichi.Tag = "riichi";
            this.p2riichi.Text = "立直";
            this.p2riichi.UseMnemonic = false;
            this.p2riichi.UseVisualStyleBackColor = true;
            // 
            // tsumo0
            // 
            this.tsumo0.AutoSize = true;
            this.tsumo0.Location = new System.Drawing.Point(140, 276);
            this.tsumo0.Name = "tsumo0";
            this.tsumo0.Size = new System.Drawing.Size(52, 30);
            this.tsumo0.TabIndex = 33;
            this.tsumo0.Tag = "tsumo";
            this.tsumo0.Text = "自摸";
            this.tsumo0.UseMnemonic = false;
            this.tsumo0.UseVisualStyleBackColor = true;
            // 
            // p4riichi
            // 
            this.p4riichi.AutoSize = true;
            this.p4riichi.Location = new System.Drawing.Point(577, 234);
            this.p4riichi.Name = "p4riichi";
            this.p4riichi.Size = new System.Drawing.Size(75, 30);
            this.p4riichi.TabIndex = 27;
            this.p4riichi.Tag = "riichi";
            this.p4riichi.Text = "立直";
            this.p4riichi.UseMnemonic = false;
            this.p4riichi.UseVisualStyleBackColor = true;
            // 
            // gameStatusLock
            // 
            this.gameStatusLock.AutoSize = true;
            this.gameStatusLock.BackgroundImage = global::riichi_display.Properties.Resources._lock;
            this.gameStatusLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gameStatusLock.Location = new System.Drawing.Point(266, 398);
            this.gameStatusLock.Name = "gameStatusLock";
            this.gameStatusLock.Size = new System.Drawing.Size(27, 27);
            this.gameStatusLock.TabIndex = 48;
            this.gameStatusLock.UseMnemonic = false;
            this.gameStatusLock.UseVisualStyleBackColor = true;
            this.gameStatusLock.Click += new System.EventHandler(this.gameStatus_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "连庄";
            // 
            // riichisticks
            // 
            this.riichisticks.AutoSize = true;
            this.riichisticks.Location = new System.Drawing.Point(33, 402);
            this.riichisticks.Name = "riichisticks";
            this.riichisticks.Size = new System.Drawing.Size(73, 20);
            this.riichisticks.TabIndex = 40;
            this.riichisticks.Text = "当前场供";
            // 
            // combo
            // 
            this.combo.AcceptsReturn = true;
            this.combo.AcceptsTab = true;
            this.combo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.combo.Enabled = false;
            this.combo.Location = new System.Drawing.Point(218, 396);
            this.combo.MaxLength = 20;
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(32, 26);
            this.combo.TabIndex = 34;
            this.combo.Text = "0";
            this.combo.WordWrap = false;
            this.combo.LostFocus += new System.EventHandler(this.combo_LoseFocus);
            // 
            // kyutaku
            // 
            this.kyutaku.AcceptsReturn = true;
            this.kyutaku.AcceptsTab = true;
            this.kyutaku.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.kyutaku.Enabled = false;
            this.kyutaku.Location = new System.Drawing.Point(112, 399);
            this.kyutaku.MaxLength = 20;
            this.kyutaku.Name = "kyutaku";
            this.kyutaku.Size = new System.Drawing.Size(36, 26);
            this.kyutaku.TabIndex = 33;
            this.kyutaku.Text = "0";
            this.kyutaku.WordWrap = false;
            this.kyutaku.LostFocus += new System.EventHandler(this.kyutaku_LoseFocus);
            // 
            // p1riichi
            // 
            this.p1riichi.AutoSize = true;
            this.p1riichi.Location = new System.Drawing.Point(157, 235);
            this.p1riichi.Name = "p1riichi";
            this.p1riichi.Size = new System.Drawing.Size(75, 30);
            this.p1riichi.TabIndex = 24;
            this.p1riichi.Tag = "riichi";
            this.p1riichi.Text = "立直";
            this.p1riichi.UseMnemonic = false;
            this.p1riichi.UseVisualStyleBackColor = true;
            // 
            // p1name
            // 
            this.p1name.AcceptsReturn = true;
            this.p1name.AcceptsTab = true;
            this.p1name.BackColor = System.Drawing.SystemColors.Window;
            this.p1name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.p1name.Location = new System.Drawing.Point(146, 112);
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
            this.p2name.Location = new System.Drawing.Point(284, 112);
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
            this.p3name.Location = new System.Drawing.Point(422, 112);
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
            this.p4name.Location = new System.Drawing.Point(565, 112);
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
            this.namelock.Location = new System.Drawing.Point(696, 115);
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
            this.label1.Location = new System.Drawing.Point(65, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "名字";
            // 
            // teamLabel
            // 
            this.teamLabel.AutoSize = true;
            this.teamLabel.Location = new System.Drawing.Point(49, 80);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(57, 20);
            this.teamLabel.TabIndex = 11;
            this.teamLabel.Text = "团队名";
            this.teamLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "点数";
            // 
            // pointLock
            // 
            this.pointLock.AutoSize = true;
            this.pointLock.BackgroundImage = global::riichi_display.Properties.Resources._lock;
            this.pointLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pointLock.Location = new System.Drawing.Point(696, 154);
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
            this.p4point.Enabled = false;
            this.p4point.Location = new System.Drawing.Point(565, 154);
            this.p4point.MaxLength = 20;
            this.p4point.Name = "p4point";
            this.p4point.ReadOnly = true;
            this.p4point.Size = new System.Drawing.Size(100, 26);
            this.p4point.TabIndex = 15;
            this.p4point.Tag = "point";
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
            this.p3point.Enabled = false;
            this.p3point.Location = new System.Drawing.Point(422, 154);
            this.p3point.MaxLength = 20;
            this.p3point.Name = "p3point";
            this.p3point.ReadOnly = true;
            this.p3point.Size = new System.Drawing.Size(100, 26);
            this.p3point.TabIndex = 14;
            this.p3point.Tag = "point";
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
            this.p2point.Enabled = false;
            this.p2point.Location = new System.Drawing.Point(284, 154);
            this.p2point.MaxLength = 20;
            this.p2point.Name = "p2point";
            this.p2point.ReadOnly = true;
            this.p2point.Size = new System.Drawing.Size(100, 26);
            this.p2point.TabIndex = 13;
            this.p2point.Tag = "point";
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
            this.p1point.Enabled = false;
            this.p1point.Location = new System.Drawing.Point(146, 154);
            this.p1point.MaxLength = 20;
            this.p1point.Name = "p1point";
            this.p1point.ReadOnly = true;
            this.p1point.Size = new System.Drawing.Size(100, 26);
            this.p1point.TabIndex = 12;
            this.p1point.Tag = "point";
            this.p1point.Text = "25000";
            this.p1point.WordWrap = false;
            this.p1point.GotFocus += new System.EventHandler(this.textboxGetFocus);
            this.p1point.LostFocus += new System.EventHandler(this.textboxLoseFocus);
            // 
            // showDisplay
            // 
            this.showDisplay.AutoSize = true;
            this.showDisplay.Location = new System.Drawing.Point(399, 397);
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
            this.button7.Location = new System.Drawing.Point(504, 397);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 30);
            this.button7.TabIndex = 44;
            this.button7.Text = "其他设置";
            this.button7.UseMnemonic = false;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // reset
            // 
            this.reset.AutoSize = true;
            this.reset.Location = new System.Drawing.Point(709, 397);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(83, 30);
            this.reset.TabIndex = 43;
            this.reset.Text = "重置游戏";
            this.reset.UseMnemonic = false;
            this.reset.UseVisualStyleBackColor = true;
            // 
            // draw
            // 
            this.draw.AutoSize = true;
            this.draw.Location = new System.Drawing.Point(613, 397);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(75, 30);
            this.draw.TabIndex = 42;
            this.draw.Text = "流局";
            this.draw.UseMnemonic = false;
            this.draw.UseVisualStyleBackColor = true;
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
            this.ClientSize = new System.Drawing.Size(834, 466);
            this.Controls.Add(this.gameStatusLock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.riichisticks);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.kyutaku);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pointGain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ptDiff3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ptDiff2);
            this.Controls.Add(this.playerList);
            this.Controls.Add(this.ron3);
            this.Controls.Add(this.ptDiff1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.p3riichi);
            this.Controls.Add(this.ptDiff0);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.tsumo3);
            this.Controls.Add(this.tsumo2);
            this.Controls.Add(this.ron2);
            this.Controls.Add(this.ron1);
            this.Controls.Add(this.tsumo1);
            this.Controls.Add(this.ron0);
            this.Controls.Add(this.p2riichi);
            this.Controls.Add(this.tsumo0);
            this.Controls.Add(this.p1riichi);
            this.Controls.Add(this.p4riichi);
            this.Controls.Add(this.pointLock);
            this.Controls.Add(this.oya4);
            this.Controls.Add(this.showDisplay);
            this.Controls.Add(this.oya3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.oya2);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.oya1);
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
            this.Controls.Add(pointgroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "洛神雀庄直播点数显示系统";
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
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox ptDiff3;
        private System.Windows.Forms.TextBox ptDiff2;
        private System.Windows.Forms.TextBox ptDiff1;
        private System.Windows.Forms.TextBox ptDiff0;
        private System.Windows.Forms.Button p1riichi;
        private System.Windows.Forms.Button p2riichi;
        private System.Windows.Forms.Button p3riichi;
        private System.Windows.Forms.Button p4riichi;
        private System.Windows.Forms.Button oya4;
        private System.Windows.Forms.Button oya3;
        private System.Windows.Forms.Button oya2;
        private System.Windows.Forms.Button oya1;
        private System.Windows.Forms.Button ron3;
        private System.Windows.Forms.Button tsumo3;
        private System.Windows.Forms.Button ron2;
        private System.Windows.Forms.Button ron1;
        private System.Windows.Forms.Button tsumo2;
        private System.Windows.Forms.Button tsumo1;
        private System.Windows.Forms.Button ron0;
        private System.Windows.Forms.Button tsumo0;
        private System.Windows.Forms.ComboBox playerList;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label riichisticks;
        private System.Windows.Forms.TextBox combo;
        private System.Windows.Forms.TextBox kyutaku;
        private System.Windows.Forms.Button showDisplay;
        private System.Windows.Forms.Button gameStatusLock;
        private System.Windows.Forms.ComboBox pointGain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
    }
}

