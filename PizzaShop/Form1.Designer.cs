namespace PizzaShop
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label idLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pizzaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzaShopDBDataSet = new PizzaShop.PizzaShopDBDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pizzaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pizzaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKPizzaToTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblHeader = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnPNSrch = new System.Windows.Forms.Button();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblPname = new System.Windows.Forms.Label();
            this.lsbxPName = new System.Windows.Forms.ListBox();
            this.lblPDetails = new System.Windows.Forms.Label();
            this.txbxPDetails = new System.Windows.Forms.TextBox();
            this.lblPSize = new System.Windows.Forms.Label();
            this.lsbxPSize = new System.Windows.Forms.ListBox();
            this.lblPBase = new System.Windows.Forms.Label();
            this.lsbxPBase = new System.Windows.Forms.ListBox();
            this.lblPSauce = new System.Windows.Forms.Label();
            this.lsbxPSauce = new System.Windows.Forms.ListBox();
            this.lblPQuan = new System.Windows.Forms.Label();
            this.numericUpDownPQuan = new System.Windows.Forms.NumericUpDown();
            this.gpbxPExTop = new System.Windows.Forms.GroupBox();
            this.ckbx8 = new System.Windows.Forms.CheckBox();
            this.ckbx9 = new System.Windows.Forms.CheckBox();
            this.ckbx10 = new System.Windows.Forms.CheckBox();
            this.ckbx11 = new System.Windows.Forms.CheckBox();
            this.ckbx12 = new System.Windows.Forms.CheckBox();
            this.ckbx13 = new System.Windows.Forms.CheckBox();
            this.ckbx14 = new System.Windows.Forms.CheckBox();
            this.ckbx7 = new System.Windows.Forms.CheckBox();
            this.ckbx6 = new System.Windows.Forms.CheckBox();
            this.ckbx5 = new System.Windows.Forms.CheckBox();
            this.ckbx4 = new System.Windows.Forms.CheckBox();
            this.ckbx3 = new System.Windows.Forms.CheckBox();
            this.ckbx2 = new System.Windows.Forms.CheckBox();
            this.ckbx1 = new System.Windows.Forms.CheckBox();
            this.txbxPSpecial = new System.Windows.Forms.TextBox();
            this.lblPSpecial = new System.Windows.Forms.Label();
            this.lblPPrice = new System.Windows.Forms.Label();
            this.lblPPriceAmount = new System.Windows.Forms.Label();
            this.btnPPlaceOrder = new System.Windows.Forms.Button();
            this.btnPReset = new System.Windows.Forms.Button();
            this.deletePizzaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pizzaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzaTableAdapter = new PizzaShop.PizzaShopDBDataSetTableAdapters.PizzaTableAdapter();
            this.tableAdapterManager = new PizzaShop.PizzaShopDBDataSetTableAdapters.TableAdapterManager();
            this.customersTableAdapter = new PizzaShop.PizzaShopDBDataSetTableAdapters.CustomersTableAdapter();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaBindingNavigator)).BeginInit();
            this.pizzaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaShopDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPizzaToTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPQuan)).BeginInit();
            this.gpbxPExTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(14, 78);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(35, 13);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(182, 78);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(45, 13);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "Address";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(555, 78);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            phoneNumberLabel.TabIndex = 9;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(238, 48);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(19, 13);
            idLabel1.TabIndex = 13;
            idLabel1.Text = "Id:";
            // 
            // pizzaBindingNavigator
            // 
            this.pizzaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pizzaBindingNavigator.BindingSource = this.customersBindingSource;
            this.pizzaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pizzaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pizzaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pizzaBindingNavigatorSaveItem});
            this.pizzaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pizzaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pizzaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pizzaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pizzaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pizzaBindingNavigator.Name = "pizzaBindingNavigator";
            this.pizzaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pizzaBindingNavigator.Size = new System.Drawing.Size(898, 25);
            this.pizzaBindingNavigator.TabIndex = 0;
            this.pizzaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.pizzaShopDBDataSet;
            // 
            // pizzaShopDBDataSet
            // 
            this.pizzaShopDBDataSet.DataSetName = "PizzaShopDBDataSet";
            this.pizzaShopDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pizzaBindingNavigatorSaveItem
            // 
            this.pizzaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pizzaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pizzaBindingNavigatorSaveItem.Image")));
            this.pizzaBindingNavigatorSaveItem.Name = "pizzaBindingNavigatorSaveItem";
            this.pizzaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pizzaBindingNavigatorSaveItem.Text = "Save Data";
            this.pizzaBindingNavigatorSaveItem.Click += new System.EventHandler(this.pizzaBindingNavigatorSaveItem_Click);
            // 
            // pizzaDataGridView
            // 
            this.pizzaDataGridView.AutoGenerateColumns = false;
            this.pizzaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pizzaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.pizzaDataGridView.DataSource = this.fKPizzaToTableBindingSource;
            this.pizzaDataGridView.Location = new System.Drawing.Point(12, 141);
            this.pizzaDataGridView.Name = "pizzaDataGridView";
            this.pizzaDataGridView.Size = new System.Drawing.Size(866, 120);
            this.pizzaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn3.HeaderText = "name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "size";
            this.dataGridViewTextBoxColumn4.HeaderText = "size";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "base";
            this.dataGridViewTextBoxColumn5.HeaderText = "base";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 90;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "sauce";
            this.dataGridViewTextBoxColumn6.HeaderText = "sauce";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 85;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "toppings";
            this.dataGridViewTextBoxColumn7.HeaderText = "toppings";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 225;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "specialReqs";
            this.dataGridViewTextBoxColumn8.HeaderText = "specialReqs";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn9.HeaderText = "quantity";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 50;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn10.HeaderText = "price";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 50;
            // 
            // fKPizzaToTableBindingSource
            // 
            this.fKPizzaToTableBindingSource.DataMember = "FK_Pizza_ToTable";
            this.fKPizzaToTableBindingSource.DataSource = this.customersBindingSource;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 36);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(197, 29);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Customer Details";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(17, 94);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(158, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(181, 94);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(371, 20);
            this.addressTextBox.TabIndex = 8;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "phoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(558, 94);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(129, 20);
            this.phoneNumberTextBox.TabIndex = 10;
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(693, 48);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(185, 23);
            this.btnViewAll.TabIndex = 11;
            this.btnViewAll.Text = "Select all Customers";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnPNSrch
            // 
            this.btnPNSrch.Location = new System.Drawing.Point(693, 92);
            this.btnPNSrch.Name = "btnPNSrch";
            this.btnPNSrch.Size = new System.Drawing.Size(185, 23);
            this.btnPNSrch.TabIndex = 12;
            this.btnPNSrch.Text = "Phone Number Search";
            this.btnPNSrch.UseVisualStyleBackColor = true;
            this.btnPNSrch.Click += new System.EventHandler(this.btnPNSrch_Click);
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Id", true));
            this.idTextBox1.Location = new System.Drawing.Point(263, 45);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(100, 20);
            this.idTextBox1.TabIndex = 14;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(12, 278);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(299, 29);
            this.lblOrder.TabIndex = 15;
            this.lblOrder.Text = "Plance an order for a Pizza";
            // 
            // lblPname
            // 
            this.lblPname.AutoSize = true;
            this.lblPname.Location = new System.Drawing.Point(9, 327);
            this.lblPname.Name = "lblPname";
            this.lblPname.Size = new System.Drawing.Size(35, 13);
            this.lblPname.TabIndex = 16;
            this.lblPname.Text = "Name";
            // 
            // lsbxPName
            // 
            this.lsbxPName.FormattingEnabled = true;
            this.lsbxPName.Items.AddRange(new object[] {
            "Indian Apache",
            "Mexican Pepper Volcano",
            "All Day Breakfast",
            "Bacon Apache",
            "Buffalo",
            "Cajun Apache",
            "Chicken Apache",
            "Geronimo",
            "Hot Apache",
            "Sitting Bull",
            "Special",
            "Texas Beef Fiesta",
            "Tomahawk",
            "Vegetarian",
            "Wigwammer",
            "MAKE YOUR OWN"});
            this.lsbxPName.Location = new System.Drawing.Point(12, 343);
            this.lsbxPName.Name = "lsbxPName";
            this.lsbxPName.Size = new System.Drawing.Size(129, 212);
            this.lsbxPName.TabIndex = 17;
            this.lsbxPName.SelectedIndexChanged += new System.EventHandler(this.lsbxPName_SelectedIndexChanged);
            // 
            // lblPDetails
            // 
            this.lblPDetails.AutoSize = true;
            this.lblPDetails.Location = new System.Drawing.Point(147, 326);
            this.lblPDetails.Name = "lblPDetails";
            this.lblPDetails.Size = new System.Drawing.Size(39, 13);
            this.lblPDetails.TabIndex = 18;
            this.lblPDetails.Text = "Details";
            // 
            // txbxPDetails
            // 
            this.txbxPDetails.Location = new System.Drawing.Point(150, 343);
            this.txbxPDetails.Multiline = true;
            this.txbxPDetails.Name = "txbxPDetails";
            this.txbxPDetails.Size = new System.Drawing.Size(297, 73);
            this.txbxPDetails.TabIndex = 19;
            // 
            // lblPSize
            // 
            this.lblPSize.AutoSize = true;
            this.lblPSize.Location = new System.Drawing.Point(147, 419);
            this.lblPSize.Name = "lblPSize";
            this.lblPSize.Size = new System.Drawing.Size(27, 13);
            this.lblPSize.TabIndex = 20;
            this.lblPSize.Text = "Size";
            // 
            // lsbxPSize
            // 
            this.lsbxPSize.FormattingEnabled = true;
            this.lsbxPSize.Items.AddRange(new object[] {
            "Personal",
            "Small",
            "Medium",
            "Large"});
            this.lsbxPSize.Location = new System.Drawing.Point(150, 437);
            this.lsbxPSize.Name = "lsbxPSize";
            this.lsbxPSize.Size = new System.Drawing.Size(116, 56);
            this.lsbxPSize.TabIndex = 21;
            this.lsbxPSize.SelectedIndexChanged += new System.EventHandler(this.lsbxPSize_SelectedIndexChanged);
            // 
            // lblPBase
            // 
            this.lblPBase.AutoSize = true;
            this.lblPBase.Location = new System.Drawing.Point(147, 496);
            this.lblPBase.Name = "lblPBase";
            this.lblPBase.Size = new System.Drawing.Size(31, 13);
            this.lblPBase.TabIndex = 22;
            this.lblPBase.Text = "Base";
            // 
            // lsbxPBase
            // 
            this.lsbxPBase.FormattingEnabled = true;
            this.lsbxPBase.Items.AddRange(new object[] {
            "Regular",
            "Apache Rising",
            "Thin"});
            this.lsbxPBase.Location = new System.Drawing.Point(150, 512);
            this.lsbxPBase.Name = "lsbxPBase";
            this.lsbxPBase.Size = new System.Drawing.Size(116, 43);
            this.lsbxPBase.TabIndex = 23;
            // 
            // lblPSauce
            // 
            this.lblPSauce.AutoSize = true;
            this.lblPSauce.Location = new System.Drawing.Point(303, 421);
            this.lblPSauce.Name = "lblPSauce";
            this.lblPSauce.Size = new System.Drawing.Size(38, 13);
            this.lblPSauce.TabIndex = 24;
            this.lblPSauce.Text = "Sauce";
            // 
            // lsbxPSauce
            // 
            this.lsbxPSauce.FormattingEnabled = true;
            this.lsbxPSauce.Items.AddRange(new object[] {
            "Original",
            "BBQ sauce",
            "No sauce",
            "Curry sauce"});
            this.lsbxPSauce.Location = new System.Drawing.Point(306, 437);
            this.lsbxPSauce.Name = "lsbxPSauce";
            this.lsbxPSauce.Size = new System.Drawing.Size(141, 56);
            this.lsbxPSauce.TabIndex = 25;
            // 
            // lblPQuan
            // 
            this.lblPQuan.AutoSize = true;
            this.lblPQuan.Location = new System.Drawing.Point(303, 519);
            this.lblPQuan.Name = "lblPQuan";
            this.lblPQuan.Size = new System.Drawing.Size(46, 13);
            this.lblPQuan.TabIndex = 26;
            this.lblPQuan.Text = "Quantity";
            // 
            // numericUpDownPQuan
            // 
            this.numericUpDownPQuan.Location = new System.Drawing.Point(306, 535);
            this.numericUpDownPQuan.Name = "numericUpDownPQuan";
            this.numericUpDownPQuan.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownPQuan.TabIndex = 27;
            this.numericUpDownPQuan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPQuan.ValueChanged += new System.EventHandler(this.numericUpDownPQuan_ValueChanged);
            // 
            // gpbxPExTop
            // 
            this.gpbxPExTop.Controls.Add(this.ckbx8);
            this.gpbxPExTop.Controls.Add(this.ckbx9);
            this.gpbxPExTop.Controls.Add(this.ckbx10);
            this.gpbxPExTop.Controls.Add(this.ckbx11);
            this.gpbxPExTop.Controls.Add(this.ckbx12);
            this.gpbxPExTop.Controls.Add(this.ckbx13);
            this.gpbxPExTop.Controls.Add(this.ckbx14);
            this.gpbxPExTop.Controls.Add(this.ckbx7);
            this.gpbxPExTop.Controls.Add(this.ckbx6);
            this.gpbxPExTop.Controls.Add(this.ckbx5);
            this.gpbxPExTop.Controls.Add(this.ckbx4);
            this.gpbxPExTop.Controls.Add(this.ckbx3);
            this.gpbxPExTop.Controls.Add(this.ckbx2);
            this.gpbxPExTop.Controls.Add(this.ckbx1);
            this.gpbxPExTop.Location = new System.Drawing.Point(473, 326);
            this.gpbxPExTop.Name = "gpbxPExTop";
            this.gpbxPExTop.Size = new System.Drawing.Size(259, 183);
            this.gpbxPExTop.TabIndex = 28;
            this.gpbxPExTop.TabStop = false;
            this.gpbxPExTop.Text = "Extra Toppings";
            // 
            // ckbx8
            // 
            this.ckbx8.AutoSize = true;
            this.ckbx8.Location = new System.Drawing.Point(137, 17);
            this.ckbx8.Name = "ckbx8";
            this.ckbx8.Size = new System.Drawing.Size(73, 17);
            this.ckbx8.TabIndex = 13;
            this.ckbx8.Text = "Pineapple";
            this.ckbx8.UseVisualStyleBackColor = true;
            this.ckbx8.Click += new System.EventHandler(this.aCheckboxHasChanged);
            // 
            // ckbx9
            // 
            this.ckbx9.AutoSize = true;
            this.ckbx9.Location = new System.Drawing.Point(137, 40);
            this.ckbx9.Name = "ckbx9";
            this.ckbx9.Size = new System.Drawing.Size(80, 17);
            this.ckbx9.TabIndex = 12;
            this.ckbx9.Text = "Mushrooms";
            this.ckbx9.UseVisualStyleBackColor = true;
            this.ckbx9.Click += new System.EventHandler(this.aCheckboxHasChanged);
            // 
            // ckbx10
            // 
            this.ckbx10.AutoSize = true;
            this.ckbx10.Location = new System.Drawing.Point(137, 63);
            this.ckbx10.Name = "ckbx10";
            this.ckbx10.Size = new System.Drawing.Size(74, 17);
            this.ckbx10.TabIndex = 11;
            this.ckbx10.Text = "Jalapenos";
            this.ckbx10.UseVisualStyleBackColor = true;
            this.ckbx10.Click += new System.EventHandler(this.aCheckboxHasChanged);
            // 
            // ckbx11
            // 
            this.ckbx11.AutoSize = true;
            this.ckbx11.Location = new System.Drawing.Point(137, 86);
            this.ckbx11.Name = "ckbx11";
            this.ckbx11.Size = new System.Drawing.Size(77, 17);
            this.ckbx11.TabIndex = 10;
            this.ckbx11.Text = "Sweetcorn";
            this.ckbx11.UseVisualStyleBackColor = true;
            this.ckbx11.Click += new System.EventHandler(this.aCheckboxHasChanged);
            // 
            // ckbx12
            // 
            this.ckbx12.AutoSize = true;
            this.ckbx12.Location = new System.Drawing.Point(137, 109);
            this.ckbx12.Name = "ckbx12";
            this.ckbx12.Size = new System.Drawing.Size(94, 17);
            this.ckbx12.TabIndex = 9;
            this.ckbx12.Text = "Great Peppers";
            this.ckbx12.UseVisualStyleBackColor = true;
            this.ckbx12.Click += new System.EventHandler(this.aCheckboxHasChanged);
            // 
            // ckbx13
            // 
            this.ckbx13.AutoSize = true;
            this.ckbx13.Location = new System.Drawing.Point(137, 132);
            this.ckbx13.Name = "ckbx13";
            this.ckbx13.Size = new System.Drawing.Size(89, 17);
            this.ckbx13.TabIndex = 8;
            this.ckbx13.Text = "Extra Cheese";
            this.ckbx13.UseVisualStyleBackColor = true;
            this.ckbx13.Click += new System.EventHandler(this.aCheckboxHasChanged);
            // 
            // ckbx14
            // 
            this.ckbx14.AutoSize = true;
            this.ckbx14.Location = new System.Drawing.Point(137, 155);
            this.ckbx14.Name = "ckbx14";
            this.ckbx14.Size = new System.Drawing.Size(57, 17);
            this.ckbx14.TabIndex = 7;
            this.ckbx14.Text = "Salami";
            this.ckbx14.UseVisualStyleBackColor = true;
            this.ckbx14.Click += new System.EventHandler(this.aCheckboxHasChanged);
            // 
            // ckbx7
            // 
            this.ckbx7.AutoSize = true;
            this.ckbx7.Location = new System.Drawing.Point(6, 155);
            this.ckbx7.Name = "ckbx7";
            this.ckbx7.Size = new System.Drawing.Size(65, 17);
            this.ckbx7.TabIndex = 6;
            this.ckbx7.Text = "Chicken";
            this.ckbx7.UseVisualStyleBackColor = true;
            this.ckbx7.Click += new System.EventHandler(this.aCheckboxHasChanged);
            // 
            // ckbx6
            // 
            this.ckbx6.AutoSize = true;
            this.ckbx6.Location = new System.Drawing.Point(6, 132);
            this.ckbx6.Name = "ckbx6";
            this.ckbx6.Size = new System.Drawing.Size(57, 17);
            this.ckbx6.TabIndex = 5;
            this.ckbx6.Text = "Bacon";
            this.ckbx6.UseVisualStyleBackColor = true;
            this.ckbx6.Click += new System.EventHandler(this.aCheckboxHasChanged);
            // 
            // ckbx5
            // 
            this.ckbx5.AutoSize = true;
            this.ckbx5.Location = new System.Drawing.Point(6, 109);
            this.ckbx5.Name = "ckbx5";
            this.ckbx5.Size = new System.Drawing.Size(68, 17);
            this.ckbx5.TabIndex = 4;
            this.ckbx5.Text = "Sausage";
            this.ckbx5.UseVisualStyleBackColor = true;
            this.ckbx5.Click += new System.EventHandler(this.aCheckboxHasChanged);
            // 
            // ckbx4
            // 
            this.ckbx4.AutoSize = true;
            this.ckbx4.Location = new System.Drawing.Point(6, 86);
            this.ckbx4.Name = "ckbx4";
            this.ckbx4.Size = new System.Drawing.Size(48, 17);
            this.ckbx4.TabIndex = 3;
            this.ckbx4.Text = "Ham";
            this.ckbx4.UseVisualStyleBackColor = true;
            this.ckbx4.Click += new System.EventHandler(this.aCheckboxHasChanged);
            // 
            // ckbx3
            // 
            this.ckbx3.AutoSize = true;
            this.ckbx3.Location = new System.Drawing.Point(6, 63);
            this.ckbx3.Name = "ckbx3";
            this.ckbx3.Size = new System.Drawing.Size(74, 17);
            this.ckbx3.TabIndex = 2;
            this.ckbx3.Text = "Pepperoni";
            this.ckbx3.UseVisualStyleBackColor = true;
            this.ckbx3.Click += new System.EventHandler(this.aCheckboxHasChanged);
            // 
            // ckbx2
            // 
            this.ckbx2.AutoSize = true;
            this.ckbx2.Location = new System.Drawing.Point(6, 40);
            this.ckbx2.Name = "ckbx2";
            this.ckbx2.Size = new System.Drawing.Size(54, 17);
            this.ckbx2.TabIndex = 1;
            this.ckbx2.Text = "Onion";
            this.ckbx2.UseVisualStyleBackColor = true;
            this.ckbx2.Click += new System.EventHandler(this.aCheckboxHasChanged);
            // 
            // ckbx1
            // 
            this.ckbx1.AutoSize = true;
            this.ckbx1.Location = new System.Drawing.Point(6, 17);
            this.ckbx1.Name = "ckbx1";
            this.ckbx1.Size = new System.Drawing.Size(73, 17);
            this.ckbx1.TabIndex = 0;
            this.ckbx1.Text = "Tomatoes";
            this.ckbx1.UseVisualStyleBackColor = true;
            this.ckbx1.Click += new System.EventHandler(this.aCheckboxHasChanged);
            // 
            // txbxPSpecial
            // 
            this.txbxPSpecial.Location = new System.Drawing.Point(12, 574);
            this.txbxPSpecial.Multiline = true;
            this.txbxPSpecial.Name = "txbxPSpecial";
            this.txbxPSpecial.Size = new System.Drawing.Size(435, 49);
            this.txbxPSpecial.TabIndex = 29;
            // 
            // lblPSpecial
            // 
            this.lblPSpecial.AutoSize = true;
            this.lblPSpecial.Location = new System.Drawing.Point(9, 558);
            this.lblPSpecial.Name = "lblPSpecial";
            this.lblPSpecial.Size = new System.Drawing.Size(110, 13);
            this.lblPSpecial.TabIndex = 30;
            this.lblPSpecial.Text = "Special Requirements";
            // 
            // lblPPrice
            // 
            this.lblPPrice.AutoSize = true;
            this.lblPPrice.Location = new System.Drawing.Point(476, 558);
            this.lblPPrice.Name = "lblPPrice";
            this.lblPPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPPrice.TabIndex = 31;
            this.lblPPrice.Text = "Price";
            // 
            // lblPPriceAmount
            // 
            this.lblPPriceAmount.AutoSize = true;
            this.lblPPriceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPriceAmount.Location = new System.Drawing.Point(475, 587);
            this.lblPPriceAmount.Name = "lblPPriceAmount";
            this.lblPPriceAmount.Size = new System.Drawing.Size(63, 24);
            this.lblPPriceAmount.TabIndex = 32;
            this.lblPPriceAmount.Text = "Empty";
            // 
            // btnPPlaceOrder
            // 
            this.btnPPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPPlaceOrder.Location = new System.Drawing.Point(587, 565);
            this.btnPPlaceOrder.Name = "btnPPlaceOrder";
            this.btnPPlaceOrder.Size = new System.Drawing.Size(145, 46);
            this.btnPPlaceOrder.TabIndex = 33;
            this.btnPPlaceOrder.Text = "Place Order";
            this.btnPPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPPlaceOrder.Click += new System.EventHandler(this.btnPPlaceOrder_Click);
            // 
            // btnPReset
            // 
            this.btnPReset.Location = new System.Drawing.Point(738, 329);
            this.btnPReset.Name = "btnPReset";
            this.btnPReset.Size = new System.Drawing.Size(127, 46);
            this.btnPReset.TabIndex = 34;
            this.btnPReset.Text = "Reset the Form";
            this.btnPReset.UseVisualStyleBackColor = true;
            this.btnPReset.Click += new System.EventHandler(this.btnPReset_Click);
            // 
            // deletePizzaToolStripButton
            // 
            this.deletePizzaToolStripButton.Name = "deletePizzaToolStripButton";
            this.deletePizzaToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // pizzaBindingSource
            // 
            this.pizzaBindingSource.DataMember = "Pizza";
            this.pizzaBindingSource.DataSource = this.pizzaShopDBDataSet;
            // 
            // pizzaTableAdapter
            // 
            this.pizzaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.PizzaTableAdapter = this.pizzaTableAdapter;
            this.tableAdapterManager.UpdateOrder = PizzaShop.PizzaShopDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 643);
            this.Controls.Add(this.btnPReset);
            this.Controls.Add(this.btnPPlaceOrder);
            this.Controls.Add(this.lblPPriceAmount);
            this.Controls.Add(this.lblPPrice);
            this.Controls.Add(this.lblPSpecial);
            this.Controls.Add(this.txbxPSpecial);
            this.Controls.Add(this.gpbxPExTop);
            this.Controls.Add(this.numericUpDownPQuan);
            this.Controls.Add(this.lblPQuan);
            this.Controls.Add(this.lsbxPSauce);
            this.Controls.Add(this.lblPSauce);
            this.Controls.Add(this.lsbxPBase);
            this.Controls.Add(this.lblPBase);
            this.Controls.Add(this.lsbxPSize);
            this.Controls.Add(this.lblPSize);
            this.Controls.Add(this.txbxPDetails);
            this.Controls.Add(this.lblPDetails);
            this.Controls.Add(this.lsbxPName);
            this.Controls.Add(this.lblPname);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(idLabel1);
            this.Controls.Add(this.idTextBox1);
            this.Controls.Add(this.btnPNSrch);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pizzaDataGridView);
            this.Controls.Add(this.pizzaBindingNavigator);
            this.Name = "Form1";
            this.Text = "Pizza Order Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pizzaBindingNavigator)).EndInit();
            this.pizzaBindingNavigator.ResumeLayout(false);
            this.pizzaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaShopDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPizzaToTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPQuan)).EndInit();
            this.gpbxPExTop.ResumeLayout(false);
            this.gpbxPExTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PizzaShopDBDataSet pizzaShopDBDataSet;
        private System.Windows.Forms.BindingSource pizzaBindingSource;
        private PizzaShopDBDataSetTableAdapters.PizzaTableAdapter pizzaTableAdapter;
        private PizzaShopDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pizzaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pizzaBindingNavigatorSaveItem;
        private PizzaShopDBDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridView pizzaDataGridView;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.BindingSource fKPizzaToTableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnPNSrch;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblPname;
        private System.Windows.Forms.ListBox lsbxPName;
        private System.Windows.Forms.Label lblPDetails;
        private System.Windows.Forms.TextBox txbxPDetails;
        private System.Windows.Forms.Label lblPSize;
        private System.Windows.Forms.ListBox lsbxPSize;
        private System.Windows.Forms.Label lblPBase;
        private System.Windows.Forms.ListBox lsbxPBase;
        private System.Windows.Forms.Label lblPSauce;
        private System.Windows.Forms.ListBox lsbxPSauce;
        private System.Windows.Forms.Label lblPQuan;
        private System.Windows.Forms.NumericUpDown numericUpDownPQuan;
        private System.Windows.Forms.GroupBox gpbxPExTop;
        private System.Windows.Forms.CheckBox ckbx8;
        private System.Windows.Forms.CheckBox ckbx9;
        private System.Windows.Forms.CheckBox ckbx10;
        private System.Windows.Forms.CheckBox ckbx11;
        private System.Windows.Forms.CheckBox ckbx12;
        private System.Windows.Forms.CheckBox ckbx13;
        private System.Windows.Forms.CheckBox ckbx14;
        private System.Windows.Forms.CheckBox ckbx7;
        private System.Windows.Forms.CheckBox ckbx6;
        private System.Windows.Forms.CheckBox ckbx5;
        private System.Windows.Forms.CheckBox ckbx4;
        private System.Windows.Forms.CheckBox ckbx3;
        private System.Windows.Forms.CheckBox ckbx2;
        private System.Windows.Forms.CheckBox ckbx1;
        private System.Windows.Forms.TextBox txbxPSpecial;
        private System.Windows.Forms.Label lblPSpecial;
        private System.Windows.Forms.Label lblPPrice;
        private System.Windows.Forms.Label lblPPriceAmount;
        private System.Windows.Forms.Button btnPPlaceOrder;
        private System.Windows.Forms.Button btnPReset;
        private System.Windows.Forms.ToolStripButton deletePizzaToolStripButton;

    }
}

