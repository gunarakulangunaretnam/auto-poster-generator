﻿namespace Auto_Poster_Generator
{
    partial class choice_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(choice_form));
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addmore_btn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(17)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.bunifuGradientPanel1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.addmore_btn);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 617);
            this.panel2.TabIndex = 7;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(17)))), ((int)(((byte)(55)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(33)))), ((int)(((byte)(101)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(17)))), ((int)(((byte)(55)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(17)))), ((int)(((byte)(55)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 20;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(802, 64);
            this.bunifuGradientPanel1.TabIndex = 14;
            this.bunifuGradientPanel1.Click += new System.EventHandler(this.bunifuGradientPanel1_Click);
            this.bunifuGradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseDown);
            this.bunifuGradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseMove);
            this.bunifuGradientPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.label2.Location = new System.Drawing.Point(251, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 44);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select an Option";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(33)))), ((int)(((byte)(101)))));
            this.button2.Font = new System.Drawing.Font("Cambria", 25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(105, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(606, 116);
            this.button2.TabIndex = 13;
            this.button2.Text = "Dynamic + Static Process";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(33)))), ((int)(((byte)(101)))));
            this.button1.Font = new System.Drawing.Font("Cambria", 25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(105, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(606, 116);
            this.button1.TabIndex = 12;
            this.button1.Text = "Dynamic Process";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addmore_btn
            // 
            this.addmore_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(33)))), ((int)(((byte)(101)))));
            this.addmore_btn.Font = new System.Drawing.Font("Cambria", 25F, System.Drawing.FontStyle.Bold);
            this.addmore_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.addmore_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addmore_btn.Location = new System.Drawing.Point(105, 130);
            this.addmore_btn.Name = "addmore_btn";
            this.addmore_btn.Size = new System.Drawing.Size(606, 116);
            this.addmore_btn.TabIndex = 11;
            this.addmore_btn.Text = "Static Process";
            this.addmore_btn.UseVisualStyleBackColor = false;
            // 
            // choice_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(33)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(812, 625);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "choice_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main_dashboard_form";
            this.panel2.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addmore_btn;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label2;


    }
}