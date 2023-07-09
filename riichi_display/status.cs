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
    public partial class status : Form
    {
        public status()
        {
            InitializeComponent();
        }

        public void StatusUpdate(object sender, StatusUpdateEvent e)
        {
            kyutaku.Text = e.Kyutaku.ToString();
            combo.Text = e.Combo.ToString();
        }

        public void RoundUpdate(object sender, RoundUpdateEvent e)
        {
            round.Text = e.Round;
        }
    }
}
