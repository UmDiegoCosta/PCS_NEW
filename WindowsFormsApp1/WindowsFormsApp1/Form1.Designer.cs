namespace WindowsFormsApp1
{
    partial class Form1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pCsDataSet = new WindowsFormsApp1.PCsDataSet();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblEmpPassword = new System.Windows.Forms.Label();
            this.txtEmpPassword = new System.Windows.Forms.TextBox();
            this.txtEmp_no = new System.Windows.Forms.TextBox();
            this.lblEmp_no = new System.Windows.Forms.Label();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.dgEmployee = new System.Windows.Forms.DataGridView();
            this.btnSaveEmp = new System.Windows.Forms.Button();
            this.btnEditEmp = new System.Windows.Forms.Button();
            this.btnNewEmp = new System.Windows.Forms.Button();
            this.txtEmpSearch = new System.Windows.Forms.TextBox();
            this.panelEmp = new System.Windows.Forms.Panel();
            this.cnEmpStatus = new System.Windows.Forms.ComboBox();
            this.txtEmpPass = new System.Windows.Forms.TextBox();
            this.lblEmpPosition = new System.Windows.Forms.Label();
            this.lblEmpManagerNo = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblEmpNo = new System.Windows.Forms.Label();
            this.lblEmpStatus = new System.Windows.Forms.Label();
            this.lblEmpPass = new System.Windows.Forms.Label();
            this.txtEmpManagerNumber = new System.Windows.Forms.TextBox();
            this.txtEmpPosition = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpNo = new System.Windows.Forms.TextBox();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.dgCustomer = new System.Windows.Forms.DataGridView();
            this.custNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveCust = new System.Windows.Forms.Button();
            this.btnEditCust = new System.Windows.Forms.Button();
            this.btnNewCust = new System.Windows.Forms.Button();
            this.txtCustomerSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.txtBillPostalCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBillCity = new System.Windows.Forms.TextBox();
            this.txtCustomerNo = new System.Windows.Forms.TextBox();
            this.txtBillStreet = new System.Windows.Forms.TextBox();
            this.lblCustNo = new System.Windows.Forms.Label();
            this.txtCustomerPostal = new System.Windows.Forms.TextBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.txtCustomerCity = new System.Windows.Forms.TextBox();
            this.lblCustPhone = new System.Windows.Forms.Label();
            this.txtCustomerStreet = new System.Windows.Forms.TextBox();
            this.lblCustShipStreetAddress = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.lblCustShipCity = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustShipPostalCode = new System.Windows.Forms.Label();
            this.lblCustBillStreetAddress = new System.Windows.Forms.Label();
            this.lblCustBillCity = new System.Windows.Forms.Label();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.dgProduct = new System.Windows.Forms.DataGridView();
            this.prodCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveProd = new System.Windows.Forms.Button();
            this.btnEditProd = new System.Windows.Forms.Button();
            this.btnNewProd = new System.Windows.Forms.Button();
            this.panelProd = new System.Windows.Forms.Panel();
            this.txtProdNo = new System.Windows.Forms.TextBox();
            this.txtProdDescription = new System.Windows.Forms.TextBox();
            this.lblProdStatus = new System.Windows.Forms.Label();
            this.cbProdStatus = new System.Windows.Forms.ComboBox();
            this.lblProdReorderPoint = new System.Windows.Forms.Label();
            this.txtProdCode = new System.Windows.Forms.TextBox();
            this.lblProdQty = new System.Windows.Forms.Label();
            this.txtProdReorderPoint = new System.Windows.Forms.TextBox();
            this.lblProdPrice = new System.Windows.Forms.Label();
            this.txtProdCategory = new System.Windows.Forms.TextBox();
            this.lblProdCarModelYear = new System.Windows.Forms.Label();
            this.txtProdQuantity = new System.Windows.Forms.TextBox();
            this.txtProdPrice = new System.Windows.Forms.TextBox();
            this.lblProdCarMake = new System.Windows.Forms.Label();
            this.lblProdNo = new System.Windows.Forms.Label();
            this.lblProdCode = new System.Windows.Forms.Label();
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.dgProductInvoice = new System.Windows.Forms.DataGridView();
            this.prodCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDescriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtInvoiceProd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgCustInvoice = new System.Windows.Forms.DataGridView();
            this.custNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPhoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtInvoiceCust = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgEmpInvoice = new System.Windows.Forms.DataGridView();
            this.empNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtInvoiceEmp = new System.Windows.Forms.TextBox();
            this.tabInvoice = new System.Windows.Forms.TabPage();
            this.rvInvoice = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFoot = new System.Windows.Forms.Label();
            this.eMPLOYEETableAdapter = new WindowsFormsApp1.PCsDataSetTableAdapters.EMPLOYEETableAdapter();
            this.cUSTOMERTableAdapter = new WindowsFormsApp1.PCsDataSetTableAdapters.CUSTOMERTableAdapter();
            this.pRODUCTTableAdapter = new WindowsFormsApp1.PCsDataSetTableAdapters.PRODUCTTableAdapter();
            this.empNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            this.TabControl.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).BeginInit();
            this.panelEmp.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).BeginInit();
            this.panelCustomer.SuspendLayout();
            this.tabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).BeginInit();
            this.panelProd.SuspendLayout();
            this.tabOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpInvoice)).BeginInit();
            this.tabInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.pCsDataSet;
            // 
            // pCsDataSet
            // 
            this.pCsDataSet.DataSetName = "PCsDataSet";
            this.pCsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.pCsDataSet;
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.pCsDataSet;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabLogin);
            this.TabControl.Controls.Add(this.tabEmployee);
            this.TabControl.Controls.Add(this.tabCustomer);
            this.TabControl.Controls.Add(this.tabProduct);
            this.TabControl.Controls.Add(this.tabOrder);
            this.TabControl.Controls.Add(this.tabInvoice);
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.Location = new System.Drawing.Point(4, 148);
            this.TabControl.Margin = new System.Windows.Forms.Padding(6);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1576, 888);
            this.TabControl.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.panel1);
            this.tabLogin.Location = new System.Drawing.Point(8, 56);
            this.tabLogin.Margin = new System.Windows.Forms.Padding(6);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(6);
            this.tabLogin.Size = new System.Drawing.Size(1560, 824);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.lblEmpPassword);
            this.panel1.Controls.Add(this.txtEmpPassword);
            this.panel1.Controls.Add(this.txtEmp_no);
            this.panel1.Controls.Add(this.lblEmp_no);
            this.panel1.Location = new System.Drawing.Point(394, 215);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 419);
            this.panel1.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(326, 319);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(6);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 44);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // lblEmpPassword
            // 
            this.lblEmpPassword.AutoSize = true;
            this.lblEmpPassword.Location = new System.Drawing.Point(22, 217);
            this.lblEmpPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmpPassword.Name = "lblEmpPassword";
            this.lblEmpPassword.Size = new System.Drawing.Size(377, 44);
            this.lblEmpPassword.TabIndex = 2;
            this.lblEmpPassword.Text = "Employee Password:";
            // 
            // txtEmpPassword
            // 
            this.txtEmpPassword.Location = new System.Drawing.Point(244, 204);
            this.txtEmpPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmpPassword.Name = "txtEmpPassword";
            this.txtEmpPassword.PasswordChar = '*';
            this.txtEmpPassword.Size = new System.Drawing.Size(354, 50);
            this.txtEmpPassword.TabIndex = 5;
            // 
            // txtEmp_no
            // 
            this.txtEmp_no.Location = new System.Drawing.Point(244, 114);
            this.txtEmp_no.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmp_no.Name = "txtEmp_no";
            this.txtEmp_no.Size = new System.Drawing.Size(354, 50);
            this.txtEmp_no.TabIndex = 3;
            this.txtEmp_no.TextChanged += new System.EventHandler(this.txtEmp_no_TextChanged);
            // 
            // lblEmp_no
            // 
            this.lblEmp_no.AutoSize = true;
            this.lblEmp_no.Location = new System.Drawing.Point(22, 127);
            this.lblEmp_no.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmp_no.Name = "lblEmp_no";
            this.lblEmp_no.Size = new System.Drawing.Size(270, 44);
            this.lblEmp_no.TabIndex = 0;
            this.lblEmp_no.Text = "Employee No.:";
            // 
            // tabEmployee
            // 
            this.tabEmployee.Controls.Add(this.label11);
            this.tabEmployee.Controls.Add(this.dgEmployee);
            this.tabEmployee.Controls.Add(this.btnSaveEmp);
            this.tabEmployee.Controls.Add(this.btnEditEmp);
            this.tabEmployee.Controls.Add(this.btnNewEmp);
            this.tabEmployee.Controls.Add(this.txtEmpSearch);
            this.tabEmployee.Controls.Add(this.panelEmp);
            this.tabEmployee.Location = new System.Drawing.Point(8, 56);
            this.tabEmployee.Margin = new System.Windows.Forms.Padding(6);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(6);
            this.tabEmployee.Size = new System.Drawing.Size(1560, 824);
            this.tabEmployee.TabIndex = 5;
            this.tabEmployee.Text = "Employee";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(769, 70);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(331, 44);
            this.label11.TabIndex = 39;
            this.label11.Text = "Search Employee:";
            // 
            // dgEmployee
            // 
            this.dgEmployee.AutoGenerateColumns = false;
            this.dgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empNoDataGridViewTextBoxColumn,
            this.empNameDataGridViewTextBoxColumn});
            this.dgEmployee.DataSource = this.eMPLOYEEBindingSource;
            this.dgEmployee.Location = new System.Drawing.Point(775, 124);
            this.dgEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.dgEmployee.Name = "dgEmployee";
            this.dgEmployee.RowTemplate.Height = 33;
            this.dgEmployee.Size = new System.Drawing.Size(756, 365);
            this.dgEmployee.TabIndex = 38;
            // 
            // btnSaveEmp
            // 
            this.btnSaveEmp.Location = new System.Drawing.Point(579, 528);
            this.btnSaveEmp.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveEmp.Name = "btnSaveEmp";
            this.btnSaveEmp.Size = new System.Drawing.Size(150, 75);
            this.btnSaveEmp.TabIndex = 37;
            this.btnSaveEmp.Text = "Save";
            this.btnSaveEmp.UseVisualStyleBackColor = true;
            // 
            // btnEditEmp
            // 
            this.btnEditEmp.Location = new System.Drawing.Point(299, 528);
            this.btnEditEmp.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditEmp.Name = "btnEditEmp";
            this.btnEditEmp.Size = new System.Drawing.Size(150, 75);
            this.btnEditEmp.TabIndex = 36;
            this.btnEditEmp.Text = "Edit";
            this.btnEditEmp.UseVisualStyleBackColor = true;
            // 
            // btnNewEmp
            // 
            this.btnNewEmp.Location = new System.Drawing.Point(25, 528);
            this.btnNewEmp.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewEmp.Name = "btnNewEmp";
            this.btnNewEmp.Size = new System.Drawing.Size(150, 75);
            this.btnNewEmp.TabIndex = 35;
            this.btnNewEmp.Text = "New";
            this.btnNewEmp.UseVisualStyleBackColor = true;
            // 
            // txtEmpSearch
            // 
            this.txtEmpSearch.Location = new System.Drawing.Point(965, 67);
            this.txtEmpSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmpSearch.Name = "txtEmpSearch";
            this.txtEmpSearch.Size = new System.Drawing.Size(564, 50);
            this.txtEmpSearch.TabIndex = 34;
            // 
            // panelEmp
            // 
            this.panelEmp.Controls.Add(this.cnEmpStatus);
            this.panelEmp.Controls.Add(this.txtEmpPass);
            this.panelEmp.Controls.Add(this.lblEmpPosition);
            this.panelEmp.Controls.Add(this.lblEmpManagerNo);
            this.panelEmp.Controls.Add(this.lblEmpName);
            this.panelEmp.Controls.Add(this.lblEmpNo);
            this.panelEmp.Controls.Add(this.lblEmpStatus);
            this.panelEmp.Controls.Add(this.lblEmpPass);
            this.panelEmp.Controls.Add(this.txtEmpManagerNumber);
            this.panelEmp.Controls.Add(this.txtEmpPosition);
            this.panelEmp.Controls.Add(this.txtEmpName);
            this.panelEmp.Controls.Add(this.txtEmpNo);
            this.panelEmp.Location = new System.Drawing.Point(25, 26);
            this.panelEmp.Margin = new System.Windows.Forms.Padding(4);
            this.panelEmp.Name = "panelEmp";
            this.panelEmp.Size = new System.Drawing.Size(704, 463);
            this.panelEmp.TabIndex = 33;
            // 
            // cnEmpStatus
            // 
            this.cnEmpStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEEBindingSource, "EmpStatus", true));
            this.cnEmpStatus.FormattingEnabled = true;
            this.cnEmpStatus.Items.AddRange(new object[] {
            "Active ",
            "Inactive"});
            this.cnEmpStatus.Location = new System.Drawing.Point(332, 310);
            this.cnEmpStatus.Margin = new System.Windows.Forms.Padding(6);
            this.cnEmpStatus.Name = "cnEmpStatus";
            this.cnEmpStatus.Size = new System.Drawing.Size(334, 50);
            this.cnEmpStatus.TabIndex = 14;
            // 
            // txtEmpPass
            // 
            this.txtEmpPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEEBindingSource, "EmpPassword", true));
            this.txtEmpPass.Location = new System.Drawing.Point(332, 373);
            this.txtEmpPass.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmpPass.Name = "txtEmpPass";
            this.txtEmpPass.PasswordChar = '*';
            this.txtEmpPass.Size = new System.Drawing.Size(334, 50);
            this.txtEmpPass.TabIndex = 12;
            // 
            // lblEmpPosition
            // 
            this.lblEmpPosition.AutoSize = true;
            this.lblEmpPosition.Location = new System.Drawing.Point(24, 177);
            this.lblEmpPosition.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmpPosition.Name = "lblEmpPosition";
            this.lblEmpPosition.Size = new System.Drawing.Size(347, 44);
            this.lblEmpPosition.TabIndex = 2;
            this.lblEmpPosition.Text = "Employee Position:";
            // 
            // lblEmpManagerNo
            // 
            this.lblEmpManagerNo.AutoSize = true;
            this.lblEmpManagerNo.Location = new System.Drawing.Point(24, 256);
            this.lblEmpManagerNo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmpManagerNo.Name = "lblEmpManagerNo";
            this.lblEmpManagerNo.Size = new System.Drawing.Size(507, 44);
            this.lblEmpManagerNo.TabIndex = 3;
            this.lblEmpManagerNo.Text = "Employee Manager Number:";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(28, 112);
            this.lblEmpName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(313, 44);
            this.lblEmpName.TabIndex = 1;
            this.lblEmpName.Text = "Employee Name:";
            // 
            // lblEmpNo
            // 
            this.lblEmpNo.AutoSize = true;
            this.lblEmpNo.Location = new System.Drawing.Point(28, 42);
            this.lblEmpNo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmpNo.Name = "lblEmpNo";
            this.lblEmpNo.Size = new System.Drawing.Size(347, 44);
            this.lblEmpNo.TabIndex = 0;
            this.lblEmpNo.Text = "Employee Number:";
            // 
            // lblEmpStatus
            // 
            this.lblEmpStatus.AutoSize = true;
            this.lblEmpStatus.Location = new System.Drawing.Point(24, 317);
            this.lblEmpStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmpStatus.Name = "lblEmpStatus";
            this.lblEmpStatus.Size = new System.Drawing.Size(319, 44);
            this.lblEmpStatus.TabIndex = 4;
            this.lblEmpStatus.Text = "Employee Status:";
            // 
            // lblEmpPass
            // 
            this.lblEmpPass.AutoSize = true;
            this.lblEmpPass.Location = new System.Drawing.Point(24, 381);
            this.lblEmpPass.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmpPass.Name = "lblEmpPass";
            this.lblEmpPass.Size = new System.Drawing.Size(377, 44);
            this.lblEmpPass.TabIndex = 5;
            this.lblEmpPass.Text = "Employee Password:";
            // 
            // txtEmpManagerNumber
            // 
            this.txtEmpManagerNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEEBindingSource, "EmpManagerNo", true));
            this.txtEmpManagerNumber.Location = new System.Drawing.Point(332, 248);
            this.txtEmpManagerNumber.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmpManagerNumber.Name = "txtEmpManagerNumber";
            this.txtEmpManagerNumber.Size = new System.Drawing.Size(334, 50);
            this.txtEmpManagerNumber.TabIndex = 10;
            // 
            // txtEmpPosition
            // 
            this.txtEmpPosition.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEEBindingSource, "EmpPosition", true));
            this.txtEmpPosition.Location = new System.Drawing.Point(332, 173);
            this.txtEmpPosition.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmpPosition.Name = "txtEmpPosition";
            this.txtEmpPosition.Size = new System.Drawing.Size(334, 50);
            this.txtEmpPosition.TabIndex = 9;
            // 
            // txtEmpName
            // 
            this.txtEmpName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEEBindingSource, "EmpName", true));
            this.txtEmpName.Location = new System.Drawing.Point(332, 108);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(334, 50);
            this.txtEmpName.TabIndex = 8;
            // 
            // txtEmpNo
            // 
            this.txtEmpNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEEBindingSource, "Emp_No", true));
            this.txtEmpNo.Location = new System.Drawing.Point(332, 40);
            this.txtEmpNo.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmpNo.Name = "txtEmpNo";
            this.txtEmpNo.Size = new System.Drawing.Size(334, 50);
            this.txtEmpNo.TabIndex = 7;
            // 
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.dgCustomer);
            this.tabCustomer.Controls.Add(this.btnSaveCust);
            this.tabCustomer.Controls.Add(this.btnEditCust);
            this.tabCustomer.Controls.Add(this.btnNewCust);
            this.tabCustomer.Controls.Add(this.txtCustomerSearch);
            this.tabCustomer.Controls.Add(this.label1);
            this.tabCustomer.Controls.Add(this.panelCustomer);
            this.tabCustomer.Location = new System.Drawing.Point(8, 56);
            this.tabCustomer.Margin = new System.Windows.Forms.Padding(6);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(6);
            this.tabCustomer.Size = new System.Drawing.Size(1560, 824);
            this.tabCustomer.TabIndex = 1;
            this.tabCustomer.Text = "Customer";
            this.tabCustomer.UseVisualStyleBackColor = true;
            // 
            // dgCustomer
            // 
            this.dgCustomer.AutoGenerateColumns = false;
            this.dgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custNoDataGridViewTextBoxColumn,
            this.custNameDataGridViewTextBoxColumn,
            this.custPhoneDataGridViewTextBoxColumn});
            this.dgCustomer.DataSource = this.cUSTOMERBindingSource;
            this.dgCustomer.Location = new System.Drawing.Point(771, 118);
            this.dgCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.dgCustomer.Name = "dgCustomer";
            this.dgCustomer.RowTemplate.Height = 33;
            this.dgCustomer.Size = new System.Drawing.Size(756, 549);
            this.dgCustomer.TabIndex = 32;
            // 
            // custNoDataGridViewTextBoxColumn
            // 
            this.custNoDataGridViewTextBoxColumn.DataPropertyName = "CustNo";
            this.custNoDataGridViewTextBoxColumn.HeaderText = "CustNo";
            this.custNoDataGridViewTextBoxColumn.Name = "custNoDataGridViewTextBoxColumn";
            // 
            // custNameDataGridViewTextBoxColumn
            // 
            this.custNameDataGridViewTextBoxColumn.DataPropertyName = "CustName";
            this.custNameDataGridViewTextBoxColumn.HeaderText = "CustName";
            this.custNameDataGridViewTextBoxColumn.Name = "custNameDataGridViewTextBoxColumn";
            this.custNameDataGridViewTextBoxColumn.Width = 378;
            // 
            // custPhoneDataGridViewTextBoxColumn
            // 
            this.custPhoneDataGridViewTextBoxColumn.DataPropertyName = "CustPhone";
            this.custPhoneDataGridViewTextBoxColumn.HeaderText = "CustPhone";
            this.custPhoneDataGridViewTextBoxColumn.Name = "custPhoneDataGridViewTextBoxColumn";
            this.custPhoneDataGridViewTextBoxColumn.Width = 200;
            // 
            // btnSaveCust
            // 
            this.btnSaveCust.Location = new System.Drawing.Point(575, 694);
            this.btnSaveCust.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveCust.Name = "btnSaveCust";
            this.btnSaveCust.Size = new System.Drawing.Size(150, 75);
            this.btnSaveCust.TabIndex = 31;
            this.btnSaveCust.Text = "Save";
            this.btnSaveCust.UseVisualStyleBackColor = true;
            // 
            // btnEditCust
            // 
            this.btnEditCust.Location = new System.Drawing.Point(295, 694);
            this.btnEditCust.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditCust.Name = "btnEditCust";
            this.btnEditCust.Size = new System.Drawing.Size(150, 75);
            this.btnEditCust.TabIndex = 30;
            this.btnEditCust.Text = "Edit";
            this.btnEditCust.UseVisualStyleBackColor = true;
            // 
            // btnNewCust
            // 
            this.btnNewCust.Location = new System.Drawing.Point(21, 694);
            this.btnNewCust.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewCust.Name = "btnNewCust";
            this.btnNewCust.Size = new System.Drawing.Size(150, 75);
            this.btnNewCust.TabIndex = 29;
            this.btnNewCust.Text = "New";
            this.btnNewCust.UseVisualStyleBackColor = true;
            // 
            // txtCustomerSearch
            // 
            this.txtCustomerSearch.Location = new System.Drawing.Point(961, 61);
            this.txtCustomerSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtCustomerSearch.Name = "txtCustomerSearch";
            this.txtCustomerSearch.Size = new System.Drawing.Size(564, 50);
            this.txtCustomerSearch.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(765, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 44);
            this.label1.TabIndex = 26;
            this.label1.Text = "Search Customer:";
            // 
            // panelCustomer
            // 
            this.panelCustomer.Controls.Add(this.txtBillPostalCode);
            this.panelCustomer.Controls.Add(this.label6);
            this.panelCustomer.Controls.Add(this.txtBillCity);
            this.panelCustomer.Controls.Add(this.txtCustomerNo);
            this.panelCustomer.Controls.Add(this.txtBillStreet);
            this.panelCustomer.Controls.Add(this.lblCustNo);
            this.panelCustomer.Controls.Add(this.txtCustomerPostal);
            this.panelCustomer.Controls.Add(this.lblCustName);
            this.panelCustomer.Controls.Add(this.txtCustomerCity);
            this.panelCustomer.Controls.Add(this.lblCustPhone);
            this.panelCustomer.Controls.Add(this.txtCustomerStreet);
            this.panelCustomer.Controls.Add(this.lblCustShipStreetAddress);
            this.panelCustomer.Controls.Add(this.txtCustomerPhone);
            this.panelCustomer.Controls.Add(this.lblCustShipCity);
            this.panelCustomer.Controls.Add(this.txtCustomerName);
            this.panelCustomer.Controls.Add(this.lblCustShipPostalCode);
            this.panelCustomer.Controls.Add(this.lblCustBillStreetAddress);
            this.panelCustomer.Controls.Add(this.lblCustBillCity);
            this.panelCustomer.Location = new System.Drawing.Point(21, 20);
            this.panelCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(704, 647);
            this.panelCustomer.TabIndex = 27;
            // 
            // txtBillPostalCode
            // 
            this.txtBillPostalCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CustBillPostalCode", true));
            this.txtBillPostalCode.Location = new System.Drawing.Point(332, 578);
            this.txtBillPostalCode.Margin = new System.Windows.Forms.Padding(6);
            this.txtBillPostalCode.Name = "txtBillPostalCode";
            this.txtBillPostalCode.Size = new System.Drawing.Size(334, 50);
            this.txtBillPostalCode.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 586);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(464, 44);
            this.label6.TabIndex = 16;
            this.label6.Text = "Customer Bill Postal Code";
            // 
            // txtBillCity
            // 
            this.txtBillCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CustBillCity", true));
            this.txtBillCity.Location = new System.Drawing.Point(332, 521);
            this.txtBillCity.Margin = new System.Windows.Forms.Padding(6);
            this.txtBillCity.Name = "txtBillCity";
            this.txtBillCity.Size = new System.Drawing.Size(334, 50);
            this.txtBillCity.TabIndex = 15;
            // 
            // txtCustomerNo
            // 
            this.txtCustomerNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CustNo", true));
            this.txtCustomerNo.Location = new System.Drawing.Point(332, 40);
            this.txtCustomerNo.Margin = new System.Windows.Forms.Padding(6);
            this.txtCustomerNo.Name = "txtCustomerNo";
            this.txtCustomerNo.Size = new System.Drawing.Size(334, 50);
            this.txtCustomerNo.TabIndex = 8;
            // 
            // txtBillStreet
            // 
            this.txtBillStreet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CustBillStreetAddress", true));
            this.txtBillStreet.Location = new System.Drawing.Point(332, 448);
            this.txtBillStreet.Margin = new System.Windows.Forms.Padding(6);
            this.txtBillStreet.Name = "txtBillStreet";
            this.txtBillStreet.Size = new System.Drawing.Size(334, 50);
            this.txtBillStreet.TabIndex = 14;
            // 
            // lblCustNo
            // 
            this.lblCustNo.AutoSize = true;
            this.lblCustNo.Location = new System.Drawing.Point(24, 46);
            this.lblCustNo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCustNo.Name = "lblCustNo";
            this.lblCustNo.Size = new System.Drawing.Size(266, 44);
            this.lblCustNo.TabIndex = 0;
            this.lblCustNo.Text = "Customer No.:";
            // 
            // txtCustomerPostal
            // 
            this.txtCustomerPostal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CustShipPostalCode", true));
            this.txtCustomerPostal.Location = new System.Drawing.Point(332, 373);
            this.txtCustomerPostal.Margin = new System.Windows.Forms.Padding(6);
            this.txtCustomerPostal.Name = "txtCustomerPostal";
            this.txtCustomerPostal.Size = new System.Drawing.Size(334, 50);
            this.txtCustomerPostal.TabIndex = 13;
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(24, 113);
            this.lblCustName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(309, 44);
            this.lblCustName.TabIndex = 1;
            this.lblCustName.Text = "Customer Name:";
            // 
            // txtCustomerCity
            // 
            this.txtCustomerCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CustShipCity", true));
            this.txtCustomerCity.Location = new System.Drawing.Point(332, 312);
            this.txtCustomerCity.Margin = new System.Windows.Forms.Padding(6);
            this.txtCustomerCity.Name = "txtCustomerCity";
            this.txtCustomerCity.Size = new System.Drawing.Size(334, 50);
            this.txtCustomerCity.TabIndex = 12;
            // 
            // lblCustPhone
            // 
            this.lblCustPhone.AutoSize = true;
            this.lblCustPhone.Location = new System.Drawing.Point(24, 181);
            this.lblCustPhone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCustPhone.Name = "lblCustPhone";
            this.lblCustPhone.Size = new System.Drawing.Size(316, 44);
            this.lblCustPhone.TabIndex = 2;
            this.lblCustPhone.Text = "Customer Phone:";
            // 
            // txtCustomerStreet
            // 
            this.txtCustomerStreet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CustShipStreetAddress", true));
            this.txtCustomerStreet.Location = new System.Drawing.Point(332, 248);
            this.txtCustomerStreet.Margin = new System.Windows.Forms.Padding(6);
            this.txtCustomerStreet.Name = "txtCustomerStreet";
            this.txtCustomerStreet.Size = new System.Drawing.Size(334, 50);
            this.txtCustomerStreet.TabIndex = 11;
            // 
            // lblCustShipStreetAddress
            // 
            this.lblCustShipStreetAddress.AutoSize = true;
            this.lblCustShipStreetAddress.Location = new System.Drawing.Point(24, 256);
            this.lblCustShipStreetAddress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCustShipStreetAddress.Name = "lblCustShipStreetAddress";
            this.lblCustShipStreetAddress.Size = new System.Drawing.Size(544, 44);
            this.lblCustShipStreetAddress.TabIndex = 3;
            this.lblCustShipStreetAddress.Text = "Customer Ship Street Address:";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CustPhone", true));
            this.txtCustomerPhone.Location = new System.Drawing.Point(332, 173);
            this.txtCustomerPhone.Margin = new System.Windows.Forms.Padding(6);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(334, 50);
            this.txtCustomerPhone.TabIndex = 10;
            // 
            // lblCustShipCity
            // 
            this.lblCustShipCity.AutoSize = true;
            this.lblCustShipCity.Location = new System.Drawing.Point(24, 317);
            this.lblCustShipCity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCustShipCity.Name = "lblCustShipCity";
            this.lblCustShipCity.Size = new System.Drawing.Size(359, 44);
            this.lblCustShipCity.TabIndex = 4;
            this.lblCustShipCity.Text = "Customer Ship City:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CustName", true));
            this.txtCustomerName.Location = new System.Drawing.Point(332, 108);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(6);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(334, 50);
            this.txtCustomerName.TabIndex = 9;
            // 
            // lblCustShipPostalCode
            // 
            this.lblCustShipPostalCode.AutoSize = true;
            this.lblCustShipPostalCode.Location = new System.Drawing.Point(24, 381);
            this.lblCustShipPostalCode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCustShipPostalCode.Name = "lblCustShipPostalCode";
            this.lblCustShipPostalCode.Size = new System.Drawing.Size(499, 44);
            this.lblCustShipPostalCode.TabIndex = 5;
            this.lblCustShipPostalCode.Text = "Customer Ship Postal Code:";
            // 
            // lblCustBillStreetAddress
            // 
            this.lblCustBillStreetAddress.AutoSize = true;
            this.lblCustBillStreetAddress.Location = new System.Drawing.Point(24, 456);
            this.lblCustBillStreetAddress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCustBillStreetAddress.Name = "lblCustBillStreetAddress";
            this.lblCustBillStreetAddress.Size = new System.Drawing.Size(520, 44);
            this.lblCustBillStreetAddress.TabIndex = 6;
            this.lblCustBillStreetAddress.Text = "Customer Bill Street Address:";
            // 
            // lblCustBillCity
            // 
            this.lblCustBillCity.AutoSize = true;
            this.lblCustBillCity.Location = new System.Drawing.Point(26, 529);
            this.lblCustBillCity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCustBillCity.Name = "lblCustBillCity";
            this.lblCustBillCity.Size = new System.Drawing.Size(324, 44);
            this.lblCustBillCity.TabIndex = 7;
            this.lblCustBillCity.Text = "Customer Bill City";
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.dgProduct);
            this.tabProduct.Controls.Add(this.txtProductSearch);
            this.tabProduct.Controls.Add(this.label2);
            this.tabProduct.Controls.Add(this.btnSaveProd);
            this.tabProduct.Controls.Add(this.btnEditProd);
            this.tabProduct.Controls.Add(this.btnNewProd);
            this.tabProduct.Controls.Add(this.panelProd);
            this.tabProduct.Location = new System.Drawing.Point(8, 56);
            this.tabProduct.Margin = new System.Windows.Forms.Padding(6);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(6);
            this.tabProduct.Size = new System.Drawing.Size(1560, 824);
            this.tabProduct.TabIndex = 2;
            this.tabProduct.Text = "Product";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // dgProduct
            // 
            this.dgProduct.AutoGenerateColumns = false;
            this.dgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodCodeDataGridViewTextBoxColumn,
            this.prodDescriptionDataGridViewTextBoxColumn});
            this.dgProduct.DataSource = this.pRODUCTBindingSource;
            this.dgProduct.Location = new System.Drawing.Point(775, 116);
            this.dgProduct.Margin = new System.Windows.Forms.Padding(4);
            this.dgProduct.Name = "dgProduct";
            this.dgProduct.RowTemplate.Height = 33;
            this.dgProduct.Size = new System.Drawing.Size(756, 481);
            this.dgProduct.TabIndex = 38;
            // 
            // prodCodeDataGridViewTextBoxColumn
            // 
            this.prodCodeDataGridViewTextBoxColumn.DataPropertyName = "ProdCode";
            this.prodCodeDataGridViewTextBoxColumn.HeaderText = "ProdCode";
            this.prodCodeDataGridViewTextBoxColumn.Name = "prodCodeDataGridViewTextBoxColumn";
            // 
            // prodDescriptionDataGridViewTextBoxColumn
            // 
            this.prodDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProdDescription";
            this.prodDescriptionDataGridViewTextBoxColumn.HeaderText = "ProdDescription";
            this.prodDescriptionDataGridViewTextBoxColumn.Name = "prodDescriptionDataGridViewTextBoxColumn";
            this.prodDescriptionDataGridViewTextBoxColumn.Width = 578;
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Location = new System.Drawing.Point(967, 59);
            this.txtProductSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(564, 50);
            this.txtProductSearch.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(771, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 44);
            this.label2.TabIndex = 36;
            this.label2.Text = "Search Product:";
            // 
            // btnSaveProd
            // 
            this.btnSaveProd.Location = new System.Drawing.Point(575, 630);
            this.btnSaveProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveProd.Name = "btnSaveProd";
            this.btnSaveProd.Size = new System.Drawing.Size(150, 75);
            this.btnSaveProd.TabIndex = 35;
            this.btnSaveProd.Text = "Save";
            this.btnSaveProd.UseVisualStyleBackColor = true;
            // 
            // btnEditProd
            // 
            this.btnEditProd.Location = new System.Drawing.Point(295, 630);
            this.btnEditProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditProd.Name = "btnEditProd";
            this.btnEditProd.Size = new System.Drawing.Size(150, 75);
            this.btnEditProd.TabIndex = 34;
            this.btnEditProd.Text = "Edit";
            this.btnEditProd.UseVisualStyleBackColor = true;
            // 
            // btnNewProd
            // 
            this.btnNewProd.Location = new System.Drawing.Point(23, 630);
            this.btnNewProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewProd.Name = "btnNewProd";
            this.btnNewProd.Size = new System.Drawing.Size(150, 75);
            this.btnNewProd.TabIndex = 33;
            this.btnNewProd.Text = "New";
            this.btnNewProd.UseVisualStyleBackColor = true;
            // 
            // panelProd
            // 
            this.panelProd.Controls.Add(this.txtProdNo);
            this.panelProd.Controls.Add(this.txtProdDescription);
            this.panelProd.Controls.Add(this.lblProdStatus);
            this.panelProd.Controls.Add(this.cbProdStatus);
            this.panelProd.Controls.Add(this.lblProdReorderPoint);
            this.panelProd.Controls.Add(this.txtProdCode);
            this.panelProd.Controls.Add(this.lblProdQty);
            this.panelProd.Controls.Add(this.txtProdReorderPoint);
            this.panelProd.Controls.Add(this.lblProdPrice);
            this.panelProd.Controls.Add(this.txtProdCategory);
            this.panelProd.Controls.Add(this.lblProdCarModelYear);
            this.panelProd.Controls.Add(this.txtProdQuantity);
            this.panelProd.Controls.Add(this.txtProdPrice);
            this.panelProd.Controls.Add(this.lblProdCarMake);
            this.panelProd.Controls.Add(this.lblProdNo);
            this.panelProd.Controls.Add(this.lblProdCode);
            this.panelProd.Location = new System.Drawing.Point(23, 22);
            this.panelProd.Margin = new System.Windows.Forms.Padding(4);
            this.panelProd.Name = "panelProd";
            this.panelProd.Size = new System.Drawing.Size(704, 575);
            this.panelProd.TabIndex = 32;
            // 
            // txtProdNo
            // 
            this.txtProdNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "ProdNo", true));
            this.txtProdNo.Location = new System.Drawing.Point(316, 37);
            this.txtProdNo.Margin = new System.Windows.Forms.Padding(6);
            this.txtProdNo.Name = "txtProdNo";
            this.txtProdNo.Size = new System.Drawing.Size(362, 50);
            this.txtProdNo.TabIndex = 10;
            // 
            // txtProdDescription
            // 
            this.txtProdDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "ProdDescription", true));
            this.txtProdDescription.Location = new System.Drawing.Point(316, 146);
            this.txtProdDescription.Margin = new System.Windows.Forms.Padding(6);
            this.txtProdDescription.Name = "txtProdDescription";
            this.txtProdDescription.Size = new System.Drawing.Size(362, 50);
            this.txtProdDescription.TabIndex = 12;
            // 
            // lblProdStatus
            // 
            this.lblProdStatus.AutoSize = true;
            this.lblProdStatus.Location = new System.Drawing.Point(30, 421);
            this.lblProdStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProdStatus.Name = "lblProdStatus";
            this.lblProdStatus.Size = new System.Drawing.Size(139, 44);
            this.lblProdStatus.TabIndex = 8;
            this.lblProdStatus.Text = "Status:";
            // 
            // cbProdStatus
            // 
            this.cbProdStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "ProdStatus", true));
            this.cbProdStatus.FormattingEnabled = true;
            this.cbProdStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cbProdStatus.Location = new System.Drawing.Point(316, 419);
            this.cbProdStatus.Margin = new System.Windows.Forms.Padding(6);
            this.cbProdStatus.Name = "cbProdStatus";
            this.cbProdStatus.Size = new System.Drawing.Size(362, 50);
            this.cbProdStatus.TabIndex = 18;
            // 
            // lblProdReorderPoint
            // 
            this.lblProdReorderPoint.AutoSize = true;
            this.lblProdReorderPoint.Location = new System.Drawing.Point(30, 369);
            this.lblProdReorderPoint.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProdReorderPoint.Name = "lblProdReorderPoint";
            this.lblProdReorderPoint.Size = new System.Drawing.Size(278, 44);
            this.lblProdReorderPoint.TabIndex = 7;
            this.lblProdReorderPoint.Text = "Re-order Point:";
            // 
            // txtProdCode
            // 
            this.txtProdCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "ProdCode", true));
            this.txtProdCode.Location = new System.Drawing.Point(316, 92);
            this.txtProdCode.Margin = new System.Windows.Forms.Padding(6);
            this.txtProdCode.Name = "txtProdCode";
            this.txtProdCode.Size = new System.Drawing.Size(362, 50);
            this.txtProdCode.TabIndex = 13;
            // 
            // lblProdQty
            // 
            this.lblProdQty.AutoSize = true;
            this.lblProdQty.Location = new System.Drawing.Point(30, 313);
            this.lblProdQty.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProdQty.Name = "lblProdQty";
            this.lblProdQty.Size = new System.Drawing.Size(315, 44);
            this.lblProdQty.TabIndex = 6;
            this.lblProdQty.Text = "Product Quantity:";
            // 
            // txtProdReorderPoint
            // 
            this.txtProdReorderPoint.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "ProdReorderPoint", true));
            this.txtProdReorderPoint.Location = new System.Drawing.Point(316, 367);
            this.txtProdReorderPoint.Margin = new System.Windows.Forms.Padding(6);
            this.txtProdReorderPoint.Name = "txtProdReorderPoint";
            this.txtProdReorderPoint.Size = new System.Drawing.Size(362, 50);
            this.txtProdReorderPoint.TabIndex = 17;
            // 
            // lblProdPrice
            // 
            this.lblProdPrice.AutoSize = true;
            this.lblProdPrice.Location = new System.Drawing.Point(30, 254);
            this.lblProdPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProdPrice.Name = "lblProdPrice";
            this.lblProdPrice.Size = new System.Drawing.Size(259, 44);
            this.lblProdPrice.TabIndex = 5;
            this.lblProdPrice.Text = "Product Price:";
            // 
            // txtProdCategory
            // 
            this.txtProdCategory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "ProdCategory", true));
            this.txtProdCategory.Location = new System.Drawing.Point(316, 198);
            this.txtProdCategory.Margin = new System.Windows.Forms.Padding(6);
            this.txtProdCategory.Name = "txtProdCategory";
            this.txtProdCategory.Size = new System.Drawing.Size(362, 50);
            this.txtProdCategory.TabIndex = 14;
            // 
            // lblProdCarModelYear
            // 
            this.lblProdCarModelYear.AutoSize = true;
            this.lblProdCarModelYear.Location = new System.Drawing.Point(30, 202);
            this.lblProdCarModelYear.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProdCarModelYear.Name = "lblProdCarModelYear";
            this.lblProdCarModelYear.Size = new System.Drawing.Size(326, 44);
            this.lblProdCarModelYear.TabIndex = 4;
            this.lblProdCarModelYear.Text = "Product Category:";
            // 
            // txtProdQuantity
            // 
            this.txtProdQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "ProdQty", true));
            this.txtProdQuantity.Location = new System.Drawing.Point(316, 310);
            this.txtProdQuantity.Margin = new System.Windows.Forms.Padding(6);
            this.txtProdQuantity.Name = "txtProdQuantity";
            this.txtProdQuantity.Size = new System.Drawing.Size(362, 50);
            this.txtProdQuantity.TabIndex = 16;
            // 
            // txtProdPrice
            // 
            this.txtProdPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "ProdPrice", true));
            this.txtProdPrice.Location = new System.Drawing.Point(316, 250);
            this.txtProdPrice.Margin = new System.Windows.Forms.Padding(6);
            this.txtProdPrice.Name = "txtProdPrice";
            this.txtProdPrice.Size = new System.Drawing.Size(362, 50);
            this.txtProdPrice.TabIndex = 15;
            // 
            // lblProdCarMake
            // 
            this.lblProdCarMake.AutoSize = true;
            this.lblProdCarMake.Location = new System.Drawing.Point(30, 150);
            this.lblProdCarMake.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProdCarMake.Name = "lblProdCarMake";
            this.lblProdCarMake.Size = new System.Drawing.Size(363, 44);
            this.lblProdCarMake.TabIndex = 2;
            this.lblProdCarMake.Text = "Product Description:";
            // 
            // lblProdNo
            // 
            this.lblProdNo.AutoSize = true;
            this.lblProdNo.Location = new System.Drawing.Point(30, 40);
            this.lblProdNo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProdNo.Name = "lblProdNo";
            this.lblProdNo.Size = new System.Drawing.Size(308, 44);
            this.lblProdNo.TabIndex = 0;
            this.lblProdNo.Text = "Product Number:";
            // 
            // lblProdCode
            // 
            this.lblProdCode.AutoSize = true;
            this.lblProdCode.Location = new System.Drawing.Point(30, 94);
            this.lblProdCode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProdCode.Name = "lblProdCode";
            this.lblProdCode.Size = new System.Drawing.Size(262, 44);
            this.lblProdCode.TabIndex = 1;
            this.lblProdCode.Text = "Product Code:";
            // 
            // tabOrder
            // 
            this.tabOrder.Controls.Add(this.btnInvoice);
            this.tabOrder.Controls.Add(this.dgProductInvoice);
            this.tabOrder.Controls.Add(this.txtInvoiceProd);
            this.tabOrder.Controls.Add(this.label5);
            this.tabOrder.Controls.Add(this.dgCustInvoice);
            this.tabOrder.Controls.Add(this.txtInvoiceCust);
            this.tabOrder.Controls.Add(this.label4);
            this.tabOrder.Controls.Add(this.label3);
            this.tabOrder.Controls.Add(this.dgEmpInvoice);
            this.tabOrder.Controls.Add(this.txtInvoiceEmp);
            this.tabOrder.Location = new System.Drawing.Point(8, 56);
            this.tabOrder.Margin = new System.Windows.Forms.Padding(6);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Padding = new System.Windows.Forms.Padding(6);
            this.tabOrder.Size = new System.Drawing.Size(1560, 824);
            this.tabOrder.TabIndex = 3;
            this.tabOrder.Text = "Order";
            this.tabOrder.UseVisualStyleBackColor = true;
            // 
            // btnInvoice
            // 
            this.btnInvoice.Location = new System.Drawing.Point(1291, 550);
            this.btnInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(150, 75);
            this.btnInvoice.TabIndex = 52;
            this.btnInvoice.Text = "Generate Invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // dgProductInvoice
            // 
            this.dgProductInvoice.AutoGenerateColumns = false;
            this.dgProductInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodCodeDataGridViewTextBoxColumn1,
            this.prodDescriptionDataGridViewTextBoxColumn1,
            this.ProdPrice});
            this.dgProductInvoice.DataSource = this.pRODUCTBindingSource;
            this.dgProductInvoice.Location = new System.Drawing.Point(27, 396);
            this.dgProductInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.dgProductInvoice.Name = "dgProductInvoice";
            this.dgProductInvoice.RowTemplate.Height = 33;
            this.dgProductInvoice.Size = new System.Drawing.Size(610, 229);
            this.dgProductInvoice.TabIndex = 51;
            // 
            // prodCodeDataGridViewTextBoxColumn1
            // 
            this.prodCodeDataGridViewTextBoxColumn1.DataPropertyName = "ProdCode";
            this.prodCodeDataGridViewTextBoxColumn1.HeaderText = "ProdCode";
            this.prodCodeDataGridViewTextBoxColumn1.Name = "prodCodeDataGridViewTextBoxColumn1";
            // 
            // prodDescriptionDataGridViewTextBoxColumn1
            // 
            this.prodDescriptionDataGridViewTextBoxColumn1.DataPropertyName = "ProdDescription";
            this.prodDescriptionDataGridViewTextBoxColumn1.HeaderText = "ProdDescription";
            this.prodDescriptionDataGridViewTextBoxColumn1.Name = "prodDescriptionDataGridViewTextBoxColumn1";
            this.prodDescriptionDataGridViewTextBoxColumn1.Width = 330;
            // 
            // ProdPrice
            // 
            this.ProdPrice.DataPropertyName = "ProdPrice";
            this.ProdPrice.HeaderText = "ProdPrice";
            this.ProdPrice.Name = "ProdPrice";
            // 
            // txtInvoiceProd
            // 
            this.txtInvoiceProd.Location = new System.Drawing.Point(219, 336);
            this.txtInvoiceProd.Margin = new System.Windows.Forms.Padding(6);
            this.txtInvoiceProd.Name = "txtInvoiceProd";
            this.txtInvoiceProd.Size = new System.Drawing.Size(420, 50);
            this.txtInvoiceProd.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 340);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 44);
            this.label5.TabIndex = 49;
            this.label5.Text = "Select Product:";
            // 
            // dgCustInvoice
            // 
            this.dgCustInvoice.AutoGenerateColumns = false;
            this.dgCustInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custNoDataGridViewTextBoxColumn1,
            this.custNameDataGridViewTextBoxColumn1,
            this.custPhoneDataGridViewTextBoxColumn1});
            this.dgCustInvoice.DataSource = this.cUSTOMERBindingSource;
            this.dgCustInvoice.Location = new System.Drawing.Point(831, 84);
            this.dgCustInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.dgCustInvoice.Name = "dgCustInvoice";
            this.dgCustInvoice.RowTemplate.Height = 33;
            this.dgCustInvoice.Size = new System.Drawing.Size(610, 192);
            this.dgCustInvoice.TabIndex = 48;
            // 
            // custNoDataGridViewTextBoxColumn1
            // 
            this.custNoDataGridViewTextBoxColumn1.DataPropertyName = "CustNo";
            this.custNoDataGridViewTextBoxColumn1.HeaderText = "CustNo";
            this.custNoDataGridViewTextBoxColumn1.Name = "custNoDataGridViewTextBoxColumn1";
            // 
            // custNameDataGridViewTextBoxColumn1
            // 
            this.custNameDataGridViewTextBoxColumn1.DataPropertyName = "CustName";
            this.custNameDataGridViewTextBoxColumn1.HeaderText = "CustName";
            this.custNameDataGridViewTextBoxColumn1.Name = "custNameDataGridViewTextBoxColumn1";
            this.custNameDataGridViewTextBoxColumn1.Width = 310;
            // 
            // custPhoneDataGridViewTextBoxColumn1
            // 
            this.custPhoneDataGridViewTextBoxColumn1.DataPropertyName = "CustPhone";
            this.custPhoneDataGridViewTextBoxColumn1.HeaderText = "CustPhone";
            this.custPhoneDataGridViewTextBoxColumn1.Name = "custPhoneDataGridViewTextBoxColumn1";
            this.custPhoneDataGridViewTextBoxColumn1.Width = 120;
            // 
            // txtInvoiceCust
            // 
            this.txtInvoiceCust.Location = new System.Drawing.Point(1023, 27);
            this.txtInvoiceCust.Margin = new System.Windows.Forms.Padding(6);
            this.txtInvoiceCust.Name = "txtInvoiceCust";
            this.txtInvoiceCust.Size = new System.Drawing.Size(420, 50);
            this.txtInvoiceCust.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(827, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 44);
            this.label4.TabIndex = 46;
            this.label4.Text = "Select Customer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 44);
            this.label3.TabIndex = 45;
            this.label3.Text = "Select Employee:";
            // 
            // dgEmpInvoice
            // 
            this.dgEmpInvoice.AutoGenerateColumns = false;
            this.dgEmpInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empNoDataGridViewTextBoxColumn1,
            this.empNameDataGridViewTextBoxColumn1,
            this.empPositionDataGridViewTextBoxColumn});
            this.dgEmpInvoice.DataSource = this.eMPLOYEEBindingSource;
            this.dgEmpInvoice.Location = new System.Drawing.Point(27, 84);
            this.dgEmpInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.dgEmpInvoice.Name = "dgEmpInvoice";
            this.dgEmpInvoice.RowTemplate.Height = 33;
            this.dgEmpInvoice.Size = new System.Drawing.Size(610, 192);
            this.dgEmpInvoice.TabIndex = 44;
            // 
            // empNoDataGridViewTextBoxColumn1
            // 
            this.empNoDataGridViewTextBoxColumn1.DataPropertyName = "Emp_No";
            this.empNoDataGridViewTextBoxColumn1.HeaderText = "Emp_No";
            this.empNoDataGridViewTextBoxColumn1.Name = "empNoDataGridViewTextBoxColumn1";
            // 
            // empNameDataGridViewTextBoxColumn1
            // 
            this.empNameDataGridViewTextBoxColumn1.DataPropertyName = "EmpName";
            this.empNameDataGridViewTextBoxColumn1.HeaderText = "EmpName";
            this.empNameDataGridViewTextBoxColumn1.Name = "empNameDataGridViewTextBoxColumn1";
            this.empNameDataGridViewTextBoxColumn1.Width = 320;
            // 
            // empPositionDataGridViewTextBoxColumn
            // 
            this.empPositionDataGridViewTextBoxColumn.DataPropertyName = "EmpPosition";
            this.empPositionDataGridViewTextBoxColumn.HeaderText = "EmpPosition";
            this.empPositionDataGridViewTextBoxColumn.Name = "empPositionDataGridViewTextBoxColumn";
            this.empPositionDataGridViewTextBoxColumn.Width = 110;
            // 
            // txtInvoiceEmp
            // 
            this.txtInvoiceEmp.Location = new System.Drawing.Point(219, 27);
            this.txtInvoiceEmp.Margin = new System.Windows.Forms.Padding(6);
            this.txtInvoiceEmp.Name = "txtInvoiceEmp";
            this.txtInvoiceEmp.Size = new System.Drawing.Size(420, 50);
            this.txtInvoiceEmp.TabIndex = 43;
            // 
            // tabInvoice
            // 
            this.tabInvoice.Controls.Add(this.rvInvoice);
            this.tabInvoice.Controls.Add(this.button1);
            this.tabInvoice.Controls.Add(this.button2);
            this.tabInvoice.Location = new System.Drawing.Point(8, 56);
            this.tabInvoice.Name = "tabInvoice";
            this.tabInvoice.Size = new System.Drawing.Size(1560, 824);
            this.tabInvoice.TabIndex = 6;
            this.tabInvoice.Text = "Invoice";
            this.tabInvoice.UseVisualStyleBackColor = true;
            // 
            // rvInvoice
            // 
            reportDataSource1.Name = "Cust";
            reportDataSource1.Value = this.cUSTOMERBindingSource;
            reportDataSource2.Name = "prod";
            reportDataSource2.Value = this.pRODUCTBindingSource;
            reportDataSource3.Name = "emp";
            reportDataSource3.Value = this.eMPLOYEEBindingSource;
            this.rvInvoice.LocalReport.DataSources.Add(reportDataSource1);
            this.rvInvoice.LocalReport.DataSources.Add(reportDataSource2);
            this.rvInvoice.LocalReport.DataSources.Add(reportDataSource3);
            this.rvInvoice.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Invoice.rdlc";
            this.rvInvoice.Location = new System.Drawing.Point(251, 135);
            this.rvInvoice.Name = "rvInvoice";
            this.rvInvoice.ServerReport.BearerToken = null;
            this.rvInvoice.Size = new System.Drawing.Size(1026, 597);
            this.rvInvoice.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1275, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 75);
            this.button1.TabIndex = 36;
            this.button1.Text = "Print Invoice";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 24);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 75);
            this.button2.TabIndex = 35;
            this.button2.Text = "New Order";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Capture1;
            this.pictureBox1.Location = new System.Drawing.Point(1342, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblFoot
            // 
            this.lblFoot.AutoSize = true;
            this.lblFoot.Location = new System.Drawing.Point(16, 1062);
            this.lblFoot.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFoot.Name = "lblFoot";
            this.lblFoot.Size = new System.Drawing.Size(608, 51);
            this.lblFoot.TabIndex = 3;
            this.lblFoot.Text = "All Rights Reserved ECS 2018";
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // empNoDataGridViewTextBoxColumn
            // 
            this.empNoDataGridViewTextBoxColumn.DataPropertyName = "Emp_No";
            this.empNoDataGridViewTextBoxColumn.HeaderText = "Emp_No";
            this.empNoDataGridViewTextBoxColumn.Name = "empNoDataGridViewTextBoxColumn";
            // 
            // empNameDataGridViewTextBoxColumn
            // 
            this.empNameDataGridViewTextBoxColumn.DataPropertyName = "EmpName";
            this.empNameDataGridViewTextBoxColumn.HeaderText = "EmpName";
            this.empNameDataGridViewTextBoxColumn.Name = "empNameDataGridViewTextBoxColumn";
            this.empNameDataGridViewTextBoxColumn.Width = 578;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1589, 1127);
            this.Controls.Add(this.lblFoot);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "PCS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabEmployee.ResumeLayout(false);
            this.tabEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).EndInit();
            this.panelEmp.ResumeLayout(false);
            this.panelEmp.PerformLayout();
            this.tabCustomer.ResumeLayout(false);
            this.tabCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).EndInit();
            this.panelCustomer.ResumeLayout(false);
            this.panelCustomer.PerformLayout();
            this.tabProduct.ResumeLayout(false);
            this.tabProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).EndInit();
            this.panelProd.ResumeLayout(false);
            this.panelProd.PerformLayout();
            this.tabOrder.ResumeLayout(false);
            this.tabOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpInvoice)).EndInit();
            this.tabInvoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.TabPage tabOrder;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEmp_no;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmp_no;
        private System.Windows.Forms.Label lblEmpPassword;
        private System.Windows.Forms.TextBox txtEmpPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblFoot;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgEmployee;
        private System.Windows.Forms.Button btnSaveEmp;
        private System.Windows.Forms.Button btnEditEmp;
        private System.Windows.Forms.Button btnNewEmp;
        private System.Windows.Forms.TextBox txtEmpSearch;
        private System.Windows.Forms.Panel panelEmp;
        private System.Windows.Forms.ComboBox cnEmpStatus;
        private System.Windows.Forms.TextBox txtEmpPass;
        private System.Windows.Forms.Label lblEmpPosition;
        private System.Windows.Forms.Label lblEmpManagerNo;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblEmpNo;
        private System.Windows.Forms.Label lblEmpStatus;
        private System.Windows.Forms.Label lblEmpPass;
        private System.Windows.Forms.TextBox txtEmpManagerNumber;
        private System.Windows.Forms.TextBox txtEmpPosition;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpNo;
        private System.Windows.Forms.DataGridView dgCustomer;
        private System.Windows.Forms.Button btnSaveCust;
        private System.Windows.Forms.Button btnEditCust;
        private System.Windows.Forms.Button btnNewCust;
        private System.Windows.Forms.TextBox txtCustomerSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.TextBox txtBillCity;
        private System.Windows.Forms.TextBox txtCustomerNo;
        private System.Windows.Forms.TextBox txtBillStreet;
        private System.Windows.Forms.Label lblCustNo;
        private System.Windows.Forms.TextBox txtCustomerPostal;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.TextBox txtCustomerCity;
        private System.Windows.Forms.Label lblCustPhone;
        private System.Windows.Forms.TextBox txtCustomerStreet;
        private System.Windows.Forms.Label lblCustShipStreetAddress;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label lblCustShipCity;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustShipPostalCode;
        private System.Windows.Forms.Label lblCustBillStreetAddress;
        private System.Windows.Forms.Label lblCustBillCity;
        private System.Windows.Forms.DataGridView dgProduct;
        private System.Windows.Forms.TextBox txtProductSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveProd;
        private System.Windows.Forms.Button btnEditProd;
        private System.Windows.Forms.Button btnNewProd;
        private System.Windows.Forms.Panel panelProd;
        private System.Windows.Forms.TextBox txtProdNo;
        private System.Windows.Forms.TextBox txtProdDescription;
        private System.Windows.Forms.Label lblProdStatus;
        private System.Windows.Forms.ComboBox cbProdStatus;
        private System.Windows.Forms.Label lblProdReorderPoint;
        private System.Windows.Forms.TextBox txtProdCode;
        private System.Windows.Forms.Label lblProdQty;
        private System.Windows.Forms.TextBox txtProdReorderPoint;
        private System.Windows.Forms.Label lblProdPrice;
        private System.Windows.Forms.TextBox txtProdCategory;
        private System.Windows.Forms.Label lblProdCarModelYear;
        private System.Windows.Forms.TextBox txtProdQuantity;
        private System.Windows.Forms.TextBox txtProdPrice;
        private System.Windows.Forms.Label lblProdCarMake;
        private System.Windows.Forms.Label lblProdNo;
        private System.Windows.Forms.Label lblProdCode;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.DataGridView dgProductInvoice;
        private System.Windows.Forms.TextBox txtInvoiceProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgCustInvoice;
        private System.Windows.Forms.TextBox txtInvoiceCust;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgEmpInvoice;
        private System.Windows.Forms.TextBox txtInvoiceEmp;
        private PCsDataSet pCsDataSet;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private PCsDataSetTableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private PCsDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.TextBox txtBillPostalCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private PCsDataSetTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private System.Windows.Forms.TabPage tabInvoice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Microsoft.Reporting.WinForms.ReportViewer rvInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPhoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDescriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameDataGridViewTextBoxColumn;
    }
}

