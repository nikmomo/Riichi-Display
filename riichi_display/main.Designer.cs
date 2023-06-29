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
            this.riichi2 = new System.Windows.Forms.Button();
            this.ptDiff0 = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.tsumo3 = new System.Windows.Forms.Button();
            this.tsumo2 = new System.Windows.Forms.Button();
            this.ron2 = new System.Windows.Forms.Button();
            this.ron1 = new System.Windows.Forms.Button();
            this.tsumo1 = new System.Windows.Forms.Button();
            this.ron0 = new System.Windows.Forms.Button();
            this.riichi1 = new System.Windows.Forms.Button();
            this.tsumo0 = new System.Windows.Forms.Button();
            this.riichi3 = new System.Windows.Forms.Button();
            this.gameStatusLock = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.riichisticks = new System.Windows.Forms.Label();
            this.combo = new System.Windows.Forms.TextBox();
            this.kyutaku = new System.Windows.Forms.TextBox();
            this.riichi0 = new System.Windows.Forms.Button();
            this.name0 = new System.Windows.Forms.TextBox();
            this.name1 = new System.Windows.Forms.TextBox();
            this.name2 = new System.Windows.Forms.TextBox();
            this.name3 = new System.Windows.Forms.TextBox();
            this.namelock = new System.Windows.Forms.Button();
            this.teamlock = new System.Windows.Forms.Button();
            this.teamname3 = new System.Windows.Forms.TextBox();
            this.teamname2 = new System.Windows.Forms.TextBox();
            this.teamname1 = new System.Windows.Forms.TextBox();
            this.teamname0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.teamLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pointLock = new System.Windows.Forms.Button();
            this.point3 = new System.Windows.Forms.TextBox();
            this.point2 = new System.Windows.Forms.TextBox();
            this.point1 = new System.Windows.Forms.TextBox();
            this.point0 = new System.Windows.Forms.TextBox();
            this.showDisplay = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.draw = new System.Windows.Forms.Button();
            this.oya3 = new System.Windows.Forms.Button();
            this.oya2 = new System.Windows.Forms.Button();
            this.oya1 = new System.Windows.Forms.Button();
            this.oya0 = new System.Windows.Forms.Button();
            this.tenpai2 = new System.Windows.Forms.Button();
            this.tenpai1 = new System.Windows.Forms.Button();
            this.tenpai0 = new System.Windows.Forms.Button();
            this.tenpai3 = new System.Windows.Forms.Button();
            pointgroup = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // pointgroup
            // 
            pointgroup.CausesValidation = false;
            pointgroup.Location = new System.Drawing.Point(12, 199);
            pointgroup.Name = "pointgroup";
            pointgroup.Size = new System.Drawing.Size(791, 27);
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
            // riichi2
            // 
            this.riichi2.AutoSize = true;
            this.riichi2.Location = new System.Drawing.Point(434, 245);
            this.riichi2.Name = "riichi2";
            this.riichi2.Size = new System.Drawing.Size(75, 30);
            this.riichi2.TabIndex = 26;
            this.riichi2.Tag = "riichi";
            this.riichi2.Text = "立直";
            this.riichi2.UseMnemonic = false;
            this.riichi2.UseVisualStyleBackColor = true;
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
            // riichi1
            // 
            this.riichi1.AutoSize = true;
            this.riichi1.Location = new System.Drawing.Point(294, 245);
            this.riichi1.Name = "riichi1";
            this.riichi1.Size = new System.Drawing.Size(75, 30);
            this.riichi1.TabIndex = 25;
            this.riichi1.Tag = "riichi";
            this.riichi1.Text = "立直";
            this.riichi1.UseMnemonic = false;
            this.riichi1.UseVisualStyleBackColor = true;
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
            // riichi3
            // 
            this.riichi3.AutoSize = true;
            this.riichi3.Location = new System.Drawing.Point(577, 245);
            this.riichi3.Name = "riichi3";
            this.riichi3.Size = new System.Drawing.Size(75, 30);
            this.riichi3.TabIndex = 27;
            this.riichi3.Tag = "riichi";
            this.riichi3.Text = "立直";
            this.riichi3.UseMnemonic = false;
            this.riichi3.UseVisualStyleBackColor = true;
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
            this.gameStatusLock.Click += new System.EventHandler(this.gameStatusLock_Click);
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
            // riichi0
            // 
            this.riichi0.AutoSize = true;
            this.riichi0.Location = new System.Drawing.Point(157, 246);
            this.riichi0.Name = "riichi0";
            this.riichi0.Size = new System.Drawing.Size(75, 30);
            this.riichi0.TabIndex = 24;
            this.riichi0.Tag = "riichi";
            this.riichi0.Text = "立直";
            this.riichi0.UseMnemonic = false;
            this.riichi0.UseVisualStyleBackColor = true;
            // 
            // name0
            // 
            this.name0.AcceptsReturn = true;
            this.name0.AcceptsTab = true;
            this.name0.BackColor = System.Drawing.SystemColors.Window;
            this.name0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.name0.Location = new System.Drawing.Point(146, 112);
            this.name0.MaxLength = 20;
            this.name0.Name = "name0";
            this.name0.ReadOnly = true;
            this.name0.Size = new System.Drawing.Size(100, 26);
            this.name0.TabIndex = 0;
            this.name0.Tag = "playerName";
            this.name0.Text = "PLAYER1";
            this.name0.WordWrap = false;
            this.name0.GotFocus += new System.EventHandler(this.textboxGetFocus);
            // 
            // name1
            // 
            this.name1.AcceptsReturn = true;
            this.name1.AcceptsTab = true;
            this.name1.BackColor = System.Drawing.SystemColors.Window;
            this.name1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.name1.Location = new System.Drawing.Point(284, 112);
            this.name1.MaxLength = 20;
            this.name1.Name = "name1";
            this.name1.ReadOnly = true;
            this.name1.Size = new System.Drawing.Size(100, 26);
            this.name1.TabIndex = 1;
            this.name1.Tag = "playerName";
            this.name1.Text = "PLAYER2";
            this.name1.WordWrap = false;
            this.name1.GotFocus += new System.EventHandler(this.textboxGetFocus);
            // 
            // name2
            // 
            this.name2.AcceptsReturn = true;
            this.name2.AcceptsTab = true;
            this.name2.BackColor = System.Drawing.SystemColors.Window;
            this.name2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.name2.Location = new System.Drawing.Point(422, 112);
            this.name2.MaxLength = 20;
            this.name2.Name = "name2";
            this.name2.ReadOnly = true;
            this.name2.Size = new System.Drawing.Size(100, 26);
            this.name2.TabIndex = 2;
            this.name2.Tag = "playerName";
            this.name2.Text = "PLAYER3";
            this.name2.WordWrap = false;
            this.name2.GotFocus += new System.EventHandler(this.textboxGetFocus);
            // 
            // name3
            // 
            this.name3.AcceptsReturn = true;
            this.name3.AcceptsTab = true;
            this.name3.BackColor = System.Drawing.SystemColors.Window;
            this.name3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.name3.Location = new System.Drawing.Point(565, 112);
            this.name3.MaxLength = 20;
            this.name3.Name = "name3";
            this.name3.ReadOnly = true;
            this.name3.Size = new System.Drawing.Size(100, 26);
            this.name3.TabIndex = 3;
            this.name3.Tag = "playerName";
            this.name3.Text = "PLAYER4";
            this.name3.WordWrap = false;
            this.name3.GotFocus += new System.EventHandler(this.textboxGetFocus);
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
            // teamname3
            // 
            this.teamname3.AcceptsReturn = true;
            this.teamname3.AcceptsTab = true;
            this.teamname3.BackColor = System.Drawing.SystemColors.Window;
            this.teamname3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teamname3.Enabled = false;
            this.teamname3.Location = new System.Drawing.Point(565, 74);
            this.teamname3.MaxLength = 20;
            this.teamname3.Name = "teamname3";
            this.teamname3.ReadOnly = true;
            this.teamname3.Size = new System.Drawing.Size(100, 26);
            this.teamname3.TabIndex = 8;
            this.teamname3.Tag = "team";
            this.teamname3.Text = "TEAM4";
            this.teamname3.Visible = false;
            this.teamname3.WordWrap = false;
            this.teamname3.GotFocus += new System.EventHandler(this.textboxGetFocus);
            // 
            // teamname2
            // 
            this.teamname2.AcceptsReturn = true;
            this.teamname2.AcceptsTab = true;
            this.teamname2.BackColor = System.Drawing.SystemColors.Window;
            this.teamname2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teamname2.Enabled = false;
            this.teamname2.Location = new System.Drawing.Point(422, 74);
            this.teamname2.MaxLength = 20;
            this.teamname2.Name = "teamname2";
            this.teamname2.ReadOnly = true;
            this.teamname2.Size = new System.Drawing.Size(100, 26);
            this.teamname2.TabIndex = 7;
            this.teamname2.Tag = "team";
            this.teamname2.Text = "TEAM3";
            this.teamname2.Visible = false;
            this.teamname2.WordWrap = false;
            this.teamname2.GotFocus += new System.EventHandler(this.textboxGetFocus);
            // 
            // teamname1
            // 
            this.teamname1.AcceptsReturn = true;
            this.teamname1.AcceptsTab = true;
            this.teamname1.BackColor = System.Drawing.SystemColors.Window;
            this.teamname1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teamname1.Enabled = false;
            this.teamname1.Location = new System.Drawing.Point(284, 74);
            this.teamname1.MaxLength = 20;
            this.teamname1.Name = "teamname1";
            this.teamname1.ReadOnly = true;
            this.teamname1.Size = new System.Drawing.Size(100, 26);
            this.teamname1.TabIndex = 6;
            this.teamname1.Tag = "team";
            this.teamname1.Text = "TEAM2";
            this.teamname1.Visible = false;
            this.teamname1.WordWrap = false;
            this.teamname1.GotFocus += new System.EventHandler(this.textboxGetFocus);
            // 
            // teamname0
            // 
            this.teamname0.AcceptsReturn = true;
            this.teamname0.AcceptsTab = true;
            this.teamname0.BackColor = System.Drawing.SystemColors.Window;
            this.teamname0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teamname0.Enabled = false;
            this.teamname0.Location = new System.Drawing.Point(146, 74);
            this.teamname0.MaxLength = 20;
            this.teamname0.Name = "teamname0";
            this.teamname0.ReadOnly = true;
            this.teamname0.Size = new System.Drawing.Size(100, 26);
            this.teamname0.TabIndex = 5;
            this.teamname0.Tag = "team";
            this.teamname0.Text = "TEAM1";
            this.teamname0.Visible = false;
            this.teamname0.WordWrap = false;
            this.teamname0.GotFocus += new System.EventHandler(this.textboxGetFocus);
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
            // point3
            // 
            this.point3.AcceptsReturn = true;
            this.point3.AcceptsTab = true;
            this.point3.BackColor = System.Drawing.SystemColors.Window;
            this.point3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.point3.Enabled = false;
            this.point3.Location = new System.Drawing.Point(565, 154);
            this.point3.MaxLength = 20;
            this.point3.Name = "point3";
            this.point3.ReadOnly = true;
            this.point3.Size = new System.Drawing.Size(100, 26);
            this.point3.TabIndex = 15;
            this.point3.Tag = "point";
            this.point3.Text = "25000";
            this.point3.WordWrap = false;
            this.point3.GotFocus += new System.EventHandler(this.textboxGetFocus);
            // 
            // point2
            // 
            this.point2.AcceptsReturn = true;
            this.point2.AcceptsTab = true;
            this.point2.BackColor = System.Drawing.SystemColors.Window;
            this.point2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.point2.Enabled = false;
            this.point2.Location = new System.Drawing.Point(422, 154);
            this.point2.MaxLength = 20;
            this.point2.Name = "point2";
            this.point2.ReadOnly = true;
            this.point2.Size = new System.Drawing.Size(100, 26);
            this.point2.TabIndex = 14;
            this.point2.Tag = "point";
            this.point2.Text = "25000";
            this.point2.WordWrap = false;
            this.point2.GotFocus += new System.EventHandler(this.textboxGetFocus);
            // 
            // point1
            // 
            this.point1.AcceptsReturn = true;
            this.point1.AcceptsTab = true;
            this.point1.BackColor = System.Drawing.SystemColors.Window;
            this.point1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.point1.Enabled = false;
            this.point1.Location = new System.Drawing.Point(284, 154);
            this.point1.MaxLength = 20;
            this.point1.Name = "point1";
            this.point1.ReadOnly = true;
            this.point1.Size = new System.Drawing.Size(100, 26);
            this.point1.TabIndex = 13;
            this.point1.Tag = "point";
            this.point1.Text = "25000";
            this.point1.WordWrap = false;
            this.point1.GotFocus += new System.EventHandler(this.textboxGetFocus);
            // 
            // point0
            // 
            this.point0.AcceptsReturn = true;
            this.point0.AcceptsTab = true;
            this.point0.BackColor = System.Drawing.SystemColors.Window;
            this.point0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.point0.Enabled = false;
            this.point0.Location = new System.Drawing.Point(146, 154);
            this.point0.MaxLength = 20;
            this.point0.Name = "point0";
            this.point0.ReadOnly = true;
            this.point0.Size = new System.Drawing.Size(100, 26);
            this.point0.TabIndex = 12;
            this.point0.Tag = "point";
            this.point0.Text = "25000";
            this.point0.WordWrap = false;
            this.point0.GotFocus += new System.EventHandler(this.textboxGetFocus);
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
            this.button7.Name = "setting";
            this.button7.Size = new System.Drawing.Size(83, 30);
            this.button7.TabIndex = 44;
            this.button7.Text = "其他设置";
            this.button7.UseMnemonic = false;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.setting_Click);
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
            this.reset.Click += new System.EventHandler(this.reset_Click);
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
            // oya3
            // 
            this.oya3.AutoSize = true;
            this.oya3.Location = new System.Drawing.Point(592, 26);
            this.oya3.Name = "oya3";
            this.oya3.Size = new System.Drawing.Size(35, 35);
            this.oya3.TabIndex = 32;
            this.oya3.Tag = "seat";
            this.oya3.Text = "子";
            this.oya3.UseMnemonic = false;
            this.oya3.UseVisualStyleBackColor = true;
            // 
            // oya2
            // 
            this.oya2.AutoSize = true;
            this.oya2.Location = new System.Drawing.Point(447, 26);
            this.oya2.Name = "oya2";
            this.oya2.Size = new System.Drawing.Size(35, 35);
            this.oya2.TabIndex = 31;
            this.oya2.Tag = "seat";
            this.oya2.Text = "子";
            this.oya2.UseMnemonic = false;
            this.oya2.UseVisualStyleBackColor = true;
            // 
            // oya1
            // 
            this.oya1.AutoSize = true;
            this.oya1.Location = new System.Drawing.Point(309, 26);
            this.oya1.Name = "oya1";
            this.oya1.Size = new System.Drawing.Size(35, 35);
            this.oya1.TabIndex = 30;
            this.oya1.Tag = "seat";
            this.oya1.Text = "子";
            this.oya1.UseMnemonic = false;
            this.oya1.UseVisualStyleBackColor = true;
            // 
            // oya0
            // 
            this.oya0.AutoSize = true;
            this.oya0.BackColor = System.Drawing.Color.DarkOrange;
            this.oya0.Location = new System.Drawing.Point(173, 26);
            this.oya0.Name = "oya0";
            this.oya0.Size = new System.Drawing.Size(35, 35);
            this.oya0.TabIndex = 29;
            this.oya0.Tag = "seat";
            this.oya0.Text = "親";
            this.oya0.UseMnemonic = false;
            this.oya0.UseVisualStyleBackColor = false;
            // 
            // tenpai2
            // 
            this.tenpai2.AutoSize = true;
            this.tenpai2.Location = new System.Drawing.Point(434, 214);
            this.tenpai2.Name = "tenpai2";
            this.tenpai2.Size = new System.Drawing.Size(75, 30);
            this.tenpai2.TabIndex = 54;
            this.tenpai2.Tag = "tenpai";
            this.tenpai2.Text = "不听";
            this.tenpai2.UseMnemonic = false;
            this.tenpai2.UseVisualStyleBackColor = true;
            this.tenpai2.Visible = false;
            // 
            // tenpai1
            // 
            this.tenpai1.AutoSize = true;
            this.tenpai1.Location = new System.Drawing.Point(294, 214);
            this.tenpai1.Name = "tenpai1";
            this.tenpai1.Size = new System.Drawing.Size(75, 30);
            this.tenpai1.TabIndex = 53;
            this.tenpai1.Tag = "tenpai";
            this.tenpai1.Text = "不听";
            this.tenpai1.UseMnemonic = false;
            this.tenpai1.UseVisualStyleBackColor = true;
            this.tenpai1.Visible = false;
            // 
            // tenpai0
            // 
            this.tenpai0.AutoSize = true;
            this.tenpai0.Location = new System.Drawing.Point(157, 215);
            this.tenpai0.Name = "tenpai0";
            this.tenpai0.Size = new System.Drawing.Size(75, 30);
            this.tenpai0.TabIndex = 52;
            this.tenpai0.Tag = "tenpai";
            this.tenpai0.Text = "不听";
            this.tenpai0.UseMnemonic = false;
            this.tenpai0.UseVisualStyleBackColor = true;
            this.tenpai0.Visible = false;
            // 
            // tenpai3
            // 
            this.tenpai3.AutoSize = true;
            this.tenpai3.Location = new System.Drawing.Point(577, 214);
            this.tenpai3.Name = "tenpai3";
            this.tenpai3.Size = new System.Drawing.Size(75, 30);
            this.tenpai3.TabIndex = 55;
            this.tenpai3.Tag = "tenpai";
            this.tenpai3.Text = "不听";
            this.tenpai3.UseMnemonic = false;
            this.tenpai3.UseVisualStyleBackColor = true;
            this.tenpai3.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 444);
            this.Controls.Add(this.tenpai2);
            this.Controls.Add(this.tenpai1);
            this.Controls.Add(this.tenpai0);
            this.Controls.Add(this.tenpai3);
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
            this.Controls.Add(this.riichi2);
            this.Controls.Add(this.ptDiff0);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.tsumo3);
            this.Controls.Add(this.tsumo2);
            this.Controls.Add(this.ron2);
            this.Controls.Add(this.ron1);
            this.Controls.Add(this.tsumo1);
            this.Controls.Add(this.ron0);
            this.Controls.Add(this.riichi1);
            this.Controls.Add(this.tsumo0);
            this.Controls.Add(this.riichi0);
            this.Controls.Add(this.riichi3);
            this.Controls.Add(this.pointLock);
            this.Controls.Add(this.oya3);
            this.Controls.Add(this.showDisplay);
            this.Controls.Add(this.oya2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.oya1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.oya0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.point3);
            this.Controls.Add(this.point2);
            this.Controls.Add(this.point1);
            this.Controls.Add(this.point0);
            this.Controls.Add(this.teamLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teamlock);
            this.Controls.Add(this.teamname3);
            this.Controls.Add(this.teamname2);
            this.Controls.Add(this.teamname1);
            this.Controls.Add(this.teamname0);
            this.Controls.Add(this.namelock);
            this.Controls.Add(this.name3);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.name0);
            this.Controls.Add(pointgroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "洛神雀庄直播点数显示系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox name0;
        public System.Windows.Forms.TextBox name1;
        public System.Windows.Forms.TextBox name2;
        public System.Windows.Forms.TextBox name3;
        private System.Windows.Forms.Button namelock;
        private System.Windows.Forms.Button teamlock;
        public System.Windows.Forms.TextBox teamname3;
        public System.Windows.Forms.TextBox teamname2;
        public System.Windows.Forms.TextBox teamname1;
        public System.Windows.Forms.TextBox teamname0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pointLock;
        public System.Windows.Forms.TextBox point3;
        public System.Windows.Forms.TextBox point2;
        public System.Windows.Forms.TextBox point1;
        public System.Windows.Forms.TextBox point0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox ptDiff3;
        private System.Windows.Forms.TextBox ptDiff2;
        private System.Windows.Forms.TextBox ptDiff1;
        private System.Windows.Forms.TextBox ptDiff0;
        private System.Windows.Forms.Button riichi0;
        private System.Windows.Forms.Button riichi1;
        private System.Windows.Forms.Button riichi2;
        private System.Windows.Forms.Button riichi3;
        private System.Windows.Forms.Button oya3;
        private System.Windows.Forms.Button oya2;
        private System.Windows.Forms.Button oya1;
        private System.Windows.Forms.Button oya0;
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
        private System.Windows.Forms.Button tenpai2;
        private System.Windows.Forms.Button tenpai1;
        private System.Windows.Forms.Button tenpai0;
        private System.Windows.Forms.Button tenpai3;
    }
}

