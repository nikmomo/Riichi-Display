﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace riichi_display
{
    //struct playerType
    //{
        
    //}
    public partial class mainForm : Form
    {
        // Declare the forms used in the main form
        private display displayForm;
        private setting setting;

        //private string currentOya;
        //private string winner;

        PointHandler handler;
        Player[] players;

        public event EventHandler<DisplayUpdateEvent> DisplayUpdateEvent;
        public event EventHandler<PointCalculateEvent> PointCalculateEvent;
        public event EventHandler<FormDisplayUpdateEvent> FormDisplayUpdateEvent;
        public event EventHandler<AddupDisplayEvent> AddupDisplayEvent;

        public mainForm()
        {
            InitializeComponent();
            // Initialize form properties and event handlers
            PropertySetup();

            // Remove focus from any form control
            ActiveControl = null;

            // Initialize and show the display form
            displayForm = new display();
            displayForm.DisplayWindowUpdateEvent += DisplayWindowUpdate;
            displayForm.Show();

            // Initialize the settings form and subscribe to its events
            setting = new setting();
            setting.teamCtrlEvent += changeTeamControl;
            setting.WindChgeEvent += windChgeControl;

            //currentOya = "0";
            handler = new PointHandler();

            players = new Player[4];
            for (int i = 0; i < players.Length; i++)
            {
                players[i] = new Player { Index = i, Name = "PLAYER" + (i + 1).ToString() };
                if (i == 0)
                    players[i].Oya = true;
            }

        }

        // Method to set up properties and event handlers for form controls
        private void PropertySetup()
        {

            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.TextBox)
                    control.KeyDown += new KeyEventHandler(enterLoseFocus);
                if (control.Tag != null)
                {
                    if (control is System.Windows.Forms.TextBox)
                        control.LostFocus += new EventHandler(textBox_LoseFocus);
                    if (control.Tag.ToString() == "seat")
                        control.Click += new EventHandler(seat_Click);
                    else if (control.Tag.ToString() == "name")
                        control.TextChanged += new EventHandler(name_changed);
                    else if (control.Tag.ToString() == "ron")
                        control.Click += new EventHandler(ron_clicked);
                    else if (control.Tag.ToString() == "tsumo")
                        control.Click += new EventHandler(tsumo_clicked);
                    else if (control.Tag.ToString() == "riichi")
                        control.Click += new EventHandler(riichi_clicked);
                }

            }
            submit.Click += submit_Click;
            pointGain.LostFocus += PointGain_LostFocus;
            pointGain.KeyPress += pointGain_KeyPress;
            pointGain.SelectedIndexChanged += playerList_SelectedIndexChanged;
        }

        // Event handler for textbox focus
        private void textboxGetFocus(object sender, EventArgs e)
        {
            // Cast the sender to a TextBox
            System.Windows.Forms.TextBox textbox = sender as System.Windows.Forms.TextBox;
            if (textbox != null)
            {
                // Set the TextBox as editable and select all its text
                textbox.ReadOnly = false;
                textbox.SelectAll();
            }
        }

        // Event handler for textbox losing focus
        //private void textboxLoseFocus(object sender, EventArgs e)
        //{
        //    DisplayUpdate(sender, new DisplayUpdateEvent());
        //}

        // Event handler for key down event
        private void enterLoseFocus(object sender, KeyEventArgs e)
        {
            // Remove focus from current control when enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = null;
            }
        }

        // Status flags for various locks
        private bool nameLockStatus = true;  // When it's false, it's unlocked, locked otherwise
        private bool teamLockStatus = false; // When it's false, it's unlocked, locked otherwise
        private bool pointLockStatus = false; // When it's false, it's unlocked, locked otherwise
        private bool gameStatus = false; // When it's false, it's unlocked, locked otherwise

        // Event handler for name lock/unlock button click
        private void namelock_Click(object sender, EventArgs e)
        {
            nameLockStatus = !nameLockStatus;
            name0.Enabled = nameLockStatus;
            name1.Enabled = nameLockStatus;
            name2.Enabled = nameLockStatus;
            name3.Enabled = nameLockStatus;
            if (!nameLockStatus)
                namelock.BackgroundImage = Properties.Resources._lock;
            else
                namelock.BackgroundImage = Properties.Resources.unlock;
        }

        // Event handler for team lock/unlock button click
        private void teamlock_Click(object sender, EventArgs e)
        {
            teamLockStatus = !teamLockStatus;
            teamname0.Enabled = teamLockStatus;
            teamname1.Enabled = teamLockStatus;
            teamname2.Enabled = teamLockStatus;
            teamname3.Enabled = teamLockStatus;
            if (!teamLockStatus)
                teamlock.BackgroundImage = Properties.Resources._lock;
            else
                teamlock.BackgroundImage = Properties.Resources.unlock;
        }

        // Event handler for point lock/unlock button click
        private void pointlock_Click(object sender, EventArgs e)
        {
            pointLockStatus = !pointLockStatus;
            point0.Enabled = pointLockStatus;
            point1.Enabled = pointLockStatus;
            point2.Enabled = pointLockStatus;
            point3.Enabled = pointLockStatus;
            if (!pointLockStatus)
                pointLock.BackgroundImage = Properties.Resources._lock;
            else
                pointLock.BackgroundImage = Properties.Resources.unlock;
        }

        private void gameStatusLock_Click(object sender, EventArgs e)
        {
            gameStatus = !gameStatus;
            kyutaku.Enabled = gameStatus;
            combo.Enabled = gameStatus;
            if (!gameStatus)
                gameStatusLock.BackgroundImage = Properties.Resources._lock;
            else
                gameStatusLock.BackgroundImage = Properties.Resources.unlock;
        }
        
        private void textBox_LoseFocus(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            int n = determinePlayer(textBox.Name); // index of the player
            switch (textBox.Tag) // update player based on the tag
            {
                case "name":
                    players[n].Name = textBox.Text;
                    break;
                case "team":
                    players[n].Team = textBox.Text;
                    break;
                case "point":
                    players[n].Point = long.Parse(textBox.Text);
                    break;
                case "addup":
                    players[n].Addup = long.Parse(textBox.Text);
                    break;
                //case "riichi": // TODO: THIS IS BUTTON
                //    players[n].Riichi = bool.Parse(textBox.Text);
                //    break;
                //case "Tenpai": // TODO: THIS IS BUTTON
                //    players[n].Tenpai = bool.Parse(textBox.Text);
                //    break;
                //case "Oya": // TODO: THIS IS BUTTON
                //    players[n].Oya = bool.Parse(textBox.Text);
                //    break;
                //case "Winner": // TODO: THIS IS BUTTON
                //    players[n].Winner = bool.Parse(textBox.Text);
                //    break;
                default:
                    throw new Exception($"Invalid tag: {textBox.Tag}");
            }
            Console.WriteLine(players[n].ToString());
            DisplayUpdate(sender, new DisplayUpdateEvent(textBox.Tag.ToString())); // display update
        }

        private int determinePlayer(string name)
        {
            int index = int.Parse(name[name.Length - 1].ToString());
            if (index > players.Length)
                throw new Exception("Invalid Index @determinePlayer!");
            return index;

        }

        // Event handlers for various control click events
        private void seat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            int n = determinePlayer(button.Name); // index of the player
            for (int i = 0; i < players.Length; i++)
            {
                if (i != n)
                    players[i].Oya = false;
                else
                    players[i].Oya = true;
            }
            button.BackColor = Color.DarkOrange;
            button.Text = "親";
            foreach (Control control in this.Controls)
            {
                if (control.Tag != null && control.Tag.ToString() == "seat" && control != button)
                {
                    control.BackColor = Color.White;
                    control.Text = "子";
                }
            }
            Console.WriteLine(players[n].ToString());
            DisplayUpdate(sender, new DisplayUpdateEvent(button.Tag.ToString())); // display update
        }

        private void setting_Click(object sender, EventArgs e)
        {
            if (setting.IsDisposed)
            {
                setting = new setting();
                setting.teamCtrlEvent += changeTeamControl;
                setting.WindChgeEvent += windChgeControl;
            }
            setting.Show();
        }

        private void showDisplay_Click(object sender, EventArgs e)
        {
            if (displayForm.IsDisposed)
            {
                displayForm = new display();
            }
            displayForm.Show();
            DisplayUpdate(sender, new DisplayUpdateEvent());
        }

        private bool teamControl = false; // Hide team when it's false, show otherwise.
        // Event handlers for setting form events
        private void changeTeamControl(object sender, TeamControlEvent e)
        {
            teamControl = !teamControl;
            teamLabel.Visible = teamControl;
            teamname0.Visible = teamControl;
            teamname1.Visible = teamControl;
            teamname2.Visible = teamControl;
            teamname3.Visible = teamControl;
            teamlock.Visible = teamControl;
            foreach(Control control in displayForm.Controls)
            {
                if (control.Tag != null && control.Tag.ToString() == "team")
                {
                    control.Visible = teamControl;
                }
            }
        }

        private bool windControl = false; // Ton when it's false, Nan otherwise.
        private void windChgeControl(object sender, WindChangeEvent e)
        {
            windControl = !windControl;
            displayForm.wind.BackgroundImage = windControl ? Properties.Resources.nan : Properties.Resources.ton;
        }

        // Event handler for text change in name textboxes
        private void name_changed(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            int n = determinePlayer(textBox.Name); // index of the player
            players[n].Name = textBox.Text;
            // Create a list to store the textbox values
            List<string> textboxValues = new List<string>();

            // Clear the combobox items
            playerList.Items.Clear();

            playerList.Items.Add("三家");

            // Add the items from the list to the combobox
            foreach (Player player in players)
            {
                playerList.Items.Add(player.Name);
            }
            Console.WriteLine(players[n].ToString());
            //DisplayUpdate(sender, new DisplayUpdateEvent(textBox.Tag.ToString())); // send display update event
        }

        // Event handler for ron button click
        private void ron_clicked(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            int n = determinePlayer(button.Name); // index of the player
            for (int i = 0; i < players.Length; i++)
            {
                players[i].ClearAddupWinner();
                if (i != n)
                    players[i].Winner = false;
                else
                {
                    players[i].Winner = true;
                    winner.Text = players[i].Name + '\r' + button.Text;
                }
            }
            Console.WriteLine(players[n].ToString());
            PointUpdate(this, new PointCalculateEvent()); // send point calculate event
            playerList.Enabled = true;
            
        }

        private void tsumo_clicked(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            int n = determinePlayer(button.Name); // index of the player
            for (int i = 0; i < players.Length; i++)
            {
                players[i].ClearAddupWinner();
                if (i != n)
                    players[i].Winner = false;
                else
                {
                    players[i].Winner = true;
                    winner.Text = players[i].Name + '\r' + button.Text;
                }
            }
            playerList.Text = "三家";
            playerList.Enabled = false;


            Console.WriteLine(players[n].ToString());
            PointUpdate(this, new PointCalculateEvent()); // send point calculate event
        }

        private void PointUpdate(object sender, PointCalculateEvent e)
        {
            if (playerList.Text == "" || pointGain.Text == "")
                return;
            int oya = 0, ko = 0;
            if (playerList.Text == "三家")
            {
                foreach (Player player in players) // This loop handling the winner only
                {
                    if (player.Winner)
                    {
                        if (player.Oya)
                        {
                            ko = handler.Oyatsumo(int.Parse(pointGain.Text));
                        }
                        else
                        {
                            (oya, ko) = handler.Kotsumo(int.Parse(pointGain.Text));
                        }
                        player.Addup = handler.FinalAddup;
                        Console.WriteLine("Oya: " + oya + " Ko: " + ko);
                        break;
                    }
                }
                foreach (Player player in players)
                {
                    if (!player.Winner)
                    {
                        if (player.Oya)
                            player.Addup = 0 - oya;
                        else
                            player.Addup = 0 - ko;
                    }
                    Console.WriteLine(player.ToString());
                    
                }
            }
            else
            {
                foreach (Player player in players) // This loop handling the winner only
                {
                    if (player.Winner)
                    {
                        ko = handler.Ron(int.Parse(pointGain.Text));
                        player.Addup = handler.FinalAddup;
                        Console.WriteLine(player.ToString());
                        break;
                    }
                }
                foreach (Player player in players)
                {
                    if (playerList.Text == player.Name)
                    {
                        player.Addup = 0 - ko;
                        Console.WriteLine(player.ToString());
                        break;
                    }
                }
                Console.WriteLine("Oya: " + oya + " Ko: " + ko);
                
            }
            FormUpdate(sender, new FormDisplayUpdateEvent());

        }

        private void pointGain_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the input is not a digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '\r')
            {
                e.Handled = true; // Reject the input
            }

            // Check if the input exceeds a maximum length
            if (!char.IsControl(e.KeyChar) && pointGain.Text.Length >= 7 && e.KeyChar != '\r')
            {
                e.Handled = true; // Reject the input
            }

            // Check if the key pressed was Enter
            if (e.KeyChar == '\r')
            {
                playerList_SelectedIndexChanged(sender, e);
            }
        }

        // Arguement remaining here, should riichi -1000 goes to addup? or point?
        private void riichi_clicked(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            int n = determinePlayer(button.Name); // index of the player

            players[n].Riichi = true;
            players[n].Point -= 1000;

            handler.AddKyutaku();

            button.Enabled = false;

            Console.WriteLine(players[n].ToString());
            DisplayUpdate(sender, new DisplayUpdateEvent(button.Tag.ToString())); // send display update event
        }

        private void submit_Click(object sender, EventArgs e)
        {
            long oyaIndex = 0;
            foreach (Player player in players)
            {
                player.Point += player.Addup;
                AddupDisplayEvent?.Invoke(this, new AddupDisplayEvent((int)player.Index, (int)player.Addup));
                if (player.Oya && (player.Winner || player.Tenpai))
                {
                    handler.AddCombo();
                    oyaIndex = player.Index;
                }
                else if (player.Oya)
                {
                    oyaIndex = player.Index + 1;
                    handler.Reset();
                }
                Console.WriteLine(player.ToString());
            }
            if (oyaIndex > 3)
            {
                windChgeControl(this, new WindChangeEvent());
                oyaIndex = 0;
            }
            System.Windows.Forms.Button control = this.Controls.Find("oya" + oyaIndex, true).FirstOrDefault() as System.Windows.Forms.Button;
            if (control != null)
            {
                control.PerformClick();
            }
            NextRound();
            DisplayUpdate(sender, new DisplayUpdateEvent());
            
        }


        private void combo_LoseFocus(object sender, EventArgs e)
        {
            handler.setCombo(int.Parse(combo.Text));
        }

        private void kyutaku_LoseFocus(object sender, EventArgs e)
        {
            handler.setKyutaku(int.Parse(kyutaku.Text));
        }

        //private void reset_Click(object sender, EventArgs e)
        //{
        //    foreach(Control control in Controls)
        //    {
        //        if (control.Tag == null) continue;
        //        if (control.Tag.ToString() == "point")
        //        {
        //            control.Text = "25000";
        //        }
        //        if (control.Tag.ToString() == "riichi")
        //        {
        //            control.Enabled = true;
        //        }
        //        // TODO: reset oya, round wind, player choose, etc.
        //        handler.Reset();
        //    }
        //    DisplayUpdate(sender, new DisplayUpdateEvent());
        //}

        private void DisplayUpdate(object sender, DisplayUpdateEvent e)
        {
            if (e.Tag == null)
            {
                foreach (var propertyName in typeof(Player).GetProperties().Select(p => p.Name))
                {
                    DisplayWindowUpdate(sender, new DisplayWindowUpdateEvent(propertyName.ToLower()));
                }
            }
            else
            {
                DisplayWindowUpdate(sender, new DisplayWindowUpdateEvent(e.Tag));
            }
            FormUpdate(sender, new FormDisplayUpdateEvent());
            // TODO: addup display update is required
        }

        private void DisplayWindowUpdate(object sender, DisplayWindowUpdateEvent e)
        {
            foreach (Player player in players)
            {
                string propertyName = e.Tag;
                string controlName = propertyName.ToLower() + player.Index; // constructing control name
                if (propertyName == "oya") // Oya handler
                {
                    controlName = "name" + player.Index;
                }
                else if (propertyName == "riichi")
                {
                    controlName = "point" + player.Index;
                }
                var control = displayForm.Controls.Find(controlName, true).FirstOrDefault();

                // Ensure the control was found
                if (control != null)
                {
                    // Depending on the name of the control, update the corresponding property
                    switch (propertyName)
                    {
                        case "name":
                            control.Text = player.Name; break;
                        case "team":
                            control.Text = player.Team; break;
                        case "point":
                            control.Text = player.Point.ToString(); break;
                        case "addup":
                            control.Text = player.Addup.ToString(); break;
                        case nameof(Player.Riichi):
                            // TODO: Set the riichi
                        case nameof(Player.Tenpai):
                            // TODO: Set the tenpai
                        case "oya":
                            if (player.Oya)
                                control.ForeColor = Color.DarkOrange;
                            else
                                control.ForeColor = Color.White;
                            break;
                        case "riichi":
                            control.Text = player.Point.ToString(); break;
                    }
                }
            }
        }

        private void AddupDisplayUpdate(object sender, AddupDisplayEvent e)
        {

        }

        // Form update only updates the controls that not usually update manually
        private void FormUpdate(object sender, FormDisplayUpdateEvent e)
        {
            // update the kyutaku & combo
            Controls["kyutaku"].Text = handler.getKyutaku().ToString();
            Controls["combo"].Text = handler.getCombo().ToString();

            foreach (Player player in players)
            {
                foreach (var propertyName in typeof(Player).GetProperties().Select(p => p.Name))
                {
                    string controlName = propertyName.ToLower() + player.Index; // constructing control name
                    var control = this.Controls.Find(controlName, true).FirstOrDefault();

                    // Ensure the control was found
                    if (control != null)
                    {
                        // Depending on the name of the control, update the corresponding property
                        switch (propertyName.ToLower())
                        {
                            case "point":
                                control.Text = player.Point.ToString(); break;
                            case "addup":
                                control.Text = player.Addup.ToString(); break;
                            case "riichi":
                                control.Enabled = !player.Riichi; break;
                            case "tenpai":
                                // TODO HERE
                                break;
                        }
                    }
                }
            }
        }

        private void PointGain_LostFocus(object sender, EventArgs e)
        {
            PointUpdate(sender, new PointCalculateEvent()); // send point calculate event
            FormUpdate(sender, new FormDisplayUpdateEvent());
        }

        private void NextRound()
        {
            foreach (Control control in this.Controls) // Enable the riichi button
            {
                if (control.Tag != null)
                {
                    if (control.Tag.ToString() == "riichi")
                    {
                        control.Enabled = true;
                    }
                    else if (control.Tag.ToString() == "addup")
                    {
                        control.Text = "0";
                    }
                }
                else if (control.Name == "playerList")
                {
                    control.Text = "";
                    control.Enabled = true;
                }
                else if (control.Name == "pointGain")
                {
                    control.Text = "0";
                }
                else if (control.Name == "winner")
                    control.Text = "";

            }
            foreach (Player player in players) // clear the last round data
            {
                player.Clear();
            }
            
        }

        private void playerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Player player in players)
            {
                player.Addup = 0;
            }
            PointUpdate(this, new PointCalculateEvent());
        }

        // TODO: 流局设计思路：给pointHandler加一个流局的method，take听牌的人数，返回一个tuple，（听牌收的点，不听交的点）
        //       每次按下按钮切换按钮以及玩家听牌状态。

        // 想法：在把所有功能实现后，可以考虑把结构重新做一下。目前过于臃肿，不适合拓展开发。新的思路是，将每个玩家的信息
        //       做成一个可转化成json的class，重新链接所有的controls，这样可以更大程度的优化整个app运行效率。

        // TODO: 将display update分为form(控制台)的update event 和 display window 的update event
    }

}