namespace ContactsDesktop
{
    partial class frmAddEditContact
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditContact));
            panel1 = new Panel();
            dropDownCountry = new ComboBox();
            label8 = new Label();
            dateOfBirthPicker = new DateTimePicker();
            label7 = new Label();
            RichTxtBoxAddress = new RichTextBox();
            label6 = new Label();
            IdLbl = new Label();
            label4 = new Label();
            TxtBxPhoneNumber = new TextBox();
            label3 = new Label();
            TxtBxEmail = new TextBox();
            label2 = new Label();
            TxtBxLastName = new TextBox();
            label1 = new Label();
            TxtBxFirstName = new TextBox();
            contactPB = new PictureBox();
            btnSetImage = new Button();
            btnSave = new Button();
            CloseBtn = new Button();
            formTitleLbl = new Label();
            btnRemoveImage = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)contactPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dropDownCountry);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(dateOfBirthPicker);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(RichTxtBoxAddress);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(IdLbl);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(TxtBxPhoneNumber);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TxtBxEmail);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TxtBxLastName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TxtBxFirstName);
            panel1.Location = new Point(12, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 603);
            panel1.TabIndex = 0;
            // 
            // dropDownCountry
            // 
            dropDownCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            dropDownCountry.FormattingEnabled = true;
            dropDownCountry.Location = new Point(158, 405);
            dropDownCountry.Name = "dropDownCountry";
            dropDownCountry.Size = new Size(151, 28);
            dropDownCountry.TabIndex = 15;
            dropDownCountry.SelectedIndexChanged += dropDownCountry_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 405);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 14;
            label8.Text = "Country";
            // 
            // dateOfBirthPicker
            // 
            dateOfBirthPicker.Location = new Point(158, 336);
            dateOfBirthPicker.Name = "dateOfBirthPicker";
            dateOfBirthPicker.Size = new Size(248, 27);
            dateOfBirthPicker.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 336);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 12;
            label7.Text = "Date of Birth";
            // 
            // RichTxtBoxAddress
            // 
            RichTxtBoxAddress.Location = new Point(158, 479);
            RichTxtBoxAddress.Name = "RichTxtBoxAddress";
            RichTxtBoxAddress.Size = new Size(168, 67);
            RichTxtBoxAddress.TabIndex = 11;
            RichTxtBoxAddress.Text = "";
            RichTxtBoxAddress.Validating += RichTxtBoxAddress_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 503);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 10;
            label6.Text = "Address";
            // 
            // IdLbl
            // 
            IdLbl.AutoSize = true;
            IdLbl.Location = new Point(24, 85);
            IdLbl.Name = "IdLbl";
            IdLbl.Size = new Size(27, 20);
            IdLbl.TabIndex = 8;
            IdLbl.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 281);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 7;
            label4.Text = "Phone Number";
            // 
            // TxtBxPhoneNumber
            // 
            TxtBxPhoneNumber.Location = new Point(158, 278);
            TxtBxPhoneNumber.MaxLength = 50;
            TxtBxPhoneNumber.Name = "TxtBxPhoneNumber";
            TxtBxPhoneNumber.PlaceholderText = "+1 234 567 890";
            TxtBxPhoneNumber.Size = new Size(197, 27);
            TxtBxPhoneNumber.TabIndex = 6;
            TxtBxPhoneNumber.TextChanged += TxtBxPhoneNumber_TextChanged;
            TxtBxPhoneNumber.KeyPress += TxtBxPhoneNumber_KeyPress;
            TxtBxPhoneNumber.Validating += TxtBx_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 228);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // TxtBxEmail
            // 
            TxtBxEmail.Location = new Point(158, 228);
            TxtBxEmail.MaxLength = 50;
            TxtBxEmail.Name = "TxtBxEmail";
            TxtBxEmail.PlaceholderText = "example@gmail.com";
            TxtBxEmail.Size = new Size(197, 27);
            TxtBxEmail.TabIndex = 4;
            TxtBxEmail.Validating += TxtBx_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 183);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 3;
            label2.Text = "Last Name";
            // 
            // TxtBxLastName
            // 
            TxtBxLastName.Location = new Point(158, 176);
            TxtBxLastName.MaxLength = 50;
            TxtBxLastName.Name = "TxtBxLastName";
            TxtBxLastName.PlaceholderText = "Last Name";
            TxtBxLastName.Size = new Size(197, 27);
            TxtBxLastName.TabIndex = 2;
            TxtBxLastName.Validating += TxtBx_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 135);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            // 
            // TxtBxFirstName
            // 
            TxtBxFirstName.Location = new Point(158, 128);
            TxtBxFirstName.MaxLength = 50;
            TxtBxFirstName.Name = "TxtBxFirstName";
            TxtBxFirstName.PlaceholderText = "First Name";
            TxtBxFirstName.Size = new Size(197, 27);
            TxtBxFirstName.TabIndex = 0;
            TxtBxFirstName.Validating += TxtBx_Validating;
            // 
            // contactPB
            // 
            contactPB.Image = Properties.Resources.user;
            contactPB.Location = new Point(480, 88);
            contactPB.Name = "contactPB";
            contactPB.Size = new Size(160, 184);
            contactPB.SizeMode = PictureBoxSizeMode.Zoom;
            contactPB.TabIndex = 1;
            contactPB.TabStop = false;
            // 
            // btnSetImage
            // 
            btnSetImage.Location = new Point(501, 298);
            btnSetImage.Name = "btnSetImage";
            btnSetImage.Size = new Size(125, 29);
            btnSetImage.TabIndex = 2;
            btnSetImage.Text = "Set Image";
            btnSetImage.UseVisualStyleBackColor = true;
            btnSetImage.Click += btnSetImage_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(480, 708);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 38);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.BackColor = Color.LightCoral;
            CloseBtn.Location = new Point(340, 708);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(118, 38);
            CloseBtn.TabIndex = 4;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // formTitleLbl
            // 
            formTitleLbl.AutoSize = true;
            formTitleLbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formTitleLbl.Location = new Point(208, 25);
            formTitleLbl.Name = "formTitleLbl";
            formTitleLbl.Size = new Size(233, 38);
            formTitleLbl.TabIndex = 5;
            formTitleLbl.Text = "Add New Contact";
            // 
            // btnRemoveImage
            // 
            btnRemoveImage.BackColor = Color.LightCoral;
            btnRemoveImage.Location = new Point(501, 333);
            btnRemoveImage.Name = "btnRemoveImage";
            btnRemoveImage.Size = new Size(125, 29);
            btnRemoveImage.TabIndex = 6;
            btnRemoveImage.Text = "Remove Image";
            btnRemoveImage.UseVisualStyleBackColor = false;
            btnRemoveImage.Click += btnRemoveImage_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            errorProvider1.Icon = (Icon)resources.GetObject("errorProvider1.Icon");
            // 
            // frmAddEditContact
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(652, 777);
            Controls.Add(btnRemoveImage);
            Controls.Add(formTitleLbl);
            Controls.Add(CloseBtn);
            Controls.Add(btnSave);
            Controls.Add(btnSetImage);
            Controls.Add(contactPB);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmAddEditContact";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contact";
            Load += AddContactForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)contactPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox TxtBxFirstName;
        private Label label1;
        private Label label2;
        private TextBox TxtBxLastName;
        private Label label4;
        private TextBox TxtBxPhoneNumber;
        private Label label3;
        private TextBox TxtBxEmail;
        private PictureBox contactPB;
        private RichTextBox RichTxtBoxAddress;
        private Label label6;
        private Label IdLbl;
        private Button btnSetImage;
        private ComboBox dropDownCountry;
        private Label label8;
        private DateTimePicker dateOfBirthPicker;
        private Label label7;
        private Button btnSave;
        private Button CloseBtn;
        private Label formTitleLbl;
        private Button btnRemoveImage;
        private ErrorProvider errorProvider1;
    }
}