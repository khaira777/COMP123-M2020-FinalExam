using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        // TIMER EVENT TO HIDE splash FORM AND SHOW THE generatename FORM
        // THIS WILL ALSO DISABLE THE SPLASH FORM TIMER
        private void splashformtimer_Tick(object sender, EventArgs e)
        {
            Program.generatenameform.Show();
            this.Hide();
            splashformtimer.Enabled = false;
        }
    }
}
