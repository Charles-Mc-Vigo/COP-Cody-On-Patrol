using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Duty_After_Coding
{
    public partial class loadingscreen : Form
    {
        public loadingscreen()
        {
            InitializeComponent();
        }

        private void loadingTimer_Tick(object sender, EventArgs e)
        {
            panel2.Width += 4;
            if (panel2.Width >= 282)
            {
                loadingTimer.Stop();
                Form1 fm1 = new Form1();
                fm1.Show();
                this.Hide();
            }
        }
    }
}
