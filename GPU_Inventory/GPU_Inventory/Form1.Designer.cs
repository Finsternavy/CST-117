
namespace GPU_Inventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titleLabel = new System.Windows.Forms.Label();
            this.manufactererLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.msrpLabel = new System.Windows.Forms.Label();
            this.coresLabel = new System.Windows.Forms.Label();
            this.clockSpeedLabel = new System.Windows.Forms.Label();
            this.memorySizeLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.manufactererTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.msrpTextBox = new System.Windows.Forms.TextBox();
            this.coresTextBox = new System.Windows.Forms.TextBox();
            this.clockSpeedTextBox = new System.Windows.Forms.TextBox();
            this.memorySizeTextBox = new System.Windows.Forms.TextBox();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exitButton = new System.Windows.Forms.Button();
            this.deleteSelected = new System.Windows.Forms.Button();
            this.updateSelected = new System.Windows.Forms.Button();
            this.manufacterer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msrp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clockSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memorySize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.titleLabel.Location = new System.Drawing.Point(344, 55);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(339, 55);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "GPU Inventory";
            // 
            // manufactererLabel
            // 
            this.manufactererLabel.AutoSize = true;
            this.manufactererLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufactererLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.manufactererLabel.Location = new System.Drawing.Point(35, 178);
            this.manufactererLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manufactererLabel.Name = "manufactererLabel";
            this.manufactererLabel.Size = new System.Drawing.Size(86, 16);
            this.manufactererLabel.TabIndex = 0;
            this.manufactererLabel.Text = "Manufacterer";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nameLabel.Location = new System.Drawing.Point(37, 224);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 16);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // msrpLabel
            // 
            this.msrpLabel.AutoSize = true;
            this.msrpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msrpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.msrpLabel.Location = new System.Drawing.Point(35, 272);
            this.msrpLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.msrpLabel.Name = "msrpLabel";
            this.msrpLabel.Size = new System.Drawing.Size(47, 16);
            this.msrpLabel.TabIndex = 0;
            this.msrpLabel.Text = "MSRP";
            // 
            // coresLabel
            // 
            this.coresLabel.AutoSize = true;
            this.coresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coresLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.coresLabel.Location = new System.Drawing.Point(35, 320);
            this.coresLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.coresLabel.Name = "coresLabel";
            this.coresLabel.Size = new System.Drawing.Size(44, 16);
            this.coresLabel.TabIndex = 0;
            this.coresLabel.Text = "Cores";
            // 
            // clockSpeedLabel
            // 
            this.clockSpeedLabel.AutoSize = true;
            this.clockSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockSpeedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clockSpeedLabel.Location = new System.Drawing.Point(35, 367);
            this.clockSpeedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clockSpeedLabel.Name = "clockSpeedLabel";
            this.clockSpeedLabel.Size = new System.Drawing.Size(86, 16);
            this.clockSpeedLabel.TabIndex = 0;
            this.clockSpeedLabel.Text = "Clock Speed";
            // 
            // memorySizeLabel
            // 
            this.memorySizeLabel.AutoSize = true;
            this.memorySizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memorySizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.memorySizeLabel.Location = new System.Drawing.Point(35, 415);
            this.memorySizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.memorySizeLabel.Name = "memorySizeLabel";
            this.memorySizeLabel.Size = new System.Drawing.Size(86, 16);
            this.memorySizeLabel.TabIndex = 0;
            this.memorySizeLabel.Text = "Memory Size";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.inventoryLabel.Location = new System.Drawing.Point(35, 463);
            this.inventoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(65, 16);
            this.inventoryLabel.TabIndex = 0;
            this.inventoryLabel.Text = "# In Stock";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(38, 516);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(136, 25);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add New GPU";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // manufactererTextBox
            // 
            this.manufactererTextBox.Location = new System.Drawing.Point(38, 196);
            this.manufactererTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manufactererTextBox.Name = "manufactererTextBox";
            this.manufactererTextBox.Size = new System.Drawing.Size(136, 20);
            this.manufactererTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(38, 242);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(136, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // msrpTextBox
            // 
            this.msrpTextBox.Location = new System.Drawing.Point(38, 290);
            this.msrpTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.msrpTextBox.Name = "msrpTextBox";
            this.msrpTextBox.Size = new System.Drawing.Size(136, 20);
            this.msrpTextBox.TabIndex = 3;
            // 
            // coresTextBox
            // 
            this.coresTextBox.Location = new System.Drawing.Point(38, 338);
            this.coresTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.coresTextBox.Name = "coresTextBox";
            this.coresTextBox.Size = new System.Drawing.Size(136, 20);
            this.coresTextBox.TabIndex = 4;
            // 
            // clockSpeedTextBox
            // 
            this.clockSpeedTextBox.Location = new System.Drawing.Point(38, 385);
            this.clockSpeedTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clockSpeedTextBox.Name = "clockSpeedTextBox";
            this.clockSpeedTextBox.Size = new System.Drawing.Size(136, 20);
            this.clockSpeedTextBox.TabIndex = 5;
            // 
            // memorySizeTextBox
            // 
            this.memorySizeTextBox.Location = new System.Drawing.Point(38, 433);
            this.memorySizeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.memorySizeTextBox.Name = "memorySizeTextBox";
            this.memorySizeTextBox.Size = new System.Drawing.Size(136, 20);
            this.memorySizeTextBox.TabIndex = 6;
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.Location = new System.Drawing.Point(38, 481);
            this.inventoryTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(136, 20);
            this.inventoryTextBox.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manufacterer,
            this.name,
            this.msrp,
            this.cores,
            this.clockSpeed,
            this.memorySize,
            this.quantity});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(213, 169);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(767, 454);
            this.dataGridView1.TabIndex = 11;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.exitButton.Location = new System.Drawing.Point(987, 11);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(34, 31);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // deleteSelected
            // 
            this.deleteSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.deleteSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelected.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteSelected.Location = new System.Drawing.Point(38, 578);
            this.deleteSelected.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteSelected.Name = "deleteSelected";
            this.deleteSelected.Size = new System.Drawing.Size(136, 29);
            this.deleteSelected.TabIndex = 9;
            this.deleteSelected.Text = "Delete Selected Row";
            this.deleteSelected.UseVisualStyleBackColor = false;
            this.deleteSelected.Click += new System.EventHandler(this.deleteSelected_Click);
            // 
            // updateSelected
            // 
            this.updateSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.updateSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateSelected.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updateSelected.Location = new System.Drawing.Point(38, 545);
            this.updateSelected.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateSelected.Name = "updateSelected";
            this.updateSelected.Size = new System.Drawing.Size(136, 29);
            this.updateSelected.TabIndex = 10;
            this.updateSelected.Text = "Update Selected Row";
            this.updateSelected.UseVisualStyleBackColor = false;
            this.updateSelected.Click += new System.EventHandler(this.updateSelected_Click);
            // 
            // manufacterer
            // 
            this.manufacterer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.manufacterer.HeaderText = "Manufacterer";
            this.manufacterer.MinimumWidth = 6;
            this.manufacterer.Name = "manufacterer";
            this.manufacterer.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // msrp
            // 
            this.msrp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.msrp.HeaderText = "MSRP";
            this.msrp.MinimumWidth = 6;
            this.msrp.Name = "msrp";
            this.msrp.ReadOnly = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 693);
            this.Controls.Add(this.updateSelected);
            this.Controls.Add(this.deleteSelected);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.memorySizeTextBox);
            this.Controls.Add(this.clockSpeedTextBox);
            this.Controls.Add(this.coresTextBox);
            this.Controls.Add(this.msrpTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.manufactererTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.memorySizeLabel);
            this.Controls.Add(this.clockSpeedLabel);
            this.Controls.Add(this.coresLabel);
            this.Controls.Add(this.msrpLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.manufactererLabel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label manufactererLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label msrpLabel;
        private System.Windows.Forms.Label coresLabel;
        private System.Windows.Forms.Label clockSpeedLabel;
        private System.Windows.Forms.Label memorySizeLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox manufactererTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox msrpTextBox;
        private System.Windows.Forms.TextBox coresTextBox;
        private System.Windows.Forms.TextBox clockSpeedTextBox;
        private System.Windows.Forms.TextBox memorySizeTextBox;
        private System.Windows.Forms.TextBox inventoryTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button deleteSelected;
        private System.Windows.Forms.Button updateSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacterer;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn msrp;
        private System.Windows.Forms.DataGridViewTextBoxColumn cores;
        private System.Windows.Forms.DataGridViewTextBoxColumn clockSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn memorySize;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
    }
}

