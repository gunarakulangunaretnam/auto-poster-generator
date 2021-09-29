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
    public partial class main_dashboard_form : Form
    {
        public main_dashboard_form()
        {
            InitializeComponent();
        }

        int move;
        int xCor;
        int Ycor;

        private void main_dashboard_form_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            xCor = e.X;
            Ycor = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {

                this.SetDesktopLocation(MousePosition.X - xCor, MousePosition.Y - Ycor);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
