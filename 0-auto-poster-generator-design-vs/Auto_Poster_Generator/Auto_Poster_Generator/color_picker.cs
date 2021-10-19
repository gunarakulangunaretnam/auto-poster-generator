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
    public partial class color_picker : Form
    {
        
        public static string globalRGBvalue = "";

        public color_picker()
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(track_red.Value, track_green.Value, track_blue.Value);
            lbl_red.Text = track_red.Value.ToString();
            lbl_green.Text = track_green.Value.ToString();
            lbl_blue.Text = track_blue.Value.ToString();

            globalRGBvalue = track_red.Value.ToString() + ", " + track_green.Value.ToString() + ", " + track_blue.Value.ToString();
        
            rgb_txtbox.Text = globalRGBvalue;

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void color_picker_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void input_data_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
