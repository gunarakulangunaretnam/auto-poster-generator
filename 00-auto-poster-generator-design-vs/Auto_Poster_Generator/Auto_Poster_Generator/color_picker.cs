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
        public color_picker()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(track_red.Value, track_green.Value, track_blue.Value);
            lbl_red.Text = track_red.Value.ToString();
            lbl_green.Text = track_green.Value.ToString();
            lbl_blue.Text = track_blue.Value.ToString();

            rgb_txtbox.Text = "("+track_red.Value.ToString()+", "+track_green.Value.ToString()+", "+track_blue.Value.ToString()+")" ;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
