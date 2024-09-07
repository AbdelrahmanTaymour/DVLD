using DVLD.Licenses.Local_Licenses;
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

namespace DVLD.Applications.Local_Driving_License.Controls
{
    public partial class ctrlDrivingLicenseApplicationInfo : UserControl
    {
        clsLocalDrivingLicenseApplication _LocalLicenseApplication;
        int _LocalLicenseApplicationID = -1;
        int _LicenseID;
        public int LocalLicenseApplicationID
        {
            get { return _LocalLicenseApplicationID; }
        }

        public ctrlDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }
        void _ResetLocalDrivingLicenseApplicationInfo()
        {
            _LocalLicenseApplicationID = -1;
            ctrlApplicationBasicInfo1.ResetApplicationInfo();
            lblAppliedFor.Text = "[???]";
            lblLocalDrivingLicenseApplicationID.Text = "[???]";
            lblPassedTests.Text = "0";
        }

        void _FillLocalDrivingLicenseApplicationInfo()
        {
            _LicenseID = _LocalLicenseApplication.GetActiveLicenseID();
            llShowLicenceInfo.Enabled = (_LicenseID != -1);

            lblAppliedFor.Text = _LocalLicenseApplication.LicenseClassInfo.LicenseCalssName;
            lblLocalDrivingLicenseApplicationID.Text = _LocalLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblPassedTests.Text = _LocalLicenseApplication.GetPassedTestCount() + "/3";
            ctrlApplicationBasicInfo1.LoadApplicationInfo(_LocalLicenseApplication.ApplicationID);

            clsLicenseClass LicenseClass = clsLicenseClass.Find(LocalLicenseApplicationID);

            if(LicenseClass != null)
            {
                lblAppliedFor.Text = LicenseClass.LicenseCalssName;
            }


        }
        public void LoadApplicationInfoByLocalDrivingAppID(int LocalLicenseApplicationID)
        {
            _LocalLicenseApplication = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationInfoByID(LocalLicenseApplicationID);

            if(_LocalLicenseApplication == null )
            {
                _ResetLocalDrivingLicenseApplicationInfo();

                MessageBox.Show("No Application with ApplicationID = " + _LocalLicenseApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillLocalDrivingLicenseApplicationInfo();
        }

        private void llShowLicenceInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_LocalLicenseApplication.GetActiveLicenseID());
            frm.ShowDialog();
        }
    }
}
