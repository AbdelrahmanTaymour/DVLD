using DVLD.Licenses;
using DVLD.Licenses.Local_Licenses;
using DVLD.Tests;
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

namespace DVLD.Applications.Local_Driving_License
{
    public partial class frmListLocalDrivingLicesnseApplications : Form
    {
        DataTable _AllLocalApplications;

        public frmListLocalDrivingLicesnseApplications()
        {
            InitializeComponent();
        }


        private void frmListLocalDrivingLicesnseApplications_Load(object sender, EventArgs e)
        {
            _AllLocalApplications = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();
            dgvLocalDrivingLicenseApplications.DataSource = _AllLocalApplications;
            cbFilterBy.SelectedItem = 0;
            lblRecordsNo.Text = "# Records:  " + dgvLocalDrivingLicenseApplications.Rows.Count.ToString();

            if(dgvLocalDrivingLicenseApplications.Rows.Count > 0)
            {
                dgvLocalDrivingLicenseApplications.Columns[0].HeaderText = "L.D.L.AppID";
                dgvLocalDrivingLicenseApplications.Columns[0].Width = 110;

                dgvLocalDrivingLicenseApplications.Columns[1].HeaderText = "Class Name";
                dgvLocalDrivingLicenseApplications.Columns[1].Width = 185;

                dgvLocalDrivingLicenseApplications.Columns[2].HeaderText = "National No.";
                dgvLocalDrivingLicenseApplications.Columns[2].Width = 90;

                dgvLocalDrivingLicenseApplications.Columns[3].HeaderText = "Full Name";
                dgvLocalDrivingLicenseApplications.Columns[3].Width = 220;

                dgvLocalDrivingLicenseApplications.Columns[4].HeaderText = "Application Date";
                dgvLocalDrivingLicenseApplications.Columns[4].Width = 110;

                dgvLocalDrivingLicenseApplications.Columns[5].HeaderText = "Passed Tests";
                dgvLocalDrivingLicenseApplications.Columns[5].Width = 90;

                dgvLocalDrivingLicenseApplications.Columns[6].HeaderText = "Status";
                dgvLocalDrivingLicenseApplications.Columns[6].Width = 110;
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");
            txtFilterValue.Text = "";
            txtFilterValue.Focus();

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch(cbFilterBy.Text)
            {
                case "L.D.L.AppID":
                    FilterColumn = "LocalDrivingLicenseApplicationID";
                    break;
                case "National No.":
                    FilterColumn = "NationalNo";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                case "Status":
                    FilterColumn = "Status";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }



            if(txtFilterValue.Text.Trim() =="" || txtFilterValue.Text.Trim() == "None")
            {
                _AllLocalApplications.DefaultView.RowFilter = "";
                lblRecordsNo.Text = "# Records:  " + dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
                return;
            }



            if (FilterColumn == "LocalDrivingLicenseApplicationID")
                _AllLocalApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn,txtFilterValue.Text.Trim());
            else
                _AllLocalApplications.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, txtFilterValue.Text.Trim());



            lblRecordsNo.Text = "# Records:  " + dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
        
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "L.D.L.AppID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        
        private void btnAddNewApplication_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicesnseApplication frm = new frmAddUpdateLocalDrivingLicesnseApplication();
            frm.ShowDialog();
            frmListLocalDrivingLicesnseApplications_Load(null, null);
        }

        private void CancelApptoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to cancel this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication =
                clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationInfoByID
                        ((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);

                if (LocalDrivingLicenseApplication != null && LocalDrivingLicenseApplication.Cancel())
                {
                    MessageBox.Show("Application Cancelled Successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListLocalDrivingLicesnseApplications_Load(null, null);
                }
                else
                    MessageBox.Show("Could not cancel applicatoin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            frmListLocalDrivingLicesnseApplications_Load(null, null);
        }

        private void EditApptoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicesnseApplication frm =
                new frmAddUpdateLocalDrivingLicesnseApplication((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            frmListLocalDrivingLicesnseApplications_Load(null, null);
        }

        private void DeletetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to Delete this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication =
                clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationInfoByID
                        ((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);

            if (LocalDrivingLicenseApplication != null && LocalDrivingLicenseApplication.Delete())
            {
                MessageBox.Show("Application Deleted Successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListLocalDrivingLicesnseApplications_Load(null, null);
            }
            else
                MessageBox.Show("Could not Delete applicatoin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            frmListLocalDrivingLicesnseApplications_Load(null, null);

        }

        private void ShowAPPDetailstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLocalDrivingLicenseApplicationInfo frm =
                new frmShowLocalDrivingLicenseApplicationInfo((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void VisionTesttoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListTestAppointments frm = new frmListTestAppointments
                ((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value, clsTestType.enTestType.VisionTest);
            frm.ShowDialog();
            frmListLocalDrivingLicesnseApplications_Load(null, null);
        }

        private void WrittenTesttoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmListTestAppointments frm = new frmListTestAppointments
                ((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value, clsTestType.enTestType.WrittenTest);
            frm.ShowDialog();
            frmListLocalDrivingLicesnseApplications_Load(null, null);
        }

        private void StreetTesttoolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmListTestAppointments frm = new frmListTestAppointments
                ((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value, clsTestType.enTestType.StreetTest);
            frm.ShowDialog();
            frmListLocalDrivingLicesnseApplications_Load(null, null);
        }

        private void cmsApplications_Opening(object sender, CancelEventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication
                = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationInfoByID(LocalDrivingLicenseApplicationID);

            int TotalPassedTests = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[5].Value;
            bool LicenseExists = LocalDrivingLicenseApplication.IsLicenseIssued();

            IssueDivingLicensetoolStripMenuItem1.Enabled = (TotalPassedTests == 3) && !LicenseExists;
            ShowLicensetoolStripMenuItem2.Enabled = LicenseExists;
            EditApptoolStripMenuItem.Enabled = !LicenseExists && (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);
            CancelApptoolStripMenuItem.Enabled = (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);
            DeletetoolStripMenuItem.Enabled = (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);

            bool PassedVisionTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.VisionTest);
            bool PassedWrittenTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.WrittenTest);
            bool PassedStreetTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.StreetTest);

            SechdualTeststoolStripMenuItem.Enabled = !LicenseExists && (!PassedVisionTest || !PassedWrittenTest || !PassedStreetTest) && (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New); ;
            if (SechdualTeststoolStripMenuItem.Enabled)
            {
                VisionTesttoolStripMenuItem1.Enabled = !PassedVisionTest;
                WrittenTesttoolStripMenuItem2.Enabled = !PassedWrittenTest && PassedVisionTest;
                StreetTesttoolStripMenuItem3.Enabled = !PassedStreetTest && PassedWrittenTest && PassedVisionTest;
            }

        }

        private void IssueDivingLicensetoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmIssueDriverLicenseFirstTime frm =
                new frmIssueDriverLicenseFirstTime((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListLocalDrivingLicesnseApplications_Load(null, null);
        }

        private void ShowLicensetoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int LicenseID = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationInfoByID
                ((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value).GetActiveLicenseID();

            if(LicenseID != -1)
            {
                frmShowLicenseInfo frm = new frmShowLicenseInfo(LicenseID);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No License Found!", "No License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void HistoryLicensestoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationInfoByID(LocalDrivingLicenseApplicationID);

            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(localDrivingLicenseApplication.ApplicantPersonID);
            frm.ShowDialog();
        }
    }
}
