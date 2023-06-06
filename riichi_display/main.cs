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
        private display displayForm;
        private setting setting;
        public mainForm()
        {
            InitializeComponent();
            PropertySetup();
            ActiveControl = null;
            displayForm = new display();
            displayForm.Show();
            setting = new setting();
            setting.teamCtrlEvent += changeTeamControl;
            setting.WindChgeEvent += windChgeControl;
        }
        private void textboxGetFocus(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textbox = sender as System.Windows.Forms.TextBox;
            if (textbox != null)
            {
                textbox.ReadOnly = false;
                textbox.SelectAll();
            }
        }

        private void textboxLoseFocus(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textbox = sender as System.Windows.Forms.TextBox;
            if (textbox != null)
            {
                Label target = displayForm.Controls.Find(textbox.Name, true).FirstOrDefault() as Label;
                if (target != null)
                    target.Text = textbox.Text;
            }
        }

        private bool nameLockStatus = true; // When it's false, it's unlocked, locked otherwise
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

        private bool teamLockStatus = false; // When it's false, it's unlocked, locked otherwise
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

        private bool pointLockStatus = true; // When it's false, it's unlocked, locked otherwise
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
            }
        }

        private void enterLoseFocus(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = null;
            }
        }

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
    }
}
