namespace HumanResourcesManager_Project.UI
{
    partial class HR_ManagerApp
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
            this.dgvHighTech = new System.Windows.Forms.DataGridView();
            this.highTechDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.highTechDataSet = new HumanResourcesManager_Project.DAL.HighTechDataSet();
            this.grpInputs = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSsn = new System.Windows.Forms.Label();
            this.txtSsn = new System.Windows.Forms.TextBox();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.grpFeedback = new System.Windows.Forms.GroupBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new HumanResourcesManager_Project.DAL.HighTechDataSetTableAdapters.EmployeeTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHighTech)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highTechDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highTechDataSet)).BeginInit();
            this.grpInputs.SuspendLayout();
            this.grpButtons.SuspendLayout();
            this.grpFeedback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHighTech
            // 
            this.dgvHighTech.AllowUserToAddRows = false;
            this.dgvHighTech.AllowUserToDeleteRows = false;
            this.dgvHighTech.AutoGenerateColumns = false;
            this.dgvHighTech.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvHighTech.ColumnHeadersHeight = 29;
            this.dgvHighTech.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHighTech.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.sSNDataGridViewTextBoxColumn,
            this.hireDateDataGridViewTextBoxColumn});
            this.dgvHighTech.DataSource = this.employeeBindingSource;
            this.dgvHighTech.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvHighTech.Location = new System.Drawing.Point(12, 452);
            this.dgvHighTech.MultiSelect = false;
            this.dgvHighTech.Name = "dgvHighTech";
            this.dgvHighTech.ReadOnly = true;
            this.dgvHighTech.RowHeadersWidth = 51;
            this.dgvHighTech.RowTemplate.Height = 24;
            this.dgvHighTech.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHighTech.ShowEditingIcon = false;
            this.dgvHighTech.Size = new System.Drawing.Size(760, 476);
            this.dgvHighTech.SelectionChanged += new System.EventHandler(this.DgvHighTech_SelectionChanged);
            this.dgvHighTech.TabIndex = 0;
            // 
            // highTechDataSetBindingSource
            // 
            this.highTechDataSetBindingSource.DataSource = this.highTechDataSet;
            this.highTechDataSetBindingSource.Position = 0;
            // 
            // highTechDataSet
            // 
            this.highTechDataSet.DataSetName = "HighTechDataSet";
            this.highTechDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpInputs
            // 
            this.grpInputs.Controls.Add(this.lblId);
            this.grpInputs.Controls.Add(this.txtId);
            this.grpInputs.Controls.Add(this.lblFirstName);
            this.grpInputs.Controls.Add(this.txtFirstName);
            this.grpInputs.Controls.Add(this.lblLastName);
            this.grpInputs.Controls.Add(this.txtLastName);
            this.grpInputs.Controls.Add(this.lblEmail);
            this.grpInputs.Controls.Add(this.txtEmail);
            this.grpInputs.Controls.Add(this.lblSsn);
            this.grpInputs.Controls.Add(this.txtSsn);
            this.grpInputs.Controls.Add(this.lblHireDate);
            this.grpInputs.Controls.Add(this.dtpHireDate);
            this.grpInputs.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.grpInputs.Location = new System.Drawing.Point(12, 12);
            this.grpInputs.Name = "grpInputs";
            this.grpInputs.Padding = new System.Windows.Forms.Padding(10);
            this.grpInputs.Size = new System.Drawing.Size(486, 266);
            this.grpInputs.TabIndex = 1;
            this.grpInputs.TabStop = false;
            this.grpInputs.Text = "Inputs";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(30, 40);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(34, 19);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(160, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(317, 28);
            this.txtId.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(30, 80);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(105, 19);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(160, 75);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(317, 28);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(30, 120);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 19);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(160, 115);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(317, 28);
            this.txtLastName.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 160);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 19);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(160, 155);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(317, 28);
            this.txtEmail.TabIndex = 7;
            // 
            // lblSsn
            // 
            this.lblSsn.AutoSize = true;
            this.lblSsn.Location = new System.Drawing.Point(30, 200);
            this.lblSsn.Name = "lblSsn";
            this.lblSsn.Size = new System.Drawing.Size(46, 19);
            this.lblSsn.TabIndex = 8;
            this.lblSsn.Text = "SSN:";
            // 
            // txtSsn
            // 
            this.txtSsn.Location = new System.Drawing.Point(160, 195);
            this.txtSsn.Name = "txtSsn";
            this.txtSsn.Size = new System.Drawing.Size(317, 28);
            this.txtSsn.TabIndex = 9;
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Location = new System.Drawing.Point(30, 240);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(92, 19);
            this.lblHireDate.TabIndex = 10;
            this.lblHireDate.Text = "Hire Date:";
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Location = new System.Drawing.Point(160, 235);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(317, 28);
            this.dtpHireDate.TabIndex = 11;
            // 
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.btnInsert);
            this.grpButtons.Controls.Add(this.btnUpdate);
            this.grpButtons.Controls.Add(this.btnDelete);
            this.grpButtons.Controls.Add(this.btnSearch);
            this.grpButtons.Controls.Add(this.btnDisplay);
            this.grpButtons.Controls.Add(this.btnRefresh);
            this.grpButtons.Controls.Add(this.btnExit);
            this.grpButtons.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpButtons.Location = new System.Drawing.Point(504, 12);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(268, 434);
            this.grpButtons.TabIndex = 2;
            this.grpButtons.TabStop = false;
            this.grpButtons.Text = "Actions";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Green;
            this.btnInsert.Location = new System.Drawing.Point(6, 27);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(256, 44);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Blue;
            this.btnUpdate.Location = new System.Drawing.Point(6, 143);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(256, 44);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(6, 85);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(256, 44);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Yellow;
            this.btnSearch.Location = new System.Drawing.Point(6, 259);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(256, 44);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.Purple;
            this.btnDisplay.Location = new System.Drawing.Point(6, 201);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(256, 44);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "DISPLAY";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Orange;
            this.btnRefresh.Location = new System.Drawing.Point(6, 317);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(256, 44);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gray;
            this.btnExit.Location = new System.Drawing.Point(6, 375);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(256, 44);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.ForeColor = System.Drawing.Color.Black;
            this.lblFeedback.Location = new System.Drawing.Point(6, 24);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(474, 100);
            this.lblFeedback.TabIndex = 3;
            this.lblFeedback.Text = "Feedback will appear here";
            this.lblFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFeedback.Visible = false;
            // 
            // grpFeedback
            // 
            this.grpFeedback.Controls.Add(this.lblFeedback);
            this.grpFeedback.Location = new System.Drawing.Point(12, 290);
            this.grpFeedback.Name = "grpFeedback";
            this.grpFeedback.Size = new System.Drawing.Size(486, 156);
            this.grpFeedback.TabIndex = 4;
            this.grpFeedback.TabStop = false;
            this.grpFeedback.Text = "Feedback";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.highTechDataSetBindingSource;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // sSNDataGridViewTextBoxColumn
            // 
            this.sSNDataGridViewTextBoxColumn.DataPropertyName = "SSN";
            this.sSNDataGridViewTextBoxColumn.HeaderText = "SSN";
            this.sSNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sSNDataGridViewTextBoxColumn.Name = "sSNDataGridViewTextBoxColumn";
            this.sSNDataGridViewTextBoxColumn.ReadOnly = true;
            this.sSNDataGridViewTextBoxColumn.Width = 125;
            // 
            // hireDateDataGridViewTextBoxColumn
            // 
            this.hireDateDataGridViewTextBoxColumn.DataPropertyName = "HireDate";
            this.hireDateDataGridViewTextBoxColumn.HeaderText = "HireDate";
            this.hireDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hireDateDataGridViewTextBoxColumn.Name = "hireDateDataGridViewTextBoxColumn";
            this.hireDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.hireDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // HR_ManagerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(784, 940);
            this.Controls.Add(this.grpButtons);
            this.Controls.Add(this.grpInputs);
            this.Controls.Add(this.dgvHighTech);
            this.Controls.Add(this.grpFeedback);
            this.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HR_ManagerApp";
            this.Text = "Human Resources ";
            this.Load += new System.EventHandler(this.HR_ManagerApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHighTech)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highTechDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highTechDataSet)).EndInit();
            this.grpInputs.ResumeLayout(false);
            this.grpInputs.PerformLayout();
            this.grpButtons.ResumeLayout(false);
            this.grpFeedback.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHighTech;
        private System.Windows.Forms.BindingSource highTechDataSetBindingSource;
        private DAL.HighTechDataSet highTechDataSet;
        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSsn;
        private System.Windows.Forms.TextBox txtSsn;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.GroupBox grpFeedback;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DAL.HighTechDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hireDateDataGridViewTextBoxColumn;
    }
}

