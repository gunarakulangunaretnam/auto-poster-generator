using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Poster_Generator
{
    public partial class dynamic_main_form : Form
    {
        public dynamic_main_form()
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
            dynamic_features_form features1 = new dynamic_features_form();
            features1.Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                file_search_txtbox.Text = opf.FileName;
            }
        }

        private void input_data_btn_Click(object sender, EventArgs e)
        {

            if (file_search_txtbox.Text != "")
            {

                dynamic_features_form features_form_obj = new dynamic_features_form();
                features_form_obj.ShowDialog();

                if (dynamic_features_form.data_file_path != "" && dynamic_features_form.y1Cor != "" && dynamic_features_form.y2Cor != "" && dynamic_features_form.x2Cor != "" && dynamic_features_form.font_family != "" && dynamic_features_form.font_size != "" && dynamic_features_form.text_align != "" && dynamic_features_form.text_stroke != "" && dynamic_features_form.text_color != "" && dynamic_features_form.text_opacity != "") {

                    table.Rows.Add(dynamic_features_form.data_file_path, dynamic_features_form.y1Cor, dynamic_features_form.y2Cor, dynamic_features_form.x1Cor, dynamic_features_form.x2Cor, dynamic_features_form.font_family, dynamic_features_form.font_size, dynamic_features_form.text_align, dynamic_features_form.text_stroke, dynamic_features_form.text_color, dynamic_features_form.text_opacity);

                }

            }
            else {

                MessageBox.Show("Please select a template", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            

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

            DialogResult dialogResult = MessageBox.Show("Do you want to remove this row number ("+ data_gridview_cell_index + 1 + ")?", "Comfirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (file_search_txtbox.Text != "")
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
                else
                {
                    MessageBox.Show("Please select a template", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            
        }

       
        public void copyTemplate() {

            string fileToCopy = file_search_txtbox.Text;
            string destinationDirectory = "dynamic-template-image/";

            File.Copy(fileToCopy, destinationDirectory + Path.GetFileName(fileToCopy));

        }

        public void copyContentFiles() {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string fileToCopy = row.Cells["Import File"].Value.ToString();
                string destinationDirectory = "dynamic-content-files/";
                File.Copy(fileToCopy, destinationDirectory + Path.GetFileName(fileToCopy));
               
            }


        }


        public void createConfigFiles(string numberOfItems, string numberOfRow, string templateName)
        {
            
            string fileName = @"dynamic_config.txt";

            File.Delete(fileName); // Delete previous config file

            if (!File.Exists(fileName))
            {
                using (StreamWriter writer = File.CreateText(fileName))
                {
                    writer.WriteLine(numberOfItems+" | "+ numberOfRow + " | "+ "dynamic-template-image/" + templateName);
                }
            }

           
        }


        public void getConfigFileData() {

            // Get number items in the first file.
            string firstFileName = dataGridView1.Rows[0].Cells[0].Value.ToString();
            var lineCount = File.ReadLines(firstFileName).Count();
            

            // Get number rows
            string numberOfRows = dataGridView1.Rows.Count.ToString();

            // Get template name

            string fileBaseName = "";

            Uri uri = new Uri(file_search_txtbox.Text);

            if (uri.IsFile) {
                fileBaseName = System.IO.Path.GetFileName(uri.LocalPath);  
            }


            createConfigFiles(lineCount.ToString(), numberOfRows, fileBaseName);
        }


        private void clearFolder(string FolderName)
        {
            DirectoryInfo dir = new DirectoryInfo(FolderName);

            foreach (FileInfo fi in dir.GetFiles())
            {
                fi.Delete();
            }

            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                clearFolder(di.FullName);
                di.Delete();
            }
        }

        public void createInputDataFile(string data) {


            string fileName = @"dynamic_input_data.txt";

            File.Delete(fileName); // Delete previous config file

            if (!File.Exists(fileName))
            {
                using (StreamWriter writer = File.CreateText(fileName))
                {
                    writer.WriteLine(data);
                }
            }

        }

        public void getInputData() {

            string inputData = "";

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string importFile = row.Cells["Import File"].Value.ToString();
                
                Uri uri = new Uri(importFile);

                if (uri.IsFile)
                {
                    importFile = System.IO.Path.GetFileName(uri.LocalPath);
                }

                importFile = "dynamic-content-files/" + importFile;

                string y1Cor = row.Cells["Y1 Coordinates"].Value.ToString();
                string y2Cor = row.Cells["Y2 Coordinates"].Value.ToString();
                string x1Cor = row.Cells["X1 Coordinates"].Value.ToString();
                string x2Cor = row.Cells["X2 Coordinates"].Value.ToString();
                string fontFamily = row.Cells["Font Family"].Value.ToString();

                fontFamily = fontFamily + ".ttf";
                fontFamily = "fonts/" + fontFamily;

                string fontSize = row.Cells["Font Size"].Value.ToString();
                string textAlign = row.Cells["Text Align"].Value.ToString().ToLower();
                string textStroke = row.Cells["Text Stroke"].Value.ToString();
                string textColor = row.Cells["Text Color"].Value.ToString();
                string textOpacity = row.Cells["Text Opacity"].Value.ToString();

                inputData = inputData + y1Cor + " | " + y2Cor + " | " + x1Cor + " | " + x2Cor + " | " + fontFamily + " | " + fontSize + " | " + textAlign + " | " + textStroke + " | " + textColor + " | " + textOpacity + " | " + importFile + "\n";
            }


            createInputDataFile(inputData);

        }


        public void startProcessing() {




        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearFolder("dynamic-content-files/");
            clearFolder("dynamic-template-image/");
            clearFolder("dynamic-generated-images/");

            copyTemplate(); //Copy template.
            copyContentFiles(); // Compy content files.

            getConfigFileData();
            getInputData(); // Get input data

            startProcessing();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
