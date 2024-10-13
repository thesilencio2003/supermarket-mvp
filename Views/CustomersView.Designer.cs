namespace Supermarket_mvp.Views
{
    partial class CustomersView
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
            customers = new Label();
            tabControl1 = new TabControl();
            tabPageCustomersList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgCustomers = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label1 = new Label();
            tabPageCustomersDetail = new TabPage();
            TxtCustomersDocument = new TextBox();
            label8 = new Label();
            TxtCustomersEmail = new TextBox();
            label7 = new Label();
            TxtCustomersPhone = new TextBox();
            label6 = new Label();
            TxtCustomersDate = new TextBox();
            label5 = new Label();
            TxtCustomersAddress = new TextBox();
            label4 = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtCustomersLastName = new TextBox();
            TxtCustomersId = new TextBox();
            TxtCustomersFirstName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Label = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCustomersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomers).BeginInit();
            tabPageCustomersDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(customers);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(988, 100);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.nueva_cuenta;
            pictureBox1.Location = new Point(12, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // customers
            // 
            customers.AutoSize = true;
            customers.Font = new Font("Arial", 18F, FontStyle.Bold);
            customers.Location = new Point(131, 38);
            customers.Name = "customers";
            customers.Size = new Size(166, 29);
            customers.TabIndex = 0;
            customers.Text = "CUSTOMERS";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCustomersList);
            tabControl1.Controls.Add(tabPageCustomersDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(988, 421);
            tabControl1.TabIndex = 2;
            // 
            // tabPageCustomersList
            // 
            tabPageCustomersList.Controls.Add(BtnClose);
            tabPageCustomersList.Controls.Add(BtnDelete);
            tabPageCustomersList.Controls.Add(BtnEdit);
            tabPageCustomersList.Controls.Add(BtnNew);
            tabPageCustomersList.Controls.Add(DgCustomers);
            tabPageCustomersList.Controls.Add(BtnSearch);
            tabPageCustomersList.Controls.Add(TxtSearch);
            tabPageCustomersList.Controls.Add(label1);
            tabPageCustomersList.Location = new Point(4, 24);
            tabPageCustomersList.Name = "tabPageCustomersList";
            tabPageCustomersList.Padding = new Padding(3);
            tabPageCustomersList.Size = new Size(980, 393);
            tabPageCustomersList.TabIndex = 0;
            tabPageCustomersList.Text = "Customers list";
            tabPageCustomersList.UseVisualStyleBackColor = true;
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
            // DgCustomers
            // 
            DgCustomers.AllowUserToAddRows = false;
            DgCustomers.AllowUserToDeleteRows = false;
            DgCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCustomers.Location = new Point(16, 79);
            DgCustomers.Name = "DgCustomers";
            DgCustomers.ReadOnly = true;
            DgCustomers.Size = new Size(701, 298);
            DgCustomers.TabIndex = 11;
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
            label1.Size = new Size(145, 21);
            label1.TabIndex = 8;
            label1.Text = "Search Customers";
            // 
            // tabPageCustomersDetail
            // 
            tabPageCustomersDetail.Controls.Add(TxtCustomersDocument);
            tabPageCustomersDetail.Controls.Add(label8);
            tabPageCustomersDetail.Controls.Add(TxtCustomersEmail);
            tabPageCustomersDetail.Controls.Add(label7);
            tabPageCustomersDetail.Controls.Add(TxtCustomersPhone);
            tabPageCustomersDetail.Controls.Add(label6);
            tabPageCustomersDetail.Controls.Add(TxtCustomersDate);
            tabPageCustomersDetail.Controls.Add(label5);
            tabPageCustomersDetail.Controls.Add(TxtCustomersAddress);
            tabPageCustomersDetail.Controls.Add(label4);
            tabPageCustomersDetail.Controls.Add(BtnCancel);
            tabPageCustomersDetail.Controls.Add(BtnSave);
            tabPageCustomersDetail.Controls.Add(TxtCustomersLastName);
            tabPageCustomersDetail.Controls.Add(TxtCustomersId);
            tabPageCustomersDetail.Controls.Add(TxtCustomersFirstName);
            tabPageCustomersDetail.Controls.Add(label2);
            tabPageCustomersDetail.Controls.Add(label3);
            tabPageCustomersDetail.Controls.Add(Label);
            tabPageCustomersDetail.Location = new Point(4, 24);
            tabPageCustomersDetail.Name = "tabPageCustomersDetail";
            tabPageCustomersDetail.Padding = new Padding(3);
            tabPageCustomersDetail.Size = new Size(980, 393);
            tabPageCustomersDetail.TabIndex = 1;
            tabPageCustomersDetail.Text = "Customers Detail";
            tabPageCustomersDetail.UseVisualStyleBackColor = true;
            // 
            // TxtCustomersDocument
            // 
            TxtCustomersDocument.Location = new Point(658, 47);
            TxtCustomersDocument.Name = "TxtCustomersDocument";
            TxtCustomersDocument.Size = new Size(209, 23);
            TxtCustomersDocument.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(659, 23);
            label8.Name = "label8";
            label8.Size = new Size(174, 21);
            label8.TabIndex = 24;
            label8.Text = "Customers Document";
            // 
            // TxtCustomersEmail
            // 
            TxtCustomersEmail.Location = new Point(642, 210);
            TxtCustomersEmail.Name = "TxtCustomersEmail";
            TxtCustomersEmail.Size = new Size(317, 23);
            TxtCustomersEmail.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(643, 186);
            label7.Name = "label7";
            label7.Size = new Size(137, 21);
            label7.TabIndex = 22;
            label7.Text = "Customers Email";
            // 
            // TxtCustomersPhone
            // 
            TxtCustomersPhone.Location = new Point(22, 210);
            TxtCustomersPhone.Name = "TxtCustomersPhone";
            TxtCustomersPhone.Size = new Size(317, 23);
            TxtCustomersPhone.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(23, 186);
            label6.Name = "label6";
            label6.Size = new Size(143, 21);
            label6.TabIndex = 20;
            label6.Text = "Customers Phone";
            // 
            // TxtCustomersDate
            // 
            TxtCustomersDate.Location = new Point(649, 117);
            TxtCustomersDate.Name = "TxtCustomersDate";
            TxtCustomersDate.Size = new Size(297, 23);
            TxtCustomersDate.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(650, 93);
            label5.Name = "label5";
            label5.Size = new Size(159, 21);
            label5.TabIndex = 18;
            label5.Text = "Customers Birthday";
            // 
            // TxtCustomersAddress
            // 
            TxtCustomersAddress.Location = new Point(395, 117);
            TxtCustomersAddress.Name = "TxtCustomersAddress";
            TxtCustomersAddress.Size = new Size(209, 23);
            TxtCustomersAddress.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(396, 93);
            label4.Name = "label4";
            label4.Size = new Size(154, 21);
            label4.TabIndex = 16;
            label4.Text = "Customers Address";
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.FromArgb(224, 224, 224);
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(548, 275);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(319, 85);
            BtnCancel.TabIndex = 15;
            BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.FromArgb(224, 224, 224);
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(23, 275);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(376, 85);
            BtnSave.TabIndex = 14;
            BtnSave.UseVisualStyleBackColor = false;
            // 
            // TxtCustomersLastName
            // 
            TxtCustomersLastName.Location = new Point(21, 117);
            TxtCustomersLastName.Name = "TxtCustomersLastName";
            TxtCustomersLastName.Size = new Size(317, 23);
            TxtCustomersLastName.TabIndex = 13;
            // 
            // TxtCustomersId
            // 
            TxtCustomersId.Location = new Point(22, 47);
            TxtCustomersId.Name = "TxtCustomersId";
            TxtCustomersId.ReadOnly = true;
            TxtCustomersId.Size = new Size(155, 23);
            TxtCustomersId.TabIndex = 12;
            TxtCustomersId.Text = "0";
            TxtCustomersId.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtCustomersFirstName
            // 
            TxtCustomersFirstName.Location = new Point(276, 47);
            TxtCustomersFirstName.Name = "TxtCustomersFirstName";
            TxtCustomersFirstName.Size = new Size(317, 23);
            TxtCustomersFirstName.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(276, 23);
            label2.Name = "label2";
            label2.Size = new Size(176, 21);
            label2.TabIndex = 10;
            label2.Text = "Customers First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 93);
            label3.Name = "label3";
            label3.Size = new Size(174, 21);
            label3.TabIndex = 9;
            label3.Text = "Customers Last Name";
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label.Location = new Point(21, 23);
            Label.Name = "Label";
            Label.Size = new Size(109, 21);
            Label.TabIndex = 8;
            Label.Text = "Customers Id";
            // 
            // CustomersView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 521);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CustomersView";
            Text = "Customers Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCustomersList.ResumeLayout(false);
            tabPageCustomersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomers).EndInit();
            tabPageCustomersDetail.ResumeLayout(false);
            tabPageCustomersDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label customers;
        private TabControl tabControl1;
        private TabPage tabPageCustomersList;
        private TabPage tabPageCustomersDetail;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgCustomers;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label1;
        private TextBox TxtCustomersAddress;
        private Label label4;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtCustomersLastName;
        private TextBox TxtCustomersId;
        private TextBox TxtCustomersFirstName;
        private Label label2;
        private Label label3;
        private Label Label;
        private TextBox TxtCustomersEmail;
        private Label label7;
        private TextBox TxtCustomersPhone;
        private Label label6;
        private TextBox TxtCustomersDate;
        private Label label5;
        private TextBox TxtCustomersDocument;
        private Label label8;
    }
}