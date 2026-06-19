using ContactsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsDesktop
{
    public partial class frmEnterID : Form
    {
        public enum frmMode { Edit = 1, Delete = 2 }
        private frmMode _mode;
        public event Action OnDeletionSuccessfull;

        public frmEnterID(frmMode mode)
        {
            InitializeComponent();
            this._mode = mode;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maskedTextBox1.Text))
            {
                int id = int.Parse(maskedTextBox1.Text);
                if (clsContact.IsExits(id))
                {
                    switch (_mode)
                    {
                        case frmMode.Edit:
                            Form contactForm = new frmAddEditContact(id);
                            contactForm.ShowDialog();
                            
                            break;
                        case frmMode.Delete:
                            clsContact contact = clsContact.Find(id);
                            if (contact != null)
                            {
                                DialogResult result = MessageBox.Show($"Are you sure you want to delete \"{contact.FirstName}\" and ID {id}", "Delete Contact?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                                if (result == DialogResult.Yes)
                                {
                                    if (clsContact.DeleteContactWithID(id))
                                    {
                                        MessageBox.Show("Contact deleted successfully");
                                        //should refresh
                                        OnDeletionSuccessfull?.Invoke();

                                    }
                                    else
                                    {
                                        MessageBox.Show("Contact deletion failed!");
                                    }
                                }
                            }
                            break;

                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Contact does not exist");
                }





            }
            else
            {
                enterIdErrorProvider.SetError(maskedTextBox1, "Cannot be empty");
                maskedTextBox1.Focus();
            }
        }

        
    }
}
