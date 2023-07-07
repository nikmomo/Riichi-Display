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
        public setting()//mainForm form, display displayform)
        {
            InitializeComponent();
        }

        private void hideTeam_Click(object sender, EventArgs e)
        {
            teamCtrlEvent?.Invoke(this, new TeamControlEvent());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindChgeEvent?.Invoke(this, new WindChangeEvent());
        }
    }
}
