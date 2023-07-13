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
    public partial class doraControl : Form
    {
        public event EventHandler<DoraUpdateEvent> DoraUpdateEvent;
        public doraControl()
        {
            InitializeComponent();
            foreach (Control control in this.Controls)
            {
                if (control.Tag != null && control.Tag.ToString() == "dora")
                {
                    ComboBox comboBox = control as ComboBox;
                    comboBox.SelectedIndexChanged += dora_SelectedIndexChanged;
                }
            }
        }

        private void dora_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox box = sender as ComboBox;
            int index = determinePlayer(box.Name);

            DoraUpdateEvent?.Invoke(sender, new DoraUpdateEvent(index, box.SelectedIndex)); // send dora update event
        }

        private int determinePlayer(string name)
        {
            int index = int.Parse(name[name.Length - 1].ToString());
            return index;
        }

        public void reset_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control.Tag != null && control.Tag.ToString() == "dora")
                {
                    ComboBox box = control as ComboBox;
                    box.SelectedIndex = 0;
                    int index = determinePlayer(box.Name);
                    DoraUpdateEvent?.Invoke(sender, new DoraUpdateEvent(index, box.SelectedIndex)); // send dora update event
                }
            }
        }
    }
}
