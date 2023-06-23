using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace riichi_display
{
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

        public mainForm()
        {
            InitializeComponent();
            // Initialize form properties and event handlers
            PropertySetup();

            // Remove focus from any form control
            ActiveControl = null;

            // Initialize and show the display form
            displayForm = new display();
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
                players[i] = new Player { Index = i };
            }

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
        // Method to set up properties and event handlers for form controls
        private void PropertySetup()
        {

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    control.KeyDown += new KeyEventHandler(enterLoseFocus);
                if (control.Tag != null)
                {
                    if (control is TextBox)
                        control.LostFocus += new EventHandler(textBox_LoseFocus);
                    if (control.Tag.ToString() == "seat")
                        control.Click += new EventHandler(seat_Click);
                    //else if (control.Tag.ToString() == "playerName")
                    //    control.TextChanged += new EventHandler(name_changed);
                    //else if (control.Tag.ToString() == "ron")
                    //    control.Click += new EventHandler(ron_clicked);
                    //else if (control.Tag.ToString() == "tsumo")
                    //    control.Click += new EventHandler(tsumo_clicked);
                    //else if (control.Tag.ToString() == "riichi")
                    //    control.Click += new EventHandler(riichi_clicked);
                }
                
            }

            pointGain.KeyPress += pointGain_KeyPress;
        }

        private void textBox_LoseFocus(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            int n = determinePlayer(textBox.Name); // index of the player
            switch (textBox.Tag) // update player based on the tag
            {
                case "playerName":
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
                case "riichi": // TODO: THIS IS BUTTON
                    players[n].Riichi = bool.Parse(textBox.Text);
                    break;
                case "Tenpai": // TODO: THIS IS BUTTON
                    players[n].Tenpai = bool.Parse(textBox.Text);
                    break;
                case "Oya": // TODO: THIS IS BUTTON
                    players[n].Oya = bool.Parse(textBox.Text);
                    break;
                case "Winner": // TODO: THIS IS BUTTON
                    players[n].Winner = bool.Parse(textBox.Text);
                    break;
                default:
                    throw new Exception($"Invalid tag: {textBox.Tag}");
            }
            Console.WriteLine(players[n].ToString());
            DisplayUpdateEvent?.Invoke(this, new DisplayUpdateEvent()); // send display update event
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
            // TODO: Keep working here <<<<<<<<<<<<<<<<
            //if (button != null)
            //{
            //    button.BackColor = Color.DarkOrange;
            //    button.Text = "親";
            //    foreach (Control control in this.Controls)
            //    {
            //        if (control.Tag != null && control.Tag.ToString() == "seat" && control != button)
            //        {
            //            control.BackColor = Color.White;
            //            control.Text = "子";
            //        }
            //    }
            //    foreach(Control control in displayForm.Controls)
            //    {
            //        if (control.Tag != null && control.Tag.ToString() == "name")
            //        {
            //            var name = "p" + button.Name.Substring(3, 1) + "name";
            //            //Console.WriteLine(name);
            //            if (control.Name == name)
            //                control.ForeColor = Color.DarkOrange;
            //            else
            //                control.ForeColor = Color.White;
            //        }
            //    }
            //}
        }

        private void button7_Click(object sender, EventArgs e)
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
            // Create a list to store the textbox values
            List<string> textboxValues = new List<string>();
            foreach (Control control in this.Controls)
            {
                if (control.Tag != null && control.Tag.ToString() == "playerName")
                {
                    // Add the text from the TextBox to the list
                    textboxValues.Add(control.Text);
                }
            }

            // Clear the combobox items
            playerList.Items.Clear();

            playerList.Items.Add("三家");

            // Add the items from the list to the combobox
            foreach (string item in textboxValues)
            {
                playerList.Items.Add(item);
            }
        }

        // Event handler for ron button click
        private void ron_clicked(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            //winner = button.Name.Substring(3);
            playerList.Enabled = true;
            
        }

        private void tsumo_clicked(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            //winner = button.Name.Substring(5);
            playerList.Text = "三家";
            playerList.Enabled = false;
            
        }

        //private void pointGain_LoseFocus(object sender, EventArgs e)
        //{
        //    if (playerList.Text == "" || pointGain.Text == "")
        //        return;
        //    if (playerList.Text == "三家")
        //    {
        //        if (winner != currentOya)
        //        {
        //            int oya, ko;

        //            (oya, ko) = handler.Kotsumo(int.Parse(pointGain.Text));
        //            foreach (Control control in this.Controls)
        //            {
        //                if (control.Name.Length > 6 && control.Name.Substring(0, 6) == "ptDiff")
        //                {
        //                    if (control.Name == "ptDiff" + currentOya)
        //                    {
        //                        control.Text = '-' + oya.ToString();
        //                    }
        //                    else if (control.Name == "ptDiff" + winner)
        //                    {
        //                        control.Text = handler.FinalAddup.ToString();
        //                    }
        //                    else
        //                    {
        //                        control.Text = '-' + ko.ToString();
        //                    }
        //                }
        //            }
        //        }
        //        else
        //        {
        //            int result = handler.Oyatsumo(int.Parse(pointGain.Text));
        //            foreach (Control control in this.Controls)
        //            {
        //                if (control.Name.Length > 6 && control.Name.Substring(0, 6) == "ptDiff")
        //                {
        //                    if (control.Name == "ptDiff" + winner)
        //                    {
        //                        control.Text = handler.FinalAddup.ToString();
        //                    }
        //                    else
        //                    {
        //                        control.Text = '-' + result.ToString();
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    else
        //    {
        //        var result = handler.Ron(int.Parse(pointGain.Text));
        //        string number = "0";
        //        foreach (Control control in this.Controls)
        //        {
        //            if (control.Tag == null || control.Tag.ToString() != "playerName")
        //                continue;
        //            if (control.Text == playerList.Text)
        //            {
        //                number = control.Name.Substring(1, 1);
        //            }
        //        }
        //        string transferNum = (int.Parse(number) - 1).ToString();
        //        //Console.WriteLine(transferNum);
        //        foreach (Control control in this.Controls)
        //        {
        //            if (control.Name == "ptDiff" + transferNum)
        //            {
        //                control.Text = "-" + result.ToString();
        //            }
        //            else if (control.Name == "ptDiff" + winner)
        //            {
        //                control.Text = handler.FinalAddup.ToString();
        //            }
        //            else if (control.Name.Length > 6 && control.Name.Substring(0, 6) == "ptDiff")
        //                control.Text = "0";
        //        }
        //    }
            
        //}

        private void pointGain_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the input is not a digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Reject the input
            }

            // Check if the input exceeds a maximum length
            if (!char.IsControl(e.KeyChar) && pointGain.Text.Length >= 7)
            {
                e.Handled = true; // Reject the input
            }
        }


        private void riichi_clicked(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            var player = button.Name.Substring(1, 1);
            handler.AddKyutaku();
            button.Enabled = false;
            foreach (Control control in this.Controls)
            {
                if (control.Name == "kyutaku")
                {
                    control.Text = handler.getKyutaku().ToString();
                    //Console.WriteLine(handler.getKyutaku());
                }
                if (control.Name == "p" + player + "point")
                {
                    PointAddup(control, "-1000");
                }
            }
        }

        //private void submit_Click(object sender, EventArgs e)
        //{
        //    string[] adjustments = ResetControlsAndGetAdjustments();

        //    AdjustPoints(adjustments);

        //    handler.clearRiichi();
        //    if (currentOya == winner)
        //    {
        //        handler.AddCombo();
        //        combo.Text = handler.getCombo().ToString();
        //    }
        //    else
        //    {
        //        HandleNonWinner();
        //    }
        //    winner = "42";
        //    DisplayUpdate(sender, new DisplayUpdateEvent());
        //}

        private string[] ResetControlsAndGetAdjustments()
        {
            string[] adjustments = new string[4];

            foreach (Control control in this.Controls)
            {
                if (control.Tag != null)
                {
                    if (control.Tag.ToString() == "riichi")
                    {
                        control.Enabled = true;
                    }
                    else if (control.Tag.ToString() == "addup") // get the points
                    {
                        int index = int.Parse(control.Name.Substring(6));
                        adjustments[index] = control.Text;
                        control.Text = "0";
                    }
                }

                switch (control.Name)
                {
                    case "kyutaku":
                    case "combo":
                        control.Text = handler.getCombo().ToString();
                        break;
                    case "pointGain":
                    case "playerList":
                        control.Text = "";
                        control.Enabled = true;
                        break;
                }
            }

            return adjustments;
        }

        private void AdjustPoints(string[] adjustments)
        {
            foreach (Control control in this.Controls) // add the points 
            {
                if (control.Tag != null && control.Tag.ToString() == "point")
                {
                    int index = int.Parse(control.Name.Substring(1, 1)) - 1;
                    PointAddup(control, adjustments[index]);
                }
            }
        }

        //private void HandleNonWinner()
        //{
        //    handler.Reset();
        //    currentOya = ((int.Parse(currentOya) + 1) % 5).ToString();
        //    if (currentOya == "4")
        //    {
        //        windChgeControl(this, new WindChangeEvent());
        //        currentOya = "0";
        //    }
        //    string transferOya = (int.Parse(currentOya) + 1).ToString();
        //    Button control = this.Controls.Find("oya" + transferOya, true).FirstOrDefault() as Button;
        //    if (control != null)
        //    {
        //        control.PerformClick();
        //    }
        //}

        private void PointAddup(Control obj, string point)
        {
            if (obj is TextBox)
            {
                int addup = int.Parse(point);
                int value = int.Parse(obj.Text);
                value += addup;
                obj.Text = value.ToString();
            }
            else
            {
                throw new Exception("Object type invalid");
            }
        }

        private void combo_LoseFocus(object sender, EventArgs e)
        {
            handler.setCombo(int.Parse(combo.Text));
        }

        private void kyutaku_LoseFocus(object sender, EventArgs e)
        {
            handler.setKyutaku(int.Parse(kyutaku.Text));
        }

        private void reset_Click(object sender, EventArgs e)
        {
            foreach(Control control in Controls)
            {
                if (control.Tag == null) continue;
                if (control.Tag.ToString() == "point")
                {
                    control.Text = "25000";
                }
                if (control.Tag.ToString() == "riichi")
                {
                    control.Enabled = true;
                }
                // TODO: reset oya, round wind, player choose, etc.
                handler.Reset();
            }
            DisplayUpdate(sender, new DisplayUpdateEvent());
        }

        private void DisplayUpdate(object sender, DisplayUpdateEvent e)
        {
            // update the kyutaku & combo
            Controls["kyutaku"].Text = handler.getKyutaku().ToString();
            Controls["combo"].Text = handler.getCombo().ToString();

            if (sender is Button)
            {
                foreach (Control control in Controls)
                {
                    if (control is TextBox)
                    {
                        Label target = displayForm.Controls.Find(control.Name, true).FirstOrDefault() as Label;
                        if (target != null)
                            target.Text = control.Text;
                    }
                }
            }
            else
            {
                TextBox textbox = sender as TextBox;

            }

            
        }

        // TODO: 流局设计思路：给pointHandler加一个流局的method，take听牌的人数，返回一个tuple，（听牌收的点，不听交的点）
        //       每次按下按钮切换按钮以及玩家听牌状态。

        // 想法：在把所有功能实现后，可以考虑把结构重新做一下。目前过于臃肿，不适合拓展开发。新的思路是，将每个玩家的信息
        //       做成一个可转化成json的class，重新链接所有的controls，这样可以更大程度的优化整个app运行效率。
    }

}