namespace Supermarket_mvp.Views
{
    partial class CategoriesView
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
            pictureBox1 = new PictureBox();
            Categories = new Label();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPageCategoriesList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgCategories = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label1 = new Label();
            tabPageCategoriesDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtCategoriesDescription = new TextBox();
            TxtCategoriesId = new TextBox();
            TxtCategoriesName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Label = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageCategoriesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategories).BeginInit();
            tabPageCategoriesDetail.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.categorias;
            pictureBox1.Location = new Point(12, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Categories
            // 
            Categories.AutoSize = true;
            Categories.Font = new Font("Arial", 18F, FontStyle.Bold);
            Categories.Location = new Point(131, 38);
            Categories.Name = "Categories";
            Categories.Size = new Size(169, 29);
            Categories.TabIndex = 0;
            Categories.Text = "CATEGORIES";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Categories);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(988, 100);
            panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategoriesList);
            tabControl1.Controls.Add(tabPageCategoriesDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(988, 421);
            tabControl1.TabIndex = 2;
            // 
            // tabPageCategoriesList
            // 
            tabPageCategoriesList.Controls.Add(BtnClose);
            tabPageCategoriesList.Controls.Add(BtnDelete);
            tabPageCategoriesList.Controls.Add(BtnEdit);
            tabPageCategoriesList.Controls.Add(BtnNew);
            tabPageCategoriesList.Controls.Add(DgCategories);
            tabPageCategoriesList.Controls.Add(BtnSearch);
            tabPageCategoriesList.Controls.Add(TxtSearch);
            tabPageCategoriesList.Controls.Add(label1);
            tabPageCategoriesList.Location = new Point(4, 24);
            tabPageCategoriesList.Name = "tabPageCategoriesList";
            tabPageCategoriesList.Padding = new Padding(3);
            tabPageCategoriesList.Size = new Size(980, 393);
            tabPageCategoriesList.TabIndex = 0;
            tabPageCategoriesList.Text = "Categories Mode List";
            tabPageCategoriesList.UseVisualStyleBackColor = true;
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
            // DgCategories
            // 
            DgCategories.AllowUserToAddRows = false;
            DgCategories.AllowUserToDeleteRows = false;
            DgCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategories.Location = new Point(16, 79);
            DgCategories.Name = "DgCategories";
            DgCategories.ReadOnly = true;
            DgCategories.Size = new Size(701, 298);
            DgCategories.TabIndex = 11;
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
            label1.Size = new Size(141, 21);
            label1.TabIndex = 8;
            label1.Text = "Search Pay Mode";
            // 
            // tabPageCategoriesDetail
            // 
            tabPageCategoriesDetail.Controls.Add(BtnCancel);
            tabPageCategoriesDetail.Controls.Add(BtnSave);
            tabPageCategoriesDetail.Controls.Add(TxtCategoriesDescription);
            tabPageCategoriesDetail.Controls.Add(TxtCategoriesId);
            tabPageCategoriesDetail.Controls.Add(TxtCategoriesName);
            tabPageCategoriesDetail.Controls.Add(label2);
            tabPageCategoriesDetail.Controls.Add(label3);
            tabPageCategoriesDetail.Controls.Add(Label);
            tabPageCategoriesDetail.Location = new Point(4, 24);
            tabPageCategoriesDetail.Name = "tabPageCategoriesDetail";
            tabPageCategoriesDetail.Padding = new Padding(3);
            tabPageCategoriesDetail.Size = new Size(980, 393);
            tabPageCategoriesDetail.TabIndex = 1;
            tabPageCategoriesDetail.Text = "Categories Detail";
            tabPageCategoriesDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.FromArgb(224, 224, 224);
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(165, 306);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(104, 57);
            BtnCancel.TabIndex = 15;
            BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.FromArgb(224, 224, 224);
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(21, 306);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(104, 57);
            BtnSave.TabIndex = 14;
            BtnSave.UseVisualStyleBackColor = false;
            // 
            // TxtCategoriesDescription
            // 
            TxtCategoriesDescription.Location = new Point(20, 184);
            TxtCategoriesDescription.Multiline = true;
            TxtCategoriesDescription.Name = "TxtCategoriesDescription";
            TxtCategoriesDescription.Size = new Size(317, 103);
            TxtCategoriesDescription.TabIndex = 13;
            // 
            // TxtCategoriesId
            // 
            TxtCategoriesId.Location = new Point(21, 50);
            TxtCategoriesId.Name = "TxtCategoriesId";
            TxtCategoriesId.ReadOnly = true;
            TxtCategoriesId.Size = new Size(155, 23);
            TxtCategoriesId.TabIndex = 12;
            TxtCategoriesId.Text = "0";
            TxtCategoriesId.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtCategoriesName
            // 
            TxtCategoriesName.Location = new Point(20, 112);
            TxtCategoriesName.Name = "TxtCategoriesName";
            TxtCategoriesName.Size = new Size(317, 23);
            TxtCategoriesName.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 88);
            label2.Name = "label2";
            label2.Size = new Size(141, 21);
            label2.TabIndex = 10;
            label2.Text = "Categories Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 160);
            label3.Name = "label3";
            label3.Size = new Size(183, 21);
            label3.TabIndex = 9;
            label3.Text = "Categories Description";
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label.Location = new Point(20, 26);
            Label.Name = "Label";
            Label.Size = new Size(110, 21);
            Label.TabIndex = 8;
            Label.Text = "Categories Id";
            // 
            // CategoriesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 521);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CategoriesView";
            Text = "Categories Management";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageCategoriesList.ResumeLayout(false);
            tabPageCategoriesList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategories).EndInit();
            tabPageCategoriesDetail.ResumeLayout(false);
            tabPageCategoriesDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Categories;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPageCategoriesList;
        private TabPage tabPageCategoriesDetail;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgCategories;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label1;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtCategoriesDescription;
        private TextBox TxtCategoriesId;
        private TextBox TxtCategoriesName;
        private Label label2;
        private Label label3;
        private Label Label;
    }
}