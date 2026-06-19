using ContactsBusinessLayer;
using ContactsDesktop.Properties;
using System.Data;
namespace ContactsDesktop
{
    public partial class frmAddEditContact : Form
    {
        int _ContactID = -1;
        clsContact contact;

        private enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode;
       DataTable CountriesDataTable = MainForm.CountriesDataTable;

        public frmAddEditContact(int contactID)
        {
            InitializeComponent();



            _ContactID = contactID;
            if (_ContactID == -1)
            {
                _Mode = enMode.AddNew;
            }
            else
            {
                _Mode = enMode.Update;
            }
        }


        private void fillCountriesComboBox()
        {

            foreach (DataRow row in CountriesDataTable.Rows)
            {
                dropDownCountry.Items.Add(row["CountryName"].ToString() as string ?? "N/A");
                
            }
        }

        private void setCorrectPhoneCode()
        {
            string countryName = dropDownCountry.SelectedItem.ToString();
            if (countryName != null)
            {
                clsCountry country = clsCountry.Find(countryName);
                if (country != null)
                {
                    if (string.IsNullOrEmpty(country.PhoneCode))
                    {
                        TxtBxPhoneNumber.PlaceholderText = $"00000000000";
                    }
                    else
                    {
                        TxtBxPhoneNumber.PlaceholderText = $"{country.PhoneCode}";
                    }

                }
            }


        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {
            fillCountriesComboBox();
            dropDownCountry.SelectedIndex = 0;
            setCorrectPhoneCode();
            btnRemoveImage.Visible = false;
            contact = clsContact.Find(_ContactID);

            if (contact == null)
            {
                if (_Mode == enMode.AddNew)
                    contact = new clsContact();
                else
                {
                    MessageBox.Show("This form will close because contact no longer exists");
                    this.Close();
                    return;
                }
            }

            switch (_Mode)
            {
                case enMode.AddNew:
                    formTitleLbl.Text = "Add New Contact";
                    IdLbl.Visible = false;
                    break;
                case enMode.Update:
                    formTitleLbl.Text = "Edit Contact";
                    IdLbl.Visible = true;
                    IdLbl.Text = $"ID: {contact.ContactID}";
                    TxtBxFirstName.Text = contact.FirstName;
                    TxtBxLastName.Text = contact.LastName;
                    TxtBxPhoneNumber.Text = contact.Phone;
                    RichTxtBoxAddress.Text = contact.Address;
                    dropDownCountry.SelectedIndex = dropDownCountry.FindString(clsCountry.Find(contact.CountryID).CountryName);
                    dateOfBirthPicker.Value = contact.DateOfBirth;
                    TxtBxEmail.Text = contact.Email;
                    if (contact.ImagePath != "N/A" && contact.ImagePath != "")
                    {
                        contactPB.Load(contact.ImagePath);
                        btnRemoveImage.Visible = true;
                    }
                    break;
            }
        }

        private void TxtBx_Enter(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSetImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Choose Contact Image";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                contact.ImagePath = imagePath;
                contactPB.Load(imagePath);
                btnRemoveImage.Visible = true;

            }



        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            contact.ImagePath = "";
            contactPB.Image = Resources.user;
            btnRemoveImage.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsFormValid())
            {
                MessageBox.Show("Please fill all required feilds!", "can't save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            contact.FirstName = TxtBxFirstName.Text;
            contact.LastName = TxtBxLastName.Text;
            contact.Email = TxtBxEmail.Text;
            contact.Phone = TxtBxPhoneNumber.Text;
            //image path is updated from btnRemoveImage or setImage
            contact.Address = RichTxtBoxAddress.Text;
            contact.DateOfBirth = dateOfBirthPicker.Value;
            contact.CountryID = clsCountry.Find(dropDownCountry.Text).CountryID;

            if (contact.Save())
            {
                MessageBox.Show("Saved Successfully");
                this.Close();

            }
            else
            {
                // bad hci practice tell user more but not backend details
                MessageBox.Show("Failed to save contact");
            }
            _Mode = enMode.Update;
        }
        private bool IsFormValid()
        {
            bool valid = false;
            if (!string.IsNullOrEmpty(TxtBxFirstName.Text)
               && !string.IsNullOrEmpty(TxtBxLastName.Text)
               && !string.IsNullOrEmpty(TxtBxEmail.Text)
               && !string.IsNullOrEmpty(TxtBxPhoneNumber.Text)
               && !string.IsNullOrEmpty(RichTxtBoxAddress.Text))
            {
                valid = true;
                errorProvider1.Clear();
            }

            return valid;
        }
        private void TxtBx_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox txBx = (TextBox)sender;
            if (string.IsNullOrEmpty(txBx.Text))
            {
                errorProvider1.SetError(txBx, "Required Feild");
            }
            else
            {
                errorProvider1.SetError(txBx, "");
            }
        }

        private void RichTxtBoxAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(RichTxtBoxAddress.Text))
            {
                errorProvider1.SetError(RichTxtBoxAddress, "Required Feild");
            }
            else
            {
                errorProvider1.SetError(RichTxtBoxAddress, "");
            }
        }

        private void dropDownCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCorrectPhoneCode();
        }

        private void TxtBxPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar !='+' ;
        }
    }
}
