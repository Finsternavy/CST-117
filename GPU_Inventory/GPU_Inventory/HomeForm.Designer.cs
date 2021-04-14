
namespace GPU_Inventory
{
    partial class HomeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.coresLabel = new System.Windows.Forms.Label();
            this.clockSpeedLabel = new System.Windows.Forms.Label();
            this.memorySizeLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.manufactererTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.coresTextBox = new System.Windows.Forms.TextBox();
            this.clockSpeedTextBox = new System.Windows.Forms.TextBox();
            this.memorySizeTextBox = new System.Windows.Forms.TextBox();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.inventoryView = new System.Windows.Forms.DataGridView();
            this.manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clockSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memorySize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitButton = new System.Windows.Forms.Button();
            this.deleteSelected = new System.Windows.Forms.Button();
            this.updateSelected = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearInputButton = new System.Windows.Forms.Button();
            this.restockAllButton = new System.Windows.Forms.Button();
            this.restockItemButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchFilterComboBox = new System.Windows.Forms.ComboBox();
            this.loadAllButton = new System.Windows.Forms.Button();
            this.filterByLabel = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.transparencyPanel = new System.Windows.Forms.Panel();
            this.hideButton = new System.Windows.Forms.Button();
            this.loginUserControl = new GPU_Inventory.LoginUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryView)).BeginInit();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.titleLabel.Location = new System.Drawing.Point(633, 55);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(422, 69);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "GPU Inventory";
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.manufacturerLabel.Location = new System.Drawing.Point(51, 217);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(108, 20);
            this.manufacturerLabel.TabIndex = 0;
            this.manufacturerLabel.Text = "Manufacturer";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameLabel.Location = new System.Drawing.Point(53, 274);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.priceLabel.Location = new System.Drawing.Point(51, 333);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(48, 20);
            this.priceLabel.TabIndex = 0;
            this.priceLabel.Text = "Price";
            // 
            // coresLabel
            // 
            this.coresLabel.AutoSize = true;
            this.coresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coresLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.coresLabel.Location = new System.Drawing.Point(51, 392);
            this.coresLabel.Name = "coresLabel";
            this.coresLabel.Size = new System.Drawing.Size(54, 20);
            this.coresLabel.TabIndex = 0;
            this.coresLabel.Text = "Cores";
            // 
            // clockSpeedLabel
            // 
            this.clockSpeedLabel.AutoSize = true;
            this.clockSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockSpeedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clockSpeedLabel.Location = new System.Drawing.Point(51, 450);
            this.clockSpeedLabel.Name = "clockSpeedLabel";
            this.clockSpeedLabel.Size = new System.Drawing.Size(103, 20);
            this.clockSpeedLabel.TabIndex = 0;
            this.clockSpeedLabel.Text = "Clock Speed";
            // 
            // memorySizeLabel
            // 
            this.memorySizeLabel.AutoSize = true;
            this.memorySizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memorySizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.memorySizeLabel.Location = new System.Drawing.Point(51, 509);
            this.memorySizeLabel.Name = "memorySizeLabel";
            this.memorySizeLabel.Size = new System.Drawing.Size(107, 20);
            this.memorySizeLabel.TabIndex = 0;
            this.memorySizeLabel.Text = "Memory Size";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inventoryLabel.Location = new System.Drawing.Point(51, 568);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(83, 20);
            this.inventoryLabel.TabIndex = 0;
            this.inventoryLabel.Text = "# In Stock";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addButton.Location = new System.Drawing.Point(55, 633);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(181, 31);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Add New GPU";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // manufactererTextBox
            // 
            this.manufactererTextBox.Location = new System.Drawing.Point(55, 239);
            this.manufactererTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manufactererTextBox.Name = "manufactererTextBox";
            this.manufactererTextBox.Size = new System.Drawing.Size(180, 22);
            this.manufactererTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(55, 296);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(180, 22);
            this.nameTextBox.TabIndex = 2;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(55, 355);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(180, 22);
            this.priceTextBox.TabIndex = 3;
            // 
            // coresTextBox
            // 
            this.coresTextBox.Location = new System.Drawing.Point(55, 414);
            this.coresTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coresTextBox.Name = "coresTextBox";
            this.coresTextBox.Size = new System.Drawing.Size(180, 22);
            this.coresTextBox.TabIndex = 4;
            // 
            // clockSpeedTextBox
            // 
            this.clockSpeedTextBox.Location = new System.Drawing.Point(55, 472);
            this.clockSpeedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clockSpeedTextBox.Name = "clockSpeedTextBox";
            this.clockSpeedTextBox.Size = new System.Drawing.Size(180, 22);
            this.clockSpeedTextBox.TabIndex = 5;
            // 
            // memorySizeTextBox
            // 
            this.memorySizeTextBox.Location = new System.Drawing.Point(55, 531);
            this.memorySizeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memorySizeTextBox.Name = "memorySizeTextBox";
            this.memorySizeTextBox.Size = new System.Drawing.Size(180, 22);
            this.memorySizeTextBox.TabIndex = 6;
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.Location = new System.Drawing.Point(55, 590);
            this.inventoryTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(180, 22);
            this.inventoryTextBox.TabIndex = 7;
            // 
            // inventoryView
            // 
            this.inventoryView.AllowUserToAddRows = false;
            this.inventoryView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.inventoryView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.inventoryView.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventoryView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.inventoryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manufacturer,
            this.name,
            this.price,
            this.cores,
            this.clockSpeed,
            this.memorySize,
            this.quantity});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inventoryView.DefaultCellStyle = dataGridViewCellStyle15;
            this.inventoryView.GridColor = System.Drawing.Color.Black;
            this.inventoryView.Location = new System.Drawing.Point(326, 276);
            this.inventoryView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inventoryView.Name = "inventoryView";
            this.inventoryView.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventoryView.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.inventoryView.RowHeadersWidth = 51;
            this.inventoryView.RowTemplate.Height = 24;
            this.inventoryView.Size = new System.Drawing.Size(1023, 559);
            this.inventoryView.TabIndex = 11;
            this.inventoryView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryView_CellClick);
            // 
            // manufacturer
            // 
            this.manufacturer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.manufacturer.HeaderText = "Manufacturer";
            this.manufacturer.MinimumWidth = 6;
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // cores
            // 
            this.cores.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cores.HeaderText = "Cores";
            this.cores.MinimumWidth = 6;
            this.cores.Name = "cores";
            this.cores.ReadOnly = true;
            // 
            // clockSpeed
            // 
            this.clockSpeed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clockSpeed.HeaderText = "Clock Speed";
            this.clockSpeed.MinimumWidth = 6;
            this.clockSpeed.Name = "clockSpeed";
            this.clockSpeed.ReadOnly = true;
            // 
            // memorySize
            // 
            this.memorySize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.memorySize.HeaderText = "Memory Size";
            this.memorySize.MinimumWidth = 6;
            this.memorySize.Name = "memorySize";
            this.memorySize.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantity.HeaderText = "# In Stock";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.exitButton.Location = new System.Drawing.Point(1331, 2);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(45, 38);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // deleteSelected
            // 
            this.deleteSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.deleteSelected.Location = new System.Drawing.Point(55, 729);
            this.deleteSelected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteSelected.Name = "deleteSelected";
            this.deleteSelected.Size = new System.Drawing.Size(181, 36);
            this.deleteSelected.TabIndex = 17;
            this.deleteSelected.Text = "Delete Selected Row";
            this.deleteSelected.UseVisualStyleBackColor = false;
            this.deleteSelected.Click += new System.EventHandler(this.deleteSelected_Click);
            // 
            // updateSelected
            // 
            this.updateSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updateSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.updateSelected.Location = new System.Drawing.Point(55, 678);
            this.updateSelected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateSelected.Name = "updateSelected";
            this.updateSelected.Size = new System.Drawing.Size(181, 36);
            this.updateSelected.TabIndex = 16;
            this.updateSelected.Text = "Update Selected Row";
            this.updateSelected.UseVisualStyleBackColor = false;
            this.updateSelected.Click += new System.EventHandler(this.updateSelected_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.searchButton.Location = new System.Drawing.Point(543, 234);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(181, 36);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.search_Click);
            // 
            // clearInputButton
            // 
            this.clearInputButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearInputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearInputButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clearInputButton.Location = new System.Drawing.Point(57, 166);
            this.clearInputButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearInputButton.Name = "clearInputButton";
            this.clearInputButton.Size = new System.Drawing.Size(181, 36);
            this.clearInputButton.TabIndex = 11;
            this.clearInputButton.Text = "Clear Input";
            this.clearInputButton.UseVisualStyleBackColor = false;
            this.clearInputButton.Click += new System.EventHandler(this.clearForm_Click);
            // 
            // restockAllButton
            // 
            this.restockAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.restockAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restockAllButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.restockAllButton.Location = new System.Drawing.Point(1208, 234);
            this.restockAllButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.restockAllButton.Name = "restockAllButton";
            this.restockAllButton.Size = new System.Drawing.Size(141, 36);
            this.restockAllButton.TabIndex = 14;
            this.restockAllButton.Text = "Restock All";
            this.restockAllButton.UseVisualStyleBackColor = false;
            this.restockAllButton.Click += new System.EventHandler(this.restockAll_Click);
            // 
            // restockItemButton
            // 
            this.restockItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.restockItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restockItemButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.restockItemButton.Location = new System.Drawing.Point(1208, 193);
            this.restockItemButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.restockItemButton.Name = "restockItemButton";
            this.restockItemButton.Size = new System.Drawing.Size(141, 36);
            this.restockItemButton.TabIndex = 13;
            this.restockItemButton.Text = "Restock Selected";
            this.restockItemButton.UseVisualStyleBackColor = false;
            this.restockItemButton.Click += new System.EventHandler(this.restockSelected_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(327, 234);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(210, 36);
            this.searchTextBox.TabIndex = 8;
            this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchFilterComboBox
            // 
            this.searchFilterComboBox.FormattingEnabled = true;
            this.searchFilterComboBox.Items.AddRange(new object[] {
            "All",
            "Manufacterer",
            "Name",
            "Price",
            "Cores",
            "Clock Speed",
            "Memory Size",
            "# In Stock"});
            this.searchFilterComboBox.Location = new System.Drawing.Point(416, 205);
            this.searchFilterComboBox.Name = "searchFilterComboBox";
            this.searchFilterComboBox.Size = new System.Drawing.Size(121, 24);
            this.searchFilterComboBox.TabIndex = 9;
            this.searchFilterComboBox.Text = "Search Filter";
            // 
            // loadAllButton
            // 
            this.loadAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.loadAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadAllButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loadAllButton.Location = new System.Drawing.Point(726, 234);
            this.loadAllButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadAllButton.Name = "loadAllButton";
            this.loadAllButton.Size = new System.Drawing.Size(181, 36);
            this.loadAllButton.TabIndex = 12;
            this.loadAllButton.Text = "Load All";
            this.loadAllButton.UseVisualStyleBackColor = false;
            this.loadAllButton.Click += new System.EventHandler(this.loadAll_Click);
            // 
            // filterByLabel
            // 
            this.filterByLabel.AutoSize = true;
            this.filterByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterByLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.filterByLabel.Location = new System.Drawing.Point(323, 210);
            this.filterByLabel.Name = "filterByLabel";
            this.filterByLabel.Size = new System.Drawing.Size(77, 20);
            this.filterByLabel.TabIndex = 0;
            this.filterByLabel.Text = "Filter By:";
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.minimizeButton.Location = new System.Drawing.Point(1294, 2);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(45, 38);
            this.minimizeButton.TabIndex = 12;
            this.minimizeButton.Text = "-";
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.controlPanel.Controls.Add(this.transparencyPanel);
            this.controlPanel.Controls.Add(this.clearInputButton);
            this.controlPanel.Controls.Add(this.manufacturerLabel);
            this.controlPanel.Controls.Add(this.updateSelected);
            this.controlPanel.Controls.Add(this.nameLabel);
            this.controlPanel.Controls.Add(this.priceLabel);
            this.controlPanel.Controls.Add(this.coresLabel);
            this.controlPanel.Controls.Add(this.clockSpeedLabel);
            this.controlPanel.Controls.Add(this.memorySizeLabel);
            this.controlPanel.Controls.Add(this.inventoryLabel);
            this.controlPanel.Controls.Add(this.deleteSelected);
            this.controlPanel.Controls.Add(this.addButton);
            this.controlPanel.Controls.Add(this.manufactererTextBox);
            this.controlPanel.Controls.Add(this.inventoryTextBox);
            this.controlPanel.Controls.Add(this.nameTextBox);
            this.controlPanel.Controls.Add(this.memorySizeTextBox);
            this.controlPanel.Controls.Add(this.priceTextBox);
            this.controlPanel.Controls.Add(this.clockSpeedTextBox);
            this.controlPanel.Controls.Add(this.coresTextBox);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(287, 853);
            this.controlPanel.TabIndex = 18;
            // 
            // transparencyPanel
            // 
            this.transparencyPanel.BackColor = System.Drawing.Color.Maroon;
            this.transparencyPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.transparencyPanel.Location = new System.Drawing.Point(0, 0);
            this.transparencyPanel.Name = "transparencyPanel";
            this.transparencyPanel.Size = new System.Drawing.Size(287, 853);
            this.transparencyPanel.TabIndex = 18;
            // 
            // hideButton
            // 
            this.hideButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.hideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hideButton.Location = new System.Drawing.Point(330, 124);
            this.hideButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(181, 36);
            this.hideButton.TabIndex = 12;
            this.hideButton.Text = "Toggle Control Panel";
            this.hideButton.UseVisualStyleBackColor = false;
            this.hideButton.Click += new System.EventHandler(this.toggleControlPanelButton_Click);
            // 
            // loginUserControl
            // 
            this.loginUserControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginUserControl.BackgroundImage")));
            this.loginUserControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginUserControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.loginUserControl.Location = new System.Drawing.Point(287, 0);
            this.loginUserControl.Name = "loginUserControl";
            this.loginUserControl.Size = new System.Drawing.Size(1089, 853);
            this.loginUserControl.TabIndex = 19;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1376, 853);
            this.ControlBox = false;
            this.Controls.Add(this.loginUserControl);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.searchFilterComboBox);
            this.Controls.Add(this.restockItemButton);
            this.Controls.Add(this.restockAllButton);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.loadAllButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.inventoryView);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.filterByLabel);
            this.Controls.Add(this.titleLabel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            ((System.ComponentModel.ISupportInitialize)(this.inventoryView)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label coresLabel;
        private System.Windows.Forms.Label clockSpeedLabel;
        private System.Windows.Forms.Label memorySizeLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox manufactererTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox coresTextBox;
        private System.Windows.Forms.TextBox clockSpeedTextBox;
        private System.Windows.Forms.TextBox memorySizeTextBox;
        private System.Windows.Forms.TextBox inventoryTextBox;
        private System.Windows.Forms.DataGridView inventoryView;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button deleteSelected;
        private System.Windows.Forms.Button updateSelected;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearInputButton;
        private System.Windows.Forms.Button restockAllButton;
        private System.Windows.Forms.Button restockItemButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox searchFilterComboBox;
        private System.Windows.Forms.Button loadAllButton;
        private System.Windows.Forms.Label filterByLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn cores;
        private System.Windows.Forms.DataGridViewTextBoxColumn clockSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn memorySize;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.Panel transparencyPanel;
        private LoginUserControl loginUserControl;
    }
}

