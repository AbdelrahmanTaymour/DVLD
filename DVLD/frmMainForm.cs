using DVLD.Applications.ApplicationTypes;
using DVLD.Applications.Local_Driving_License;
using DVLD.Applications.International_License;
using DVLD.Drivers;
using DVLD.Globle_Classes;
using DVLD.Login;
using DVLD.People;
using DVLD.Properties;
using DVLD.Tests.Test_Types;
using DVLD.Users;
using System;
using System.Drawing;
using System.Windows.Forms;
using DVLD.Applications.Renew_Local_License;
using DVLD.Applications.Replace_Lost_Or_Damaged_License;
using DVLD.Applications.Rlease_Detained_License;
using DVLD.Licenses.Detain_License;
using DVLD.Tests.Questions;

namespace DVLD
{
    public partial class frmMainForm : Form
    {
       
        private bool _CloseAllApplication = true;
        public delegate void OnCloseApplication(bool CloseAllApplication);
        public event OnCloseApplication ApplicationClose;
        
        private void frmMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ApplicationClose(_CloseAllApplication);
            
        }

        public frmMainForm()
        {
            InitializeComponent();
            _CustomizeDesign();
        }

        //Design Procedures
        private void _LoadForm(object Form)
        {
            if (Prevfrm != null)
                Prevfrm.Close();

            if (panelMainForm.Controls.Count > 0)
                this.panelMainForm.Controls.RemoveAt(0);

            Form frm = Form as Form;
            frm.TopLevel = false;

            frm.Dock = DockStyle.Fill;
            Prevfrm = frm;
            panelMainForm.Controls.Add(frm);


            frm.Show();

        }
        private void _CustomizeDesign()
        {
            panelDrivingLicensesServices_SubMenu.Visible = false;
            panelManageApplication_SubMenu.Visible = false;
            panelNewDrivingLicense_SubSubMenu.Visible = false;
        }
        private void _HideSubMenus()
        {
            if (panelNewDrivingLicense_SubSubMenu.Visible == true)
                panelNewDrivingLicense_SubSubMenu.Visible = false;

            if (panelDrivingLicensesServices_SubMenu.Visible == true)
                panelDrivingLicensesServices_SubMenu.Visible = false;

            if (panelManageApplication_SubMenu.Visible == true)
                panelManageApplication_SubMenu.Visible = false;



        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (panelDrivingLicensesServices_SubMenu == subMenu)
            {

                if (panelNewDrivingLicense_SubSubMenu.Visible == true)
                    panelNewDrivingLicense_SubSubMenu.Visible = false;

                panelDrivingLicensesServices_SubMenu.Height = 260;

                if (subMenu.Visible == false)
                {
                    _HideSubMenus();
                    subMenu.Visible = true;
                }
                else
                    subMenu.Visible = false;

                return;
            }

            if (subMenu == panelNewDrivingLicense_SubSubMenu)
            {
                if (subMenu.Visible == false)
                {
                    panelDrivingLicensesServices_SubMenu.Height = 338;
                    subMenu.Visible = true;
                }
                else
                {
                    panelDrivingLicensesServices_SubMenu.Height = 260;
                    subMenu.Visible = false;
                }

                return;
            }

            if (subMenu.Visible == false)
            {
                _HideSubMenus();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        
        
        //Main Buttons
        private void btnMainLogo_Click(object sender, EventArgs e)
        {
            _HideSubMenus();
            _LoadForm(new frmDashboard());
        }
        private void btnDrivingLicensesServices_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelDrivingLicensesServices_SubMenu);
        }
        private void btnManageApplication_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelManageApplication_SubMenu);
        }
        

        Form Prevfrm = null;
        private void btnManageApplicationTypes_Click(object sender, EventArgs e)
        {
            _LoadForm (new frmListApplicationTypes());
        }
        private void btnManageTestTypes_Click(object sender, EventArgs e)
        {
            _LoadForm(new frmListTestTypes());
        }
        private void btnPeople_Click(object sender, EventArgs e)
        {
            _HideSubMenus();
            _LoadForm(new frmManagePeople());
            lblFormTitle.Text = "Manage People";
            pbFormImageTitle.Image = Resources.People_64;
        }
        private void btnDrivers_Click(object sender, EventArgs e)
        {
            _HideSubMenus();
            _LoadForm(new frmListDrivers());
            lblFormTitle.Text = "Manage Drivers";
            pbFormImageTitle.Image = Resources.Drivers_64;
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            _HideSubMenus();
            _LoadForm(new frmManageUser());
            lblFormTitle.Text = "Manage Users";
            pbFormImageTitle.Image = Resources.Users_2_400;
        }
        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet.");
        }
        private void btnProfileArrow_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show();
        }

        //...
        //Sub Buttons
        
        //Driving Licenses Services
        private void btnNewDrivingLicense_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelNewDrivingLicense_SubSubMenu);
        }
        private void btnLocalLicense_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicesnseApplication frm = new frmAddUpdateLocalDrivingLicesnseApplication();
            frm.ShowDialog();
        }
        private void btnInternationalLicense_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicenseApplication frm = new frmNewInternationalLicenseApplication();
            frm.ShowDialog();
        }
        private void btnRenewDrivingLicense_Click(object sender, EventArgs e)
        {
            frmRenewLocalDrivingLicenseApplication frm = new frmRenewLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }
        private void btnRepalcementLostOrDamagedLicense_Click(object sender, EventArgs e)
        {
            frmReplaceLostOrDamagedLicense frm = new frmReplaceLostOrDamagedLicense();
            frm.ShowDialog();
        }
        private void btnReleaseDetainedDrivingLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicenseApplication frm = new frmReleaseDetainedLicenseApplication();
            frm.ShowDialog();
        }
        private void btnRetakeTest_Click(object sender, EventArgs e)
        {
            _LoadForm(new frmListLocalDrivingLicesnseApplications());
        }
        
        //Manage Applications
        private void btnLocalLicenseApplications_Click(object sender, EventArgs e)
        {
            _LoadForm(new frmListLocalDrivingLicesnseApplications());
        }
        private void btnInternatonalicenseApplications_Click(object sender, EventArgs e)
        {
            _LoadForm(new frmListInternationalLicenseApplication());
        }
        
        //Detain Licenses
        private void btnManageDetainedLicenses_Click(object sender, EventArgs e)
        {
            _LoadForm(new frmListDetainedLicenses());
        }
        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicenseApplication frm = new frmDetainLicenseApplication();
            frm.ShowDialog();
        }
        private void btnReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicenseApplication frm = new frmReleaseDetainedLicenseApplication();
            frm.ShowDialog();
        }
        
        //Profile
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _CloseAllApplication = false;
            this.Close();
        }
        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserInfo frm = new frmShowUserInfo(clsGlobal.CurrentUser.UserID);
            frm.Show();
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }
        private void frmMainForm_Load(object sender, EventArgs e)
        {
            pbCurrentUserImage.ImageLocation = clsGlobal.CurrentUser.PersonInfo.ImagePath;
            lblUserName.Text = clsGlobal.CurrentUser.Username;
            lblUserRole.Text = clsGlobal.CurrentUser.RoleInfo.RoleName;
        }
        private void pbCurrentUserImage_Click(object sender, EventArgs e)
        {
            frmShowUserInfo frm = new frmShowUserInfo(clsGlobal.CurrentUser.UserID);
            frm.Show();
        }


        
    }
}
