﻿/*
This file is part of Riichi Livestream Display System.

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


using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Button = System.Windows.Forms.Button;

namespace riichi_display
{ 
    public partial class mainForm : Form
    {
        private readonly string LOGFOLDERPATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "RiichiLogs");
        private readonly string LOGPATH;

        // Declaration of forms used in the main form
        private displayForm displayForm;
        private settingForm setting;
        private statusBar statusForm;
        private doraControl doraControl;

        private PointHandler handler;
        private Player[] players;
        private Logger log;
        private SettingSaveLoader sl;

        // Declare events to handle various actions in the application
        private event EventHandler<DisplayUpdateEvent> DisplayUpdateEvent;
        private event EventHandler<DisplayWindowUpdateEvent> DisplayWindowUpdateEvent;
        private event EventHandler<PointCalculateEvent> PointCalculateEvent;
        private event EventHandler<FormDisplayUpdateEvent> FormDisplayUpdateEvent;
        private event EventHandler<AddupDisplayEvent> AddupDisplayEvent;
        private event EventHandler<RiichiDisplayEvent> RiichiDisplayEvent;
        private event EventHandler<WindChangeEvent> WindChangeEvent;
        private event EventHandler<RoundUpdateEvent> RoundUpdateEvent;

        private bool isDraw = false;
        private bool doubleEnter = false;

        public mainForm()
        {
            LOGPATH = LOGFOLDERPATH + "/gamelog-" + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".txt"; // set the log path

            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(SavePlayerWhenClosing);

            log = new Logger(LOGPATH);
            // Initialize form properties and event handlers
            PointCalculateEvent += han_SelectedIndexChanged; // Subscribe han_selectedIndexChanged instead of PointUpdate because easier to manage
            FormDisplayUpdateEvent += FormUpdate;
            DisplayUpdateEvent += DisplayUpdate;
            WindChangeEvent += windChgeControl;
            ActiveControl = null; // Remove focus from any form control

            // Initialize and show the display form
            displayForm = new displayForm();
            DisplayWindowUpdateEvent += DisplayWindowUpdate;
            RiichiDisplayEvent += displayForm.RiichiSwitch;
            AddupDisplayEvent += displayForm.AddupUpdate;
            displayForm.Show();

            // Initialize the settings form and subscribe to its events
            setting = new settingForm(LOGFOLDERPATH);
            setting.teamCtrlEvent += changeTeamControl;
            setting.WindChgeEvent += windChgeControl;
            setting.windIndicator.Click += (s, e) => { displayForm.wind.Visible = !displayForm.wind.Visible; };
            setting.OnFontUpdate += displayForm.OnFontUpdate;
            //setting.riichiDisplay.Click += displayForm.OnRiichiPoistionUpdate;

            statusForm = new statusBar();
            RoundUpdateEvent += statusForm.RoundUpdate;
            statusForm.Show();

            doraControl = new doraControl();
            doraControl.DoraUpdateEvent += statusForm.DoraUpdate;
            doraControl.Show();

            sl = new SettingSaveLoader();
            players = sl.LoadPlayer();
            handler = sl.LoadHandler();
            displayForm.OnStart(sl.LoadDisplay());
            setting.OnStart(sl.LoadDisplay());
            status.SelectedIndex = sl.LoadRoundIndex();
            setting.newShortCut.Click += sl.CreateShortCut;

            handler.StatusUpdateEvent += (s, e) => { kyutaku.Text = handler.getKyutaku().ToString(); combo.Text = handler.getCombo().ToString(); };
            handler.StatusUpdateEvent += statusForm.StatusUpdate; // Subscribe the status when updated
            
            // Set up properties and event handlers for form controls
            PropertySetup();

            handler.SendStatusUpdateEvent();
            DisplayUpdateEvent?.Invoke(this, new DisplayUpdateEvent()); // send display update event
        }

        // Method to set up properties and event handlers for form controls
        private void PropertySetup()
        {
            foreach (Control control in this.Controls)
            {
                // Set up event handlers for various control types and tags
                if (control is System.Windows.Forms.TextBox)
                    control.KeyDown += new KeyEventHandler(enterLoseFocus);
                if (control.Tag != null)
                {
                    if (control is System.Windows.Forms.TextBox && control.Tag.ToString() != "status")
                        control.LostFocus += new EventHandler(textBox_LoseFocus);
                    switch (control.Tag.ToString())
                    {
                        case "seat":
                            control.Click += new EventHandler(seat_Click);
                            break;
                        case "name":
                            control.TextChanged += new EventHandler(name_changed);
                            break;
                        case "ron":
                            control.Click += new EventHandler(ron_clicked);
                            break;
                        case "tsumo":
                            control.Click += new EventHandler(tsumo_clicked);
                            break;
                        case "riichi":
                            control.Click += new EventHandler(riichi_clicked);
                            break;
                        case "tenpai":
                            control.Click += new EventHandler(tenpai_Click);
                            break;
                    }
                }
            }

            // Set up additional event handlers for specific controls
            submit.Click += submit_Click;
            submit.Click += doraControl.reset_Click;

            //pointGain.LostFocus += PointGain_LostFocus;
            pointGain.KeyPress += pointGain_KeyPress;
            pointGain.KeyDown += pointGain_KeyDown;
            pointGain.SelectedIndexChanged += point_SelectedIndexChanged;
            //pointGain.SelectedIndexChanged += playerList_SelectedIndexChanged; // PointGain using same method because requires same functionality

            playerList.SelectedIndexChanged += playerList_SelectedIndexChanged;

            reset.Click += reset_Click;
            reset.Click += doraControl.reset_Click;

            teamlock.Click += (sender, e) => Lock_Clicked(sender, e, "team");
            namelock.Click += (sender, e) => Lock_Clicked(sender, e, "name");
            pointLock.Click += (sender, e) => Lock_Clicked(sender, e, "point");
            gameStatusLock.Click += (sender, e) => Lock_Clicked(sender, e, "status");

            han.SelectedIndex = 0;
            fu.SelectedIndex = 2;
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

        // Event handler for key down event
        private void enterLoseFocus(object sender, KeyEventArgs e)
        {
            // Remove focus from current control when enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = null;
            }
        }

        // Lock control
        private void Lock_Clicked(object sender, EventArgs e, string tag)
        {
            Button button = sender as Button;
            bool currentStatus = false;
            foreach (Control control in Controls)
            {
                if (control.Tag != null)
                {
                    if (control.Tag.ToString() == tag)
                    {
                        control.Enabled = !control.Enabled;
                        currentStatus = control.Enabled;
                    }
                }
            }
            button.BackgroundImage = currentStatus ? Properties.Resources.unlock : Properties.Resources._lock;
        }

        // Event handler for setting form events to change team control visibility
        private void changeTeamControl(object sender, TeamControlEvent e)
        {
            teamLabel.Visible = !teamLabel.Visible;
            teamname0.Visible = teamLabel.Visible;
            teamname1.Visible = teamLabel.Visible;
            teamname2.Visible = teamLabel.Visible;
            teamname3.Visible = teamLabel.Visible;
            teamlock.Visible = teamLabel.Visible;
            // Also change visibility on displayForm
            foreach (Control control in displayForm.Controls)
            {
                if (control.Tag != null && control.Tag.ToString() == "team")
                {
                    control.Visible = teamLabel.Visible;
                }
            }
        }

        private void textBox_LoseFocus(object sender, EventArgs e)
        {
            // Event handler for text box losing focus. It updates player details based on the text box that lost focus.
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            if (textBox.Tag.ToString() == "status") return; // exclude the status because they don't need to update player info
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
                    players[n].Point = int.Parse(textBox.Text);
                    break;
                case "addup":
                    break;
                default:
                    throw new Exception($"Invalid tag: {textBox.Tag}");
            }
            string value = textBox.Tag.ToString().ToUpper();

            if (Enum.TryParse(value, out EditType editType))
            {
                log.LogEditValue(editType, n, textBox.Text);
            }
            Console.WriteLine(players[n].ToString());
            DisplayUpdateEvent?.Invoke(sender, new DisplayUpdateEvent(textBox.Tag.ToString())); // send display update event
        }

        private int determinePlayer(string name)
        {
            // Determine the player index based on the name
            int index = int.Parse(name[name.Length - 1].ToString());
            if (index > players.Length)
                throw new Exception("Invalid Index @determinePlayer!");
            return index;
        }

        // Event handler for clicking on a seat button
        private void seat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            int n = determinePlayer(button.Name); // Get index of the player
            for (int i = 0; i < players.Length; i++)
            {
                if (i != n)
                    players[i].Oya = false; // Set other players as non-dealer
                else
                {
                    players[i].Oya = true; // Set current player as dealer
                    log.LogEditValue(EditType.DEALER, n, "IS DEALER"); // mark the manual changes of dealer
                }
            }
            //Console.WriteLine(players[n].ToString());
            DisplayUpdateEvent?.Invoke(sender, new DisplayUpdateEvent()); // Send display update event
        }

        // Event handler for clicking on a setting button
        private void setting_Click(object sender, EventArgs e)
        {
            if (setting.IsDisposed)
            {
                setting = new settingForm(LOGFOLDERPATH);
                setting.teamCtrlEvent += changeTeamControl;
                setting.WindChgeEvent += windChgeControl;
                setting.windIndicator.Click += (s, p) => { displayForm.wind.Visible = !displayForm.wind.Visible; };
                setting.newShortCut.Click += sl.CreateShortCut;
            }
            setting.Show();
        }

        private bool windControl = false; // Ton when it's false, Nan otherwise.

        // Event handler for changing wind control
        private void windChgeControl(object sender, WindChangeEvent e)
        {
            windControl = !windControl;
            if (e.Signal == 42)
                windControl = false;
            displayForm.wind.BackgroundImage = windControl ? Properties.Resources.nan : Properties.Resources.ton;
        }

        // Event handler for text change in name textboxes
        private void name_changed(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            int n = determinePlayer(textBox.Name); // Get index of the player
            players[n].Name = textBox.Text;
            // Clear the combobox items
            playerList.Items.Clear();

            playerList.Items.Add("三家");
            // Add player names to combobox
            foreach (Player player in players)
            {
                playerList.Items.Add(player.Name);
            }
            //Console.WriteLine(players[n].ToString());
        }

        // Event handler for ron/tsumo button click
        private void SetWinnerAndCalculatePoints(object sender, bool isTsumo)
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

            if (isTsumo)
            {
                log.Action = ActionType.TSUMO;
                playerList.Text = "三家";
                playerList.Enabled = false;
            }
            else
            {
                log.Action = ActionType.RON;
                playerList.Enabled = true;
            }

            submit.Enabled = true;
            Console.WriteLine(players[n].ToString());
            PointCalculateEvent?.Invoke(sender, new PointCalculateEvent()); // send point calculate event
        }

        // ron button clicked
        private void ron_clicked(object sender, EventArgs e)
        {
            SetWinnerAndCalculatePoints(sender, false);
        }

        // tsumo button clicked
        private void tsumo_clicked(object sender, EventArgs e)
        {
            SetWinnerAndCalculatePoints(sender, true);
        }

        // Event handler for clicking on a Riichi button
        private void riichi_clicked(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            int n = determinePlayer(button.Name); // Get index of the player

            // Player goes into Riichi, lose 1000 points
            players[n].Riichi = !players[n].Riichi;
            players[n].Point += players[n].Riichi ? -1000 : 1000;

            // Add a point to the "kyutaku" pot
            if (players[n].Riichi)
            {
                handler.AddKyutaku();
            }
            else
            {
                handler.setKyutaku(handler.getKyutaku() - 1);
            }

            var tenpaiButton = this.Controls.Find("tenpai" + n, true).FirstOrDefault() as System.Windows.Forms.Button;
            tenpaiButton.PerformClick();

            //button.Text = players[n].Riichi ? "取消立直" : "立直";
            //// Disable the Riichi button after click
            //button.Enabled = false;

            // Print out player status
            Console.WriteLine(players[n].ToString());

            // Invoke the relevant events
            log.LogRiichi(players[n]);

            DisplayUpdateEvent?.Invoke(sender, new DisplayUpdateEvent()); // Send display update event
            //FormDisplayUpdateEvent?.Invoke(sender, new FormDisplayUpdateEvent()); // Send form update event
            //RiichiDisplayEvent?.Invoke(sender, new RiichiDisplayEvent(n, players[n].Riichi)); // Send riichi update
            AddupDisplayEvent?.Invoke(this, new AddupDisplayEvent(n, -1000));
            //DisplayWindowUpdateEvent?.Invoke(sender, new DisplayWindowUpdateEvent(button.Tag.ToString())); // Send display update event
        }

        // Event handler for clicking on the submit button
        private void submit_Click(object sender, EventArgs e)
        {
            doubleEnter = false;

            long oyaIndex = 0;
            bool oyaWin = false;

            log.LogStatus(status.Text, handler.getKyutaku(), handler.getCombo()); // Log the status before the round ends

            // Loop through all players
            foreach (Player player in players)
            {
                // Update players' points
                player.Point += player.Addup;
                AddupDisplayEvent?.Invoke(this, new AddupDisplayEvent(player.Index, player.Addup));

                // Determine the index of the dealer and whether the dealer won or not
                if (isDraw && player.Oya && player.Tenpai)
                {
                    oyaIndex = player.Index;
                }
                else if (player.Oya && player.Winner)
                {
                    oyaWin = true;
                    oyaIndex = player.Index;
                }
                else if (player.Oya)
                {
                    oyaIndex = player.Index + 1;
                    ToNextRoundIdicator();
                }

                //Console.WriteLine(player.ToString());
            }

            log.LogSubmission(players); // Log the submission

            // Increment the combo count depending on the game result
            if (isDraw)
            {
                handler.AddCombo();
            }
            else if (oyaWin)
            {
                handler.AddCombo();
                handler.clearRiichi();
            }
            else
            {
                handler.Reset();
            }

            // Handle wind rotation
            if (oyaIndex > 3)
            {
                WindChangeEvent?.Invoke(sender, new WindChangeEvent());
                oyaIndex = 0;
            }

            // Click on the next dealer button programmatically
            System.Windows.Forms.Button control = this.Controls.Find("oya" + oyaIndex, true).FirstOrDefault() as System.Windows.Forms.Button;
            if (control != null)
            {
                control.PerformClick();
            }

            NextRound();
            DisplayUpdateEvent?.Invoke(sender, new DisplayUpdateEvent()); // Send display update event
        }

        // Event handler for clicking on the reset button
        private void reset_Click(object sender, EventArgs e)
        {
            NextRound();
            
            // Reset all players and the handler
            foreach (Player player in players)
                player.Reset();
            handler.Reset();

            // Click on the first dealer button programmatically
            oya0.PerformClick();
            ToNextRoundIdicator(0);

            log.LogReset();
            WindChangeEvent?.Invoke(sender, new WindChangeEvent(42));
            DisplayUpdateEvent?.Invoke(sender, new DisplayUpdateEvent()); // Send display update event
            FormDisplayUpdateEvent?.Invoke(sender, new FormDisplayUpdateEvent()); // Send form update event
        }

        // Event handler for clicking on the draw button
        private void draw_Click(object sender, EventArgs e)
        {
            isDraw = !isDraw;
            
            // Toggle visibility and availability of related controls
            tenpai0.Visible = isDraw;
            tenpai1.Visible = isDraw;
            tenpai2.Visible = isDraw;
            tenpai3.Visible = isDraw;
            tenpaiLabel.Visible = isDraw;
            tsumo0.Enabled = !isDraw;
            tsumo1.Enabled = !isDraw;
            tsumo2.Enabled = !isDraw;
            tsumo3.Enabled = !isDraw;
            ron0.Enabled = !isDraw;
            ron1.Enabled = !isDraw;
            ron2.Enabled = !isDraw;
            ron3.Enabled = !isDraw;
            winner.Visible = !isDraw;

            if (!isDraw) // Lock submit if draw is cancelled to prevent potential bugs
            {
                submit.Enabled = false;
            }


            // Read the current tenpai status
            foreach (Player player in players)
            {
                if (player.Riichi)
                {
                    var control = Controls.Find("tenpai" + player.Index, true).FirstOrDefault();
                    Button button = control as Button;
                    if (button.Text == "不听")
                        button.PerformClick();
                }
            }

            FormDisplayUpdateEvent?.Invoke(sender, new FormDisplayUpdateEvent()); // Send form update event
            if (!isDraw)
            {
                addup0.Text = "0";
                addup1.Text = "0";
                addup2.Text = "0";
                addup3.Text = "0";
            }
            // Enable the submit button
            submit.Enabled = true;
            log.Action = ActionType.DRAW;
        }

        // Event handler for clicking on a tenpai button
        private void tenpai_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            int n = determinePlayer(button.Name); // Get index of the player

            // Toggle player's Tenpai status
            players[n].Tenpai = !players[n].Tenpai;

            // Handle text and point change
            if (players[n].Tenpai)
            {
                handler.Tenpai++;
            }
            else
            {
                handler.Tenpai--;
            }

            (int receive, int pay) = handler.GetTenpaiAddup();

            // Apply the point exchange to all players
            foreach (Player player in players)
            {
                if (player.Tenpai)
                {
                    player.Addup = receive;
                }
                else
                {
                    player.Addup = 0 - pay;
                }
            }

            FormDisplayUpdateEvent?.Invoke(sender, new FormDisplayUpdateEvent()); // Send form update event
        }
        private void PointUpdate(object sender, PointCalculateEvent e)
        {
            // Ensure playerList and pointGain fields are not empty
            if (playerList.Text == "" || pointGain.Text == "")
                return;
            int oya = 0, ko = 0;

            if (playerList.Text == "三家")
            {
                // Iterating over each player and handling only the winner
                foreach (Player player in players)
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

                // Iterate over each player and adjust the points for non-winners
                foreach (Player player in players)
                {
                    if (!player.Winner)
                    {
                        player.Addup = player.Oya ? 0 - oya : 0 - ko;
                    }
                    Console.WriteLine(player.ToString());
                }
            }
            else
            {
                foreach (Player player in players) // This loop handles the winner only
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

            // Invoke FormDisplayUpdateEvent to update the form
            FormDisplayUpdateEvent?.Invoke(sender, new FormDisplayUpdateEvent());
        }

        bool justEdit = false;
        // Handles the key press event for pointGain input, ensuring only digit input of a certain length is allowed
        private void pointGain_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the input is not a digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '\r')
            {
                e.Handled = true; // Reject the input
            }
            if (e.KeyChar != '\r' && char.IsDigit(e.KeyChar))
            {
                justEdit = true;
                doubleEnter = false;
            }
            // Check if the input exceeds a maximum length
            if (!char.IsControl(e.KeyChar) && pointGain.Text.Length >= 7 && e.KeyChar != '\r')
            {
                e.Handled = true; // Reject the input
            }
        }

        // Handles the key down event for pointGain input, performs operations when Enter is pressed
        private void pointGain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check if the key pressed was Enter
            {
                if (!doubleEnter)
                {
                    doubleEnter = true;
                    PointCalculateEvent?.Invoke(sender, new PointCalculateEvent(pointGain.Text)); // send point update event
                    log.LogPoint(pointGain.Text);
                    Console.WriteLine("Waiting Next Enter");
                }
                else
                {
                    submit.PerformClick();
                    Console.WriteLine("Next Enter Executed");
                }
            }
        }

        // When combo control loses focus, update the combo in the handler
        private void combo_LoseFocus(object sender, EventArgs e)
        {
            handler.setCombo(int.Parse(combo.Text));
        }

        // When kyutaku control loses focus, update the kyutaku in the handler
        private void kyutaku_LoseFocus(object sender, EventArgs e)
        {
            handler.setKyutaku(int.Parse(kyutaku.Text));
        }

        // Update the display when a DisplayUpdateEvent is triggered
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

            // Invoke FormDisplayUpdateEvent to update the form
            FormDisplayUpdateEvent?.Invoke(sender, new FormDisplayUpdateEvent());
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
                    UpdateControl(displayForm, player, "name", player.Name);
                    var control = displayForm.Controls.Find(controlName, true).FirstOrDefault();
                    if (control != null)
                    {
                        if (player.Oya)
                            control.ForeColor = Color.DarkOrange;
                        else
                            control.ForeColor = Color.White;
                    }
                }
                else if (propertyName == "riichi")
                {
                    controlName = "point" + player.Index;
                    var control = displayForm.Controls.Find(controlName, true).FirstOrDefault();
                    RiichiDisplayEvent?.Invoke(sender, new RiichiDisplayEvent(player.Index, player.Riichi)); // send riichi update
                    if (control != null)
                    {
                        control.Text = player.Point.ToString();
                    }
                }
                else
                {
                    if (propertyName == "Addup")
                        return;
                    // For other properties, we can use our new method to update the control
                    var property = typeof(Player).GetProperty(char.ToUpper(propertyName[0]) + propertyName.Substring(1));
                    if (property != null)
                    {
                        object value = property.GetValue(player);
                        UpdateControl(displayForm, player, propertyName, value);
                    }
                }
            }
        }


        // Form update only updates the controls that are not usually updated manually
        private void FormUpdate(object sender, FormDisplayUpdateEvent e)
        {
            // update the kyutaku & combo
            Controls["kyutaku"].Text = handler.getKyutaku().ToString();
            Controls["combo"].Text = handler.getCombo().ToString();

            foreach (Player player in players)
            {
                UpdateControl(this, player, "point", player.Point);
                UpdateControl(this, player, "addup", player.Addup);
                UpdateControl(this, player, "name", player.Name);
                UpdateControl(this, player, "team", player.Team);

                Button control = this.Controls.Find("riichi" + player.Index, true).FirstOrDefault() as Button;
                if (control != null)
                {
                    control.Text = player.Riichi ? "取消立直" : "立直";

                }

                control = this.Controls.Find("oya" + player.Index, true).FirstOrDefault() as Button;
                if (player.Oya)
                {
                    control.BackColor = Color.DarkOrange;
                    control.Text = "親";
                }
                else // Reset other buttons to non-dealer state
                {
                    control.BackColor = Color.White;
                    control.Text = "子";
                }

                control = this.Controls.Find("tenpai" + player.Index, true).FirstOrDefault() as Button;
                if (player.Tenpai)
                {
                    control.Text = "听牌";
                }
                else
                {
                    control.Text = "不听";
                }
            }
        }


        // Prepares for the next round by resetting fields and controls
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
                    else if (control.Tag.ToString() == "tenpai")
                    {
                        control.Text = "不听";
                    }
                }
                else
                {
                    switch (control.Name)
                    {
                        case "playerList":
                            control.Text = "";
                            control.Enabled = true;
                            break;
                        case "pointGain":
                            control.Text = "0";
                            break;
                        case "winner":
                            control.Text = "";
                            break;
                        case "draw":
                            if (isDraw)
                            {
                                Button button = control as Button;
                                button.PerformClick();
                            }
                            break;
                    }
                }
            }
            foreach (Player player in players) // clear the last round data
            {
                player.Clear();
            }
            handler.Tenpai = 0;
            submit.Enabled = false;
            fu.Enabled = true;
            han.SelectedIndex = 0;
            fu.SelectedIndex = 2;
        }

        // Resets the addup values of all players and sends a point update event
        private void playerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Player player in players)
            {
                player.Addup = 0;
            }
            PointCalculateEvent?.Invoke(sender, new PointCalculateEvent()); // send point update event
        }

        // Adjusts the status selection to the next round
        private void ToNextRoundIdicator()
        {
            if (status.SelectedIndex < 7 || (status.SelectedIndex > 7 && status.SelectedIndex < 11))
                status.SelectedIndex++;
            else
                status.SelectedIndex = 0;
            RoundUpdateEvent?.Invoke(this, new RoundUpdateEvent(status.Text));
        }

        // Adjusts the status selection to a specified round
        private void ToNextRoundIdicator(int index)
        {
            status.SelectedIndex = index;
            RoundUpdateEvent?.Invoke(this, new RoundUpdateEvent(status.Text));
        }

        // Handles the event when status is changed, and adjusts the status selection
        private void status_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToNextRoundIdicator(status.SelectedIndex);
        }

        private void UpdateControl(Form form, Player player, string propertyName, object newValue)
        {
            if (propertyName == "addup" && form != this)
                return;
            string controlName = propertyName.ToLower() + player.Index; // constructing control name
            var control = form.Controls.Find(controlName, true).FirstOrDefault();

            // Ensure the control was found
            if (control != null)
            {
                control.Text = newValue.ToString();
            }
        }

        private void han_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool oyaWinner = false;
            bool hasWinner = false;
            fu.Enabled = han.SelectedIndex >= 4 ? false : true;
            foreach (Player player in players)
            {
                if (player.Winner) hasWinner = true; // Check if there is a winner in game
                oyaWinner = player.Oya && player.Winner;
                if (oyaWinner) break;// If found out oya is winner, break
            }
            if (!hasWinner) { return;  }
            ActiveControl = pointGain;
            doubleEnter = true; // wait for the next enter

            log.LogHanFu(han.Text, fu.Text);
            // If user edit manually, the priority is higher
            pointGain.Text = justEdit ? pointGain.Text : handler.CalculatePoint(han.SelectedIndex, fu.SelectedIndex, oyaWinner).ToString();
            justEdit = false;
            PointUpdate(sender, new PointCalculateEvent()); // send point update event
        }

        private void point_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox box  = sender as System.Windows.Forms.ComboBox;
            doubleEnter = true; // wait for the next enter

            log.LogPoint(box.Text);
            //justEdit = false;
            PointUpdate(sender, new PointCalculateEvent()); // send point update event
        }

        private void SavePlayerWhenClosing(object sender, FormClosingEventArgs e)
        {
            displayStatus disStatus = displayForm.OnClose();
            sl.SaveState(players, handler, status.SelectedIndex, disStatus);
        }

        // TODO: Test round index editing storage
    }
}