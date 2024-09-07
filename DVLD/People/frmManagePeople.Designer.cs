namespace DVLD.People
{
    partial class frmManagePeople
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagePeople));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties33 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties34 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties35 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties36 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panelManagePeople = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.dgvPeopleList = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowDetailstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewPersontoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EdittoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SendEmailtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhoneCalltoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFilterValue = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.cbFilterBy = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRecordsNo = new Bunifu.UI.WinForms.BunifuLabel();
            this.panelManagePeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelManagePeople
            // 
            this.panelManagePeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelManagePeople.AutoScroll = true;
            this.panelManagePeople.BackColor = System.Drawing.Color.Transparent;
            this.panelManagePeople.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.panelManagePeople.BorderRadius = 60;
            this.panelManagePeople.BorderThickness = 10;
            this.panelManagePeople.Controls.Add(this.dgvPeopleList);
            this.panelManagePeople.Controls.Add(this.txtFilterValue);
            this.panelManagePeople.Controls.Add(this.btnAddNewPerson);
            this.panelManagePeople.Controls.Add(this.bunifuLabel2);
            this.panelManagePeople.Controls.Add(this.cbFilterBy);
            this.panelManagePeople.Controls.Add(this.bunifuLabel1);
            this.panelManagePeople.Controls.Add(this.pictureBox1);
            this.panelManagePeople.Controls.Add(this.lblRecordsNo);
            this.panelManagePeople.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.panelManagePeople.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.panelManagePeople.Location = new System.Drawing.Point(0, 0);
            this.panelManagePeople.MaximumSize = new System.Drawing.Size(1261, 976);
            this.panelManagePeople.Name = "panelManagePeople";
            this.panelManagePeople.PanelColor = System.Drawing.Color.White;
            this.panelManagePeople.PanelColor2 = System.Drawing.Color.White;
            this.panelManagePeople.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.panelManagePeople.ShadowDept = 2;
            this.panelManagePeople.ShadowDepth = 0;
            this.panelManagePeople.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.ForwardDiagonal;
            this.panelManagePeople.ShadowTopLeftVisible = false;
            this.panelManagePeople.Size = new System.Drawing.Size(1261, 965);
            this.panelManagePeople.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.panelManagePeople.TabIndex = 1;
            // 
            // dgvPeopleList
            // 
            this.dgvPeopleList.AllowCustomTheming = false;
            this.dgvPeopleList.AllowUserToAddRows = false;
            this.dgvPeopleList.AllowUserToDeleteRows = false;
            this.dgvPeopleList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvPeopleList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPeopleList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeopleList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPeopleList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPeopleList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPeopleList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeopleList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPeopleList.ColumnHeadersHeight = 40;
            this.dgvPeopleList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPeopleList.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvPeopleList.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvPeopleList.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPeopleList.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvPeopleList.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPeopleList.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvPeopleList.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvPeopleList.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvPeopleList.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvPeopleList.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPeopleList.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvPeopleList.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPeopleList.CurrentTheme.Name = null;
            this.dgvPeopleList.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPeopleList.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvPeopleList.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPeopleList.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvPeopleList.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPeopleList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPeopleList.EnableHeadersVisualStyles = false;
            this.dgvPeopleList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvPeopleList.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvPeopleList.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvPeopleList.HeaderForeColor = System.Drawing.Color.White;
            this.dgvPeopleList.Location = new System.Drawing.Point(43, 376);
            this.dgvPeopleList.Name = "dgvPeopleList";
            this.dgvPeopleList.ReadOnly = true;
            this.dgvPeopleList.RowHeadersVisible = false;
            this.dgvPeopleList.RowTemplate.Height = 40;
            this.dgvPeopleList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeopleList.Size = new System.Drawing.Size(1159, 495);
            this.dgvPeopleList.TabIndex = 11;
            this.dgvPeopleList.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowDetailstoolStripMenuItem,
            this.AddNewPersontoolStripMenuItem,
            this.EdittoolStripMenuItem,
            this.DeletetoolStripMenuItem,
            this.toolStripSeparator1,
            this.SendEmailtoolStripMenuItem,
            this.PhoneCalltoolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(218, 238);
            // 
            // ShowDetailstoolStripMenuItem
            // 
            this.ShowDetailstoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ShowDetailstoolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_321;
            this.ShowDetailstoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowDetailstoolStripMenuItem.Name = "ShowDetailstoolStripMenuItem";
            this.ShowDetailstoolStripMenuItem.Size = new System.Drawing.Size(217, 38);
            this.ShowDetailstoolStripMenuItem.Text = "Show Details";
            this.ShowDetailstoolStripMenuItem.Click += new System.EventHandler(this.ShowDetailstoolStripMenuItem_Click);
            // 
            // AddNewPersontoolStripMenuItem
            // 
            this.AddNewPersontoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.AddNewPersontoolStripMenuItem.Image = global::DVLD.Properties.Resources.AddPerson_32;
            this.AddNewPersontoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddNewPersontoolStripMenuItem.Name = "AddNewPersontoolStripMenuItem";
            this.AddNewPersontoolStripMenuItem.Size = new System.Drawing.Size(217, 38);
            this.AddNewPersontoolStripMenuItem.Text = "Add New Person";
            this.AddNewPersontoolStripMenuItem.Click += new System.EventHandler(this.AddNewPersontoolStripMenuItem_Click);
            // 
            // EdittoolStripMenuItem
            // 
            this.EdittoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.EdittoolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_32;
            this.EdittoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EdittoolStripMenuItem.Name = "EdittoolStripMenuItem";
            this.EdittoolStripMenuItem.Size = new System.Drawing.Size(217, 38);
            this.EdittoolStripMenuItem.Text = "Edit";
            this.EdittoolStripMenuItem.Click += new System.EventHandler(this.EdittoolStripMenuItem_Click);
            // 
            // DeletetoolStripMenuItem
            // 
            this.DeletetoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.DeletetoolStripMenuItem.Image = global::DVLD.Properties.Resources.Delete_32;
            this.DeletetoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeletetoolStripMenuItem.Name = "DeletetoolStripMenuItem";
            this.DeletetoolStripMenuItem.Size = new System.Drawing.Size(217, 38);
            this.DeletetoolStripMenuItem.Text = "Delete";
            this.DeletetoolStripMenuItem.Click += new System.EventHandler(this.DeletetoolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(214, 6);
            // 
            // SendEmailtoolStripMenuItem
            // 
            this.SendEmailtoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.SendEmailtoolStripMenuItem.Image = global::DVLD.Properties.Resources.send_email_32;
            this.SendEmailtoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SendEmailtoolStripMenuItem.Name = "SendEmailtoolStripMenuItem";
            this.SendEmailtoolStripMenuItem.Size = new System.Drawing.Size(217, 38);
            this.SendEmailtoolStripMenuItem.Text = "Send Email";
            this.SendEmailtoolStripMenuItem.Click += new System.EventHandler(this.SendEmailtoolStripMenuItem_Click);
            // 
            // PhoneCalltoolStripMenuItem
            // 
            this.PhoneCalltoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.PhoneCalltoolStripMenuItem.Image = global::DVLD.Properties.Resources.call_32;
            this.PhoneCalltoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PhoneCalltoolStripMenuItem.Name = "PhoneCalltoolStripMenuItem";
            this.PhoneCalltoolStripMenuItem.Size = new System.Drawing.Size(217, 38);
            this.PhoneCalltoolStripMenuItem.Text = "Phone Call";
            this.PhoneCalltoolStripMenuItem.Click += new System.EventHandler(this.PhoneCalltoolStripMenuItem_Click);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.AcceptsReturn = false;
            this.txtFilterValue.AcceptsTab = false;
            this.txtFilterValue.AnimationSpeed = 200;
            this.txtFilterValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFilterValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFilterValue.BackColor = System.Drawing.Color.Transparent;
            this.txtFilterValue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFilterValue.BackgroundImage")));
            this.txtFilterValue.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtFilterValue.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtFilterValue.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtFilterValue.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtFilterValue.BorderRadius = 1;
            this.txtFilterValue.BorderThickness = 1;
            this.txtFilterValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterValue.DefaultText = "";
            this.txtFilterValue.FillColor = System.Drawing.Color.White;
            this.txtFilterValue.HideSelection = true;
            this.txtFilterValue.IconLeft = null;
            this.txtFilterValue.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.IconPadding = 10;
            this.txtFilterValue.IconRight = null;
            this.txtFilterValue.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.Lines = new string[0];
            this.txtFilterValue.Location = new System.Drawing.Point(373, 333);
            this.txtFilterValue.MaxLength = 32767;
            this.txtFilterValue.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtFilterValue.Modified = false;
            this.txtFilterValue.Multiline = false;
            this.txtFilterValue.Name = "txtFilterValue";
            stateProperties33.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties33.FillColor = System.Drawing.Color.Empty;
            stateProperties33.ForeColor = System.Drawing.Color.Empty;
            stateProperties33.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterValue.OnActiveState = stateProperties33;
            stateProperties34.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties34.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties34.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtFilterValue.OnDisabledState = stateProperties34;
            stateProperties35.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties35.FillColor = System.Drawing.Color.Empty;
            stateProperties35.ForeColor = System.Drawing.Color.Empty;
            stateProperties35.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterValue.OnHoverState = stateProperties35;
            stateProperties36.BorderColor = System.Drawing.Color.Silver;
            stateProperties36.FillColor = System.Drawing.Color.White;
            stateProperties36.ForeColor = System.Drawing.Color.Empty;
            stateProperties36.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterValue.OnIdleState = stateProperties36;
            this.txtFilterValue.Padding = new System.Windows.Forms.Padding(3);
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFilterValue.PlaceholderText = "Enter text";
            this.txtFilterValue.ReadOnly = false;
            this.txtFilterValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.SelectionLength = 0;
            this.txtFilterValue.SelectionStart = 0;
            this.txtFilterValue.ShortcutsEnabled = true;
            this.txtFilterValue.Size = new System.Drawing.Size(199, 32);
            this.txtFilterValue.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtFilterValue.TabIndex = 10;
            this.txtFilterValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFilterValue.TextMarginBottom = 0;
            this.txtFilterValue.TextMarginLeft = 3;
            this.txtFilterValue.TextMarginTop = 0;
            this.txtFilterValue.TextPlaceholder = "Enter text";
            this.txtFilterValue.UseSystemPasswordChar = false;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.WordWrap = true;
            this.txtFilterValue.TextChange += new System.EventHandler(this.txtFilterValue_TextChange);
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.BackColor = System.Drawing.Color.White;
            this.btnAddNewPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewPerson.Image = global::DVLD.Properties.Resources.Add_Person_40;
            this.btnAddNewPerson.Location = new System.Drawing.Point(1104, 318);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(89, 47);
            this.btnAddNewPerson.TabIndex = 7;
            this.btnAddNewPerson.UseVisualStyleBackColor = false;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            this.bunifuLabel2.Location = new System.Drawing.Point(55, 337);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(78, 25);
            this.bunifuLabel2.TabIndex = 5;
            this.bunifuLabel2.Text = "Filter By:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterBy.BackgroundColor = System.Drawing.Color.White;
            this.cbFilterBy.BorderColor = System.Drawing.Color.Silver;
            this.cbFilterBy.BorderRadius = 1;
            this.cbFilterBy.Color = System.Drawing.Color.Silver;
            this.cbFilterBy.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbFilterBy.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbFilterBy.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbFilterBy.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbFilterBy.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbFilterBy.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterBy.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbFilterBy.FillDropDown = true;
            this.cbFilterBy.FillIndicator = false;
            this.cbFilterBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.ForeColor = System.Drawing.Color.Black;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Icon = null;
            this.cbFilterBy.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbFilterBy.IndicatorColor = System.Drawing.Color.Gray;
            this.cbFilterBy.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbFilterBy.ItemBackColor = System.Drawing.Color.White;
            this.cbFilterBy.ItemBorderColor = System.Drawing.Color.White;
            this.cbFilterBy.ItemForeColor = System.Drawing.Color.Black;
            this.cbFilterBy.ItemHeight = 26;
            this.cbFilterBy.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cbFilterBy.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No.",
            "First Name",
            "Last Name",
            "Gendor",
            "Nationality",
            "Phone",
            "Email"});
            this.cbFilterBy.ItemTopMargin = 3;
            this.cbFilterBy.Location = new System.Drawing.Point(152, 333);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(185, 32);
            this.cbFilterBy.TabIndex = 4;
            this.cbFilterBy.Text = null;
            this.cbFilterBy.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbFilterBy.TextLeftMargin = 5;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(551, 210);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(170, 32);
            this.bunifuLabel1.TabIndex = 3;
            this.bunifuLabel1.Text = "Manage People";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(526, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblRecordsNo
            // 
            this.lblRecordsNo.AllowParentOverrides = false;
            this.lblRecordsNo.AutoEllipsis = false;
            this.lblRecordsNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRecordsNo.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblRecordsNo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecordsNo.Location = new System.Drawing.Point(55, 877);
            this.lblRecordsNo.Name = "lblRecordsNo";
            this.lblRecordsNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRecordsNo.Size = new System.Drawing.Size(48, 21);
            this.lblRecordsNo.TabIndex = 1;
            this.lblRecordsNo.Text = "# ?????";
            this.lblRecordsNo.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblRecordsNo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1245, 937);
            this.Controls.Add(this.panelManagePeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManagePeople";
            this.Text = "frmManagePeople";
            this.Load += new System.EventHandler(this.frmManagePeople_Load);
            this.panelManagePeople.ResumeLayout(false);
            this.panelManagePeople.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuShadowPanel panelManagePeople;
        private Bunifu.UI.WinForms.BunifuLabel lblRecordsNo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuDropdown cbFilterBy;
        private System.Windows.Forms.Button btnAddNewPerson;
        private Bunifu.UI.WinForms.BunifuTextBox txtFilterValue;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShowDetailstoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewPersontoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EdittoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeletetoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SendEmailtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PhoneCalltoolStripMenuItem;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvPeopleList;
    }
}