using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Auto_Poster_Generator
{
    public partial class features_form : Form
    {
        public features_form()
        {
            InitializeComponent();
        }

        public static string data_file_path = "";
        public static string y1Cor = "";
        public static string y2Cor = "";
        public static string x1Cor = "";
        public static string x2Cor = "";
        public static string font_family = "";
        public static string font_size = "";
        public static string text_align = "";
        public static string text_stroke = "";
        public static string text_color = "";
        public static string text_opacity = "";

        int move;
        int xCor;
        int Ycor;

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Database files (*.txt)|*.txt";
            opf.FilterIndex = 0;
      

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

            string[] files = Directory.GetFiles("fonts", "*", SearchOption.AllDirectories);
            
            foreach (string file_name in files)
            {

                List<string> file_name_list = new List<string>(file_name.Split(new string[] { "\\" , "."}, StringSplitOptions.None));

                //MessageBox.Show(file_name_list[1].ToString());
                
                //insert file names into combo box
                font_family_combobox.Items.Add(file_name_list[1]);
            }

        }

        private void color_txtbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            stroke_opacity.Text = opacity_trackbar.Value.ToString();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            data_file_path = file_search_txtbox.Text;
            y1Cor = y1_txtbox.Text;
            y2Cor = y2_txtbox.Text;
            x1Cor = x1_txtbox.Text;
            x2Cor = x2_txtbox.Text;
            font_family = font_family_combobox.Text;
            font_size = fontsize_txtbox.Text;
            text_align = align_combobox.Text;
            text_stroke = stroke_trackBar.Value.ToString();
            text_color = color_txtbox.Text;
            text_opacity = opacity_trackbar.Value.ToString();

            this.Close();
        }

        private void font_family_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stroke_trackBar_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void stroke_trackBar_Scroll(object sender, EventArgs e)
        {
            stroke_display.Text = stroke_trackBar.Value.ToString();
        }

        private void opacity_trackbar_Scroll(object sender, EventArgs e)
        {
            stroke_opacity.Text = opacity_trackbar.Value.ToString();
        }


        private void y1_txtbox_TextChanged_1(object sender, EventArgs e)
        {
            string this_value = y1_txtbox.Text;
            string result = Regex.Replace(this_value, @"[^\d]", "");
            y1_txtbox.Text = result;


        }

        private void y2_txtbox_TextChanged(object sender, EventArgs e)
        {
            string this_value = y2_txtbox.Text;
            string result = Regex.Replace(this_value, @"[^\d]", "");
            y2_txtbox.Text = result;
        }

        private void x1_txtbox_TextChanged(object sender, EventArgs e)
        {
            string this_value = x1_txtbox.Text;
            string result = Regex.Replace(this_value, @"[^\d]", "");
            x1_txtbox.Text = result;
        }

        private void x2_txtbox_TextChanged(object sender, EventArgs e)
        {
            string this_value = x2_txtbox.Text;
            string result = Regex.Replace(this_value, @"[^\d]", "");
            x2_txtbox.Text = result;
        }

        private void fontsize_txtbox_TextChanged(object sender, EventArgs e)
        {
            string this_value = fontsize_txtbox.Text;
            string result = Regex.Replace(this_value, @"[^\d]", "");
            fontsize_txtbox.Text = result;
        }
    }
}
