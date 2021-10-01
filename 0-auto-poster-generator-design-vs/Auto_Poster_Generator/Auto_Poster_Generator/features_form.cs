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
    public partial class features_form : Form
    {
        public features_form()
        {
            InitializeComponent();
        }

        int move;
        int xCor;
        int Ycor;

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                file_search_txtbox.Text = opf.FileName;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            color_picker color_picker1 = new color_picker();
            color_picker1.ShowDialog();
            color_txtbox.Text = color_picker.globalRGBvalue;
           

        }
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void features_form_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            
        }

        private void color_txtbox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
