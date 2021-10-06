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

        string data_gridview_cell_index = "";

        DataTable table = new DataTable();

        public void dataTable()
        {

            
            table.Columns.Add("Import File");
            table.Columns.Add("Y1 Coordinates");
            table.Columns.Add("Y2 Coordinates");
            table.Columns.Add("X1 Coordinates");
            table.Columns.Add("X2 Coordinates");
            table.Columns.Add("Font Family");
            table.Columns.Add("Font Size");
            table.Columns.Add("Text Align");
            table.Columns.Add("Text Stroke");
            table.Columns.Add("Text Color");
            table.Columns.Add("Text Opacity");

            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            features_form features1 = new features_form();
            features1.Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                file_search_txtbox.Text = opf.FileName;
            }
        }

        private void input_data_btn_Click(object sender, EventArgs e)
        {
            features_form features_form_obj = new features_form();
            features_form_obj.ShowDialog();
            table.Rows.Add(features_form.data_file_path, features_form.y1Cor, features_form.y2Cor, features_form.x1Cor, features_form.x2Cor, features_form.font_family, features_form.font_size, features_form.text_align, features_form.text_stroke, features_form.text_color, features_form.text_opacity);



        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void insert_img_btn_Click(object sender, EventArgs e)
        {

            if (file_search_txtbox.Text != "")
            {

                template_pic_box.BorderStyle = BorderStyle.None;
                template_pic_box.ImageLocation = file_search_txtbox.Text;
            }
            else {

                MessageBox.Show("Please select an image!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error  // for Warning  
                                        //MessageBoxIcon.Error // for Error 
                                        //MessageBoxIcon.Information  // for Information
                                        //MessageBoxIcon.Question // for Question
                );

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void main_form_Load(object sender, EventArgs e)
        {
            dataTable();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            table.Rows.Add("kdjsd", "dsds", "kdjsd", "dsds", "kdjsd", "dsds", "kdjsd", "dsds", "kdjsd", "dsds", "kdjsd");
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridView1.CurrentRow.Index;

            data_gridview_cell_index = rowindex.ToString();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (data_gridview_cell_index != "")
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(Convert.ToInt32(data_gridview_cell_index));
                }
                catch (Exception err)
                {
                   
                }
                
            }
        }
    }
}
