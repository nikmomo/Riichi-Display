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

        private string currentOya;
        private string winner;

        pointHandler handler;
        public event EventHandler<WindChangeEvent> WindChgeEvent;

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

            currentOya = "0";
            handler = new pointHandler();


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
        private void textboxLoseFocus(object sender, EventArgs e)
        {
            // Cast the sender to a TextBox
            System.Windows.Forms.TextBox textbox = sender as System.Windows.Forms.TextBox;
            if (textbox != null)
            {
                // Find the corresponding label in the display form and set its text
                Label target = displayForm.Controls.Find(textbox.Name, true).FirstOrDefault() as Label;
                if (target != null)
                    target.Text = textbox.Text;
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
            p1name.Enabled = nameLockStatus;
            p2name.Enabled = nameLockStatus;
            p3name.Enabled = nameLockStatus;
            p4name.Enabled = nameLockStatus;
            if (!nameLockStatus)
                namelock.BackgroundImage = Properties.Resources._lock;
            else
                namelock.BackgroundImage = Properties.Resources.unlock;
        }

        // Event handler for team lock/unlock button click
        private void teamlock_Click(object sender, EventArgs e)
        {
            teamLockStatus = !teamLockStatus;
            team1name.Enabled = teamLockStatus;
            team2name.Enabled = teamLockStatus;
            team3name.Enabled = teamLockStatus;
            team4name.Enabled = teamLockStatus;
            if (!teamLockStatus)
                teamlock.BackgroundImage = Properties.Resources._lock;
            else
                teamlock.BackgroundImage = Properties.Resources.unlock;
        }

        // Event handler for point lock/unlock button click
        private void pointlock_Click(object sender, EventArgs e)
        {
            pointLockStatus = !pointLockStatus;
            p1point.Enabled = pointLockStatus;
            p2point.Enabled = pointLockStatus;
            p3point.Enabled = pointLockStatus;
            p4point.Enabled = pointLockStatus;
            if (!pointLockStatus)
                pointLock.BackgroundImage = Properties.Resources._lock;
            else
                pointLock.BackgroundImage = Properties.Resources.unlock;
        }

        private void gameStatus_Click(object sender, EventArgs e)
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
                    if (control.Tag.ToString() == "seat")
                        control.Click += new EventHandler(seat_Click);
                    else if (control.Tag.ToString() == "playerName")
                        control.TextChanged += new EventHandler(name_changed);
                    else if (control.Tag.ToString() == "ron")
                        control.Click += new EventHandler(ron_clicked);
                    else if (control.Tag.ToString() == "tsumo")
                        control.Click += new EventHandler(tsumo_clicked);
                    else if (control.Tag.ToString() == "riichi")
                        control.Click += new EventHandler(riichi_clicked);
                }
                
            }

            pointGain.KeyPress += pointGain_KeyPress;
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

        // Event handlers for various control click events
        private void seat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            currentOya = (int.Parse(button.Name.Substring(3)) - 1).ToString();
            //Console.WriteLine(currentOya);
            if (button != null)
            {
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
                foreach(Control control in displayForm.Controls)
                {
                    if (control.Tag != null && control.Tag.ToString() == "name")
                    {
                        var name = "p" + button.Name.Substring(3, 1) + "name";
                        //Console.WriteLine(name);
                        if (control.Name == name)
                            control.ForeColor = Color.DarkOrange;
                        else
                            control.ForeColor = Color.White;
                    }
                }
            }
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
            foreach (Control textbox in this.Controls)
            {
                if (textbox is TextBox)
                {
                    Label target = displayForm.Controls.Find(textbox.Name, true).FirstOrDefault() as Label;
                    if (target != null)
                        target.Text = textbox.Text;
                }
            }
        }

        private bool teamControl = false; // Hide team when it's false, show otherwise.
        // Event handlers for setting form events
        private void changeTeamControl(object sender, TeamControlEvent e)
        {
            teamControl = !teamControl;
            teamLabel.Visible = teamControl;
            team1name.Visible = teamControl;
            team2name.Visible = teamControl;
            team3name.Visible = teamControl;
            team4name.Visible = teamControl;
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
            winner = button.Name.Substring(3);
            playerList.Enabled = true;
            
        }

        private void tsumo_clicked(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            winner = button.Name.Substring(5);
            playerList.Text = "三家";
            playerList.Enabled = false;
            
        }

        private void pointGain_LoseFocus(object sender, EventArgs e)
        {
            if (playerList.Text == "" || pointGain.Text == "")
                return;
            if (playerList.Text == "三家")
            {
                if (winner != currentOya)
                {
                    int oya, ko;

                    (oya, ko) = handler.Kotsumo(int.Parse(pointGain.Text));
                    //Console.WriteLine("Oya" + currentOya + '\n' + "Ko" + winner);
                    foreach (Control control in this.Controls)
                    {
                        if (control.Name.Length > 6 && control.Name.Substring(0, 6) == "ptDiff")
                        {
                            if (control.Name == "ptDiff" + currentOya)
                            {
                                control.Text = '-' + oya.ToString();
                            }
                            else if (control.Name == "ptDiff" + winner)
                            {
                                control.Text = handler.FinalAddup.ToString();
                            }
                            else
                            {
                                control.Text = '-' + ko.ToString();
                            }
                        }
                    }
                }
                else
                {
                    int result = handler.Oyatsumo(int.Parse(pointGain.Text));
                    foreach (Control control in this.Controls)
                    {
                        if (control.Name.Length > 6 && control.Name.Substring(0, 6) == "ptDiff")
                        {
                            if (control.Name == "ptDiff" + winner)
                            {
                                control.Text = handler.FinalAddup.ToString();
                            }
                            else
                            {
                                control.Text = '-' + result.ToString();
                            }
                        }
                    }
                }
            }
            else
            {
                var result = handler.Ron(int.Parse(pointGain.Text));
                string number = "0";
                foreach (Control control in this.Controls)
                {
                    if (control.Tag == null || control.Tag.ToString() != "playerName")
                        continue;
                    if (control.Text == playerList.Text)
                    {
                        number = control.Name.Substring(1, 1);
                    }
                }
                string transferNum = (int.Parse(number) - 1).ToString();
                //Console.WriteLine(transferNum);
                foreach (Control control in this.Controls)
                {
                    if (control.Name == "ptDiff" + transferNum)
                    {
                        control.Text = "-" + result.ToString();
                    }
                    else if (control.Name == "ptDiff" + winner)
                    {
                        control.Text = handler.FinalAddup.ToString();
                    }
                    else if (control.Name.Length > 6 && control.Name.Substring(0, 6) == "ptDiff")
                        control.Text = "0";
                }
            }
            
        }

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

        private void submit_Click(object sender, EventArgs e)
        {
            string p1Adjust = "0", p2Adjust = "0", p3Adjust = "0", p4Adjust = "0";
            foreach (Control control in this.Controls) // get points and reset the status of control
            {
                if (control.Tag != null)
                {
                    if (control.Tag.ToString() == "riichi")
                    {
                        control.Enabled = true;
                    }
                    else if (control.Tag.ToString() == "addup") // get the points
                    {
                        switch (control.Name.Substring(6))
                        {
                            case "0":
                                p1Adjust = control.Text;
                                control.Text = "0";
                                break;
                            case "1":
                                p2Adjust = control.Text;
                                control.Text = "0";
                                break;
                            case "2":
                                p3Adjust = control.Text;
                                control.Text = "0";
                                break;
                            case "3":
                                p4Adjust = control.Text;
                                control.Text = "0";
                                break;
                        }
                    }
                }
                if (control.Name == "kyutaku")
                    control.Text = handler.getKyutaku().ToString();
                else if (control.Name == "combo")
                    control.Text = handler.getCombo().ToString();
                else if (control.Name == "pointGain")
                    control.Text = "";
                else if (control.Name == "playerList")
                {
                    control.Text = "";
                    control.Enabled = true;
                }

            }
            foreach (Control control in this.Controls) // add the points 
            {
                if (control.Tag != null)
                {
                    if (control.Tag.ToString() == "point")
                    {
                        switch (control.Name.Substring(1, 1))
                        {
                            case "1":
                                PointAddup(control, p1Adjust);
                                break;
                            case "2":
                                PointAddup(control, p2Adjust);
                                break;
                            case "3":
                                PointAddup(control, p3Adjust);
                                break;
                            case "4":
                                PointAddup(control, p4Adjust);
                                break;
                        }
                    }
                }
            }
            handler.clearRiichi();
            if (currentOya == winner)
            {
                handler.AddCombo();
                combo.Text = handler.getCombo().ToString();
            }
            else
            {
                handler.Reset();
                currentOya = (int.Parse(currentOya) + 1).ToString();
                if (currentOya == "4")
                {
                    currentOya = "0";
                    windChgeControl(sender, new WindChangeEvent());
                }
                string transferOya = (int.Parse(currentOya) + 1).ToString();
                Button control = this.Controls.Find("oya" + transferOya, true).FirstOrDefault() as Button;
                if (control != null)
                {
                    control.PerformClick();
                }
            }
            winner = "42";
            Console.WriteLine(handler.getKyutaku().ToString());
            Controls["kyutaku"].Text = handler.getKyutaku().ToString();
            Controls["combo"].Text = handler.getCombo().ToString();
            foreach (Control control in Controls)
            {
                if (control.Tag != null && control.Tag.ToString() == "point")
                {
                    textboxLoseFocus(control, e);
                }
            }
        }

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
    }

}