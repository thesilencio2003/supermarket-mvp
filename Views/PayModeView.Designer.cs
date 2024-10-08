namespace Supermarket_mvp.Views
{
    partial class PayModelView
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
            PayMode = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPagePayModeList = new TabPage();
            tabPagePayModeDetail = new TabPage();
            label1 = new Label();
            TxtSearch = new TextBox();
            BtnSearch = new Button();
            DgPayMode = new DataGridView();
            BtnNew = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnClose = new Button();
            Label = new Label();
            label3 = new Label();
            label2 = new Label();
            TxtPayModeName = new TextBox();
            TxtPayModeId = new TextBox();
            TxtPayModeObservation = new TextBox();
            BtnSave = new Button();
            BtnCancel = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPagePayModeList.SuspendLayout();
            tabPagePayModeDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(PayMode);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(988, 100);
            panel1.TabIndex = 0;
            // 
            // PayMode
            // 
            PayMode.AutoSize = true;
            PayMode.Font = new Font("Arial", 18F, FontStyle.Bold);
            PayMode.Location = new Point(131, 38);
            PayMode.Name = "PayMode";
            PayMode.Size = new Size(136, 29);
            PayMode.TabIndex = 0;
            PayMode.Text = "PAY MODE";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buy;
            pictureBox1.Location = new Point(12, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePayModeList);
            tabControl1.Controls.Add(tabPagePayModeDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(988, 421);
            tabControl1.TabIndex = 1;
            // 
            // tabPagePayModeList
            // 
            tabPagePayModeList.Controls.Add(BtnClose);
            tabPagePayModeList.Controls.Add(BtnDelete);
            tabPagePayModeList.Controls.Add(BtnEdit);
            tabPagePayModeList.Controls.Add(BtnNew);
            tabPagePayModeList.Controls.Add(DgPayMode);
            tabPagePayModeList.Controls.Add(BtnSearch);
            tabPagePayModeList.Controls.Add(TxtSearch);
            tabPagePayModeList.Controls.Add(label1);
            tabPagePayModeList.Location = new Point(4, 24);
            tabPagePayModeList.Name = "tabPagePayModeList";
            tabPagePayModeList.Padding = new Padding(3);
            tabPagePayModeList.Size = new Size(980, 393);
            tabPagePayModeList.TabIndex = 0;
            tabPagePayModeList.Text = "Pay Mode List ";
            tabPagePayModeList.UseVisualStyleBackColor = true;
            // 
            // tabPagePayModeDetail
            // 
            tabPagePayModeDetail.Controls.Add(BtnCancel);
            tabPagePayModeDetail.Controls.Add(BtnSave);
            tabPagePayModeDetail.Controls.Add(TxtPayModeObservation);
            tabPagePayModeDetail.Controls.Add(TxtPayModeId);
            tabPagePayModeDetail.Controls.Add(TxtPayModeName);
            tabPagePayModeDetail.Controls.Add(label2);
            tabPagePayModeDetail.Controls.Add(label3);
            tabPagePayModeDetail.Controls.Add(Label);
            tabPagePayModeDetail.Location = new Point(4, 24);
            tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            tabPagePayModeDetail.Padding = new Padding(3);
            tabPagePayModeDetail.Size = new Size(980, 393);
            tabPagePayModeDetail.TabIndex = 1;
            tabPagePayModeDetail.Text = "Pay Mode Detai";
            tabPagePayModeDetail.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 13);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 0;
            label1.Text = "Search Pay Mode";
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(23, 38);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(624, 23);
            TxtSearch.TabIndex = 1;
            TxtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // BtnSearch
            // 
            BtnSearch.BackColor = Color.FromArgb(224, 224, 224);
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(653, 26);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(71, 45);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = false;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(23, 77);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.Size = new Size(701, 298);
            DgPayMode.TabIndex = 3;
            // 
            // BtnNew
            // 
            BtnNew.BackColor = Color.FromArgb(224, 224, 224);
            BtnNew.ForeColor = SystemColors.ControlText;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(747, 79);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(224, 69);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = false;
            // 
            // BtnEdit
            // 
            BtnEdit.BackColor = Color.FromArgb(224, 224, 224);
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(748, 154);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(224, 71);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = false;
            BtnEdit.Click += button1_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = Color.FromArgb(224, 224, 224);
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(748, 231);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(223, 68);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnClose
            // 
            BtnClose.BackColor = Color.FromArgb(224, 224, 224);
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(748, 305);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(223, 70);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = false;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label.Location = new Point(23, 22);
            Label.Name = "Label";
            Label.Size = new Size(105, 21);
            Label.TabIndex = 0;
            Label.Text = "Pay Mode Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 156);
            label3.Name = "label3";
            label3.Size = new Size(184, 21);
            label3.TabIndex = 1;
            label3.Text = "Pay Mode Observation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 84);
            label2.Name = "label2";
            label2.Size = new Size(136, 21);
            label2.TabIndex = 2;
            label2.Text = "Pay Mode Name";
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(23, 108);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.Size = new Size(317, 23);
            TxtPayModeName.TabIndex = 3;
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(24, 46);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.Size = new Size(155, 23);
            TxtPayModeId.TabIndex = 4;
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(23, 180);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.Size = new Size(317, 103);
            TxtPayModeObservation.TabIndex = 5;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.FromArgb(224, 224, 224);
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(24, 302);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(104, 57);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = false;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.FromArgb(224, 224, 224);
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(168, 302);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(104, 57);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = false;
            // 
            // PayModelView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 521);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PayModelView";
            Text = "Pay Mode Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPagePayModeList.ResumeLayout(false);
            tabPagePayModeList.PerformLayout();
            tabPagePayModeDetail.ResumeLayout(false);
            tabPagePayModeDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label PayMode;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPagePayModeList;
        private TabPage tabPagePayModeDetail;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label1;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgPayMode;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtPayModeObservation;
        private TextBox TxtPayModeId;
        private TextBox TxtPayModeName;
        private Label label2;
        private Label label3;
        private Label Label;
    }
}