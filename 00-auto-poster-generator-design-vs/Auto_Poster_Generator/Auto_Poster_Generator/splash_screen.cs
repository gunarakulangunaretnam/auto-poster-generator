using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Poster_Generator
{
    public partial class splash_screen : Form
    {
        public splash_screen()
        {
            InitializeComponent();
        }

        int progressBarStatus = 0;

        private void loading_screen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            progressBarStatus++;

            if (progressBarStatus == 100)
            {
                this.Hide();
                timer1.Stop();
                choice_form main_form_object = new choice_form();
                main_form_object.Show();
            }
            else
            {
                splash_screen_progressbar.Value = progressBarStatus;
            }
        }
    }
}
