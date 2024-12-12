namespace DispensaryManagementSystem
{
    partial class Salary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.dgvSalary = new MetroFramework.Controls.MetroGrid();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblVarifySalary = new MetroFramework.Controls.MetroLabel();
            this.lblVarifyPost = new MetroFramework.Controls.MetroLabel();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.cmbEmployeePost = new MetroFramework.Controls.MetroComboBox();
            this.txtSalesmanSalary = new MetroFramework.Controls.MetroTextBox();
            this.txtManagerSalary = new MetroFramework.Controls.MetroTextBox();
            this.txtSalary = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).BeginInit();
            this.metroPanel3.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroPanel4);
            this.metroPanel1.Controls.Add(this.metroPanel3);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1000, 578);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.dgvSalary);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(0, 34);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(1000, 375);
            this.metroPanel4.TabIndex = 4;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // dgvSalary
            // 
            this.dgvSalary.AllowUserToAddRows = false;
            this.dgvSalary.AllowUserToDeleteRows = false;
            this.dgvSalary.AllowUserToResizeRows = false;
            this.dgvSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalary.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSalary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSalary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.EmployeeName,
            this.Post,
            this.EmployeeSalary});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalary.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalary.EnableHeadersVisualStyles = false;
            this.dgvSalary.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSalary.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSalary.Location = new System.Drawing.Point(0, 0);
            this.dgvSalary.Name = "dgvSalary";
            this.dgvSalary.ReadOnly = true;
            this.dgvSalary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalary.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvSalary.RowHeadersVisible = false;
            this.dgvSalary.RowHeadersWidth = 51;
            this.dgvSalary.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSalary.RowTemplate.Height = 24;
            this.dgvSalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalary.Size = new System.Drawing.Size(1000, 375);
            this.dgvSalary.Style = MetroFramework.MetroColorStyle.Green;
            this.dgvSalary.TabIndex = 2;
            this.dgvSalary.UseStyleColors = true;
            // 
            // EmployeeId
            // 
            this.EmployeeId.DataPropertyName = "EmployeeId";
            this.EmployeeId.HeaderText = "Employee ID";
            this.EmployeeId.MinimumWidth = 6;
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "Employee Name";
            this.EmployeeName.MinimumWidth = 6;
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            // 
            // Post
            // 
            this.Post.DataPropertyName = "EmployeePost";
            this.Post.HeaderText = "Post";
            this.Post.MinimumWidth = 6;
            this.Post.Name = "Post";
            this.Post.ReadOnly = true;
            // 
            // EmployeeSalary
            // 
            this.EmployeeSalary.DataPropertyName = "EmployeeSalary";
            this.EmployeeSalary.HeaderText = "Employee Salary";
            this.EmployeeSalary.MinimumWidth = 6;
            this.EmployeeSalary.Name = "EmployeeSalary";
            this.EmployeeSalary.ReadOnly = true;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.metroLabel2);
            this.metroPanel3.Controls.Add(this.metroLabel1);
            this.metroPanel3.Controls.Add(this.metroLabel3);
            this.metroPanel3.Controls.Add(this.lblVarifySalary);
            this.metroPanel3.Controls.Add(this.lblVarifyPost);
            this.metroPanel3.Controls.Add(this.btnUpdate);
            this.metroPanel3.Controls.Add(this.cmbEmployeePost);
            this.metroPanel3.Controls.Add(this.txtSalesmanSalary);
            this.metroPanel3.Controls.Add(this.txtManagerSalary);
            this.metroPanel3.Controls.Add(this.txtSalary);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 409);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(1000, 169);
            this.metroPanel3.TabIndex = 3;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.ForeColor = System.Drawing.Color.Green;
            this.metroLabel3.Location = new System.Drawing.Point(14, 9);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(141, 20);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Select Employee Post";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.UseStyleColors = true;
            // 
            // lblVarifySalary
            // 
            this.lblVarifySalary.AutoSize = true;
            this.lblVarifySalary.BackColor = System.Drawing.Color.Transparent;
            this.lblVarifySalary.ForeColor = System.Drawing.Color.Red;
            this.lblVarifySalary.Location = new System.Drawing.Point(14, 140);
            this.lblVarifySalary.Name = "lblVarifySalary";
            this.lblVarifySalary.Size = new System.Drawing.Size(321, 20);
            this.lblVarifySalary.Style = MetroFramework.MetroColorStyle.Green;
            this.lblVarifySalary.TabIndex = 13;
            this.lblVarifySalary.Text = "Please Enter Employee Salary With a Valid Amount";
            this.lblVarifySalary.UseCustomBackColor = true;
            this.lblVarifySalary.UseCustomForeColor = true;
            this.lblVarifySalary.UseStyleColors = true;
            this.lblVarifySalary.Visible = false;
            // 
            // lblVarifyPost
            // 
            this.lblVarifyPost.AutoSize = true;
            this.lblVarifyPost.BackColor = System.Drawing.Color.Transparent;
            this.lblVarifyPost.ForeColor = System.Drawing.Color.Red;
            this.lblVarifyPost.Location = new System.Drawing.Point(14, 69);
            this.lblVarifyPost.Name = "lblVarifyPost";
            this.lblVarifyPost.Size = new System.Drawing.Size(214, 20);
            this.lblVarifyPost.Style = MetroFramework.MetroColorStyle.Green;
            this.lblVarifyPost.TabIndex = 12;
            this.lblVarifyPost.Text = "Please Select Employee Post First";
            this.lblVarifyPost.UseCustomBackColor = true;
            this.lblVarifyPost.UseCustomForeColor = true;
            this.lblVarifyPost.UseStyleColors = true;
            this.lblVarifyPost.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(271, 94);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 41);
            this.btnUpdate.Style = MetroFramework.MetroColorStyle.Green;
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.UseStyleColors = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbEmployeePost
            // 
            this.cmbEmployeePost.FormattingEnabled = true;
            this.cmbEmployeePost.ItemHeight = 24;
            this.cmbEmployeePost.Items.AddRange(new object[] {
            "Manager",
            "Salesman"});
            this.cmbEmployeePost.Location = new System.Drawing.Point(14, 34);
            this.cmbEmployeePost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEmployeePost.Name = "cmbEmployeePost";
            this.cmbEmployeePost.Size = new System.Drawing.Size(225, 30);
            this.cmbEmployeePost.Style = MetroFramework.MetroColorStyle.Green;
            this.cmbEmployeePost.TabIndex = 9;
            this.cmbEmployeePost.UseSelectable = true;
            this.cmbEmployeePost.UseStyleColors = true;
            this.cmbEmployeePost.TextChanged += new System.EventHandler(this.cmbEmployeePost_TextChanged);
            // 
            // txtSalesmanSalary
            // 
            // 
            // 
            // 
            this.txtSalesmanSalary.CustomButton.Image = null;
            this.txtSalesmanSalary.CustomButton.Location = new System.Drawing.Point(195, 2);
            this.txtSalesmanSalary.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalesmanSalary.CustomButton.Name = "";
            this.txtSalesmanSalary.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtSalesmanSalary.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSalesmanSalary.CustomButton.TabIndex = 1;
            this.txtSalesmanSalary.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSalesmanSalary.CustomButton.UseSelectable = true;
            this.txtSalesmanSalary.CustomButton.Visible = false;
            this.txtSalesmanSalary.Lines = new string[0];
            this.txtSalesmanSalary.Location = new System.Drawing.Point(735, 101);
            this.txtSalesmanSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalesmanSalary.MaxLength = 32767;
            this.txtSalesmanSalary.Name = "txtSalesmanSalary";
            this.txtSalesmanSalary.PasswordChar = '\0';
            this.txtSalesmanSalary.PromptText = "Salary";
            this.txtSalesmanSalary.ReadOnly = true;
            this.txtSalesmanSalary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSalesmanSalary.SelectedText = "";
            this.txtSalesmanSalary.SelectionLength = 0;
            this.txtSalesmanSalary.SelectionStart = 0;
            this.txtSalesmanSalary.ShortcutsEnabled = true;
            this.txtSalesmanSalary.Size = new System.Drawing.Size(227, 34);
            this.txtSalesmanSalary.Style = MetroFramework.MetroColorStyle.Green;
            this.txtSalesmanSalary.TabIndex = 5;
            this.txtSalesmanSalary.UseSelectable = true;
            this.txtSalesmanSalary.UseStyleColors = true;
            this.txtSalesmanSalary.WaterMark = "Salary";
            this.txtSalesmanSalary.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSalesmanSalary.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtManagerSalary
            // 
            // 
            // 
            // 
            this.txtManagerSalary.CustomButton.Image = null;
            this.txtManagerSalary.CustomButton.Location = new System.Drawing.Point(195, 2);
            this.txtManagerSalary.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtManagerSalary.CustomButton.Name = "";
            this.txtManagerSalary.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtManagerSalary.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtManagerSalary.CustomButton.TabIndex = 1;
            this.txtManagerSalary.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtManagerSalary.CustomButton.UseSelectable = true;
            this.txtManagerSalary.CustomButton.Visible = false;
            this.txtManagerSalary.Lines = new string[0];
            this.txtManagerSalary.Location = new System.Drawing.Point(735, 34);
            this.txtManagerSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtManagerSalary.MaxLength = 32767;
            this.txtManagerSalary.Name = "txtManagerSalary";
            this.txtManagerSalary.PasswordChar = '\0';
            this.txtManagerSalary.PromptText = "Salary";
            this.txtManagerSalary.ReadOnly = true;
            this.txtManagerSalary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtManagerSalary.SelectedText = "";
            this.txtManagerSalary.SelectionLength = 0;
            this.txtManagerSalary.SelectionStart = 0;
            this.txtManagerSalary.ShortcutsEnabled = true;
            this.txtManagerSalary.Size = new System.Drawing.Size(227, 34);
            this.txtManagerSalary.Style = MetroFramework.MetroColorStyle.Green;
            this.txtManagerSalary.TabIndex = 4;
            this.txtManagerSalary.UseSelectable = true;
            this.txtManagerSalary.UseStyleColors = true;
            this.txtManagerSalary.WaterMark = "Salary";
            this.txtManagerSalary.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtManagerSalary.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSalary
            // 
            // 
            // 
            // 
            this.txtSalary.CustomButton.Image = null;
            this.txtSalary.CustomButton.Location = new System.Drawing.Point(195, 2);
            this.txtSalary.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalary.CustomButton.Name = "";
            this.txtSalary.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtSalary.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSalary.CustomButton.TabIndex = 1;
            this.txtSalary.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSalary.CustomButton.UseSelectable = true;
            this.txtSalary.CustomButton.Visible = false;
            this.txtSalary.Lines = new string[0];
            this.txtSalary.Location = new System.Drawing.Point(14, 101);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalary.MaxLength = 32767;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.PromptText = "Enter Salary";
            this.txtSalary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSalary.SelectedText = "";
            this.txtSalary.SelectionLength = 0;
            this.txtSalary.SelectionStart = 0;
            this.txtSalary.ShortcutsEnabled = true;
            this.txtSalary.Size = new System.Drawing.Size(227, 34);
            this.txtSalary.Style = MetroFramework.MetroColorStyle.Green;
            this.txtSalary.TabIndex = 3;
            this.txtSalary.UseSelectable = true;
            this.txtSalary.UseStyleColors = true;
            this.txtSalary.WaterMark = "Enter Salary";
            this.txtSalary.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSalary.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSalary.TextChanged += new System.EventHandler(this.txtSalary_TextChanged);
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.label1);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1000, 34);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Salary Sheet";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.ForeColor = System.Drawing.Color.Green;
            this.metroLabel1.Location = new System.Drawing.Point(735, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 20);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Manager Salary";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.ForeColor = System.Drawing.Color.Green;
            this.metroLabel2.Location = new System.Drawing.Point(735, 74);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(108, 20);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Salesman Salary";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "Salary";
            this.Size = new System.Drawing.Size(1000, 578);
            this.Load += new System.EventHandler(this.Salary_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox txtSalary;
        private MetroFramework.Controls.MetroTextBox txtSalesmanSalary;
        private MetroFramework.Controls.MetroTextBox txtManagerSalary;
        private MetroFramework.Controls.MetroComboBox cmbEmployeePost;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroLabel lblVarifyPost;
        private MetroFramework.Controls.MetroLabel lblVarifySalary;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroGrid dgvSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeSalary;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
