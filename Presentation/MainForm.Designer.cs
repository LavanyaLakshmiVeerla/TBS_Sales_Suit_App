namespace TBS_Sales_Suit_App.Presentation
{
    partial class MainForm
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
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabCustomerAdd = new System.Windows.Forms.TabPage();
            this.txtBxValidityAdd = new System.Windows.Forms.TextBox();
            this.txtBxMemSinceAdd = new System.Windows.Forms.TextBox();
            this.txtBxDOBAdd = new System.Windows.Forms.TextBox();
            this.dtpValidityAdd = new System.Windows.Forms.DateTimePicker();
            this.dtpMemSinceAdd = new System.Windows.Forms.DateTimePicker();
            this.dtpDOBAdd = new System.Windows.Forms.DateTimePicker();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBxNameAdd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBxAddrAdd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBxContactAdd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabCustomerView = new System.Windows.Forms.TabPage();
            this.txtBxValidityInfo = new System.Windows.Forms.TextBox();
            this.txtBxMemsinceInfo = new System.Windows.Forms.TextBox();
            this.txtBxDOBInfo = new System.Windows.Forms.TextBox();
            this.dtpValidityInfo = new System.Windows.Forms.DateTimePicker();
            this.dtpMemSinceInfo = new System.Windows.Forms.DateTimePicker();
            this.dtpDOBInfo = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBxNameInfo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBxAddrInfo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBxContactInfo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GetCustomerInfo = new System.Windows.Forms.Button();
            this.txtBxContact = new System.Windows.Forms.TextBox();
            this.txtBxCName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSales = new System.Windows.Forms.TabPage();
            this.txtBxSalesFinalBill = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtBxSalesMemFees = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtBxSalesQuantity = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtBxSalesCNameDisplay = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtBxSalesAfterDisc = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtBxSalesTotalCost = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtBxSalesNoIP = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnSalesPrepareBill = new System.Windows.Forms.Button();
            this.dgvSalesBooks = new System.Windows.Forms.DataGridView();
            this.cbxBxSalesBooks = new System.Windows.Forms.ComboBox();
            this.btnSalesAddBook = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.btnSalesGetCustomer = new System.Windows.Forms.Button();
            this.txtBxSaleCName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tabImpExp = new System.Windows.Forms.TabPage();
            this.lblInputFormat = new System.Windows.Forms.Label();
            this.cbxInputFormat = new System.Windows.Forms.ComboBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtBxSalesDiscPercent = new System.Windows.Forms.TextBox();
            this.tabMenu.SuspendLayout();
            this.tabCustomerAdd.SuspendLayout();
            this.tabCustomerView.SuspendLayout();
            this.tabSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesBooks)).BeginInit();
            this.tabImpExp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabImpExp);
            this.tabMenu.Controls.Add(this.tabCustomerAdd);
            this.tabMenu.Controls.Add(this.tabCustomerView);
            this.tabMenu.Controls.Add(this.tabSales);
            this.tabMenu.Location = new System.Drawing.Point(0, 27);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(800, 446);
            this.tabMenu.TabIndex = 0;
            // 
            // tabCustomerAdd
            // 
            this.tabCustomerAdd.Controls.Add(this.txtBxValidityAdd);
            this.tabCustomerAdd.Controls.Add(this.txtBxMemSinceAdd);
            this.tabCustomerAdd.Controls.Add(this.txtBxDOBAdd);
            this.tabCustomerAdd.Controls.Add(this.dtpValidityAdd);
            this.tabCustomerAdd.Controls.Add(this.dtpMemSinceAdd);
            this.tabCustomerAdd.Controls.Add(this.dtpDOBAdd);
            this.tabCustomerAdd.Controls.Add(this.btnAddCustomer);
            this.tabCustomerAdd.Controls.Add(this.label18);
            this.tabCustomerAdd.Controls.Add(this.label3);
            this.tabCustomerAdd.Controls.Add(this.label11);
            this.tabCustomerAdd.Controls.Add(this.txtBxNameAdd);
            this.tabCustomerAdd.Controls.Add(this.label12);
            this.tabCustomerAdd.Controls.Add(this.txtBxAddrAdd);
            this.tabCustomerAdd.Controls.Add(this.label13);
            this.tabCustomerAdd.Controls.Add(this.txtBxContactAdd);
            this.tabCustomerAdd.Controls.Add(this.label14);
            this.tabCustomerAdd.Controls.Add(this.label15);
            this.tabCustomerAdd.Controls.Add(this.label16);
            this.tabCustomerAdd.Location = new System.Drawing.Point(4, 22);
            this.tabCustomerAdd.Name = "tabCustomerAdd";
            this.tabCustomerAdd.Size = new System.Drawing.Size(792, 420);
            this.tabCustomerAdd.TabIndex = 3;
            this.tabCustomerAdd.Text = "Add Customer";
            this.tabCustomerAdd.UseVisualStyleBackColor = true;
            // 
            // txtBxValidityAdd
            // 
            this.txtBxValidityAdd.Location = new System.Drawing.Point(500, 129);
            this.txtBxValidityAdd.Name = "txtBxValidityAdd";
            this.txtBxValidityAdd.Size = new System.Drawing.Size(177, 20);
            this.txtBxValidityAdd.TabIndex = 43;
            // 
            // txtBxMemSinceAdd
            // 
            this.txtBxMemSinceAdd.Location = new System.Drawing.Point(500, 79);
            this.txtBxMemSinceAdd.Name = "txtBxMemSinceAdd";
            this.txtBxMemSinceAdd.Size = new System.Drawing.Size(177, 20);
            this.txtBxMemSinceAdd.TabIndex = 42;
            // 
            // txtBxDOBAdd
            // 
            this.txtBxDOBAdd.Location = new System.Drawing.Point(149, 237);
            this.txtBxDOBAdd.Name = "txtBxDOBAdd";
            this.txtBxDOBAdd.Size = new System.Drawing.Size(177, 20);
            this.txtBxDOBAdd.TabIndex = 41;
            // 
            // dtpValidityAdd
            // 
            this.dtpValidityAdd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpValidityAdd.Location = new System.Drawing.Point(685, 129);
            this.dtpValidityAdd.Name = "dtpValidityAdd";
            this.dtpValidityAdd.Size = new System.Drawing.Size(21, 20);
            this.dtpValidityAdd.TabIndex = 40;
            // 
            // dtpMemSinceAdd
            // 
            this.dtpMemSinceAdd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMemSinceAdd.Location = new System.Drawing.Point(685, 79);
            this.dtpMemSinceAdd.Name = "dtpMemSinceAdd";
            this.dtpMemSinceAdd.Size = new System.Drawing.Size(21, 20);
            this.dtpMemSinceAdd.TabIndex = 39;
            // 
            // dtpDOBAdd
            // 
            this.dtpDOBAdd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOBAdd.Location = new System.Drawing.Point(332, 237);
            this.dtpDOBAdd.Name = "dtpDOBAdd";
            this.dtpDOBAdd.Size = new System.Drawing.Size(20, 20);
            this.dtpDOBAdd.TabIndex = 38;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(326, 310);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(101, 23);
            this.btnAddCustomer.TabIndex = 37;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(393, 135);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Valid until :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(44, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Add new Customer :";
            // 
            // txtBxNameAdd
            // 
            this.txtBxNameAdd.Location = new System.Drawing.Point(149, 79);
            this.txtBxNameAdd.Name = "txtBxNameAdd";
            this.txtBxNameAdd.Size = new System.Drawing.Size(177, 20);
            this.txtBxNameAdd.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Name :";
            // 
            // txtBxAddrAdd
            // 
            this.txtBxAddrAdd.Location = new System.Drawing.Point(149, 130);
            this.txtBxAddrAdd.Name = "txtBxAddrAdd";
            this.txtBxAddrAdd.Size = new System.Drawing.Size(177, 20);
            this.txtBxAddrAdd.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(55, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Address :";
            // 
            // txtBxContactAdd
            // 
            this.txtBxContactAdd.Location = new System.Drawing.Point(149, 184);
            this.txtBxContactAdd.Name = "txtBxContactAdd";
            this.txtBxContactAdd.Size = new System.Drawing.Size(177, 20);
            this.txtBxContactAdd.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(55, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Contact Number :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(55, 237);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Date of Birth :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(392, 82);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "Member since :";
            // 
            // tabCustomerView
            // 
            this.tabCustomerView.Controls.Add(this.txtBxValidityInfo);
            this.tabCustomerView.Controls.Add(this.txtBxMemsinceInfo);
            this.tabCustomerView.Controls.Add(this.txtBxDOBInfo);
            this.tabCustomerView.Controls.Add(this.dtpValidityInfo);
            this.tabCustomerView.Controls.Add(this.dtpMemSinceInfo);
            this.tabCustomerView.Controls.Add(this.dtpDOBInfo);
            this.tabCustomerView.Controls.Add(this.btnUpdateCustomer);
            this.tabCustomerView.Controls.Add(this.lblMessage);
            this.tabCustomerView.Controls.Add(this.label10);
            this.tabCustomerView.Controls.Add(this.txtBxNameInfo);
            this.tabCustomerView.Controls.Add(this.label9);
            this.tabCustomerView.Controls.Add(this.txtBxAddrInfo);
            this.tabCustomerView.Controls.Add(this.label8);
            this.tabCustomerView.Controls.Add(this.txtBxContactInfo);
            this.tabCustomerView.Controls.Add(this.label7);
            this.tabCustomerView.Controls.Add(this.label6);
            this.tabCustomerView.Controls.Add(this.label5);
            this.tabCustomerView.Controls.Add(this.label4);
            this.tabCustomerView.Controls.Add(this.GetCustomerInfo);
            this.tabCustomerView.Controls.Add(this.txtBxContact);
            this.tabCustomerView.Controls.Add(this.txtBxCName);
            this.tabCustomerView.Controls.Add(this.label2);
            this.tabCustomerView.Controls.Add(this.label1);
            this.tabCustomerView.Location = new System.Drawing.Point(4, 22);
            this.tabCustomerView.Name = "tabCustomerView";
            this.tabCustomerView.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomerView.Size = new System.Drawing.Size(792, 420);
            this.tabCustomerView.TabIndex = 0;
            this.tabCustomerView.Text = "View/Update Customers";
            this.tabCustomerView.UseVisualStyleBackColor = true;
            // 
            // txtBxValidityInfo
            // 
            this.txtBxValidityInfo.Location = new System.Drawing.Point(467, 152);
            this.txtBxValidityInfo.Name = "txtBxValidityInfo";
            this.txtBxValidityInfo.Size = new System.Drawing.Size(177, 20);
            this.txtBxValidityInfo.TabIndex = 45;
            // 
            // txtBxMemsinceInfo
            // 
            this.txtBxMemsinceInfo.Location = new System.Drawing.Point(467, 99);
            this.txtBxMemsinceInfo.Name = "txtBxMemsinceInfo";
            this.txtBxMemsinceInfo.Size = new System.Drawing.Size(177, 20);
            this.txtBxMemsinceInfo.TabIndex = 44;
            // 
            // txtBxDOBInfo
            // 
            this.txtBxDOBInfo.Location = new System.Drawing.Point(113, 260);
            this.txtBxDOBInfo.Name = "txtBxDOBInfo";
            this.txtBxDOBInfo.Size = new System.Drawing.Size(177, 20);
            this.txtBxDOBInfo.TabIndex = 43;
            // 
            // dtpValidityInfo
            // 
            this.dtpValidityInfo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpValidityInfo.Location = new System.Drawing.Point(650, 151);
            this.dtpValidityInfo.Name = "dtpValidityInfo";
            this.dtpValidityInfo.Size = new System.Drawing.Size(20, 20);
            this.dtpValidityInfo.TabIndex = 42;
            // 
            // dtpMemSinceInfo
            // 
            this.dtpMemSinceInfo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMemSinceInfo.Location = new System.Drawing.Point(650, 99);
            this.dtpMemSinceInfo.Name = "dtpMemSinceInfo";
            this.dtpMemSinceInfo.Size = new System.Drawing.Size(21, 20);
            this.dtpMemSinceInfo.TabIndex = 41;
            // 
            // dtpDOBInfo
            // 
            this.dtpDOBInfo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOBInfo.Location = new System.Drawing.Point(294, 260);
            this.dtpDOBInfo.Name = "dtpDOBInfo";
            this.dtpDOBInfo.Size = new System.Drawing.Size(20, 20);
            this.dtpDOBInfo.TabIndex = 40;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(294, 319);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCustomer.TabIndex = 39;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(224, 72);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 16);
            this.lblMessage.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Customer Information :";
            // 
            // txtBxNameInfo
            // 
            this.txtBxNameInfo.Location = new System.Drawing.Point(113, 99);
            this.txtBxNameInfo.Name = "txtBxNameInfo";
            this.txtBxNameInfo.Size = new System.Drawing.Size(177, 20);
            this.txtBxNameInfo.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Name :";
            // 
            // txtBxAddrInfo
            // 
            this.txtBxAddrInfo.Location = new System.Drawing.Point(113, 150);
            this.txtBxAddrInfo.Name = "txtBxAddrInfo";
            this.txtBxAddrInfo.Size = new System.Drawing.Size(177, 20);
            this.txtBxAddrInfo.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Address :";
            // 
            // txtBxContactInfo
            // 
            this.txtBxContactInfo.Location = new System.Drawing.Point(113, 204);
            this.txtBxContactInfo.Name = "txtBxContactInfo";
            this.txtBxContactInfo.Size = new System.Drawing.Size(177, 20);
            this.txtBxContactInfo.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Contact Number :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Date of Birth :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Member since :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valid until :";
            // 
            // GetCustomerInfo
            // 
            this.GetCustomerInfo.Location = new System.Drawing.Point(650, 22);
            this.GetCustomerInfo.Name = "GetCustomerInfo";
            this.GetCustomerInfo.Size = new System.Drawing.Size(82, 23);
            this.GetCustomerInfo.TabIndex = 4;
            this.GetCustomerInfo.Text = "Search";
            this.GetCustomerInfo.UseVisualStyleBackColor = true;
            this.GetCustomerInfo.Click += new System.EventHandler(this.GetCustomerInfo_Click);
            // 
            // txtBxContact
            // 
            this.txtBxContact.Location = new System.Drawing.Point(467, 24);
            this.txtBxContact.Name = "txtBxContact";
            this.txtBxContact.Size = new System.Drawing.Size(177, 20);
            this.txtBxContact.TabIndex = 3;
            // 
            // txtBxCName
            // 
            this.txtBxCName.Location = new System.Drawing.Point(113, 24);
            this.txtBxCName.Name = "txtBxCName";
            this.txtBxCName.Size = new System.Drawing.Size(177, 20);
            this.txtBxCName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact Number :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name :";
            // 
            // tabSales
            // 
            this.tabSales.Controls.Add(this.txtBxSalesDiscPercent);
            this.tabSales.Controls.Add(this.btnReset);
            this.tabSales.Controls.Add(this.txtBxSalesFinalBill);
            this.tabSales.Controls.Add(this.label29);
            this.tabSales.Controls.Add(this.txtBxSalesMemFees);
            this.tabSales.Controls.Add(this.label28);
            this.tabSales.Controls.Add(this.txtBxSalesQuantity);
            this.tabSales.Controls.Add(this.label27);
            this.tabSales.Controls.Add(this.txtBxSalesCNameDisplay);
            this.tabSales.Controls.Add(this.label26);
            this.tabSales.Controls.Add(this.txtBxSalesAfterDisc);
            this.tabSales.Controls.Add(this.label25);
            this.tabSales.Controls.Add(this.label24);
            this.tabSales.Controls.Add(this.txtBxSalesTotalCost);
            this.tabSales.Controls.Add(this.label23);
            this.tabSales.Controls.Add(this.txtBxSalesNoIP);
            this.tabSales.Controls.Add(this.label22);
            this.tabSales.Controls.Add(this.btnSalesPrepareBill);
            this.tabSales.Controls.Add(this.dgvSalesBooks);
            this.tabSales.Controls.Add(this.cbxBxSalesBooks);
            this.tabSales.Controls.Add(this.btnSalesAddBook);
            this.tabSales.Controls.Add(this.label21);
            this.tabSales.Controls.Add(this.btnSalesGetCustomer);
            this.tabSales.Controls.Add(this.txtBxSaleCName);
            this.tabSales.Controls.Add(this.label20);
            this.tabSales.Location = new System.Drawing.Point(4, 22);
            this.tabSales.Name = "tabSales";
            this.tabSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabSales.Size = new System.Drawing.Size(792, 420);
            this.tabSales.TabIndex = 1;
            this.tabSales.Text = "Add Purchase";
            this.tabSales.UseVisualStyleBackColor = true;
            // 
            // txtBxSalesFinalBill
            // 
            this.txtBxSalesFinalBill.Location = new System.Drawing.Point(496, 381);
            this.txtBxSalesFinalBill.Name = "txtBxSalesFinalBill";
            this.txtBxSalesFinalBill.ReadOnly = true;
            this.txtBxSalesFinalBill.Size = new System.Drawing.Size(177, 20);
            this.txtBxSalesFinalBill.TabIndex = 29;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(335, 384);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(105, 13);
            this.label29.TabIndex = 28;
            this.label29.Text = "Final Bill Amount (₹) :";
            // 
            // txtBxSalesMemFees
            // 
            this.txtBxSalesMemFees.Location = new System.Drawing.Point(496, 352);
            this.txtBxSalesMemFees.Name = "txtBxSalesMemFees";
            this.txtBxSalesMemFees.Size = new System.Drawing.Size(177, 20);
            this.txtBxSalesMemFees.TabIndex = 27;
            this.txtBxSalesMemFees.Text = "0";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(335, 355);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(111, 13);
            this.label28.TabIndex = 26;
            this.label28.Text = "Membership Fees (₹) :";
            // 
            // txtBxSalesQuantity
            // 
            this.txtBxSalesQuantity.Location = new System.Drawing.Point(500, 63);
            this.txtBxSalesQuantity.Name = "txtBxSalesQuantity";
            this.txtBxSalesQuantity.Size = new System.Drawing.Size(87, 20);
            this.txtBxSalesQuantity.TabIndex = 25;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(443, 67);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(52, 13);
            this.label27.TabIndex = 24;
            this.label27.Text = "Quantity :";
            // 
            // txtBxSalesCNameDisplay
            // 
            this.txtBxSalesCNameDisplay.Location = new System.Drawing.Point(137, 236);
            this.txtBxSalesCNameDisplay.Name = "txtBxSalesCNameDisplay";
            this.txtBxSalesCNameDisplay.ReadOnly = true;
            this.txtBxSalesCNameDisplay.Size = new System.Drawing.Size(177, 20);
            this.txtBxSalesCNameDisplay.TabIndex = 23;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(33, 239);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(88, 13);
            this.label26.TabIndex = 22;
            this.label26.Text = "Customer Name :";
            // 
            // txtBxSalesAfterDisc
            // 
            this.txtBxSalesAfterDisc.Location = new System.Drawing.Point(496, 323);
            this.txtBxSalesAfterDisc.Name = "txtBxSalesAfterDisc";
            this.txtBxSalesAfterDisc.ReadOnly = true;
            this.txtBxSalesAfterDisc.Size = new System.Drawing.Size(177, 20);
            this.txtBxSalesAfterDisc.TabIndex = 21;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(335, 327);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(145, 13);
            this.label25.TabIndex = 20;
            this.label25.Text = "Total Cost after Discount (₹) :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(335, 299);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(112, 13);
            this.label24.TabIndex = 18;
            this.label24.Text = "Discount Percent (%) :";
            // 
            // txtBxSalesTotalCost
            // 
            this.txtBxSalesTotalCost.Location = new System.Drawing.Point(496, 265);
            this.txtBxSalesTotalCost.Name = "txtBxSalesTotalCost";
            this.txtBxSalesTotalCost.ReadOnly = true;
            this.txtBxSalesTotalCost.Size = new System.Drawing.Size(177, 20);
            this.txtBxSalesTotalCost.TabIndex = 17;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(335, 268);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(154, 13);
            this.label23.TabIndex = 16;
            this.label23.Text = "Total Cost before Discount (₹) :";
            // 
            // txtBxSalesNoIP
            // 
            this.txtBxSalesNoIP.Location = new System.Drawing.Point(496, 236);
            this.txtBxSalesNoIP.Name = "txtBxSalesNoIP";
            this.txtBxSalesNoIP.ReadOnly = true;
            this.txtBxSalesNoIP.Size = new System.Drawing.Size(177, 20);
            this.txtBxSalesNoIP.TabIndex = 15;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(335, 239);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(121, 13);
            this.label22.TabIndex = 14;
            this.label22.Text = "No of Items Purchased :";
            // 
            // btnSalesPrepareBill
            // 
            this.btnSalesPrepareBill.Location = new System.Drawing.Point(591, 206);
            this.btnSalesPrepareBill.Name = "btnSalesPrepareBill";
            this.btnSalesPrepareBill.Size = new System.Drawing.Size(82, 23);
            this.btnSalesPrepareBill.TabIndex = 13;
            this.btnSalesPrepareBill.Text = "Prepare Bill";
            this.btnSalesPrepareBill.UseVisualStyleBackColor = true;
            this.btnSalesPrepareBill.Click += new System.EventHandler(this.btnSalesPrepareBill_Click);
            // 
            // dgvSalesBooks
            // 
            this.dgvSalesBooks.AllowUserToOrderColumns = true;
            this.dgvSalesBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesBooks.Location = new System.Drawing.Point(33, 91);
            this.dgvSalesBooks.Name = "dgvSalesBooks";
            this.dgvSalesBooks.Size = new System.Drawing.Size(640, 109);
            this.dgvSalesBooks.TabIndex = 12;
            // 
            // cbxBxSalesBooks
            // 
            this.cbxBxSalesBooks.FormattingEnabled = true;
            this.cbxBxSalesBooks.Location = new System.Drawing.Point(244, 63);
            this.cbxBxSalesBooks.Name = "cbxBxSalesBooks";
            this.cbxBxSalesBooks.Size = new System.Drawing.Size(177, 21);
            this.cbxBxSalesBooks.Sorted = true;
            this.cbxBxSalesBooks.TabIndex = 11;
            // 
            // btnSalesAddBook
            // 
            this.btnSalesAddBook.Location = new System.Drawing.Point(591, 62);
            this.btnSalesAddBook.Name = "btnSalesAddBook";
            this.btnSalesAddBook.Size = new System.Drawing.Size(82, 23);
            this.btnSalesAddBook.TabIndex = 10;
            this.btnSalesAddBook.Text = "Add Book";
            this.btnSalesAddBook.UseVisualStyleBackColor = true;
            this.btnSalesAddBook.Click += new System.EventHandler(this.btnSalesAddBook_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(30, 66);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 13);
            this.label21.TabIndex = 8;
            this.label21.Text = "Select Book Name :";
            // 
            // btnSalesGetCustomer
            // 
            this.btnSalesGetCustomer.Location = new System.Drawing.Point(446, 26);
            this.btnSalesGetCustomer.Name = "btnSalesGetCustomer";
            this.btnSalesGetCustomer.Size = new System.Drawing.Size(82, 23);
            this.btnSalesGetCustomer.TabIndex = 7;
            this.btnSalesGetCustomer.Text = "Get Customer";
            this.btnSalesGetCustomer.UseVisualStyleBackColor = true;
            this.btnSalesGetCustomer.Click += new System.EventHandler(this.btnSalesGetCustomer_Click);
            // 
            // txtBxSaleCName
            // 
            this.txtBxSaleCName.Location = new System.Drawing.Point(244, 27);
            this.txtBxSaleCName.Name = "txtBxSaleCName";
            this.txtBxSaleCName.Size = new System.Drawing.Size(177, 20);
            this.txtBxSaleCName.TabIndex = 6;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(30, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(208, 13);
            this.label20.TabIndex = 5;
            this.label20.Text = "Enter Customer Name or Contact Number :";
            // 
            // tabImpExp
            // 
            this.tabImpExp.Controls.Add(this.lblInputFormat);
            this.tabImpExp.Controls.Add(this.cbxInputFormat);
            this.tabImpExp.Controls.Add(this.btnImport);
            this.tabImpExp.Location = new System.Drawing.Point(4, 22);
            this.tabImpExp.Name = "tabImpExp";
            this.tabImpExp.Size = new System.Drawing.Size(792, 420);
            this.tabImpExp.TabIndex = 2;
            this.tabImpExp.Text = "Import/Export";
            this.tabImpExp.UseVisualStyleBackColor = true;
            // 
            // lblInputFormat
            // 
            this.lblInputFormat.AutoSize = true;
            this.lblInputFormat.Location = new System.Drawing.Point(59, 68);
            this.lblInputFormat.Name = "lblInputFormat";
            this.lblInputFormat.Size = new System.Drawing.Size(108, 13);
            this.lblInputFormat.TabIndex = 2;
            this.lblInputFormat.Text = "Choose Input format :";
            // 
            // cbxInputFormat
            // 
            this.cbxInputFormat.FormattingEnabled = true;
            this.cbxInputFormat.Items.AddRange(new object[] {
            "EXCEL",
            "CSV",
            "XML",
            "JSON",
            "TEXT"});
            this.cbxInputFormat.Location = new System.Drawing.Point(204, 65);
            this.cbxInputFormat.Name = "cbxInputFormat";
            this.cbxInputFormat.Size = new System.Drawing.Size(121, 21);
            this.cbxInputFormat.TabIndex = 1;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(204, 117);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import data";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(718, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(591, 25);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(82, 23);
            this.btnReset.TabIndex = 30;
            this.btnReset.Text = "Reset All";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtBxSalesDiscPercent
            // 
            this.txtBxSalesDiscPercent.Location = new System.Drawing.Point(496, 296);
            this.txtBxSalesDiscPercent.Name = "txtBxSalesDiscPercent";
            this.txtBxSalesDiscPercent.Size = new System.Drawing.Size(177, 20);
            this.txtBxSalesDiscPercent.TabIndex = 31;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabMenu);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TBS Sales Suit";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabMenu.ResumeLayout(false);
            this.tabCustomerAdd.ResumeLayout(false);
            this.tabCustomerAdd.PerformLayout();
            this.tabCustomerView.ResumeLayout(false);
            this.tabCustomerView.PerformLayout();
            this.tabSales.ResumeLayout(false);
            this.tabSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesBooks)).EndInit();
            this.tabImpExp.ResumeLayout(false);
            this.tabImpExp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabCustomerView;
        private System.Windows.Forms.TabPage tabSales;
        private System.Windows.Forms.TabPage tabImpExp;
        private System.Windows.Forms.Label lblInputFormat;
        private System.Windows.Forms.ComboBox cbxInputFormat;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button GetCustomerInfo;
        private System.Windows.Forms.TextBox txtBxContact;
        private System.Windows.Forms.TextBox txtBxCName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBxNameInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBxAddrInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBxContactInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TabPage tabCustomerAdd;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBxNameAdd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBxAddrAdd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBxContactAdd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.DateTimePicker dtpValidityAdd;
        private System.Windows.Forms.DateTimePicker dtpMemSinceAdd;
        private System.Windows.Forms.DateTimePicker dtpValidityInfo;
        private System.Windows.Forms.DateTimePicker dtpMemSinceInfo;
        private System.Windows.Forms.DateTimePicker dtpDOBInfo;
        private System.Windows.Forms.TextBox txtBxDOBInfo;
        private System.Windows.Forms.TextBox txtBxMemsinceInfo;
        private System.Windows.Forms.TextBox txtBxValidityInfo;
        private System.Windows.Forms.TextBox txtBxValidityAdd;
        private System.Windows.Forms.TextBox txtBxMemSinceAdd;
        private System.Windows.Forms.TextBox txtBxDOBAdd;
        private System.Windows.Forms.DateTimePicker dtpDOBAdd;
        private System.Windows.Forms.DataGridView dgvSalesBooks;
        private System.Windows.Forms.ComboBox cbxBxSalesBooks;
        private System.Windows.Forms.Button btnSalesAddBook;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnSalesGetCustomer;
        private System.Windows.Forms.TextBox txtBxSaleCName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnSalesPrepareBill;
        private System.Windows.Forms.TextBox txtBxSalesAfterDisc;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtBxSalesTotalCost;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtBxSalesNoIP;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtBxSalesCNameDisplay;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtBxSalesQuantity;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtBxSalesFinalBill;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtBxSalesMemFees;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtBxSalesDiscPercent;
    }
}