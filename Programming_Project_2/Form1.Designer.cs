
namespace Programming_Project_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.teamListBox = new System.Windows.Forms.ListBox();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.preferredTeamLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.joinTeamButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.profilePreviewLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.previewLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.clickImageLabel = new System.Windows.Forms.Label();
            this.employeesLabel = new System.Windows.Forms.Label();
            this.employeesListLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phoneCheckBox = new System.Windows.Forms.CheckBox();
            this.firstNameCheckBox = new System.Windows.Forms.CheckBox();
            this.emailCheckBox = new System.Windows.Forms.CheckBox();
            this.ageCheckBox = new System.Windows.Forms.CheckBox();
            this.lastNameCheckBox = new System.Windows.Forms.CheckBox();
            this.sexCheckBox = new System.Windows.Forms.CheckBox();
            this.teamCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(391, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // teamListBox
            // 
            this.teamListBox.FormattingEnabled = true;
            this.teamListBox.Items.AddRange(new object[] {
            "Red Team",
            "Blue Team",
            "Green Team"});
            this.teamListBox.Location = new System.Drawing.Point(67, 168);
            this.teamListBox.Name = "teamListBox";
            this.teamListBox.Size = new System.Drawing.Size(82, 43);
            this.teamListBox.TabIndex = 7;
            this.teamListBox.SelectedIndexChanged += new System.EventHandler(this.teamListBox_SelectedIndexChanged);
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(227, 177);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.maleRadioButton.TabIndex = 8;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            this.maleRadioButton.CheckedChanged += new System.EventHandler(this.maleRadioButton_CheckedChanged);
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(306, 177);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.femaleRadioButton.TabIndex = 9;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // preferredTeamLabel
            // 
            this.preferredTeamLabel.AutoSize = true;
            this.preferredTeamLabel.Location = new System.Drawing.Point(64, 152);
            this.preferredTeamLabel.Name = "preferredTeamLabel";
            this.preferredTeamLabel.Size = new System.Drawing.Size(80, 13);
            this.preferredTeamLabel.TabIndex = 4;
            this.preferredTeamLabel.Text = "Preferred Team";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(224, 152);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(25, 13);
            this.sexLabel.TabIndex = 4;
            this.sexLabel.Text = "Sex";
            // 
            // joinTeamButton
            // 
            this.joinTeamButton.Location = new System.Drawing.Point(325, 322);
            this.joinTeamButton.Name = "joinTeamButton";
            this.joinTeamButton.Size = new System.Drawing.Size(130, 34);
            this.joinTeamButton.TabIndex = 11;
            this.joinTeamButton.Text = "Join Team";
            this.joinTeamButton.UseVisualStyleBackColor = true;
            this.joinTeamButton.Click += new System.EventHandler(this.joinTeamButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(461, 322);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(130, 34);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // profilePreviewLabel
            // 
            this.profilePreviewLabel.AutoSize = true;
            this.profilePreviewLabel.Location = new System.Drawing.Point(456, 21);
            this.profilePreviewLabel.Name = "profilePreviewLabel";
            this.profilePreviewLabel.Size = new System.Drawing.Size(77, 13);
            this.profilePreviewLabel.TabIndex = 4;
            this.profilePreviewLabel.Text = "Profile Preview";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(27, 66);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "First Name";
            // 
            // previewLabel
            // 
            this.previewLabel.AutoSize = true;
            this.previewLabel.Location = new System.Drawing.Point(388, 262);
            this.previewLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.previewLabel.Name = "previewLabel";
            this.previewLabel.Size = new System.Drawing.Size(0, 13);
            this.previewLabel.TabIndex = 7;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(90, 59);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(97, 20);
            this.firstNameTextBox.TabIndex = 1;

            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(204, 66);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(268, 60);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(97, 20);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(90, 85);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(97, 20);
            this.emailTextBox.TabIndex = 3;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(90, 111);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(97, 20);
            this.ageTextBox.TabIndex = 5;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(268, 86);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(97, 20);
            this.phoneTextBox.TabIndex = 4;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(224, 92);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneLabel.TabIndex = 6;
            this.phoneLabel.Text = "Phone";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(52, 93);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(58, 118);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(26, 13);
            this.ageLabel.TabIndex = 6;
            this.ageLabel.Text = "Age";
            // 
            // clickImageLabel
            // 
            this.clickImageLabel.AutoSize = true;
            this.clickImageLabel.Location = new System.Drawing.Point(388, 43);
            this.clickImageLabel.Name = "clickImageLabel";
            this.clickImageLabel.Size = new System.Drawing.Size(120, 13);
            this.clickImageLabel.TabIndex = 4;
            this.clickImageLabel.Text = "(Click Image to Change)";
            // 
            // employeesLabel
            // 
            this.employeesLabel.AutoSize = true;
            this.employeesLabel.Location = new System.Drawing.Point(67, 398);
            this.employeesLabel.Name = "employeesLabel";
            this.employeesLabel.Size = new System.Drawing.Size(61, 13);
            this.employeesLabel.TabIndex = 14;
            this.employeesLabel.Text = "Employees:";
            // 
            // employeesListLabel
            // 
            this.employeesListLabel.AutoSize = true;
            this.employeesListLabel.Location = new System.Drawing.Point(67, 424);
            this.employeesListLabel.Name = "employeesListLabel";
            this.employeesListLabel.Size = new System.Drawing.Size(0, 13);
            this.employeesListLabel.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.teamCheckBox);
            this.groupBox1.Controls.Add(this.sexCheckBox);
            this.groupBox1.Controls.Add(this.phoneCheckBox);
            this.groupBox1.Controls.Add(this.firstNameCheckBox);
            this.groupBox1.Controls.Add(this.emailCheckBox);
            this.groupBox1.Controls.Add(this.ageCheckBox);
            this.groupBox1.Controls.Add(this.lastNameCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(67, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 113);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Visible To Others";
            // 
            // phoneCheckBox
            // 
            this.phoneCheckBox.AutoSize = true;
            this.phoneCheckBox.Location = new System.Drawing.Point(119, 42);
            this.phoneCheckBox.Name = "phoneCheckBox";
            this.phoneCheckBox.Size = new System.Drawing.Size(57, 17);
            this.phoneCheckBox.TabIndex = 14;
            this.phoneCheckBox.Text = "Phone";
            this.phoneCheckBox.UseVisualStyleBackColor = true;
            // 
            // firstNameCheckBox
            // 
            this.firstNameCheckBox.AutoSize = true;
            this.firstNameCheckBox.Location = new System.Drawing.Point(4, 19);
            this.firstNameCheckBox.Name = "firstNameCheckBox";
            this.firstNameCheckBox.Size = new System.Drawing.Size(76, 17);
            this.firstNameCheckBox.TabIndex = 15;
            this.firstNameCheckBox.Text = "First Name";
            this.firstNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // emailCheckBox
            // 
            this.emailCheckBox.AutoSize = true;
            this.emailCheckBox.Location = new System.Drawing.Point(4, 42);
            this.emailCheckBox.Name = "emailCheckBox";
            this.emailCheckBox.Size = new System.Drawing.Size(51, 17);
            this.emailCheckBox.TabIndex = 16;
            this.emailCheckBox.Text = "Email";
            this.emailCheckBox.UseVisualStyleBackColor = true;
            // 
            // ageCheckBox
            // 
            this.ageCheckBox.AutoSize = true;
            this.ageCheckBox.Location = new System.Drawing.Point(4, 65);
            this.ageCheckBox.Name = "ageCheckBox";
            this.ageCheckBox.Size = new System.Drawing.Size(45, 17);
            this.ageCheckBox.TabIndex = 17;
            this.ageCheckBox.Text = "Age";
            this.ageCheckBox.UseVisualStyleBackColor = true;
            // 
            // lastNameCheckBox
            // 
            this.lastNameCheckBox.AutoSize = true;
            this.lastNameCheckBox.Location = new System.Drawing.Point(119, 19);
            this.lastNameCheckBox.Name = "lastNameCheckBox";
            this.lastNameCheckBox.Size = new System.Drawing.Size(77, 17);
            this.lastNameCheckBox.TabIndex = 18;
            this.lastNameCheckBox.Text = "Last Name";
            this.lastNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // sexCheckBox
            // 
            this.sexCheckBox.AutoSize = true;
            this.sexCheckBox.Location = new System.Drawing.Point(119, 65);
            this.sexCheckBox.Name = "sexCheckBox";
            this.sexCheckBox.Size = new System.Drawing.Size(44, 17);
            this.sexCheckBox.TabIndex = 14;
            this.sexCheckBox.Text = "Sex";
            this.sexCheckBox.UseVisualStyleBackColor = true;
            // 
            // teamCheckBox
            // 
            this.teamCheckBox.AutoSize = true;
            this.teamCheckBox.Location = new System.Drawing.Point(3, 88);
            this.teamCheckBox.Name = "teamCheckBox";
            this.teamCheckBox.Size = new System.Drawing.Size(53, 17);
            this.teamCheckBox.TabIndex = 14;
            this.teamCheckBox.Text = "Team";
            this.teamCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(626, 603);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.employeesListLabel);
            this.Controls.Add(this.employeesLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.previewLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.joinTeamButton);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.clickImageLabel);
            this.Controls.Add(this.profilePreviewLabel);
            this.Controls.Add(this.preferredTeamLabel);
            this.Controls.Add(this.femaleRadioButton);
            this.Controls.Add(this.maleRadioButton);
            this.Controls.Add(this.teamListBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Employee Profile Updater";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox teamListBox;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.Label preferredTeamLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Button joinTeamButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label profilePreviewLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label previewLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label clickImageLabel;
        private System.Windows.Forms.Label employeesLabel;
        private System.Windows.Forms.Label employeesListLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox phoneCheckBox;
        private System.Windows.Forms.CheckBox firstNameCheckBox;
        private System.Windows.Forms.CheckBox emailCheckBox;
        private System.Windows.Forms.CheckBox ageCheckBox;
        private System.Windows.Forms.CheckBox lastNameCheckBox;
        private System.Windows.Forms.CheckBox teamCheckBox;
        private System.Windows.Forms.CheckBox sexCheckBox;
    }
}

