using DVLD.Globle_Classes;
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
    public partial class frmAddUpdateLocalDrivingLicesnseApplication : Form
    {
        public enum enMode { AddNew=0,Update=1}
        
        enMode _Mode = enMode.AddNew;
        int _LocalDrivingLicenseApplicationID = -1;
        int _SelectedPersonID = -1;
        clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplicationInfo;

        public frmAddUpdateLocalDrivingLicesnseApplication()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddUpdateLocalDrivingLicesnseApplication(int LocalDrivingLicesnseApplicationID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicesnseApplicationID;
            _Mode = enMode.Update;
        }

        void _FillLicenseClassesInComoboBox()
        {
            DataTable dtLicenseClasses = clsLicenseClass.GetAllLicenseClasses();

            foreach(DataRow row in dtLicenseClasses.Rows)
            {
                cbLicenseClass.Items.Add(row["ClassName"]);
            }
        }

        void _ResetDefaultValue()
        {
            _FillLicenseClassesInComoboBox();

            if (_Mode == enMode.AddNew)
            {
                //lblTitle.Text = "Add New Local Driving License Application";
                //this.Text = "Add New L.D.L Application";
                
                _LocalDrivingLicenseApplicationInfo = new clsLocalDrivingLicenseApplication();

                ctrlPersonCardWithFilter1.Focus();
                tpApplicationInfo.Enabled = false;
                
                cbLicenseClass.SelectedIndex = 2;
                lblFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.NewDrivingLicense).ApplicationTypeFees.ToString();
                lblApplicationDate.Text = DateTime.Now.ToString();
                lblCreatedByUser.Text = clsGlobal.CurrentUser.Username;

            }
            else
            {
                //lblTitle.Text = "Update Local Driving License Application";
                //this.Text = "Update L.D.L Application";

                tpApplicationInfo.Enabled = true;
                btnSave.Enabled = true;
            }

            lblTitle.Text = this.Text = ((_Mode == enMode.AddNew) ? "Add New " : "Update ") + "Local Driving License Application";
        }

        void _LoadData()
        {
            ctrlPersonCardWithFilter1.FilterEnabled = false;
            _LocalDrivingLicenseApplicationInfo = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationInfoByID(_LocalDrivingLicenseApplicationID);

            if(_LocalDrivingLicenseApplicationInfo == null)
            {
                MessageBox.Show("No Application with ID = " + _LocalDrivingLicenseApplicationID, "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            ctrlPersonCardWithFilter1.LoadPersonInfo(_LocalDrivingLicenseApplicationInfo.ApplicantPersonID);
            lblLocalDrivingLicebseApplicationID.Text = _LocalDrivingLicenseApplicationInfo.LocalDrivingLicenseApplicationID.ToString();
            lblApplicationDate.Text = _LocalDrivingLicenseApplicationInfo.ApplicationDate.ToString();
            cbLicenseClass.SelectedIndex = cbLicenseClass.FindString(clsLicenseClass.Find(_LocalDrivingLicenseApplicationInfo.LicenseClassID).LicenseCalssName);
            lblFees.Text = _LocalDrivingLicenseApplicationInfo.PaidFees.ToString();
            lblCreatedByUser.Text = clsUser.FindByUserID(_LocalDrivingLicenseApplicationInfo.CreatedByUserID).Username;

        }

        private void frmAddUpdateLocalDrivingLicesnseApplication_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void ctrlPersonCardWithFilter1_OnPersonSelected(int obj)
        {
            _SelectedPersonID = obj;
        }

        private void btnPersonInfoNext_Click(object sender, EventArgs e)
        {
            if(_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tpApplicationInfo.Enabled = true;
                tcApplicationInfo.SelectedTab = tcApplicationInfo.TabPages["tpApplicationInfo"];
                return;
            }

            if(_SelectedPersonID == -1)
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.FilterFocus();
                return;
            }

            btnSave.Enabled = true;
            tpApplicationInfo.Enabled = true;
            tcApplicationInfo.SelectedTab = tcApplicationInfo.TabPages["tpApplicationInfo"];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int LicenseClassID = clsLicenseClass.Find(cbLicenseClass.Text).LicenseClassID;

            int ActiveApplicationID = clsApplication.GetActiveApplicationIDForLicenseClass(_SelectedPersonID, clsApplication.enApplicationType.NewDrivingLicense, LicenseClassID);
        
            if(ActiveApplicationID != -1)
            {
                MessageBox.Show("Choose another License Class, the selected Person Already have an active application for the selected class with id=" + ActiveApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbLicenseClass.Focus();
                return;
            }

            if (clsLicense.IsLicenseExistByPersonID(ctrlPersonCardWithFilter1.PersonID, LicenseClassID))
            {

                MessageBox.Show("Person already have a license with the same applied driving class, Choose diffrent driving class", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _LocalDrivingLicenseApplicationInfo.ApplicantPersonID = _SelectedPersonID;
            _LocalDrivingLicenseApplicationInfo.ApplicationDate = DateTime.Now;
            _LocalDrivingLicenseApplicationInfo.ApplicationTypeID = 1;
            _LocalDrivingLicenseApplicationInfo.ApplicationStatus = clsApplication.enApplicationStatus.New;
            _LocalDrivingLicenseApplicationInfo.PaidFees = Convert.ToSingle(lblFees.Text);
            _LocalDrivingLicenseApplicationInfo.LastStatusDate = DateTime.Now;
            _LocalDrivingLicenseApplicationInfo.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _LocalDrivingLicenseApplicationInfo.LicenseClassID = LicenseClassID;

            if(_LocalDrivingLicenseApplicationInfo.Save())
            {
                lblLocalDrivingLicebseApplicationID.Text = _LocalDrivingLicenseApplicationInfo.LocalDrivingLicenseApplicationID.ToString();
                _Mode = enMode.Update;
                lblTitle.Text = "Update Local Driving License Application";
                this.Text = "Update L.D.L Application";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void frmAddUpdateLocalDrivingLicesnseApplication_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.FilterFocus();
        }
    }
}
