namespace Supermarket_mvp.Views
{
    partial class ProductView
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
            pictureBox1 = new PictureBox();
            Product = new Label();
            tabControl1 = new TabControl();
            tabPageProductModeList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgProduct = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label1 = new Label();
            tabPageProductDetail = new TabPage();
            TxtProductStock = new TextBox();
            cc = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtProductPrice = new TextBox();
            TxtProductId = new TextBox();
            TxtProductName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Label = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProductModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).BeginInit();
            tabPageProductDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Product);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(988, 100);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(12, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Product
            // 
            Product.AutoSize = true;
            Product.Font = new Font("Arial", 18F, FontStyle.Bold);
            Product.Location = new Point(131, 38);
            Product.Name = "Product";
            Product.Size = new Size(104, 29);
            Product.TabIndex = 0;
            Product.Text = "Product";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductModeList);
            tabControl1.Controls.Add(tabPageProductDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(988, 421);
            tabControl1.TabIndex = 2;
            // 
            // tabPageProductModeList
            // 
            tabPageProductModeList.Controls.Add(BtnClose);
            tabPageProductModeList.Controls.Add(BtnDelete);
            tabPageProductModeList.Controls.Add(BtnEdit);
            tabPageProductModeList.Controls.Add(BtnNew);
            tabPageProductModeList.Controls.Add(DgProduct);
            tabPageProductModeList.Controls.Add(BtnSearch);
            tabPageProductModeList.Controls.Add(TxtSearch);
            tabPageProductModeList.Controls.Add(label1);
            tabPageProductModeList.Location = new Point(4, 24);
            tabPageProductModeList.Name = "tabPageProductModeList";
            tabPageProductModeList.Padding = new Padding(3);
            tabPageProductModeList.Size = new Size(980, 393);
            tabPageProductModeList.TabIndex = 0;
            tabPageProductModeList.Text = "Product Mode List";
            tabPageProductModeList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.BackColor = Color.FromArgb(224, 224, 224);
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(741, 307);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(223, 70);
            BtnClose.TabIndex = 15;
            BtnClose.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.BackColor = Color.FromArgb(224, 224, 224);
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(741, 233);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(223, 68);
            BtnDelete.TabIndex = 14;
            BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.BackColor = Color.FromArgb(224, 224, 224);
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(741, 156);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(224, 71);
            BtnEdit.TabIndex = 13;
            BtnEdit.UseVisualStyleBackColor = false;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.BackColor = Color.FromArgb(224, 224, 224);
            BtnNew.ForeColor = SystemColors.ControlText;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(740, 81);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(224, 69);
            BtnNew.TabIndex = 12;
            BtnNew.UseVisualStyleBackColor = false;
            // 
            // DgProduct
            // 
            DgProduct.AllowUserToAddRows = false;
            DgProduct.AllowUserToDeleteRows = false;
            DgProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProduct.Location = new Point(16, 79);
            DgProduct.Name = "DgProduct";
            DgProduct.ReadOnly = true;
            DgProduct.Size = new Size(701, 298);
            DgProduct.TabIndex = 11;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.BackColor = Color.FromArgb(224, 224, 224);
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(648, 28);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(71, 45);
            BtnSearch.TabIndex = 10;
            BtnSearch.UseVisualStyleBackColor = false;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(16, 40);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(624, 23);
            TxtSearch.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 8;
            label1.Text = "Search Product";
            // 
            // tabPageProductDetail
            // 
            tabPageProductDetail.Controls.Add(TxtProductStock);
            tabPageProductDetail.Controls.Add(cc);
            tabPageProductDetail.Controls.Add(BtnCancel);
            tabPageProductDetail.Controls.Add(BtnSave);
            tabPageProductDetail.Controls.Add(TxtProductPrice);
            tabPageProductDetail.Controls.Add(TxtProductId);
            tabPageProductDetail.Controls.Add(TxtProductName);
            tabPageProductDetail.Controls.Add(label2);
            tabPageProductDetail.Controls.Add(label3);
            tabPageProductDetail.Controls.Add(Label);
            tabPageProductDetail.Location = new Point(4, 24);
            tabPageProductDetail.Name = "tabPageProductDetail";
            tabPageProductDetail.Padding = new Padding(3);
            tabPageProductDetail.Size = new Size(980, 393);
            tabPageProductDetail.TabIndex = 1;
            tabPageProductDetail.Text = "Product Detail";
            tabPageProductDetail.UseVisualStyleBackColor = true;
            // 
            // TxtProductStock
            // 
            TxtProductStock.Location = new Point(21, 250);
            TxtProductStock.Name = "TxtProductStock";
            TxtProductStock.PlaceholderText = "Product Stock";
            TxtProductStock.Size = new Size(317, 23);
            TxtProductStock.TabIndex = 17;
            TxtProductStock.TextChanged += textBox1_TextChanged;
            // 
            // cc
            // 
            cc.AutoSize = true;
            cc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cc.Location = new Point(21, 226);
            cc.Name = "cc";
            cc.Size = new Size(116, 21);
            cc.TabIndex = 16;
            cc.Text = "Product Stock";
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.FromArgb(224, 224, 224);
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(165, 298);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(104, 57);
            BtnCancel.TabIndex = 15;
            BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.FromArgb(224, 224, 224);
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(21, 298);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(104, 57);
            BtnSave.TabIndex = 14;
            BtnSave.UseVisualStyleBackColor = false;
            // 
            // TxtProductPrice
            // 
            TxtProductPrice.Location = new Point(20, 176);
            TxtProductPrice.Name = "TxtProductPrice";
            TxtProductPrice.PlaceholderText = "Product Price";
            TxtProductPrice.Size = new Size(317, 23);
            TxtProductPrice.TabIndex = 13;
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(21, 42);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.ReadOnly = true;
            TxtProductId.Size = new Size(155, 23);
            TxtProductId.TabIndex = 12;
            TxtProductId.Text = "0";
            TxtProductId.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(20, 104);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.PlaceholderText = "Product Name";
            TxtProductName.Size = new Size(317, 23);
            TxtProductName.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 80);
            label2.Name = "label2";
            label2.Size = new Size(120, 21);
            label2.TabIndex = 10;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 152);
            label3.Name = "label3";
            label3.Size = new Size(112, 21);
            label3.TabIndex = 9;
            label3.Text = "Product Price";
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label.Location = new Point(20, 18);
            Label.Name = "Label";
            Label.Size = new Size(89, 21);
            Label.TabIndex = 8;
            Label.Text = "Product Id";
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 521);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "ProductView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProductModeList.ResumeLayout(false);
            tabPageProductModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).EndInit();
            tabPageProductDetail.ResumeLayout(false);
            tabPageProductDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label Product;
        private TabControl tabControl1;
        private TabPage tabPageProductModeList;
        private TabPage tabPageProductDetail;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgProduct;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label1;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtProductPrice;
        private TextBox TxtProductId;
        private TextBox TxtProductName;
        private Label label2;
        private Label label3;
        private Label Label;
        private TextBox TxtProductStock;
        private Label cc;
    }
}