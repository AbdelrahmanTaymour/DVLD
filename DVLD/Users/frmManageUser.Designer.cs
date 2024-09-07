namespace DVLD.Users
{
    partial class frmManageUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageUser));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panelManageUsers = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.cbIsActive = new Bunifu.UI.WinForms.BunifuDropdown();
            this.dgvUsers = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowDetailstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewPersontoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EdittoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CahngePasswordtoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SendEmailtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhoneCalltoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFilterValue = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.cbFilterBy = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRecordsNo = new Bunifu.UI.WinForms.BunifuLabel();
            this.panelManageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelManageUsers
            // 
            this.panelManageUsers.AutoScroll = true;
            this.panelManageUsers.BackColor = System.Drawing.Color.Transparent;
            this.panelManageUsers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.panelManageUsers.BorderRadius = 60;
            this.panelManageUsers.BorderThickness = 10;
            this.panelManageUsers.Controls.Add(this.cbIsActive);
            this.panelManageUsers.Controls.Add(this.dgvUsers);
            this.panelManageUsers.Controls.Add(this.txtFilterValue);
            this.panelManageUsers.Controls.Add(this.btnAddUser);
            this.panelManageUsers.Controls.Add(this.bunifuLabel2);
            this.panelManageUsers.Controls.Add(this.cbFilterBy);
            this.panelManageUsers.Controls.Add(this.bunifuLabel1);
            this.panelManageUsers.Controls.Add(this.pictureBox1);
            this.panelManageUsers.Controls.Add(this.lblRecordsNo);
            this.panelManageUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManageUsers.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.panelManageUsers.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.panelManageUsers.Location = new System.Drawing.Point(0, 0);
            this.panelManageUsers.MaximumSize = new System.Drawing.Size(1261, 976);
            this.panelManageUsers.Name = "panelManageUsers";
            this.panelManageUsers.PanelColor = System.Drawing.Color.White;
            this.panelManageUsers.PanelColor2 = System.Drawing.Color.White;
            this.panelManageUsers.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.panelManageUsers.ShadowDept = 2;
            this.panelManageUsers.ShadowDepth = 0;
            this.panelManageUsers.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.ForwardDiagonal;
            this.panelManageUsers.ShadowTopLeftVisible = false;
            this.panelManageUsers.Size = new System.Drawing.Size(1245, 937);
            this.panelManageUsers.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.panelManageUsers.TabIndex = 2;
            // 
            // cbIsActive
            // 
            this.cbIsActive.BackColor = System.Drawing.Color.Transparent;
            this.cbIsActive.BackgroundColor = System.Drawing.Color.White;
            this.cbIsActive.BorderColor = System.Drawing.Color.Silver;
            this.cbIsActive.BorderRadius = 1;
            this.cbIsActive.Color = System.Drawing.Color.Silver;
            this.cbIsActive.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbIsActive.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbIsActive.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbIsActive.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbIsActive.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbIsActive.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbIsActive.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbIsActive.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsActive.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbIsActive.FillDropDown = true;
            this.cbIsActive.FillIndicator = false;
            this.cbIsActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbIsActive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsActive.ForeColor = System.Drawing.Color.Black;
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.Icon = null;
            this.cbIsActive.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbIsActive.IndicatorColor = System.Drawing.Color.Gray;
            this.cbIsActive.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbIsActive.ItemBackColor = System.Drawing.Color.White;
            this.cbIsActive.ItemBorderColor = System.Drawing.Color.White;
            this.cbIsActive.ItemForeColor = System.Drawing.Color.Black;
            this.cbIsActive.ItemHeight = 26;
            this.cbIsActive.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cbIsActive.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsActive.ItemTopMargin = 3;
            this.cbIsActive.Location = new System.Drawing.Point(373, 331);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(114, 32);
            this.cbIsActive.TabIndex = 12;
            this.cbIsActive.Text = null;
            this.cbIsActive.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbIsActive.TextLeftMargin = 5;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowCustomTheming = false;
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.ColumnHeadersHeight = 40;
            this.dgvUsers.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvUsers.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvUsers.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvUsers.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvUsers.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvUsers.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUsers.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvUsers.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvUsers.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvUsers.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvUsers.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUsers.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvUsers.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUsers.CurrentTheme.Name = null;
            this.dgvUsers.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsers.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvUsers.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvUsers.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvUsers.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvUsers.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvUsers.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvUsers.HeaderForeColor = System.Drawing.Color.White;
            this.dgvUsers.Location = new System.Drawing.Point(43, 376);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowTemplate.Height = 40;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1159, 495);
            this.dgvUsers.TabIndex = 11;
            this.dgvUsers.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
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
            this.CahngePasswordtoolStripMenuItem1,
            this.toolStripSeparator1,
            this.SendEmailtoolStripMenuItem,
            this.PhoneCalltoolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(225, 276);
            // 
            // ShowDetailstoolStripMenuItem
            // 
            this.ShowDetailstoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ShowDetailstoolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_321;
            this.ShowDetailstoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowDetailstoolStripMenuItem.Name = "ShowDetailstoolStripMenuItem";
            this.ShowDetailstoolStripMenuItem.Size = new System.Drawing.Size(224, 38);
            this.ShowDetailstoolStripMenuItem.Text = "Show Details";
            this.ShowDetailstoolStripMenuItem.Click += new System.EventHandler(this.ShowDetailstoolStripMenuItem_Click);
            // 
            // AddNewPersontoolStripMenuItem
            // 
            this.AddNewPersontoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.AddNewPersontoolStripMenuItem.Image = global::DVLD.Properties.Resources.AddPerson_32;
            this.AddNewPersontoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddNewPersontoolStripMenuItem.Name = "AddNewPersontoolStripMenuItem";
            this.AddNewPersontoolStripMenuItem.Size = new System.Drawing.Size(224, 38);
            this.AddNewPersontoolStripMenuItem.Text = "Add New Person";
            this.AddNewPersontoolStripMenuItem.Click += new System.EventHandler(this.AddNewPersontoolStripMenuItem_Click);
            // 
            // EdittoolStripMenuItem
            // 
            this.EdittoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.EdittoolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_32;
            this.EdittoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EdittoolStripMenuItem.Name = "EdittoolStripMenuItem";
            this.EdittoolStripMenuItem.Size = new System.Drawing.Size(224, 38);
            this.EdittoolStripMenuItem.Text = "Edit";
            this.EdittoolStripMenuItem.Click += new System.EventHandler(this.EdittoolStripMenuItem_Click);
            // 
            // DeletetoolStripMenuItem
            // 
            this.DeletetoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.DeletetoolStripMenuItem.Image = global::DVLD.Properties.Resources.Delete_32;
            this.DeletetoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeletetoolStripMenuItem.Name = "DeletetoolStripMenuItem";
            this.DeletetoolStripMenuItem.Size = new System.Drawing.Size(224, 38);
            this.DeletetoolStripMenuItem.Text = "Delete";
            this.DeletetoolStripMenuItem.Click += new System.EventHandler(this.DeletetoolStripMenuItem_Click);
            // 
            // CahngePasswordtoolStripMenuItem1
            // 
            this.CahngePasswordtoolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.CahngePasswordtoolStripMenuItem1.Image = global::DVLD.Properties.Resources.Password_32;
            this.CahngePasswordtoolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CahngePasswordtoolStripMenuItem1.Name = "CahngePasswordtoolStripMenuItem1";
            this.CahngePasswordtoolStripMenuItem1.Size = new System.Drawing.Size(224, 38);
            this.CahngePasswordtoolStripMenuItem1.Text = "Change Password";
            this.CahngePasswordtoolStripMenuItem1.Click += new System.EventHandler(this.ChangePasswordtoolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // SendEmailtoolStripMenuItem
            // 
            this.SendEmailtoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.SendEmailtoolStripMenuItem.Image = global::DVLD.Properties.Resources.send_email_32;
            this.SendEmailtoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SendEmailtoolStripMenuItem.Name = "SendEmailtoolStripMenuItem";
            this.SendEmailtoolStripMenuItem.Size = new System.Drawing.Size(224, 38);
            this.SendEmailtoolStripMenuItem.Text = "Send Email";
            // 
            // PhoneCalltoolStripMenuItem
            // 
            this.PhoneCalltoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.PhoneCalltoolStripMenuItem.Image = global::DVLD.Properties.Resources.call_32;
            this.PhoneCalltoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PhoneCalltoolStripMenuItem.Name = "PhoneCalltoolStripMenuItem";
            this.PhoneCalltoolStripMenuItem.Size = new System.Drawing.Size(224, 38);
            this.PhoneCalltoolStripMenuItem.Text = "Phone Call";
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
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterValue.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtFilterValue.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterValue.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterValue.OnIdleState = stateProperties4;
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
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.White;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Image = global::DVLD.Properties.Resources.user_add_12818;
            this.btnAddUser.Location = new System.Drawing.Point(1104, 318);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(89, 47);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
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
            "User ID",
            "UserName",
            "Person ID",
            "Full Name",
            "Role",
            "Is Active"});
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
            this.bunifuLabel1.Size = new System.Drawing.Size(155, 32);
            this.bunifuLabel1.TabIndex = 3;
            this.bunifuLabel1.Text = "Manage Users";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Users_2_400;
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
            // frmManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1245, 937);
            this.Controls.Add(this.panelManageUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageUser";
            this.Text = "frmManageUser";
            this.Load += new System.EventHandler(this.frmManageUser_Load);
            this.panelManageUsers.ResumeLayout(false);
            this.panelManageUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuShadowPanel panelManageUsers;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvUsers;
        private Bunifu.UI.WinForms.BunifuTextBox txtFilterValue;
        private System.Windows.Forms.Button btnAddUser;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuDropdown cbFilterBy;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel lblRecordsNo;
        private Bunifu.UI.WinForms.BunifuDropdown cbIsActive;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShowDetailstoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewPersontoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EdittoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeletetoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SendEmailtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PhoneCalltoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CahngePasswordtoolStripMenuItem1;
    }
}