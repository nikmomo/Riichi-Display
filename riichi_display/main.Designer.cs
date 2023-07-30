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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.pointGain = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addup3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addup2 = new System.Windows.Forms.TextBox();
            this.playerList = new System.Windows.Forms.ComboBox();
            this.ron3 = new System.Windows.Forms.Button();
            this.addup1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.riichi2 = new System.Windows.Forms.Button();
            this.addup0 = new System.Windows.Forms.TextBox();
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
            this.label5 = new System.Windows.Forms.Label();
            this.riichisticks = new System.Windows.Forms.Label();
            this.combo = new System.Windows.Forms.TextBox();
            this.kyutaku = new System.Windows.Forms.TextBox();
            this.riichi0 = new System.Windows.Forms.Button();
            this.name0 = new System.Windows.Forms.TextBox();
            this.name1 = new System.Windows.Forms.TextBox();
            this.name2 = new System.Windows.Forms.TextBox();
            this.name3 = new System.Windows.Forms.TextBox();
            this.teamname3 = new System.Windows.Forms.TextBox();
            this.teamname2 = new System.Windows.Forms.TextBox();
            this.teamname1 = new System.Windows.Forms.TextBox();
            this.teamname0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.teamLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.point3 = new System.Windows.Forms.TextBox();
            this.point2 = new System.Windows.Forms.TextBox();
            this.point1 = new System.Windows.Forms.TextBox();
            this.point0 = new System.Windows.Forms.TextBox();
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
            this.winner = new System.Windows.Forms.Label();
            this.gameStatusLock = new System.Windows.Forms.Button();
            this.pointLock = new System.Windows.Forms.Button();
            this.teamlock = new System.Windows.Forms.Button();
            this.namelock = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.ComboBox();
            this.tenpaiLabel = new System.Windows.Forms.Label();
            this.han = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fu = new System.Windows.Forms.ComboBox();
            this.labelfu = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.pointGain.Location = new System.Drawing.Point(438, 202);
            this.pointGain.Margin = new System.Windows.Forms.Padding(2);
            this.pointGain.MaxLength = 20;
            this.pointGain.Name = "pointGain";
            this.pointGain.Size = new System.Drawing.Size(68, 20);
            this.pointGain.TabIndex = 49;
            this.pointGain.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 48;
            this.label2.Text = "得点:";
            // 
            // addup3
            // 
            this.addup3.AcceptsReturn = true;
            this.addup3.AcceptsTab = true;
            this.addup3.BackColor = System.Drawing.SystemColors.Window;
            this.addup3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.addup3.Location = new System.Drawing.Point(376, 229);
            this.addup3.Margin = new System.Windows.Forms.Padding(2);
            this.addup3.MaxLength = 20;
            this.addup3.Name = "addup3";
            this.addup3.ReadOnly = true;
            this.addup3.Size = new System.Drawing.Size(68, 21);
            this.addup3.TabIndex = 21;
            this.addup3.Tag = "addup";
            this.addup3.Text = "0";
            this.addup3.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 204);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 50;
            this.label6.Text = "放铳者：";
            // 
            // addup2
            // 
            this.addup2.AcceptsReturn = true;
            this.addup2.AcceptsTab = true;
            this.addup2.BackColor = System.Drawing.SystemColors.Window;
            this.addup2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.addup2.Location = new System.Drawing.Point(281, 229);
            this.addup2.Margin = new System.Windows.Forms.Padding(2);
            this.addup2.MaxLength = 20;
            this.addup2.Name = "addup2";
            this.addup2.ReadOnly = true;
            this.addup2.Size = new System.Drawing.Size(68, 21);
            this.addup2.TabIndex = 20;
            this.addup2.Tag = "addup";
            this.addup2.Text = "0";
            this.addup2.WordWrap = false;
            // 
            // playerList
            // 
            this.playerList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.playerList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.playerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerList.FormattingEnabled = true;
            this.playerList.Items.AddRange(new object[] {
            "三家",
            "PLAYER1",
            "PLAYER2",
            "PLAYER3",
            "PLAYER4"});
            this.playerList.Location = new System.Drawing.Point(97, 202);
            this.playerList.Margin = new System.Windows.Forms.Padding(2);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(68, 20);
            this.playerList.TabIndex = 39;
            // 
            // ron3
            // 
            this.ron3.AutoSize = true;
            this.ron3.Location = new System.Drawing.Point(458, 173);
            this.ron3.Margin = new System.Windows.Forms.Padding(2);
            this.ron3.Name = "ron3";
            this.ron3.Size = new System.Drawing.Size(39, 22);
            this.ron3.TabIndex = 38;
            this.ron3.Tag = "ron";
            this.ron3.Text = "荣和";
            this.ron3.UseMnemonic = false;
            this.ron3.UseVisualStyleBackColor = true;
            // 
            // addup1
            // 
            this.addup1.AcceptsReturn = true;
            this.addup1.AcceptsTab = true;
            this.addup1.BackColor = System.Drawing.SystemColors.Window;
            this.addup1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.addup1.Location = new System.Drawing.Point(189, 229);
            this.addup1.Margin = new System.Windows.Forms.Padding(2);
            this.addup1.MaxLength = 20;
            this.addup1.Name = "addup1";
            this.addup1.ReadOnly = true;
            this.addup1.Size = new System.Drawing.Size(68, 21);
            this.addup1.TabIndex = 19;
            this.addup1.Tag = "addup";
            this.addup1.Text = "0";
            this.addup1.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "最终得点\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // riichi2
            // 
            this.riichi2.AutoSize = true;
            this.riichi2.Location = new System.Drawing.Point(311, 146);
            this.riichi2.Margin = new System.Windows.Forms.Padding(2);
            this.riichi2.Name = "riichi2";
            this.riichi2.Size = new System.Drawing.Size(78, 22);
            this.riichi2.TabIndex = 26;
            this.riichi2.Tag = "riichi";
            this.riichi2.Text = "立直";
            this.riichi2.UseMnemonic = false;
            this.riichi2.UseVisualStyleBackColor = true;
            // 
            // addup0
            // 
            this.addup0.AcceptsReturn = true;
            this.addup0.AcceptsTab = true;
            this.addup0.BackColor = System.Drawing.SystemColors.Window;
            this.addup0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.addup0.Location = new System.Drawing.Point(97, 229);
            this.addup0.Margin = new System.Windows.Forms.Padding(2);
            this.addup0.MaxLength = 20;
            this.addup0.Name = "addup0";
            this.addup0.ReadOnly = true;
            this.addup0.Size = new System.Drawing.Size(68, 21);
            this.addup0.TabIndex = 18;
            this.addup0.Tag = "addup";
            this.addup0.Text = "0";
            this.addup0.WordWrap = false;
            // 
            // submit
            // 
            this.submit.AutoSize = true;
            this.submit.Enabled = false;
            this.submit.Location = new System.Drawing.Point(464, 229);
            this.submit.Margin = new System.Windows.Forms.Padding(2);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(64, 22);
            this.submit.TabIndex = 22;
            this.submit.Text = "提交";
            this.submit.UseMnemonic = false;
            this.submit.UseVisualStyleBackColor = true;
            // 
            // tsumo3
            // 
            this.tsumo3.AutoSize = true;
            this.tsumo3.Location = new System.Drawing.Point(420, 173);
            this.tsumo3.Margin = new System.Windows.Forms.Padding(2);
            this.tsumo3.Name = "tsumo3";
            this.tsumo3.Size = new System.Drawing.Size(39, 22);
            this.tsumo3.TabIndex = 37;
            this.tsumo3.Tag = "tsumo";
            this.tsumo3.Text = "自摸";
            this.tsumo3.UseMnemonic = false;
            this.tsumo3.UseVisualStyleBackColor = true;
            // 
            // tsumo2
            // 
            this.tsumo2.AutoSize = true;
            this.tsumo2.Location = new System.Drawing.Point(311, 173);
            this.tsumo2.Margin = new System.Windows.Forms.Padding(2);
            this.tsumo2.Name = "tsumo2";
            this.tsumo2.Size = new System.Drawing.Size(39, 22);
            this.tsumo2.TabIndex = 35;
            this.tsumo2.Tag = "tsumo";
            this.tsumo2.Text = "自摸";
            this.tsumo2.UseMnemonic = false;
            this.tsumo2.UseVisualStyleBackColor = true;
            // 
            // ron2
            // 
            this.ron2.AutoSize = true;
            this.ron2.Location = new System.Drawing.Point(350, 173);
            this.ron2.Margin = new System.Windows.Forms.Padding(2);
            this.ron2.Name = "ron2";
            this.ron2.Size = new System.Drawing.Size(39, 22);
            this.ron2.TabIndex = 36;
            this.ron2.Tag = "ron";
            this.ron2.Text = "荣和";
            this.ron2.UseMnemonic = false;
            this.ron2.UseVisualStyleBackColor = true;
            // 
            // ron1
            // 
            this.ron1.AutoSize = true;
            this.ron1.Location = new System.Drawing.Point(240, 173);
            this.ron1.Margin = new System.Windows.Forms.Padding(2);
            this.ron1.Name = "ron1";
            this.ron1.Size = new System.Drawing.Size(39, 22);
            this.ron1.TabIndex = 36;
            this.ron1.Tag = "ron";
            this.ron1.Text = "荣和";
            this.ron1.UseMnemonic = false;
            this.ron1.UseVisualStyleBackColor = true;
            // 
            // tsumo1
            // 
            this.tsumo1.AutoSize = true;
            this.tsumo1.Location = new System.Drawing.Point(201, 173);
            this.tsumo1.Margin = new System.Windows.Forms.Padding(2);
            this.tsumo1.Name = "tsumo1";
            this.tsumo1.Size = new System.Drawing.Size(39, 22);
            this.tsumo1.TabIndex = 35;
            this.tsumo1.Tag = "tsumo";
            this.tsumo1.Text = "自摸";
            this.tsumo1.UseMnemonic = false;
            this.tsumo1.UseVisualStyleBackColor = true;
            // 
            // ron0
            // 
            this.ron0.AutoSize = true;
            this.ron0.Location = new System.Drawing.Point(132, 173);
            this.ron0.Margin = new System.Windows.Forms.Padding(2);
            this.ron0.Name = "ron0";
            this.ron0.Size = new System.Drawing.Size(39, 22);
            this.ron0.TabIndex = 34;
            this.ron0.Tag = "ron";
            this.ron0.Text = "荣和";
            this.ron0.UseMnemonic = false;
            this.ron0.UseVisualStyleBackColor = true;
            // 
            // riichi1
            // 
            this.riichi1.AutoSize = true;
            this.riichi1.Location = new System.Drawing.Point(201, 146);
            this.riichi1.Margin = new System.Windows.Forms.Padding(2);
            this.riichi1.Name = "riichi1";
            this.riichi1.Size = new System.Drawing.Size(78, 22);
            this.riichi1.TabIndex = 25;
            this.riichi1.Tag = "riichi";
            this.riichi1.Text = "立直";
            this.riichi1.UseMnemonic = false;
            this.riichi1.UseVisualStyleBackColor = true;
            // 
            // tsumo0
            // 
            this.tsumo0.AutoSize = true;
            this.tsumo0.Location = new System.Drawing.Point(93, 173);
            this.tsumo0.Margin = new System.Windows.Forms.Padding(2);
            this.tsumo0.Name = "tsumo0";
            this.tsumo0.Size = new System.Drawing.Size(39, 22);
            this.tsumo0.TabIndex = 33;
            this.tsumo0.Tag = "tsumo";
            this.tsumo0.Text = "自摸";
            this.tsumo0.UseMnemonic = false;
            this.tsumo0.UseVisualStyleBackColor = true;
            // 
            // riichi3
            // 
            this.riichi3.AutoSize = true;
            this.riichi3.Location = new System.Drawing.Point(420, 146);
            this.riichi3.Margin = new System.Windows.Forms.Padding(2);
            this.riichi3.Name = "riichi3";
            this.riichi3.Size = new System.Drawing.Size(77, 22);
            this.riichi3.TabIndex = 27;
            this.riichi3.Tag = "riichi";
            this.riichi3.Text = "立直";
            this.riichi3.UseMnemonic = false;
            this.riichi3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 261);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 41;
            this.label5.Text = "连庄";
            // 
            // riichisticks
            // 
            this.riichisticks.AutoSize = true;
            this.riichisticks.Location = new System.Drawing.Point(21, 261);
            this.riichisticks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.riichisticks.Name = "riichisticks";
            this.riichisticks.Size = new System.Drawing.Size(29, 12);
            this.riichisticks.TabIndex = 40;
            this.riichisticks.Text = "场供";
            // 
            // combo
            // 
            this.combo.AcceptsReturn = true;
            this.combo.AcceptsTab = true;
            this.combo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.combo.Enabled = false;
            this.combo.Location = new System.Drawing.Point(115, 258);
            this.combo.Margin = new System.Windows.Forms.Padding(2);
            this.combo.MaxLength = 20;
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(23, 21);
            this.combo.TabIndex = 34;
            this.combo.Tag = "status";
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
            this.kyutaku.Location = new System.Drawing.Point(53, 258);
            this.kyutaku.Margin = new System.Windows.Forms.Padding(2);
            this.kyutaku.MaxLength = 20;
            this.kyutaku.Name = "kyutaku";
            this.kyutaku.Size = new System.Drawing.Size(23, 21);
            this.kyutaku.TabIndex = 33;
            this.kyutaku.Tag = "status";
            this.kyutaku.Text = "0";
            this.kyutaku.WordWrap = false;
            this.kyutaku.LostFocus += new System.EventHandler(this.kyutaku_LoseFocus);
            // 
            // riichi0
            // 
            this.riichi0.AutoSize = true;
            this.riichi0.Location = new System.Drawing.Point(93, 146);
            this.riichi0.Margin = new System.Windows.Forms.Padding(2);
            this.riichi0.Name = "riichi0";
            this.riichi0.Size = new System.Drawing.Size(78, 22);
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
            this.name0.Location = new System.Drawing.Point(99, 67);
            this.name0.Margin = new System.Windows.Forms.Padding(2);
            this.name0.MaxLength = 20;
            this.name0.Name = "name0";
            this.name0.ReadOnly = true;
            this.name0.Size = new System.Drawing.Size(68, 21);
            this.name0.TabIndex = 0;
            this.name0.Tag = "name";
            this.name0.Text = "PLAYER1";
            this.name0.WordWrap = false;
            this.name0.GotFocus += new System.EventHandler(this.textboxGetFocus);
            // 
            // name1
            // 
            this.name1.AcceptsReturn = true;
            this.name1.AcceptsTab = true;
            this.name1.BackColor = System.Drawing.SystemColors.Window;
            this.name1.Location = new System.Drawing.Point(207, 67);
            this.name1.Margin = new System.Windows.Forms.Padding(2);
            this.name1.MaxLength = 20;
            this.name1.Name = "name1";
            this.name1.ReadOnly = true;
            this.name1.Size = new System.Drawing.Size(68, 21);
            this.name1.TabIndex = 1;
            this.name1.Tag = "name";
            this.name1.Text = "PLAYER2";
            this.name1.WordWrap = false;
            this.name1.GotFocus += new System.EventHandler(this.textboxGetFocus);
            // 
            // name2
            // 
            this.name2.AcceptsReturn = true;
            this.name2.AcceptsTab = true;
            this.name2.BackColor = System.Drawing.SystemColors.Window;
            this.name2.Location = new System.Drawing.Point(316, 67);
            this.name2.Margin = new System.Windows.Forms.Padding(2);
            this.name2.MaxLength = 20;
            this.name2.Name = "name2";
            this.name2.ReadOnly = true;
            this.name2.Size = new System.Drawing.Size(68, 21);
            this.name2.TabIndex = 2;
            this.name2.Tag = "name";
            this.name2.Text = "PLAYER3";
            this.name2.WordWrap = false;
            this.name2.GotFocus += new System.EventHandler(this.textboxGetFocus);
            // 
            // name3
            // 
            this.name3.AcceptsReturn = true;
            this.name3.AcceptsTab = true;
            this.name3.BackColor = System.Drawing.SystemColors.Window;
            this.name3.Location = new System.Drawing.Point(425, 67);
            this.name3.Margin = new System.Windows.Forms.Padding(2);
            this.name3.MaxLength = 20;
            this.name3.Name = "name3";
            this.name3.ReadOnly = true;
            this.name3.Size = new System.Drawing.Size(68, 21);
            this.name3.TabIndex = 3;
            this.name3.Tag = "name";
            this.name3.Text = "PLAYER4";
            this.name3.WordWrap = false;
            this.name3.GotFocus += new System.EventHandler(this.textboxGetFocus);
            // 
            // teamname3
            // 
            this.teamname3.AcceptsReturn = true;
            this.teamname3.AcceptsTab = true;
            this.teamname3.BackColor = System.Drawing.SystemColors.Window;
            this.teamname3.Enabled = false;
            this.teamname3.Location = new System.Drawing.Point(425, 44);
            this.teamname3.Margin = new System.Windows.Forms.Padding(2);
            this.teamname3.MaxLength = 20;
            this.teamname3.Name = "teamname3";
            this.teamname3.ReadOnly = true;
            this.teamname3.Size = new System.Drawing.Size(68, 21);
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
            this.teamname2.Enabled = false;
            this.teamname2.Location = new System.Drawing.Point(316, 44);
            this.teamname2.Margin = new System.Windows.Forms.Padding(2);
            this.teamname2.MaxLength = 20;
            this.teamname2.Name = "teamname2";
            this.teamname2.ReadOnly = true;
            this.teamname2.Size = new System.Drawing.Size(68, 21);
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
            this.teamname1.Enabled = false;
            this.teamname1.Location = new System.Drawing.Point(207, 44);
            this.teamname1.Margin = new System.Windows.Forms.Padding(2);
            this.teamname1.MaxLength = 20;
            this.teamname1.Name = "teamname1";
            this.teamname1.ReadOnly = true;
            this.teamname1.Size = new System.Drawing.Size(68, 21);
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
            this.teamname0.Enabled = false;
            this.teamname0.Location = new System.Drawing.Point(99, 44);
            this.teamname0.Margin = new System.Windows.Forms.Padding(2);
            this.teamname0.MaxLength = 20;
            this.teamname0.Name = "teamname0";
            this.teamname0.ReadOnly = true;
            this.teamname0.Size = new System.Drawing.Size(68, 21);
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
            this.label1.Location = new System.Drawing.Point(43, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "名字";
            // 
            // teamLabel
            // 
            this.teamLabel.AutoSize = true;
            this.teamLabel.Location = new System.Drawing.Point(33, 48);
            this.teamLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(41, 12);
            this.teamLabel.TabIndex = 11;
            this.teamLabel.Text = "团队名";
            this.teamLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "点数";
            // 
            // point3
            // 
            this.point3.AcceptsReturn = true;
            this.point3.AcceptsTab = true;
            this.point3.BackColor = System.Drawing.SystemColors.Window;
            this.point3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.point3.Enabled = false;
            this.point3.Location = new System.Drawing.Point(425, 92);
            this.point3.Margin = new System.Windows.Forms.Padding(2);
            this.point3.MaxLength = 20;
            this.point3.Name = "point3";
            this.point3.ReadOnly = true;
            this.point3.Size = new System.Drawing.Size(68, 21);
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
            this.point2.Location = new System.Drawing.Point(316, 92);
            this.point2.Margin = new System.Windows.Forms.Padding(2);
            this.point2.MaxLength = 20;
            this.point2.Name = "point2";
            this.point2.ReadOnly = true;
            this.point2.Size = new System.Drawing.Size(68, 21);
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
            this.point1.Location = new System.Drawing.Point(207, 92);
            this.point1.Margin = new System.Windows.Forms.Padding(2);
            this.point1.MaxLength = 20;
            this.point1.Name = "point1";
            this.point1.ReadOnly = true;
            this.point1.Size = new System.Drawing.Size(68, 21);
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
            this.point0.Location = new System.Drawing.Point(99, 92);
            this.point0.Margin = new System.Windows.Forms.Padding(2);
            this.point0.MaxLength = 20;
            this.point0.Name = "point0";
            this.point0.ReadOnly = true;
            this.point0.Size = new System.Drawing.Size(68, 21);
            this.point0.TabIndex = 12;
            this.point0.Tag = "point";
            this.point0.Text = "25000";
            this.point0.WordWrap = false;
            this.point0.GotFocus += new System.EventHandler(this.textboxGetFocus);
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.Location = new System.Drawing.Point(371, 258);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(63, 22);
            this.button7.TabIndex = 44;
            this.button7.Text = "其他设置";
            this.button7.UseMnemonic = false;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.setting_Click);
            // 
            // reset
            // 
            this.reset.AutoSize = true;
            this.reset.Location = new System.Drawing.Point(491, 258);
            this.reset.Margin = new System.Windows.Forms.Padding(2);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(63, 22);
            this.reset.TabIndex = 43;
            this.reset.Text = "重置游戏";
            this.reset.UseMnemonic = false;
            this.reset.UseVisualStyleBackColor = true;
            // 
            // draw
            // 
            this.draw.AutoSize = true;
            this.draw.Location = new System.Drawing.Point(437, 258);
            this.draw.Margin = new System.Windows.Forms.Padding(2);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(50, 22);
            this.draw.TabIndex = 42;
            this.draw.Text = "流局";
            this.draw.UseMnemonic = false;
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // oya3
            // 
            this.oya3.AutoSize = true;
            this.oya3.Location = new System.Drawing.Point(444, 16);
            this.oya3.Margin = new System.Windows.Forms.Padding(2);
            this.oya3.Name = "oya3";
            this.oya3.Size = new System.Drawing.Size(27, 22);
            this.oya3.TabIndex = 32;
            this.oya3.Tag = "seat";
            this.oya3.Text = "子";
            this.oya3.UseMnemonic = false;
            this.oya3.UseVisualStyleBackColor = true;
            // 
            // oya2
            // 
            this.oya2.AutoSize = true;
            this.oya2.Location = new System.Drawing.Point(334, 16);
            this.oya2.Margin = new System.Windows.Forms.Padding(2);
            this.oya2.Name = "oya2";
            this.oya2.Size = new System.Drawing.Size(27, 22);
            this.oya2.TabIndex = 31;
            this.oya2.Tag = "seat";
            this.oya2.Text = "子";
            this.oya2.UseMnemonic = false;
            this.oya2.UseVisualStyleBackColor = true;
            // 
            // oya1
            // 
            this.oya1.AutoSize = true;
            this.oya1.Location = new System.Drawing.Point(226, 16);
            this.oya1.Margin = new System.Windows.Forms.Padding(2);
            this.oya1.Name = "oya1";
            this.oya1.Size = new System.Drawing.Size(27, 22);
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
            this.oya0.Location = new System.Drawing.Point(118, 16);
            this.oya0.Margin = new System.Windows.Forms.Padding(2);
            this.oya0.Name = "oya0";
            this.oya0.Size = new System.Drawing.Size(27, 22);
            this.oya0.TabIndex = 29;
            this.oya0.Tag = "seat";
            this.oya0.Text = "親";
            this.oya0.UseMnemonic = false;
            this.oya0.UseVisualStyleBackColor = false;
            // 
            // tenpai2
            // 
            this.tenpai2.AutoSize = true;
            this.tenpai2.Location = new System.Drawing.Point(325, 120);
            this.tenpai2.Margin = new System.Windows.Forms.Padding(2);
            this.tenpai2.Name = "tenpai2";
            this.tenpai2.Size = new System.Drawing.Size(50, 22);
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
            this.tenpai1.Location = new System.Drawing.Point(214, 120);
            this.tenpai1.Margin = new System.Windows.Forms.Padding(2);
            this.tenpai1.Name = "tenpai1";
            this.tenpai1.Size = new System.Drawing.Size(50, 22);
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
            this.tenpai0.Location = new System.Drawing.Point(107, 120);
            this.tenpai0.Margin = new System.Windows.Forms.Padding(2);
            this.tenpai0.Name = "tenpai0";
            this.tenpai0.Size = new System.Drawing.Size(50, 22);
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
            this.tenpai3.Location = new System.Drawing.Point(433, 120);
            this.tenpai3.Margin = new System.Windows.Forms.Padding(2);
            this.tenpai3.Name = "tenpai3";
            this.tenpai3.Size = new System.Drawing.Size(50, 22);
            this.tenpai3.TabIndex = 55;
            this.tenpai3.Tag = "tenpai";
            this.tenpai3.Text = "不听";
            this.tenpai3.UseMnemonic = false;
            this.tenpai3.UseVisualStyleBackColor = true;
            this.tenpai3.Visible = false;
            // 
            // winner
            // 
            this.winner.AutoSize = true;
            this.winner.Location = new System.Drawing.Point(33, 152);
            this.winner.Name = "winner";
            this.winner.Size = new System.Drawing.Size(0, 12);
            this.winner.TabIndex = 56;
            this.winner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameStatusLock
            // 
            this.gameStatusLock.AutoSize = true;
            this.gameStatusLock.BackgroundImage = global::riichi_display.Properties.Resources._lock;
            this.gameStatusLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gameStatusLock.Location = new System.Drawing.Point(222, 261);
            this.gameStatusLock.Margin = new System.Windows.Forms.Padding(2);
            this.gameStatusLock.Name = "gameStatusLock";
            this.gameStatusLock.Size = new System.Drawing.Size(18, 16);
            this.gameStatusLock.TabIndex = 48;
            this.gameStatusLock.UseMnemonic = false;
            this.gameStatusLock.UseVisualStyleBackColor = true;
            // 
            // pointLock
            // 
            this.pointLock.AutoSize = true;
            this.pointLock.BackgroundImage = global::riichi_display.Properties.Resources._lock;
            this.pointLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pointLock.Location = new System.Drawing.Point(515, 94);
            this.pointLock.Margin = new System.Windows.Forms.Padding(2);
            this.pointLock.Name = "pointLock";
            this.pointLock.Size = new System.Drawing.Size(18, 16);
            this.pointLock.TabIndex = 16;
            this.pointLock.UseMnemonic = false;
            this.pointLock.UseVisualStyleBackColor = true;
            // 
            // teamlock
            // 
            this.teamlock.AutoSize = true;
            this.teamlock.BackgroundImage = global::riichi_display.Properties.Resources._lock;
            this.teamlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.teamlock.Location = new System.Drawing.Point(515, 46);
            this.teamlock.Margin = new System.Windows.Forms.Padding(2);
            this.teamlock.MaximumSize = new System.Drawing.Size(23, 20);
            this.teamlock.Name = "teamlock";
            this.teamlock.Size = new System.Drawing.Size(18, 16);
            this.teamlock.TabIndex = 9;
            this.teamlock.UseMnemonic = false;
            this.teamlock.UseVisualStyleBackColor = true;
            this.teamlock.Visible = false;
            // 
            // namelock
            // 
            this.namelock.AutoSize = true;
            this.namelock.BackgroundImage = global::riichi_display.Properties.Resources.unlock;
            this.namelock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.namelock.Location = new System.Drawing.Point(515, 70);
            this.namelock.Margin = new System.Windows.Forms.Padding(2);
            this.namelock.Name = "namelock";
            this.namelock.Size = new System.Drawing.Size(18, 16);
            this.namelock.TabIndex = 4;
            this.namelock.UseMnemonic = false;
            this.namelock.UseVisualStyleBackColor = true;
            // 
            // status
            // 
            this.status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.status.BackColor = System.Drawing.SystemColors.Window;
            this.status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status.Enabled = false;
            this.status.Items.AddRange(new object[] {
            "東一局",
            "東二局",
            "東三局",
            "東四局",
            "南一局",
            "南二局",
            "南三局",
            "南四局",
            "西一局",
            "西二局",
            "西三局",
            "西四局"});
            this.status.Location = new System.Drawing.Point(155, 259);
            this.status.Margin = new System.Windows.Forms.Padding(2);
            this.status.MaxLength = 20;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(59, 20);
            this.status.TabIndex = 57;
            this.status.Tag = "status";
            this.status.SelectedIndexChanged += new System.EventHandler(this.status_SelectedIndexChanged);
            // 
            // tenpaiLabel
            // 
            this.tenpaiLabel.AutoSize = true;
            this.tenpaiLabel.Location = new System.Drawing.Point(19, 125);
            this.tenpaiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tenpaiLabel.Name = "tenpaiLabel";
            this.tenpaiLabel.Size = new System.Drawing.Size(53, 12);
            this.tenpaiLabel.TabIndex = 58;
            this.tenpaiLabel.Tag = "tenpai";
            this.tenpaiLabel.Text = "听牌状态";
            this.tenpaiLabel.Visible = false;
            // 
            // han
            // 
            this.han.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.han.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.han.BackColor = System.Drawing.SystemColors.Window;
            this.han.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.han.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "满贯",
            "跳满",
            "倍满",
            "三倍满",
            "役满",
            "双倍役满",
            "三倍役满",
            "四倍役满",
            "五倍役满"});
            this.han.Location = new System.Drawing.Point(238, 202);
            this.han.Margin = new System.Windows.Forms.Padding(2);
            this.han.MaxLength = 20;
            this.han.Name = "han";
            this.han.Size = new System.Drawing.Size(51, 20);
            this.han.TabIndex = 59;
            this.han.SelectedIndexChanged += new System.EventHandler(this.han_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 205);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 60;
            this.label7.Text = "翻";
            // 
            // fu
            // 
            this.fu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.fu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.fu.BackColor = System.Drawing.SystemColors.Window;
            this.fu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fu.Items.AddRange(new object[] {
            "20",
            "25",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120"});
            this.fu.Location = new System.Drawing.Point(311, 202);
            this.fu.Margin = new System.Windows.Forms.Padding(2);
            this.fu.MaxLength = 20;
            this.fu.Name = "fu";
            this.fu.Size = new System.Drawing.Size(50, 20);
            this.fu.TabIndex = 61;
            this.fu.SelectedIndexChanged += new System.EventHandler(this.han_SelectedIndexChanged);
            // 
            // labelfu
            // 
            this.labelfu.AutoSize = true;
            this.labelfu.Location = new System.Drawing.Point(365, 205);
            this.labelfu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelfu.Name = "labelfu";
            this.labelfu.Size = new System.Drawing.Size(17, 12);
            this.labelfu.TabIndex = 62;
            this.labelfu.Text = "符";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 205);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 63;
            this.label8.Text = "点数计算:";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 292);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelfu);
            this.Controls.Add(this.fu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.han);
            this.Controls.Add(this.tenpaiLabel);
            this.Controls.Add(this.status);
            this.Controls.Add(this.winner);
            this.Controls.Add(this.tenpai2);
            this.Controls.Add(this.tenpai1);
            this.Controls.Add(this.tenpai0);
            this.Controls.Add(this.tenpai3);
            this.Controls.Add(this.gameStatusLock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.riichisticks);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.kyutaku);
            this.Controls.Add(this.pointGain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addup3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addup2);
            this.Controls.Add(this.playerList);
            this.Controls.Add(this.ron3);
            this.Controls.Add(this.addup1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.riichi2);
            this.Controls.Add(this.addup0);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "雀庄直播计分显示系统 By Shin Z";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name0;
        private System.Windows.Forms.TextBox name1;
        private System.Windows.Forms.TextBox name2;
        private System.Windows.Forms.TextBox name3;
        private System.Windows.Forms.Button namelock;
        private System.Windows.Forms.Button teamlock;
        private System.Windows.Forms.TextBox teamname3;
        private System.Windows.Forms.TextBox teamname2;
        private System.Windows.Forms.TextBox teamname1;
        private System.Windows.Forms.TextBox teamname0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pointLock;
        private System.Windows.Forms.TextBox point3;
        private System.Windows.Forms.TextBox point2;
        private System.Windows.Forms.TextBox point1;
        private System.Windows.Forms.TextBox point0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox addup3;
        private System.Windows.Forms.TextBox addup2;
        private System.Windows.Forms.TextBox addup1;
        private System.Windows.Forms.TextBox addup0;
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
        private System.Windows.Forms.Button gameStatusLock;
        private System.Windows.Forms.ComboBox pointGain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tenpai2;
        private System.Windows.Forms.Button tenpai1;
        private System.Windows.Forms.Button tenpai0;
        private System.Windows.Forms.Button tenpai3;
        private System.Windows.Forms.Label winner;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label tenpaiLabel;
        private System.Windows.Forms.ComboBox han;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox fu;
        private System.Windows.Forms.Label labelfu;
        private System.Windows.Forms.Label label8;
    }
}

