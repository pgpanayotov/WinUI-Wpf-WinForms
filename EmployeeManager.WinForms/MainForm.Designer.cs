namespace EmployeeManager.WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.headerControl1 = new EmployeeManager.WinForms.Controls.HeaderControl();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.lsbEmployees = new System.Windows.Forms.ListBox();
            this.pnlRefresh = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlMainArea = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.checkIsCoffeeDrinker = new System.Windows.Forms.CheckBox();
            this.cmbJobRole = new System.Windows.Forms.ComboBox();
            this.dtpEntryDate = new System.Windows.Forms.DateTimePicker();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblJobRole = new System.Windows.Forms.Label();
            this.lblEntryDate = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.EmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.pnlRefresh.SuspendLayout();
            this.pnlMainArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.headerControl1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1029, 126);
            this.pnlHeader.TabIndex = 0;
            // 
            // headerControl1
            // 
            this.headerControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.headerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerControl1.Location = new System.Drawing.Point(0, 0);
            this.headerControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.headerControl1.Name = "headerControl1";
            this.headerControl1.Size = new System.Drawing.Size(1029, 126);
            this.headerControl1.TabIndex = 0;
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.Controls.Add(this.lsbEmployees);
            this.pnlNavigation.Controls.Add(this.pnlRefresh);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 126);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(242, 433);
            this.pnlNavigation.TabIndex = 1;
            // 
            // lsbEmployees
            // 
            this.lsbEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbEmployees.FormattingEnabled = true;
            this.lsbEmployees.ItemHeight = 23;
            this.lsbEmployees.Location = new System.Drawing.Point(0, 60);
            this.lsbEmployees.Name = "lsbEmployees";
            this.lsbEmployees.Size = new System.Drawing.Size(242, 373);
            this.lsbEmployees.TabIndex = 1;
            // 
            // pnlRefresh
            // 
            this.pnlRefresh.Controls.Add(this.btnRefresh);
            this.pnlRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRefresh.Location = new System.Drawing.Point(0, 0);
            this.pnlRefresh.Name = "pnlRefresh";
            this.pnlRefresh.Size = new System.Drawing.Size(242, 60);
            this.pnlRefresh.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(69, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(104, 39);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlMainArea
            // 
            this.pnlMainArea.Controls.Add(this.btnSave);
            this.pnlMainArea.Controls.Add(this.checkIsCoffeeDrinker);
            this.pnlMainArea.Controls.Add(this.cmbJobRole);
            this.pnlMainArea.Controls.Add(this.dtpEntryDate);
            this.pnlMainArea.Controls.Add(this.txtFirstName);
            this.pnlMainArea.Controls.Add(this.lblJobRole);
            this.pnlMainArea.Controls.Add(this.lblEntryDate);
            this.pnlMainArea.Controls.Add(this.lblFirstName);
            this.pnlMainArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainArea.Location = new System.Drawing.Point(242, 126);
            this.pnlMainArea.Name = "pnlMainArea";
            this.pnlMainArea.Size = new System.Drawing.Size(787, 433);
            this.pnlMainArea.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(46, 362);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 32);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // checkIsCoffeeDrinker
            // 
            this.checkIsCoffeeDrinker.AutoSize = true;
            this.checkIsCoffeeDrinker.Location = new System.Drawing.Point(47, 236);
            this.checkIsCoffeeDrinker.Name = "checkIsCoffeeDrinker";
            this.checkIsCoffeeDrinker.Size = new System.Drawing.Size(163, 29);
            this.checkIsCoffeeDrinker.TabIndex = 6;
            this.checkIsCoffeeDrinker.Text = "Is Coffee Drinker";
            this.checkIsCoffeeDrinker.UseVisualStyleBackColor = true;
            // 
            // cmbJobRole
            // 
            this.cmbJobRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbJobRole.FormattingEnabled = true;
            this.cmbJobRole.Location = new System.Drawing.Point(47, 181);
            this.cmbJobRole.Name = "cmbJobRole";
            this.cmbJobRole.Size = new System.Drawing.Size(660, 31);
            this.cmbJobRole.TabIndex = 5;
            // 
            // dtpEntryDate
            // 
            this.dtpEntryDate.Location = new System.Drawing.Point(47, 119);
            this.dtpEntryDate.Name = "dtpEntryDate";
            this.dtpEntryDate.Size = new System.Drawing.Size(229, 31);
            this.dtpEntryDate.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(47, 55);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(660, 31);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblJobRole
            // 
            this.lblJobRole.AutoSize = true;
            this.lblJobRole.Location = new System.Drawing.Point(47, 153);
            this.lblJobRole.Name = "lblJobRole";
            this.lblJobRole.Size = new System.Drawing.Size(74, 25);
            this.lblJobRole.TabIndex = 2;
            this.lblJobRole.Text = "JobRole";
            // 
            // lblEntryDate
            // 
            this.lblEntryDate.AutoSize = true;
            this.lblEntryDate.Location = new System.Drawing.Point(47, 89);
            this.lblEntryDate.Name = "lblEntryDate";
            this.lblEntryDate.Size = new System.Drawing.Size(89, 25);
            this.lblEntryDate.TabIndex = 1;
            this.lblEntryDate.Text = "EntryDate";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(47, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(92, 25);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "FirstName";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 559);
            this.Controls.Add(this.pnlMainArea);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "EmployeeManager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlNavigation.ResumeLayout(false);
            this.pnlRefresh.ResumeLayout(false);
            this.pnlMainArea.ResumeLayout(false);
            this.pnlMainArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.ListBox lsbEmployees;
        private System.Windows.Forms.Panel pnlRefresh;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlMainArea;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox checkIsCoffeeDrinker;
        private System.Windows.Forms.ComboBox cmbJobRole;
        private System.Windows.Forms.DateTimePicker dtpEntryDate;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblJobRole;
        private System.Windows.Forms.Label lblEntryDate;
        private System.Windows.Forms.Label lblFirstName;
        private Controls.HeaderControl headerControl1;
        private System.Windows.Forms.BindingSource EmployeesBindingSource;
    }
}
