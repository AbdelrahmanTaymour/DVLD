using DVLD.Globle_Classes;
using DVLD.RUser;
using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD_Buisness.clsUser;

namespace DVLD.Login
{
    public partial class frmLogin : Form
    {
        string _Key = clsGlobal.Key;
        int _FieldLoginTrials;
        Dictionary<clsUser.enRole, Func<Form>> _formMapping;
        public frmLogin()
        {
            InitializeComponent();
            _FieldLoginTrials = 0;

            _formMapping = new Dictionary<clsUser.enRole, Func<Form>>
            {
                {enRole.Administrator, () => new frmMainForm()},
                {enRole.GeneralUser, () => new frmRUserHome()}
            };
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                
                errorProvider1.SetError(txtUserName, "Username cannot be blank!");
                return;
            }
            else
                errorProvider1.SetError(txtUserName, null);
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {

                errorProvider1.SetError(txtPassword, "Password cannot be blank!");
                return;
            }
            else
                errorProvider1.SetError(txtPassword, null);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some Fields are required!");
                return;
            }

            clsUser _User = clsUser.FindByUsernameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());

            if (_User != null)
            {
                if(chkRememberMe.Checked)
                    clsGlobal.SaveLoginCredentials(_User.Username, clsUtil.Encrypt(txtPassword.Text.Trim(), _Key));
                else
                    clsGlobal.SaveLoginCredentials("", "");

                if (!_User.IsActive)
                {
                    txtUserName.Focus();
                    MessageBox.Show("Your account is not active, Please contact your admin!");
                    return;
                }

                clsGlobal.CurrentUser = _User;
                this.Hide();
                _OpenMainForm(_User);
            }
            else
            {
                txtUserName.Focus();
                _FieldLoginTrials++;

                if (_FieldLoginTrials >= 3)
                {
                    clsGlobal.SaveToEventLog($"{_FieldLoginTrials} Field Login Trials!", EventLogEntryType.Warning);
                }

                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string Username = "", Password = "";
            if (clsGlobal.GetLoginCredentials(out Username, out Password))
            {
                txtUserName.Text = Username;
                txtPassword.Text = clsUtil.Decrypt(Password, _Key);
                chkRememberMe.Checked = true;
            }
            else
                chkRememberMe.Checked = false;
        }

        private void _OpenMainForm(clsUser user)
        {
            Form frm = _formMapping[user.Role]();

            // Handle Apllicathion Closing Event
            if(frm is frmMainForm AdminFormHome)
            {
                AdminFormHome.ApplicationClose += _HandleApplcaitionClosing;
            }
            if (frm is frmRUserHome GeneralUserHome)
            {
                GeneralUserHome.ApplicationClose += _HandleApplcaitionClosing;
            }


            frm.ShowDialog();
        }
        private void _HandleApplcaitionClosing(bool CloseAllApplication)
        {
            if (CloseAllApplication) 
                this.Close();
            else 
                this.Show();
        }
    }
}
