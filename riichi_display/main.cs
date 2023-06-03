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
    public partial class main : Form
    {
        
        public main()
        {
            InitializeComponent();
        }
        private void NameGetFocus(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textbox = sender as System.Windows.Forms.TextBox;
            if (textbox != null)
            {
                textbox.ReadOnly = false;
                textbox.BackColor = Color.White;
                textbox.SelectAll();
            }
        }

        private void NameLoseFocus(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textbox = sender as System.Windows.Forms.TextBox;
            if (textbox != null)
            {
                p1name.ReadOnly = true;
                p1name.BackColor = Color.LightGray;
            }
        }
    }
}
