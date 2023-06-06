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
        
        public mainForm()
        {
            InitializeComponent();
            display displayForm = new display(this);
            displayForm.Show();
        }
        private void NameGetFocus(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textbox = sender as System.Windows.Forms.TextBox;
            if (textbox != null)
            {
                textbox.ReadOnly = false;
                textbox.SelectAll();
            }
        }

        private void NameLoseFocus(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textbox = sender as System.Windows.Forms.TextBox;
            if (textbox != null)
            {
                textbox.ReadOnly = true;
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
                namelock.Text = "Unlock";
            else
                namelock.Text = "Lock";
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
                teamlock.Text = "Unlock";
            else
                teamlock.Text = "Lock";
        }

    }
}
