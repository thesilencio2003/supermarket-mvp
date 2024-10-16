﻿namespace Supermarket_mvp.Views
{
    partial class MainView
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
            panel1 = new Panel();
            BtnCustomers = new Button();
            BtnCategories = new Button();
            BtnProduct = new Button();
            BtnExit = new Button();
            BtnPayMode = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnCustomers);
            panel1.Controls.Add(BtnCategories);
            panel1.Controls.Add(BtnProduct);
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(BtnPayMode);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 575);
            panel1.TabIndex = 0;
            // 
            // BtnCustomers
            // 
            BtnCustomers.BackColor = Color.FromArgb(224, 224, 224);
            BtnCustomers.BackgroundImage = Properties.Resources.nueva_cuenta;
            BtnCustomers.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCustomers.Location = new Point(2, 331);
            BtnCustomers.Name = "BtnCustomers";
            BtnCustomers.Size = new Size(197, 76);
            BtnCustomers.TabIndex = 5;
            BtnCustomers.UseVisualStyleBackColor = false;
            // 
            // BtnCategories
            // 
            BtnCategories.BackColor = Color.FromArgb(224, 224, 224);
            BtnCategories.BackgroundImage = Properties.Resources.categorias;
            BtnCategories.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCategories.Location = new Point(2, 249);
            BtnCategories.Name = "BtnCategories";
            BtnCategories.Size = new Size(197, 76);
            BtnCategories.TabIndex = 4;
            BtnCategories.UseVisualStyleBackColor = false;
            // 
            // BtnProduct
            // 
            BtnProduct.BackColor = Color.FromArgb(224, 224, 224);
            BtnProduct.BackgroundImage = Properties.Resources.products;
            BtnProduct.BackgroundImageLayout = ImageLayout.Zoom;
            BtnProduct.Location = new Point(0, 171);
            BtnProduct.Name = "BtnProduct";
            BtnProduct.Size = new Size(197, 76);
            BtnProduct.TabIndex = 3;
            BtnProduct.UseVisualStyleBackColor = false;
            // 
            // BtnExit
            // 
            BtnExit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            BtnExit.BackColor = Color.FromArgb(224, 224, 224);
            BtnExit.BackgroundImage = Properties.Resources.salida;
            BtnExit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnExit.Location = new Point(0, 447);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(197, 128);
            BtnExit.TabIndex = 2;
            BtnExit.UseVisualStyleBackColor = false;
            // 
            // BtnPayMode
            // 
            BtnPayMode.BackColor = Color.FromArgb(224, 224, 224);
            BtnPayMode.BackgroundImage = Properties.Resources.buy;
            BtnPayMode.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPayMode.Location = new Point(0, 82);
            BtnPayMode.Name = "BtnPayMode";
            BtnPayMode.Size = new Size(197, 83);
            BtnPayMode.TabIndex = 1;
            BtnPayMode.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sell;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 575);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "Supermarket ";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnPayMode;
        private PictureBox pictureBox1;
        private Button BtnExit;
        private Button BtnProduct;
        private Button BtnCategories;
        private Button BtnCustomers;
    }
}