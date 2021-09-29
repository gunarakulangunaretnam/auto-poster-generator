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
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            features_form features1 = new features_form();
            features1.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
