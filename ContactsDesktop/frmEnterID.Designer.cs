namespace ContactsDesktop
{
    partial class frmEnterID
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
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            btnOk = new Button();
            enterIdErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)enterIdErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(235, 25);
            maskedTextBox1.Mask = "00000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(56, 27);
            maskedTextBox1.TabIndex = 0;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 28);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter Contact ID:";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(156, 86);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(81, 26);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // enterIdErrorProvider
            // 
            enterIdErrorProvider.ContainerControl = this;
            // 
            // frmEnterID
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(402, 124);
            Controls.Add(btnOk);
            Controls.Add(label1);
            Controls.Add(maskedTextBox1);
            Name = "frmEnterID";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EnterID";
            
            ((System.ComponentModel.ISupportInitialize)enterIdErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private Label label1;
        private Button btnOk;
        private ErrorProvider enterIdErrorProvider;
    }
}