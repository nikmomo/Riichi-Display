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
    public partial class display : Form
    {
        public display()
        {
            InitializeComponent();
        }
        
        public void RiichiSwitch(object sender, RiichiDisplayEvent e)
        {
            Control control = this.Controls.Find("riichi" + e.Index, true).FirstOrDefault() as System.Windows.Forms.Control;
            control.Visible = e.Show;
        }
    }
}
