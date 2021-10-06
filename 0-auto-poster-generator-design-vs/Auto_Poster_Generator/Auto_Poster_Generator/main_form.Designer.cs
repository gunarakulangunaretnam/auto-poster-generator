namespace Auto_Poster_Generator
{
    partial class main_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.insert_img_btn = new System.Windows.Forms.Button();
            this.template_pic_box = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.file_search_txtbox = new System.Windows.Forms.TextBox();
            this.browser_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.input_data_btn = new System.Windows.Forms.Button();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.close_btn1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.template_pic_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browser_btn)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(17)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.input_data_btn);
            this.panel1.Controls.Add(this.bunifuGradientPanel1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1717, 783);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.insert_img_btn);
            this.groupBox1.Controls.Add(this.template_pic_box);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.file_search_txtbox);
            this.groupBox1.Controls.Add(this.browser_btn);
            this.groupBox1.Location = new System.Drawing.Point(294, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1122, 332);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // insert_img_btn
            // 
            this.insert_img_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insert_img_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(33)))), ((int)(((byte)(101)))));
            this.insert_img_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insert_img_btn.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.insert_img_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.insert_img_btn.Location = new System.Drawing.Point(513, 245);
            this.insert_img_btn.Name = "insert_img_btn";
            this.insert_img_btn.Size = new System.Drawing.Size(208, 44);
            this.insert_img_btn.TabIndex = 18;
            this.insert_img_btn.Text = "Insert Image";
            this.insert_img_btn.UseVisualStyleBackColor = false;
            this.insert_img_btn.Click += new System.EventHandler(this.insert_img_btn_Click);
            // 
            // template_pic_box
            // 
            this.template_pic_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.template_pic_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.template_pic_box.Location = new System.Drawing.Point(748, 49);
            this.template_pic_box.Name = "template_pic_box";
            this.template_pic_box.Size = new System.Drawing.Size(349, 240);
            this.template_pic_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.template_pic_box.TabIndex = 17;
            this.template_pic_box.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Template";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // file_search_txtbox
            // 
            this.file_search_txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.file_search_txtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.file_search_txtbox.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.file_search_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(17)))), ((int)(((byte)(55)))));
            this.file_search_txtbox.Location = new System.Drawing.Point(321, 50);
            this.file_search_txtbox.Multiline = true;
            this.file_search_txtbox.Name = "file_search_txtbox";
            this.file_search_txtbox.ReadOnly = true;
            this.file_search_txtbox.Size = new System.Drawing.Size(400, 29);
            this.file_search_txtbox.TabIndex = 15;
            this.file_search_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // browser_btn
            // 
            this.browser_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browser_btn.BackColor = System.Drawing.Color.Transparent;
            this.browser_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browser_btn.Image = ((System.Drawing.Image)(resources.GetObject("browser_btn.Image")));
            this.browser_btn.ImageActive = null;
            this.browser_btn.Location = new System.Drawing.Point(669, 104);
            this.browser_btn.Name = "browser_btn";
            this.browser_btn.Size = new System.Drawing.Size(52, 56);
            this.browser_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.browser_btn.TabIndex = 16;
            this.browser_btn.TabStop = false;
            this.browser_btn.Zoom = 10;
            this.browser_btn.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // input_data_btn
            // 
            this.input_data_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(33)))), ((int)(((byte)(101)))));
            this.input_data_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.input_data_btn.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.input_data_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.input_data_btn.Location = new System.Drawing.Point(156, 462);
            this.input_data_btn.Name = "input_data_btn";
            this.input_data_btn.Size = new System.Drawing.Size(162, 44);
            this.input_data_btn.TabIndex = 13;
            this.input_data_btn.Text = "Input Data";
            this.input_data_btn.UseVisualStyleBackColor = false;
            this.input_data_btn.Click += new System.EventHandler(this.input_data_btn_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel1.Controls.Add(this.close_btn1);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(17)))), ((int)(((byte)(55)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(33)))), ((int)(((byte)(101)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(17)))), ((int)(((byte)(55)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(17)))), ((int)(((byte)(55)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 20;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1717, 64);
            this.bunifuGradientPanel1.TabIndex = 3;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // close_btn1
            // 
            this.close_btn1.BackColor = System.Drawing.Color.Transparent;
            this.close_btn1.Dock = System.Windows.Forms.DockStyle.Right;
            this.close_btn1.Image = ((System.Drawing.Image)(resources.GetObject("close_btn1.Image")));
            this.close_btn1.ImageActive = null;
            this.close_btn1.Location = new System.Drawing.Point(1667, 0);
            this.close_btn1.Name = "close_btn1";
            this.close_btn1.Size = new System.Drawing.Size(48, 62);
            this.close_btn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn1.TabIndex = 56;
            this.close_btn1.TabStop = false;
            this.close_btn1.Zoom = 10;
            this.close_btn1.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(682, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generate Posters";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(33)))), ((int)(((byte)(101)))));
            this.dataGridView1.Location = new System.Drawing.Point(156, 512);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1409, 235);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(33)))), ((int)(((byte)(101)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.button1.Location = new System.Drawing.Point(343, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 44);
            this.button1.TabIndex = 15;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // main_form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(33)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(1734, 799);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.main_form_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.template_pic_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browser_btn)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button input_data_btn;
        private Bunifu.Framework.UI.BunifuImageButton close_btn1;
        private System.Windows.Forms.Button insert_img_btn;
        private System.Windows.Forms.PictureBox template_pic_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox file_search_txtbox;
        private Bunifu.Framework.UI.BunifuImageButton browser_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}

