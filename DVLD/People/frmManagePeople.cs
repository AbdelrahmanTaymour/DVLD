using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DVLD.People
{
    public partial class frmManagePeople : Form
    {
        private static DataTable _dtAllPeople = clsPerson.GetAllPeople();
        DataTable _dtPeopleList = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo", "FirstName", "LastName",
                                                       "GendorCaption", "DateOfBirth", "CountryName",  "Phone", "Email");
        public frmManagePeople()
        {
            InitializeComponent();
        }
        void _RefreshPeopleList()
        {
            _dtAllPeople = clsPerson.GetAllPeople();
            _dtPeopleList = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo", "FirstName", "LastName", 
                                                        "GendorCaption", "DateOfBirth", "CountryName", "Phone", "Email");

            dgvPeopleList.DataSource = _dtPeopleList;
            lblRecordsNo.Text = dgvPeopleList.Rows.Count.ToString();
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            dgvPeopleList.DataSource = _dtPeopleList;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsNo.Text = "# Records:  " + dgvPeopleList.Rows.Count.ToString();

        }

        private void txtFilterValue_TextChange(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilterBy.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Nationality":
                    FilterColumn = "CountryName";
                    break;

                case "Gendor":
                    FilterColumn = "GendorCaption";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeopleList.DefaultView.RowFilter = "";
                lblRecordsNo.Text = "# Records:  " + dgvPeopleList.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "PersonID")
                _dtPeopleList.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtPeopleList.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsNo.Text = "# Records:  " + dgvPeopleList.Rows.Count.ToString();
        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = !(cbFilterBy.SelectedItem.ToString() == "None");
            
            if (txtFilterValue.Visible)
            {
                txtFilterValue.Focus();
                txtFilterValue.Text = "";
            }
        }
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilterBy.Text == "Person ID")
            {
                if (!Char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
        }
        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePersonInfo();
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void ShowDetailstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowPersonInfo((int)dgvPeopleList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
        private void AddNewPersontoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePersonInfo();
            frm.ShowDialog();
            _RefreshPeopleList();
        }
        private void EdittoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePersonInfo((int)dgvPeopleList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeopleList();
        }
        private void DeletetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete Person [" + dgvPeopleList.CurrentRow.Cells[0].Value + "]", 
                    "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string PersonImagePath = clsPerson.Find((int)dgvPeopleList.CurrentRow.Cells[0].Value).ImagePath;

                if(clsPerson.DeletePerson((int)dgvPeopleList.CurrentRow.Cells[0].Value))
                {
                    //Delete Image From Project Image Folder
                    File.Delete(PersonImagePath);
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeopleList();
                }
                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SendEmailtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet!", "SendEmail", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void PhoneCalltoolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet!", "SendEmail", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
