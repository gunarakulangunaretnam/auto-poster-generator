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
    public partial class choice_form : Form
    {
        public choice_form()
        {
            InitializeComponent();
        }

        int move;
        int xCor;
        int Ycor;

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            xCor = e.X;
            Ycor = e.Y;
        }

        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {

                this.SetDesktopLocation(MousePosition.X - xCor, MousePosition.Y - Ycor);
            }
        }

        private void bunifuGradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main_form main_form_obj = new main_form();
            main_form_obj.Show();
            this.Hide();
        }

    }
}
