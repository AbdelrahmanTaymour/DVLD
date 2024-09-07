namespace DVLD.Applications.ApplicationTypes
{
    partial class frmListApplicationTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListApplicationTypes));
            this.panelManageUsers = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.dgvApplicationTypes = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditAPPltoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRecordsNo = new Bunifu.UI.WinForms.BunifuLabel();
            this.panelManageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).BeginInit();
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
            this.panelManageUsers.Controls.Add(this.dgvApplicationTypes);
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
            this.panelManageUsers.Size = new System.Drawing.Size(1229, 898);
            this.panelManageUsers.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.panelManageUsers.TabIndex = 3;
            this.panelManageUsers.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panelManageUsers_ControlAdded);
            // 
            // dgvApplicationTypes
            // 
            this.dgvApplicationTypes.AllowCustomTheming = false;
            this.dgvApplicationTypes.AllowUserToAddRows = false;
            this.dgvApplicationTypes.AllowUserToDeleteRows = false;
            this.dgvApplicationTypes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvApplicationTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApplicationTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApplicationTypes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvApplicationTypes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvApplicationTypes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvApplicationTypes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplicationTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvApplicationTypes.ColumnHeadersHeight = 40;
            this.dgvApplicationTypes.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvApplicationTypes.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvApplicationTypes.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvApplicationTypes.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvApplicationTypes.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvApplicationTypes.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvApplicationTypes.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvApplicationTypes.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvApplicationTypes.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvApplicationTypes.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvApplicationTypes.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvApplicationTypes.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvApplicationTypes.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvApplicationTypes.CurrentTheme.Name = null;
            this.dgvApplicationTypes.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvApplicationTypes.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvApplicationTypes.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvApplicationTypes.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvApplicationTypes.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvApplicationTypes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvApplicationTypes.EnableHeadersVisualStyles = false;
            this.dgvApplicationTypes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvApplicationTypes.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvApplicationTypes.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvApplicationTypes.HeaderForeColor = System.Drawing.Color.White;
            this.dgvApplicationTypes.Location = new System.Drawing.Point(39, 316);
            this.dgvApplicationTypes.Name = "dgvApplicationTypes";
            this.dgvApplicationTypes.ReadOnly = true;
            this.dgvApplicationTypes.RowHeadersVisible = false;
            this.dgvApplicationTypes.RowTemplate.Height = 40;
            this.dgvApplicationTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplicationTypes.Size = new System.Drawing.Size(1159, 495);
            this.dgvApplicationTypes.TabIndex = 11;
            this.dgvApplicationTypes.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvApplicationTypes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApplicationTypes_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditAPPltoolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(252, 42);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // EditAPPltoolStripMenuItem
            // 
            this.EditAPPltoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.EditAPPltoolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_321;
            this.EditAPPltoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditAPPltoolStripMenuItem.Name = "EditAPPltoolStripMenuItem";
            this.EditAPPltoolStripMenuItem.Size = new System.Drawing.Size(251, 38);
            this.EditAPPltoolStripMenuItem.Text = "Edit Application Type";
            this.EditAPPltoolStripMenuItem.Click += new System.EventHandler(this.EditAPPltoolStripMenuItem_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(478, 210);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(288, 32);
            this.bunifuLabel1.TabIndex = 3;
            this.bunifuLabel1.Text = "Manage Application Types";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel1.Click += new System.EventHandler(this.bunifuLabel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Application_Types_512;
            this.pictureBox1.Location = new System.Drawing.Point(512, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblRecordsNo
            // 
            this.lblRecordsNo.AllowParentOverrides = false;
            this.lblRecordsNo.AutoEllipsis = false;
            this.lblRecordsNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRecordsNo.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblRecordsNo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecordsNo.Location = new System.Drawing.Point(52, 826);
            this.lblRecordsNo.Name = "lblRecordsNo";
            this.lblRecordsNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRecordsNo.Size = new System.Drawing.Size(48, 21);
            this.lblRecordsNo.TabIndex = 1;
            this.lblRecordsNo.Text = "# ?????";
            this.lblRecordsNo.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblRecordsNo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblRecordsNo.Click += new System.EventHandler(this.lblRecordsNo_Click);
            // 
            // frmListApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1229, 898);
            this.Controls.Add(this.panelManageUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListApplicationTypes";
            this.Text = "List Application Types";
            this.Load += new System.EventHandler(this.frmListApplicationTypes_Load);
            this.panelManageUsers.ResumeLayout(false);
            this.panelManageUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuShadowPanel panelManageUsers;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvApplicationTypes;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel lblRecordsNo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EditAPPltoolStripMenuItem;
    }
}