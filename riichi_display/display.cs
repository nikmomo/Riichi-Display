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
        public event EventHandler<DisplayWindowUpdateEvent> DisplayWindowUpdateEvent;
        public event EventHandler<AddupDisplayEvent> AddupDisplayEvent;
        public display()
        {
            InitializeComponent();
        }

    }
}
