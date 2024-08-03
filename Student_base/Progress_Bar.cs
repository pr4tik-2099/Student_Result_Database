using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_base
{
    public partial class Progress_Bar : Form
    {
        public Progress_Bar()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            p_bar.Width += 8;

            if(p_bar.Width > 800) 
            { 
                timer1.Stop();
                login lgn = new login();
                this.Hide();
                lgn.Show();
                
            }
        }
    }
}
