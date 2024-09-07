using DVLD.Globle_Classes;
using DVLD.Properties;
using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Bunifu.UI.WinForms;

namespace DVLD.People
{
    public partial class frmAddUpdatePersonInfo : Form
    {
        public delegate void BackHandler(object sender, int PersonID);
        public event BackHandler DataBack;

        public enum enMode { AddNew = 0, Update=1}
        public enum enGendor { Male = 0, Female=1}
        public enMode Mode = enMode.AddNew;

        clsPerson _Person;
        int _PersonID;

        public frmAddUpdatePersonInfo()
        {
            InitializeComponent();

            Mode = enMode.AddNew;
        }
        public frmAddUpdatePersonInfo(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            Mode = enMode.Update;
        }

        void _FillCountries()
        {
            DataTable dataTable = clsCountry.GetAllCountries();

            foreach (DataRow row in dataTable.Rows)
            {
                cbCountries.Items.Add(row["CountryName"]);
            }
        }
        void _ResetDefualtValues()
        {
            _FillCountries();
            
            if (Mode == enMode.AddNew)
            {
                lblTitle.Text = this.Text = "Add New Person";
                _Person = new clsPerson();
            }
            else
                lblTitle.Text = this.Text = "Update Person";

            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = ""; 
            txtLastName.Text = "";
            rbMale.Checked = true;
            txtNationalNo.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";

            lblRemoveImage.Visible = (pbPersonImage.ImageLocation != null);
            cbCountries.SelectedIndex = cbCountries.FindString("Egypt");

            DateTime now = DateTime.Now;
            dpDateOfBirth.MaxDate = now.AddYears(-18);
            dpDateOfBirth.MinDate = now.AddYears(-100);
            dpDateOfBirth.Value = dpDateOfBirth.MaxDate;


            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Male_256;
            else
                pbPersonImage.Image = Resources.Female_256;


        }
        bool _HandlePersonImage()
        {


            if (_Person.ImagePath != pbPersonImage.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {

                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException iox)
                    {
                        clsGlobal.SaveToEventLog($"IOException: {iox.Message}");
                    }
                }

                if (pbPersonImage.ImageLocation != null)
                {

                    string SourceImageFile = pbPersonImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbPersonImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }
        void _LoadPersonData()
        {
            _Person = clsPerson.Find(_PersonID);

            if(_Person==null)
            {
                MessageBox.Show("No Person with ID = " + _PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblPersonID.Text = _PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            txtPhone.Text = _Person.Phone;
            txtAddress.Text = _Person.Address;
            txtEmail.Text = _Person.Email;
            dpDateOfBirth.Value = _Person.DateOfBirth;

            if (_Person.Gendor == (byte)enGendor.Male)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            cbCountries.SelectedIndex = cbCountries.FindString(_Person.CountryInfo.CountryName);

            if (_Person.ImagePath != "")
                pbPersonImage.ImageLocation = _Person.ImagePath;

            lblRemoveImage.Visible = (_Person.ImagePath != "");
        }
        private void frmAddUpdatePersonInfo_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (Mode == enMode.Update)
                _LoadPersonData();
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            try
            {
                BunifuTextBox txtBox = ((BunifuTextBox)sender);

                if (string.IsNullOrEmpty(txtBox.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtBox, "This field is required!");
                }
                else
                {
                    errorProvider1.SetError(txtBox, null);
                }
            }
            catch (Exception ex) 
            {
                clsGlobal.SaveToEventLog($"Unexpected Error: {ex.Message}");
            }
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, null);
            }

            if(txtNationalNo.Text.Trim() != _Person.NationalNo && clsPerson.IsPersonExist(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "This National No. is used for another person");
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, null);
            }
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
                return;

            if (!clsValidatoin.IsValidEmail(txtEmail.Text))
            {

                errorProvider1.SetError(txtEmail, "This Email is not valid");
                
            }
            else
                errorProvider1.SetError(txtEmail, null);
        }
        
        private void rbMale_Click(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Male_256;
        }
        private void rbFemale_Click(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Female_256;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!_HandlePersonImage())
            {
                return;
            }

            short NationalityCountryID = clsCountry.Find(cbCountries.Text).CountryID;

            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim();
            _Person.ThirdName = txtThirdName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.NationalNo = txtNationalNo.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();
            _Person.DateOfBirth = dpDateOfBirth.Value;

            _Person.NationalityCountryID = NationalityCountryID;

            if (rbMale.Checked)
                _Person.Gendor = (byte)enGendor.Male;
            else
                _Person.Gendor = (byte)enGendor.Female;


            if (pbPersonImage.ImageLocation != null)
                _Person.ImagePath = pbPersonImage.ImageLocation;
            else
                _Person.ImagePath = "";

            if(_Person.Save())
            {
                Mode = enMode.Update;
                lblTitle.Text = "Update Person";
                lblPersonID.Text = _Person.PersonID.ToString();

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataBack?.Invoke(this, _Person.PersonID);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            

        }
        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string FilePath = openFileDialog1.FileName;
                pbPersonImage.Load(FilePath);
                lblRemoveImage.Visible = true;
            }
        }
        private void lblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;

            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Male_256;
            else
                pbPersonImage.Image = Resources.Male_256;

            lblRemoveImage.Visible = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
