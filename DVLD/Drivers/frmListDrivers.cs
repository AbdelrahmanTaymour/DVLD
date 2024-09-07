using DVLD.Licenses;
using DVLD.People;
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

namespace DVLD.Drivers
{
    public partial class frmListDrivers : Form
    {
        DataTable _dtAllDrivers;
        public frmListDrivers()
        {
            InitializeComponent();
        }

        private void frmListDrivers_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            _dtAllDrivers = clsDriver.GetAllDrivers();
            dgvDriversList.DataSource = _dtAllDrivers;
            lblRecordsNo.Text = "# Records:  " + dgvDriversList.Rows.Count.ToString();

            if(dgvDriversList.Rows.Count > 0)
            {
                dgvDriversList.Columns[0].HeaderText = "Driver ID";
                dgvDriversList.Columns[0].Width = 120;

                dgvDriversList.Columns[1].HeaderText = "Person ID";
                dgvDriversList.Columns[1].Width = 120;

                dgvDriversList.Columns[2].HeaderText = "National No.";
                dgvDriversList.Columns[2].Width = 140;

                dgvDriversList.Columns[3].HeaderText = "Full Name";
                dgvDriversList.Columns[3].Width = 320;

                dgvDriversList.Columns[4].HeaderText = "Date";
                dgvDriversList.Columns[4].Width = 170;

                dgvDriversList.Columns[5].HeaderText = "Active Licenses";
                dgvDriversList.Columns[5].Width = 150;
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");


            if (cbFilterBy.Text == "None")
            {
                txtFilterValue.Enabled = false;
            }
            else
                txtFilterValue.Enabled = true;

            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "Driver ID":
                    FilterColumn = "DriverID";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;


                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllDrivers.DefaultView.RowFilter = "";
                lblRecordsNo.Text = "# Records:  " + dgvDriversList.Rows.Count.ToString();
                return;
            }


            if (FilterColumn != "FullName" && FilterColumn != "NationalNo")
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsNo.Text = "# Records:  " + dgvDriversList.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Driver ID" || cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ShowDetailstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo((int)dgvDriversList.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            frmListDrivers_Load(null, null);
        }

        

        private void showPersonLicenseHistorytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory((int)dgvDriversList.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }
    }
}
