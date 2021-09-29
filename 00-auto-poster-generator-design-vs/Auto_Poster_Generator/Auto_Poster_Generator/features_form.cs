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

        private void label2_Click(object sender, EventArgs e)
        {

        }

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
            color_picker1.Show();
        }
    }
}
