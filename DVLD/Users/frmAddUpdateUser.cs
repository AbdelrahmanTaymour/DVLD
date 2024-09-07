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

namespace DVLD.Users
{
    public partial class frmAddUpdateUser : Form
    {
        enum enMode { AddNew=0, Update=1};
        enMode _Mode = enMode.AddNew;
        int _UserID;
        clsUser _User;
        public frmAddUpdateUser()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }
        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
            _Mode = enMode.Update;

        }

        void _ResetDefaultValue()
        {
            if(_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
                this.Text = "Add New User";

                _User = new clsUser();
                
                tpLoginInfo.Enabled = false;
                tpPermissions.Enabled = false;
                ctrlPersonCardWithFilter1.Focus();
            }
            else
            {
                lblTitle.Text = "Update User";
                this.Text = "Update User";

                ctrlPersonCardWithFilter1.FilterEnabled = false;
                tpLoginInfo.Enabled = true;
                tpPermissions.Enabled = true;
                btnSave.Enabled = true;
            }

            cbRole.SelectedIndex = cbRole.FindString("License Officer");

            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            chkIsActive.Checked = true;
        }
        void _LoadUserInfo()
        {
            _User = clsUser.FindByUserID(_UserID);

            if(_User == null)
            {
                MessageBox.Show("No User with ID = " + _UserID, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            
            ctrlPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);
            lblUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.Username;

            cbRole.SelectedIndex = cbRole.FindString(_User.RoleInfo.RoleName);
            
            chkIsActive.Checked = (_User.IsActive);
            

        }
        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();

            if (_Mode == enMode.Update)
                _LoadUserInfo();
        }

        private void btnPersonInfoNext_Click(object sender, EventArgs e)
        {
            if(_Mode == enMode.Update)
            {
                tpPermissions.Enabled = true;
                btnSave.Enabled = true;
                tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpPermissions"];
                return;
            }

            if(ctrlPersonCardWithFilter1.PersonID != -1)
            {
                if(!clsUser.IsUserExistForPersonID(ctrlPersonCardWithFilter1.PersonID))
                {
                    //btnSave.Enabled = true;
                    tpPermissions.Enabled = true;
                    tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpPermissions"];
                    
                }
                else
                {
                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardWithFilter1.FilterFocus();
                }
            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.Focus();
            }
        }
        private void btnPermissionsNext_Click(object sender, EventArgs e)
        {
            tpLoginInfo.Enabled = true;
            btnSave.Enabled = true;
            tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpLoginInfo"];
            txtUserName.Focus();
        }

        private void frmAddUpdateUser_Activated(object sender, EventArgs e)
        {
            //ctrlPersonCardWithFilter1.FilterFocus();
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "Username cannot be blank");
                return;
            }
            else
                errorProvider1.SetError(txtUserName, null);

            if(_Mode == enMode.AddNew)
            {
                if(clsUser.IsUserExist(txtUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUserName, "username is used by another user");
                    return;
                }
                else
                    errorProvider1.SetError(txtUserName, null);
            }
            else
            {
                if(_User.Username != txtUserName.Text.Trim() && clsUser.IsUserExist(txtUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUserName, "username is used by another user");
                    return;
                }
                else
                    errorProvider1.SetError(txtUserName, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password cannot be blank");
                return;
            }
            else
                errorProvider1.SetError(txtPassword, null);
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Confirm Password cannot be blank");
                return;
            }
            else
                errorProvider1.SetError(txtConfirmPassword, null);

            if(txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match New Password!");
                return;
            }
            else
                errorProvider1.SetError(txtConfirmPassword, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                   "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            short? RoleID = clsRole.Find(cbRole.Text).RoleID;

            _User.PersonID = ctrlPersonCardWithFilter1.PersonID;
            _User.Role = (clsUser.enRole)RoleID;
            _User.Username = txtUserName.Text.Trim();
            _User.Password = txtPassword.Text.Trim();
            _User.IsActive = (chkIsActive.Checked);

            if(_User.Save())
            {
                _UserID = _User.UserID;
                _Mode = enMode.Update;

                lblTitle.Text = "Update User";
                this.Text = "Update User";
                lblUserID.Text = _User.UserID.ToString();
                ctrlPersonCardWithFilter1.FilterEnabled = false;

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
