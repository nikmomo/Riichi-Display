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
        private bool pointLockStatus = true; // When it's false, it's unlocked, locked otherwise

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

        // Method to set up properties and event handlers for form controls
        private void PropertySetup()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.KeyDown += new KeyEventHandler(enterLoseFocus);
                    //Console.WriteLine(control.Name);
                }
                if (control.Tag != null && control.Tag.ToString() == "seat")
                {
                    control.Click += new EventHandler(seat_Click);
                }
                if (control.Tag != null && control.Tag.ToString() == "playerName")
                {
                    control.TextChanged += new EventHandler(name_changed);
                }
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

        // Event handlers for various control click events
        private void seat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
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
                        Console.WriteLine(name);
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
            var num = button.Name.Substring(1, 1);
            foreach (Control control in this.Controls)
            {
                if (control.Tag != null && control.Tag.ToString() == "playerName")
                {
                    // TODO: Add code here
                    if (control.Name == "name")
                        control.ForeColor = Color.DarkOrange;
                    else
                        control.ForeColor = Color.White;
                }
            }
            
        }
    }
}
