namespace DispensaryManagementSystem
{
    partial class ProductCart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCart));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel8 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel11 = new MetroFramework.Controls.MetroPanel();
            this.btnRemoveFromCart = new MetroFramework.Controls.MetroButton();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.txtSellerName = new MetroFramework.Controls.MetroTextBox();
            this.dgvCart = new MetroFramework.Controls.MetroGrid();
            this.serialId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdCart = new System.Drawing.Printing.PrintDocument();
            this.ppdCart = new System.Windows.Forms.PrintPreviewDialog();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel10 = new MetroFramework.Controls.MetroPanel();
            this.btnShowAll = new MetroFramework.Controls.MetroButton();
            this.txtAutoSearch = new MetroFramework.Controls.MetroTextBox();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.dgvProduct = new MetroFramework.Controls.MetroGrid();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.txtProductQuantity = new MetroFramework.Controls.MetroTextBox();
            this.txtProductPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtProductName = new MetroFramework.Controls.MetroTextBox();
            this.btnAddToCart = new MetroFramework.Controls.MetroButton();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel7 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.metroPanel8.SuspendLayout();
            this.metroPanel11.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            this.metroPanel5.SuspendLayout();
            this.metroPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel8
            // 
            this.metroPanel8.Controls.Add(this.metroPanel11);
            this.metroPanel8.Controls.Add(this.dgvCart);
            this.metroPanel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel8.HorizontalScrollbarBarColor = true;
            this.metroPanel8.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel8.HorizontalScrollbarSize = 8;
            this.metroPanel8.Location = new System.Drawing.Point(0, 29);
            this.metroPanel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroPanel8.Name = "metroPanel8";
            this.metroPanel8.Size = new System.Drawing.Size(236, 441);
            this.metroPanel8.TabIndex = 15;
            this.metroPanel8.VerticalScrollbarBarColor = true;
            this.metroPanel8.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel8.VerticalScrollbarSize = 8;
            // 
            // metroPanel11
            // 
            this.metroPanel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel11.Controls.Add(this.btnRemoveFromCart);
            this.metroPanel11.Controls.Add(this.metroPanel4);
            this.metroPanel11.Controls.Add(this.btnPrint);
            this.metroPanel11.Controls.Add(this.txtSellerName);
            this.metroPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel11.HorizontalScrollbarBarColor = true;
            this.metroPanel11.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel11.HorizontalScrollbarSize = 8;
            this.metroPanel11.Location = new System.Drawing.Point(0, 323);
            this.metroPanel11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroPanel11.Name = "metroPanel11";
            this.metroPanel11.Size = new System.Drawing.Size(236, 118);
            this.metroPanel11.TabIndex = 2;
            this.metroPanel11.VerticalScrollbarBarColor = true;
            this.metroPanel11.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel11.VerticalScrollbarSize = 8;
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.BackColor = System.Drawing.Color.Green;
            this.btnRemoveFromCart.ForeColor = System.Drawing.Color.White;
            this.btnRemoveFromCart.Location = new System.Drawing.Point(119, 72);
            this.btnRemoveFromCart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(104, 31);
            this.btnRemoveFromCart.Style = MetroFramework.MetroColorStyle.Green;
            this.btnRemoveFromCart.TabIndex = 19;
            this.btnRemoveFromCart.Text = "Remove";
            this.btnRemoveFromCart.UseMnemonic = false;
            this.btnRemoveFromCart.UseSelectable = true;
            this.btnRemoveFromCart.UseStyleColors = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.lblTotal);
            this.metroPanel4.Controls.Add(this.metroLabel1);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 8;
            this.metroPanel4.Location = new System.Drawing.Point(0, 0);
            this.metroPanel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(234, 40);
            this.metroPanel4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroPanel4.TabIndex = 18;
            this.metroPanel4.UseStyleColors = true;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(175, 14);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(16, 19);
            this.lblTotal.Style = MetroFramework.MetroColorStyle.Green;
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "0";
            this.lblTotal.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(11, 14);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Total Amount";
            this.metroLabel1.UseStyleColors = true;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Green;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(12, 72);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(104, 31);
            this.btnPrint.Style = MetroFramework.MetroColorStyle.Green;
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Save and Print";
            this.btnPrint.UseMnemonic = false;
            this.btnPrint.UseSelectable = true;
            this.btnPrint.UseStyleColors = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtSellerName
            // 
            // 
            // 
            // 
            this.txtSellerName.CustomButton.Image = null;
            this.txtSellerName.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txtSellerName.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSellerName.CustomButton.Name = "";
            this.txtSellerName.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtSellerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSellerName.CustomButton.TabIndex = 1;
            this.txtSellerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSellerName.CustomButton.UseSelectable = true;
            this.txtSellerName.CustomButton.Visible = false;
            this.txtSellerName.Lines = new string[0];
            this.txtSellerName.Location = new System.Drawing.Point(12, 45);
            this.txtSellerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSellerName.MaxLength = 32767;
            this.txtSellerName.Name = "txtSellerName";
            this.txtSellerName.PasswordChar = '\0';
            this.txtSellerName.PromptText = "Enter Seller Name";
            this.txtSellerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSellerName.SelectedText = "";
            this.txtSellerName.SelectionLength = 0;
            this.txtSellerName.SelectionStart = 0;
            this.txtSellerName.ShortcutsEnabled = true;
            this.txtSellerName.Size = new System.Drawing.Size(212, 23);
            this.txtSellerName.Style = MetroFramework.MetroColorStyle.Green;
            this.txtSellerName.TabIndex = 13;
            this.txtSellerName.UseSelectable = true;
            this.txtSellerName.WaterMark = "Enter Seller Name";
            this.txtSellerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtSellerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AllowUserToResizeRows = false;
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialId,
            this.CartProductName,
            this.PQuantity,
            this.Pprice});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCart.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCart.EnableHeadersVisualStyles = false;
            this.dgvCart.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvCart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCart.Location = new System.Drawing.Point(0, 0);
            this.dgvCart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(236, 323);
            this.dgvCart.Style = MetroFramework.MetroColorStyle.Green;
            this.dgvCart.TabIndex = 13;
            this.dgvCart.UseStyleColors = true;
            this.dgvCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellContentClick);
            // 
            // serialId
            // 
            this.serialId.HeaderText = "Serial";
            this.serialId.MinimumWidth = 6;
            this.serialId.Name = "serialId";
            this.serialId.ReadOnly = true;
            // 
            // CartProductName
            // 
            this.CartProductName.HeaderText = "Name";
            this.CartProductName.MinimumWidth = 6;
            this.CartProductName.Name = "CartProductName";
            this.CartProductName.ReadOnly = true;
            // 
            // PQuantity
            // 
            this.PQuantity.HeaderText = "quantity";
            this.PQuantity.MinimumWidth = 6;
            this.PQuantity.Name = "PQuantity";
            this.PQuantity.ReadOnly = true;
            // 
            // Pprice
            // 
            this.Pprice.HeaderText = "Price";
            this.Pprice.MinimumWidth = 6;
            this.Pprice.Name = "Pprice";
            this.Pprice.ReadOnly = true;
            // 
            // pdCart
            // 
            this.pdCart.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdCart_PrintPage);
            // 
            // ppdCart
            // 
            this.ppdCart.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdCart.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdCart.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdCart.Enabled = true;
            this.ppdCart.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdCart.Icon")));
            this.ppdCart.Name = "ppdCart";
            this.ppdCart.Visible = false;
            // 
            // pbRefresh
            // 
            this.pbRefresh.Image = global::DispensaryManagementSystem.Properties.Resources.icons8_available_updates_52;
            this.pbRefresh.Location = new System.Drawing.Point(486, 2);
            this.pbRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(21, 23);
            this.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRefresh.TabIndex = 12;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.Click += new System.EventHandler(this.pbRefresh_Click);
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.metroPanel10);
            this.metroPanel5.Controls.Add(this.dgvProduct);
            this.metroPanel5.Controls.Add(this.metroPanel2);
            this.metroPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 8;
            this.metroPanel5.Location = new System.Drawing.Point(238, 0);
            this.metroPanel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(654, 470);
            this.metroPanel5.TabIndex = 8;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 8;
            // 
            // metroPanel10
            // 
            this.metroPanel10.BackColor = System.Drawing.Color.White;
            this.metroPanel10.Controls.Add(this.pbRefresh);
            this.metroPanel10.Controls.Add(this.btnShowAll);
            this.metroPanel10.Controls.Add(this.txtAutoSearch);
            this.metroPanel10.Controls.Add(this.txtSearch);
            this.metroPanel10.Controls.Add(this.btnSearch);
            this.metroPanel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel10.HorizontalScrollbarBarColor = true;
            this.metroPanel10.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel10.HorizontalScrollbarSize = 8;
            this.metroPanel10.Location = new System.Drawing.Point(0, 0);
            this.metroPanel10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroPanel10.Name = "metroPanel10";
            this.metroPanel10.Size = new System.Drawing.Size(654, 27);
            this.metroPanel10.TabIndex = 12;
            this.metroPanel10.VerticalScrollbarBarColor = true;
            this.metroPanel10.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel10.VerticalScrollbarSize = 8;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.Green;
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(538, 2);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(104, 23);
            this.btnShowAll.Style = MetroFramework.MetroColorStyle.Green;
            this.btnShowAll.TabIndex = 10;
            this.btnShowAll.Text = "Show all Product";
            this.btnShowAll.UseMnemonic = false;
            this.btnShowAll.UseSelectable = true;
            this.btnShowAll.UseStyleColors = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // txtAutoSearch
            // 
            // 
            // 
            // 
            this.txtAutoSearch.CustomButton.Image = null;
            this.txtAutoSearch.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.txtAutoSearch.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAutoSearch.CustomButton.Name = "";
            this.txtAutoSearch.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtAutoSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAutoSearch.CustomButton.TabIndex = 1;
            this.txtAutoSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAutoSearch.CustomButton.UseSelectable = true;
            this.txtAutoSearch.CustomButton.Visible = false;
            this.txtAutoSearch.Lines = new string[0];
            this.txtAutoSearch.Location = new System.Drawing.Point(274, 2);
            this.txtAutoSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAutoSearch.MaxLength = 32767;
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.PasswordChar = '\0';
            this.txtAutoSearch.PromptText = "Search by Group Name";
            this.txtAutoSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAutoSearch.SelectedText = "";
            this.txtAutoSearch.SelectionLength = 0;
            this.txtAutoSearch.SelectionStart = 0;
            this.txtAutoSearch.ShortcutsEnabled = true;
            this.txtAutoSearch.Size = new System.Drawing.Size(176, 23);
            this.txtAutoSearch.Style = MetroFramework.MetroColorStyle.Green;
            this.txtAutoSearch.TabIndex = 11;
            this.txtAutoSearch.UseSelectable = true;
            this.txtAutoSearch.WaterMark = "Search by Group Name";
            this.txtAutoSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtAutoSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.txtSearch.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(2, 2);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search by Product Name";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(176, 23);
            this.txtSearch.Style = MetroFramework.MetroColorStyle.Green;
            this.txtSearch.TabIndex = 8;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search by Product Name";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Green;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(177, 2);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 23);
            this.btnSearch.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseMnemonic = false;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.UseStyleColors = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.GroupName,
            this.CompanyName,
            this.ProductQuantity,
            this.ProductPrice});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProduct.Location = new System.Drawing.Point(0, 29);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(654, 362);
            this.dgvProduct.Style = MetroFramework.MetroColorStyle.Green;
            this.dgvProduct.TabIndex = 2;
            this.dgvProduct.UseCustomBackColor = true;
            this.dgvProduct.UseCustomForeColor = true;
            this.dgvProduct.UseStyleColors = true;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "productId";
            this.ProductId.HeaderText = "Id";
            this.ProductId.MinimumWidth = 6;
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "productName";
            this.ProductName.HeaderText = "Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // GroupName
            // 
            this.GroupName.DataPropertyName = "groupName";
            this.GroupName.HeaderText = "Group Name";
            this.GroupName.MinimumWidth = 6;
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "companyName";
            this.CompanyName.HeaderText = "Company Name";
            this.CompanyName.MinimumWidth = 6;
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.DataPropertyName = "quantity";
            this.ProductQuantity.HeaderText = "Quantity";
            this.ProductQuantity.MinimumWidth = 6;
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.ReadOnly = true;
            // 
            // ProductPrice
            // 
            this.ProductPrice.DataPropertyName = "price";
            this.ProductPrice.HeaderText = "Price";
            this.ProductPrice.MinimumWidth = 6;
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.label10);
            this.metroPanel2.Controls.Add(this.txtProductQuantity);
            this.metroPanel2.Controls.Add(this.txtProductPrice);
            this.metroPanel2.Controls.Add(this.txtProductName);
            this.metroPanel2.Controls.Add(this.btnAddToCart);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 8;
            this.metroPanel2.Location = new System.Drawing.Point(0, 391);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(654, 79);
            this.metroPanel2.TabIndex = 10;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 8;
            // 
            // txtProductQuantity
            // 
            // 
            // 
            // 
            this.txtProductQuantity.CustomButton.Image = null;
            this.txtProductQuantity.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.txtProductQuantity.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProductQuantity.CustomButton.Name = "";
            this.txtProductQuantity.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtProductQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductQuantity.CustomButton.TabIndex = 1;
            this.txtProductQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductQuantity.CustomButton.UseSelectable = true;
            this.txtProductQuantity.CustomButton.Visible = false;
            this.txtProductQuantity.Lines = new string[0];
            this.txtProductQuantity.Location = new System.Drawing.Point(333, 6);
            this.txtProductQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProductQuantity.MaxLength = 32767;
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.PasswordChar = '\0';
            this.txtProductQuantity.PromptText = "Enter Product Quantity";
            this.txtProductQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductQuantity.SelectedText = "";
            this.txtProductQuantity.SelectionLength = 0;
            this.txtProductQuantity.SelectionStart = 0;
            this.txtProductQuantity.ShortcutsEnabled = true;
            this.txtProductQuantity.Size = new System.Drawing.Size(149, 23);
            this.txtProductQuantity.Style = MetroFramework.MetroColorStyle.Green;
            this.txtProductQuantity.TabIndex = 16;
            this.txtProductQuantity.UseSelectable = true;
            this.txtProductQuantity.WaterMark = "Enter Product Quantity";
            this.txtProductQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtProductQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtProductQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductQuantity_KeyPress);
            // 
            // txtProductPrice
            // 
            // 
            // 
            // 
            this.txtProductPrice.CustomButton.Image = null;
            this.txtProductPrice.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.txtProductPrice.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProductPrice.CustomButton.Name = "";
            this.txtProductPrice.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtProductPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductPrice.CustomButton.TabIndex = 1;
            this.txtProductPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductPrice.CustomButton.UseSelectable = true;
            this.txtProductPrice.CustomButton.Visible = false;
            this.txtProductPrice.Lines = new string[0];
            this.txtProductPrice.Location = new System.Drawing.Point(172, 6);
            this.txtProductPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProductPrice.MaxLength = 32767;
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.PasswordChar = '\0';
            this.txtProductPrice.PromptText = "Product Price";
            this.txtProductPrice.ReadOnly = true;
            this.txtProductPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductPrice.SelectedText = "";
            this.txtProductPrice.SelectionLength = 0;
            this.txtProductPrice.SelectionStart = 0;
            this.txtProductPrice.ShortcutsEnabled = true;
            this.txtProductPrice.Size = new System.Drawing.Size(149, 23);
            this.txtProductPrice.Style = MetroFramework.MetroColorStyle.Green;
            this.txtProductPrice.TabIndex = 15;
            this.txtProductPrice.UseSelectable = true;
            this.txtProductPrice.WaterMark = "Product Price";
            this.txtProductPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtProductPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtProductName
            // 
            // 
            // 
            // 
            this.txtProductName.CustomButton.Image = null;
            this.txtProductName.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.txtProductName.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProductName.CustomButton.Name = "";
            this.txtProductName.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtProductName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductName.CustomButton.TabIndex = 1;
            this.txtProductName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductName.CustomButton.UseSelectable = true;
            this.txtProductName.CustomButton.Visible = false;
            this.txtProductName.Lines = new string[0];
            this.txtProductName.Location = new System.Drawing.Point(12, 6);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProductName.MaxLength = 32767;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.PromptText = "Product Name";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductName.SelectedText = "";
            this.txtProductName.SelectionLength = 0;
            this.txtProductName.SelectionStart = 0;
            this.txtProductName.ShortcutsEnabled = true;
            this.txtProductName.Size = new System.Drawing.Size(149, 23);
            this.txtProductName.Style = MetroFramework.MetroColorStyle.Green;
            this.txtProductName.TabIndex = 14;
            this.txtProductName.UseSelectable = true;
            this.txtProductName.WaterMark = "Product Name";
            this.txtProductName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtProductName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.Green;
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(537, 4);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(76, 31);
            this.btnAddToCart.Style = MetroFramework.MetroColorStyle.Green;
            this.btnAddToCart.TabIndex = 12;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseMnemonic = false;
            this.btnAddToCart.UseSelectable = true;
            this.btnAddToCart.UseStyleColors = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // metroPanel3
            // 
            this.metroPanel3.BackColor = System.Drawing.Color.LimeGreen;
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 8;
            this.metroPanel3.Location = new System.Drawing.Point(236, 0);
            this.metroPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(2, 470);
            this.metroPanel3.TabIndex = 7;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.UseCustomForeColor = true;
            this.metroPanel3.UseStyleColors = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 8;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroPanel5);
            this.metroPanel1.Controls.Add(this.metroPanel3);
            this.metroPanel1.Controls.Add(this.metroPanel7);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 8;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(892, 470);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 8;
            // 
            // metroPanel7
            // 
            this.metroPanel7.Controls.Add(this.metroLabel7);
            this.metroPanel7.Controls.Add(this.metroPanel8);
            this.metroPanel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel7.HorizontalScrollbarBarColor = true;
            this.metroPanel7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel7.HorizontalScrollbarSize = 8;
            this.metroPanel7.Location = new System.Drawing.Point(0, 0);
            this.metroPanel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroPanel7.Name = "metroPanel7";
            this.metroPanel7.Size = new System.Drawing.Size(236, 470);
            this.metroPanel7.TabIndex = 5;
            this.metroPanel7.VerticalScrollbarBarColor = true;
            this.metroPanel7.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel7.VerticalScrollbarSize = 8;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.metroLabel7.Location = new System.Drawing.Point(12, 8);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(77, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel7.TabIndex = 16;
            this.metroLabel7.Text = "Cart Details";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            this.metroLabel7.UseStyleColors = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(9, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(245, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "# Row must be selected before removing from cart";
            // 
            // ProductCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProductCart";
            this.Size = new System.Drawing.Size(892, 470);
            this.Load += new System.EventHandler(this.ProductCart_Load);
            this.metroPanel8.ResumeLayout(false);
            this.metroPanel11.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel7.ResumeLayout(false);
            this.metroPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel8;
        private MetroFramework.Controls.MetroPanel metroPanel11;
        private MetroFramework.Controls.MetroButton btnRemoveFromCart;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroLabel lblTotal;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnPrint;
        private MetroFramework.Controls.MetroTextBox txtSellerName;
        private MetroFramework.Controls.MetroGrid dgvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pprice;
        private System.Drawing.Printing.PrintDocument pdCart;
        private System.Windows.Forms.PrintPreviewDialog ppdCart;
        private System.Windows.Forms.PictureBox pbRefresh;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroPanel metroPanel10;
        private MetroFramework.Controls.MetroTextBox txtAutoSearch;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroGrid dgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox txtProductQuantity;
        private MetroFramework.Controls.MetroTextBox txtProductPrice;
        private MetroFramework.Controls.MetroTextBox txtProductName;
        private MetroFramework.Controls.MetroButton btnAddToCart;
        private MetroFramework.Controls.MetroButton btnShowAll;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.Label label10;
    }
}
