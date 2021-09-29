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
    public partial class loading_screen : Form
    {
        public loading_screen()
        {
            InitializeComponent();
        }

        int progressBarStatus = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBarStatus++;

            if (progressBarStatus == 100)
            {

                this.Hide();
                timer1.Stop();
                main_dashboard_form main_form_object = new main_dashboard_form();
                main_form_object.Show();
               
            }
            else
            {
                
                progressBar1.Value = progressBarStatus;

            }

        }

        private void loading_screen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
