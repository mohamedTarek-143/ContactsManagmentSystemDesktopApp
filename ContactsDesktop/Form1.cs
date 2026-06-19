using ContactsBusinessLayer;
using System.Data;
using System.Windows.Forms;
namespace ContactsDesktop
{
    public partial class MainForm : Form
    {
        DataTable dtAllDetails;
        public static DataTable CountriesDataTable = clsCountry.GetAllCountriesNames();
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void _RefreshContactsList()
        {
            dtAllDetails = clsContact.GetAllDetails();
            dgvAllContacts.DataSource = dtAllDetails;
            dgvAllContacts.Columns["FirstName"].HeaderText = "First Name";
            dgvAllContacts.Columns["LastName"].HeaderText = "Last Name";
            dgvAllContacts.Columns["DateOfBirth"].HeaderText = "Date Of Birth";
            dgvAllContacts.Columns["CountryName"].HeaderText = "Country";

            // dgvAllContacts.Columns["ContactID"].Visible = false;
            dgvAllContacts.Columns["CountryID"].Visible = false;
            dgvAllContacts.Columns["ImagePath"].Visible = false;
            dgvAllContacts.Columns["Code"].Visible = false;

            dgvAllContacts.Columns["DateOfBirth"].DefaultCellStyle.Format = "dd/MM/yyyy";

            UpdateNoResultsLabel();
            dgvAllContacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }




        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form addContactForm = new frmAddEditContact(-1);
            addContactForm.ShowDialog();
            _RefreshContactsList();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _RefreshContactsList();
            fillCBcountryFilter();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form editForm = new frmAddEditContact((int)dgvAllContacts.CurrentRow.Cells[0].Value);
            editForm.ShowDialog();
            _RefreshContactsList();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dgvAllContacts.CurrentRow.Cells[0].Value;
            string firstName = (string)dgvAllContacts.CurrentRow.Cells[1].Value;
            DialogResult result = MessageBox.Show($"Are you sure you want to delete \"{firstName}\" and ID {id}", "Delete Contact?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                if (clsContact.DeleteContactWithID(id))
                {
                    MessageBox.Show("Contact deleted successfully");
                    _RefreshContactsList();

                }
                else
                {
                    MessageBox.Show("Contact deletion failed!");
                }
            }
        }


        private void searchBarTxtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(searchBarTxtBox.Text))
                {
                    string searchForStr = searchBarTxtBox.Text.ToLower().Trim().Replace("'", "''");
                    dtAllDetails.DefaultView.RowFilter =
                        $"FirstName LIKE '%{searchForStr}%' OR LastName LIKE'%{searchForStr}%' OR CountryName LIKE '%{searchForStr}%' OR Phone LIKE'%{searchForStr}%'";
                    dgvAllContacts.DataSource = dtAllDetails.DefaultView;

                }
                else
                {
                    dtAllDetails.DefaultView.RowFilter = "";
                    dgvAllContacts.DataSource = dtAllDetails;
                }
                UpdateNoResultsLabel();
            }
            catch (Exception E)
            {
                dtAllDetails.DefaultView.RowFilter = "";

            }




        }
        private void UpdateNoResultsLabel()
        {
            bool noResults = dtAllDetails.DefaultView.Count == 0;
            if (noResults)
            {
                lblFoundTxt.Visible = true;
            }
            else
            {
                lblFoundTxt.Visible = false;
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEnterID enterIDform = new frmEnterID(frmEnterID.frmMode.Edit);


            enterIDform.ShowDialog();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmEnterID enterIDform = new frmEnterID(frmEnterID.frmMode.Delete);

            enterIDform.OnDeletionSuccessfull += _RefreshContactsList;
            enterIDform.ShowDialog();
            enterIDform.OnDeletionSuccessfull -= _RefreshContactsList;
        }


        private void dgvAllContacts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int id = Convert.ToInt32(dgvAllContacts.Rows[e.RowIndex].Cells["ContactID"].Value);
            Form form = new frmAddEditContact(id);
            form.ShowDialog();
            _RefreshContactsList();
            dgvAllContacts.ClearSelection();
        }

        private void fillCBcountryFilter()
        {
            CBcountryFilter.Items.Add("None");
            
            foreach(DataRow row in CountriesDataTable.Rows)
            {
                CBcountryFilter.Items.Add(row["CountryName"].ToString());
            }
            CBcountryFilter.SelectedIndex = 0;
        }
        private void CBcountryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
           string country = CBcountryFilter.Text;

            if(country != null && country != "None")
            {
                dtAllDetails.DefaultView.RowFilter = $"CountryName LIKE '%{country}%'";
                dgvAllContacts.DataSource = dtAllDetails.DefaultView;

            }
            else
            {
                dtAllDetails.DefaultView.RowFilter = "";
                dgvAllContacts.DataSource = dtAllDetails.DefaultView;
            }
              
           
            
        }
    }
}
