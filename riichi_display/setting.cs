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
    public partial class setting : Form
    {
        public event EventHandler<TeamControlEvent> teamCtrlEvent;
        public event EventHandler<WindChangeEvent> WindChgeEvent;
        //private mainForm mainFm;
        //public display displayFm;
        public setting()//mainForm form, display displayform)
        {
            InitializeComponent();
            //mainFm = form;
            //displayFm = displayform;
        }

        protected virtual void ChangeTeamControl()
        {
            teamCtrlEvent?.Invoke(this, new TeamControlEvent());
        }

        protected virtual void WindChangeControl()
        {
            WindChgeEvent?.Invoke(this, new WindChangeEvent());
        }

        private void showDisplay_Click(object sender, EventArgs e)
        {
            //if (displayFm.IsDisposed)
            //{
            //    displayFm = new display();
            //}
            //displayFm.Show();
            //foreach (Control textbox in mainFm.Controls)
            //{
            //    if (textbox is TextBox)
            //    {
            //        Label target = displayFm.Controls.Find(textbox.Name, true).FirstOrDefault() as Label;
            //        if (target != null)
            //            target.Text = textbox.Text;
            //    }
            //}
        }

        private void hideTeam_Click(object sender, EventArgs e)
        {
            this.ChangeTeamControl();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindChangeControl();
        }
    }
}
