namespace DVLD.Tests.Questions
{
    partial class frmAddUpdateQuestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbLicenseClass = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnTestType = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtQuestionText = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOptionA = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOptionB = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOptionC = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOptionD = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtModelAnswer = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblQuetionText = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblOptionA = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblOptionB = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblOptionC = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblOptionD = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Image = global::DVLD.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1030, 790);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 37);
            this.btnSave.TabIndex = 128;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(888, 790);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 129;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1173, 55);
            this.lblTitle.TabIndex = 125;
            this.lblTitle.Text = "Add New Question";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbLicenseClass
            // 
            this.gbLicenseClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbLicenseClass.BackColor = System.Drawing.Color.Transparent;
            this.gbLicenseClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gbLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gbLicenseClass.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gbLicenseClass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gbLicenseClass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbLicenseClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gbLicenseClass.ItemHeight = 30;
            this.gbLicenseClass.Items.AddRange(new object[] {
            "gggg",
            "gggggg",
            "ggg",
            "ggggggg",
            "gggg"});
            this.gbLicenseClass.Location = new System.Drawing.Point(256, 79);
            this.gbLicenseClass.Name = "gbLicenseClass";
            this.gbLicenseClass.Size = new System.Drawing.Size(241, 36);
            this.gbLicenseClass.TabIndex = 0;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(816, 79);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(209, 36);
            this.guna2ComboBox1.TabIndex = 2;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.guna2GroupBox1.Controls.Add(this.btnTestType);
            this.guna2GroupBox1.Controls.Add(this.guna2ComboBox1);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GroupBox1.Controls.Add(this.gbLicenseClass);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(172)))));
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 55);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1173, 147);
            this.guna2GroupBox1.TabIndex = 126;
            this.guna2GroupBox1.Text = "Question Category";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(100, 86);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(101, 23);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "License Class";
            // 
            // btnTestType
            // 
            this.btnTestType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTestType.BackColor = System.Drawing.Color.Transparent;
            this.btnTestType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.btnTestType.Location = new System.Drawing.Point(686, 86);
            this.btnTestType.Name = "btnTestType";
            this.btnTestType.Size = new System.Drawing.Size(75, 23);
            this.btnTestType.TabIndex = 3;
            this.btnTestType.Text = "Test Type";
            // 
            // txtQuestionText
            // 
            this.txtQuestionText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuestionText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuestionText.DefaultText = "";
            this.txtQuestionText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuestionText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuestionText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuestionText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuestionText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuestionText.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtQuestionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.txtQuestionText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuestionText.Location = new System.Drawing.Point(256, 67);
            this.txtQuestionText.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuestionText.Name = "txtQuestionText";
            this.txtQuestionText.PasswordChar = '\0';
            this.txtQuestionText.PlaceholderText = "";
            this.txtQuestionText.SelectedText = "";
            this.txtQuestionText.Size = new System.Drawing.Size(769, 50);
            this.txtQuestionText.TabIndex = 3;
            // 
            // txtOptionA
            // 
            this.txtOptionA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOptionA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOptionA.DefaultText = "";
            this.txtOptionA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOptionA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOptionA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOptionA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOptionA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOptionA.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtOptionA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.txtOptionA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOptionA.Location = new System.Drawing.Point(256, 157);
            this.txtOptionA.Margin = new System.Windows.Forms.Padding(4);
            this.txtOptionA.Name = "txtOptionA";
            this.txtOptionA.PasswordChar = '\0';
            this.txtOptionA.PlaceholderText = "";
            this.txtOptionA.SelectedText = "";
            this.txtOptionA.Size = new System.Drawing.Size(769, 50);
            this.txtOptionA.TabIndex = 5;
            // 
            // txtOptionB
            // 
            this.txtOptionB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOptionB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOptionB.DefaultText = "";
            this.txtOptionB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOptionB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOptionB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOptionB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOptionB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOptionB.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtOptionB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.txtOptionB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOptionB.Location = new System.Drawing.Point(256, 226);
            this.txtOptionB.Margin = new System.Windows.Forms.Padding(4);
            this.txtOptionB.Name = "txtOptionB";
            this.txtOptionB.PasswordChar = '\0';
            this.txtOptionB.PlaceholderText = "";
            this.txtOptionB.SelectedText = "";
            this.txtOptionB.Size = new System.Drawing.Size(769, 50);
            this.txtOptionB.TabIndex = 5;
            // 
            // txtOptionC
            // 
            this.txtOptionC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOptionC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOptionC.DefaultText = "";
            this.txtOptionC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOptionC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOptionC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOptionC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOptionC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOptionC.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtOptionC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.txtOptionC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOptionC.Location = new System.Drawing.Point(256, 292);
            this.txtOptionC.Margin = new System.Windows.Forms.Padding(4);
            this.txtOptionC.Name = "txtOptionC";
            this.txtOptionC.PasswordChar = '\0';
            this.txtOptionC.PlaceholderText = "";
            this.txtOptionC.SelectedText = "";
            this.txtOptionC.Size = new System.Drawing.Size(769, 50);
            this.txtOptionC.TabIndex = 5;
            // 
            // txtOptionD
            // 
            this.txtOptionD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOptionD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOptionD.DefaultText = "";
            this.txtOptionD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOptionD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOptionD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOptionD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOptionD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOptionD.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtOptionD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.txtOptionD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOptionD.Location = new System.Drawing.Point(256, 362);
            this.txtOptionD.Margin = new System.Windows.Forms.Padding(4);
            this.txtOptionD.Name = "txtOptionD";
            this.txtOptionD.PasswordChar = '\0';
            this.txtOptionD.PlaceholderText = "";
            this.txtOptionD.SelectedText = "";
            this.txtOptionD.Size = new System.Drawing.Size(769, 50);
            this.txtOptionD.TabIndex = 5;
            // 
            // txtModelAnswer
            // 
            this.txtModelAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModelAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModelAnswer.DefaultText = "";
            this.txtModelAnswer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtModelAnswer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtModelAnswer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtModelAnswer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtModelAnswer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtModelAnswer.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtModelAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.txtModelAnswer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtModelAnswer.Location = new System.Drawing.Point(256, 453);
            this.txtModelAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelAnswer.Name = "txtModelAnswer";
            this.txtModelAnswer.PasswordChar = '\0';
            this.txtModelAnswer.PlaceholderText = "";
            this.txtModelAnswer.SelectedText = "";
            this.txtModelAnswer.Size = new System.Drawing.Size(769, 50);
            this.txtModelAnswer.TabIndex = 7;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.guna2GroupBox2.Controls.Add(this.txtModelAnswer);
            this.guna2GroupBox2.Controls.Add(this.guna2HtmlLabel8);
            this.guna2GroupBox2.Controls.Add(this.txtOptionD);
            this.guna2GroupBox2.Controls.Add(this.lblOptionD);
            this.guna2GroupBox2.Controls.Add(this.txtOptionC);
            this.guna2GroupBox2.Controls.Add(this.lblOptionC);
            this.guna2GroupBox2.Controls.Add(this.txtOptionB);
            this.guna2GroupBox2.Controls.Add(this.lblOptionB);
            this.guna2GroupBox2.Controls.Add(this.txtOptionA);
            this.guna2GroupBox2.Controls.Add(this.lblOptionA);
            this.guna2GroupBox2.Controls.Add(this.txtQuestionText);
            this.guna2GroupBox2.Controls.Add(this.lblQuetionText);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(172)))));
            this.guna2GroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Location = new System.Drawing.Point(0, 202);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(1173, 537);
            this.guna2GroupBox2.TabIndex = 127;
            this.guna2GroupBox2.Text = "Question";
            // 
            // lblQuetionText
            // 
            this.lblQuetionText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuetionText.BackColor = System.Drawing.Color.Transparent;
            this.lblQuetionText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuetionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.lblQuetionText.Location = new System.Drawing.Point(100, 81);
            this.lblQuetionText.Name = "lblQuetionText";
            this.lblQuetionText.Size = new System.Drawing.Size(109, 23);
            this.lblQuetionText.TabIndex = 2;
            this.lblQuetionText.Text = "Question Text";
            // 
            // lblOptionA
            // 
            this.lblOptionA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOptionA.BackColor = System.Drawing.Color.Transparent;
            this.lblOptionA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptionA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.lblOptionA.Location = new System.Drawing.Point(100, 171);
            this.lblOptionA.Name = "lblOptionA";
            this.lblOptionA.Size = new System.Drawing.Size(71, 23);
            this.lblOptionA.TabIndex = 4;
            this.lblOptionA.Text = "Option A";
            // 
            // lblOptionB
            // 
            this.lblOptionB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOptionB.BackColor = System.Drawing.Color.Transparent;
            this.lblOptionB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptionB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.lblOptionB.Location = new System.Drawing.Point(100, 240);
            this.lblOptionB.Name = "lblOptionB";
            this.lblOptionB.Size = new System.Drawing.Size(70, 23);
            this.lblOptionB.TabIndex = 4;
            this.lblOptionB.Text = "Option B";
            // 
            // lblOptionC
            // 
            this.lblOptionC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOptionC.BackColor = System.Drawing.Color.Transparent;
            this.lblOptionC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptionC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.lblOptionC.Location = new System.Drawing.Point(100, 306);
            this.lblOptionC.Name = "lblOptionC";
            this.lblOptionC.Size = new System.Drawing.Size(70, 23);
            this.lblOptionC.TabIndex = 4;
            this.lblOptionC.Text = "Option C";
            // 
            // lblOptionD
            // 
            this.lblOptionD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOptionD.BackColor = System.Drawing.Color.Transparent;
            this.lblOptionD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptionD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.lblOptionD.Location = new System.Drawing.Point(100, 376);
            this.lblOptionD.Name = "lblOptionD";
            this.lblOptionD.Size = new System.Drawing.Size(72, 23);
            this.lblOptionD.TabIndex = 4;
            this.lblOptionD.Text = "Option D";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(100, 467);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(112, 23);
            this.guna2HtmlLabel8.TabIndex = 6;
            this.guna2HtmlLabel8.Text = "Model Answer";
            // 
            // frmAddUpdateQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1173, 841);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddUpdateQuestion";
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2ComboBox gbLicenseClass;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel btnTestType;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtQuestionText;
        private Guna.UI2.WinForms.Guna2TextBox txtOptionA;
        private Guna.UI2.WinForms.Guna2TextBox txtOptionB;
        private Guna.UI2.WinForms.Guna2TextBox txtOptionC;
        private Guna.UI2.WinForms.Guna2TextBox txtOptionD;
        private Guna.UI2.WinForms.Guna2TextBox txtModelAnswer;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOptionD;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOptionC;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOptionB;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOptionA;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQuetionText;
    }
}