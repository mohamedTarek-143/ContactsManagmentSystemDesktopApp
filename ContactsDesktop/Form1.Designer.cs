namespace ContactsDesktop
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            AddBtn = new Button();
            panel2 = new Panel();
            label2 = new Label();
            CBcountryFilter = new ComboBox();
            btnDelete = new Button();
            btnEdit = new Button();
            pictureBox1 = new PictureBox();
            searchBarTxtBox = new TextBox();
            dgvAllContacts = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            lblFoundTxt = new Label();
            panel3 = new Panel();
            contextMenuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAllContacts).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(123, 52);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(122, 24);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(122, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.Right;
            AddBtn.BackColor = Color.PaleGreen;
            AddBtn.ForeColor = Color.Black;
            AddBtn.Location = new Point(894, 22);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(118, 36);
            AddBtn.TabIndex = 0;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(CBcountryFilter);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(searchBarTxtBox);
            panel2.Controls.Add(AddBtn);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(1319, 75);
            panel2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(89, 29);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 8;
            label2.Text = "Country Filter";
            // 
            // CBcountryFilter
            // 
            CBcountryFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            CBcountryFilter.FlatStyle = FlatStyle.System;
            CBcountryFilter.FormattingEnabled = true;
            CBcountryFilter.Location = new Point(192, 27);
            CBcountryFilter.Name = "CBcountryFilter";
            CBcountryFilter.Size = new Size(100, 28);
            CBcountryFilter.TabIndex = 7;
            CBcountryFilter.SelectedIndexChanged += CBcountryFilter_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Right;
            btnDelete.BackColor = Color.Pink;
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(1163, 22);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 36);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Right;
            btnEdit.BackColor = Color.Beige;
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(1028, 22);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(118, 36);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources.search2;
            pictureBox1.Location = new Point(315, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // searchBarTxtBox
            // 
            searchBarTxtBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            searchBarTxtBox.Location = new Point(373, 27);
            searchBarTxtBox.Name = "searchBarTxtBox";
            searchBarTxtBox.PlaceholderText = "Search";
            searchBarTxtBox.Size = new Size(476, 27);
            searchBarTxtBox.TabIndex = 3;
            searchBarTxtBox.TextChanged += searchBarTxtBox_TextChanged;
            // 
            // dgvAllContacts
            // 
            dgvAllContacts.AllowUserToAddRows = false;
            dgvAllContacts.AllowUserToDeleteRows = false;
            dgvAllContacts.BackgroundColor = Color.Gainsboro;
            dgvAllContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllContacts.ContextMenuStrip = contextMenuStrip1;
            dgvAllContacts.Dock = DockStyle.Fill;
            dgvAllContacts.Location = new Point(0, 0);
            dgvAllContacts.Name = "dgvAllContacts";
            dgvAllContacts.ReadOnly = true;
            dgvAllContacts.RowHeadersVisible = false;
            dgvAllContacts.RowHeadersWidth = 51;
            dgvAllContacts.Size = new Size(1319, 477);
            dgvAllContacts.TabIndex = 0;
            dgvAllContacts.CellDoubleClick += dgvAllContacts_CellDoubleClick;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Nirmala UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Honeydew;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1319, 80);
            label1.TabIndex = 7;
            label1.Text = "Contacts Manager";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblFoundTxt);
            panel1.Controls.Add(dgvAllContacts);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 155);
            panel1.Name = "panel1";
            panel1.Size = new Size(1319, 477);
            panel1.TabIndex = 8;
            // 
            // lblFoundTxt
            // 
            lblFoundTxt.AutoSize = true;
            lblFoundTxt.BackColor = Color.White;
            lblFoundTxt.Location = new Point(563, 249);
            lblFoundTxt.Name = "lblFoundTxt";
            lblFoundTxt.Size = new Size(135, 20);
            lblFoundTxt.TabIndex = 7;
            lblFoundTxt.Text = "No Contacts Found";
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1319, 80);
            panel3.TabIndex = 10;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(1319, 632);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contacts Manager";
            Load += MainForm_Load;
            contextMenuStrip1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAllContacts).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Button AddBtn;
        private PictureBox pictureBox1;
        private DataGridView dgvAllContacts;
        private TextBox searchBarTxtBox;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnDelete;
        private Button btnEdit;
        private Label lblFoundTxt;
        private Label label2;
        private ComboBox CBcountryFilter;
    }
}