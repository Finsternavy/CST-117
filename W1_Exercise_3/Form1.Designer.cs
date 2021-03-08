
namespace W1_Exercise_3
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
            this.inchesInputLable = new System.Windows.Forms.Label();
            this.inchesTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.millimetersLabel = new System.Windows.Forms.Label();
            this.millimetersTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.inchesErrorLabel = new System.Windows.Forms.Label();
            this.millimetersErrorLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inchesInputLable
            // 
            this.inchesInputLable.AutoSize = true;
            this.inchesInputLable.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inchesInputLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.inchesInputLable.Location = new System.Drawing.Point(269, 176);
            this.inchesInputLable.Name = "inchesInputLable";
            this.inchesInputLable.Size = new System.Drawing.Size(83, 27);
            this.inchesInputLable.TabIndex = 0;
            this.inchesInputLable.Text = "Inches";
            this.inchesInputLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // inchesTextBox
            // 
            this.inchesTextBox.BackColor = System.Drawing.Color.Silver;
            this.inchesTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inchesTextBox.Location = new System.Drawing.Point(358, 177);
            this.inchesTextBox.Name = "inchesTextBox";
            this.inchesTextBox.Size = new System.Drawing.Size(118, 26);
            this.inchesTextBox.TabIndex = 1;
            this.inchesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(123, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(566, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Convert inches to millimeters or millimeters to inches";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // millimetersLabel
            // 
            this.millimetersLabel.AutoSize = true;
            this.millimetersLabel.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.millimetersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.millimetersLabel.Location = new System.Drawing.Point(218, 214);
            this.millimetersLabel.Name = "millimetersLabel";
            this.millimetersLabel.Size = new System.Drawing.Size(134, 27);
            this.millimetersLabel.TabIndex = 0;
            this.millimetersLabel.Text = "Millimeters";
            this.millimetersLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // millimetersTextBox
            // 
            this.millimetersTextBox.BackColor = System.Drawing.Color.Silver;
            this.millimetersTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.millimetersTextBox.Location = new System.Drawing.Point(358, 215);
            this.millimetersTextBox.Name = "millimetersTextBox";
            this.millimetersTextBox.Size = new System.Drawing.Size(118, 26);
            this.millimetersTextBox.TabIndex = 1;
            this.millimetersTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.convertButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.convertButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.convertButton.Location = new System.Drawing.Point(736, 12);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(45, 34);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "X";
            this.convertButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.xButton);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearButton.Location = new System.Drawing.Point(358, 302);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(118, 34);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // inchesErrorLabel
            // 
            this.inchesErrorLabel.AutoSize = true;
            this.inchesErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.inchesErrorLabel.Location = new System.Drawing.Point(497, 184);
            this.inchesErrorLabel.Name = "inchesErrorLabel";
            this.inchesErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.inchesErrorLabel.TabIndex = 3;
            // 
            // millimetersErrorLabel
            // 
            this.millimetersErrorLabel.AutoSize = true;
            this.millimetersErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.millimetersErrorLabel.Location = new System.Drawing.Point(497, 228);
            this.millimetersErrorLabel.Name = "millimetersErrorLabel";
            this.millimetersErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.millimetersErrorLabel.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(358, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "CONVERT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.convertButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 466);
            this.Controls.Add(this.millimetersErrorLabel);
            this.Controls.Add(this.inchesErrorLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.millimetersTextBox);
            this.Controls.Add(this.inchesTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.millimetersLabel);
            this.Controls.Add(this.inchesInputLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inch and Millimeter Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inchesInputLable;
        private System.Windows.Forms.TextBox inchesTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label millimetersLabel;
        private System.Windows.Forms.TextBox millimetersTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label inchesErrorLabel;
        private System.Windows.Forms.Label millimetersErrorLabel;
        private System.Windows.Forms.Button button1;
    }
}

