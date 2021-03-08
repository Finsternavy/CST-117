
namespace W1_Exercise_1
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
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.generateMessageBtn = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.colorDropDownBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(343, 29);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(100, 13);
            this.label.TabIndex = 0;
            this.label.Text = "Week 1: Exercise 1";
            this.label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter your name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "What\'s your favorite Color?";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(346, 107);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(277, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // generateMessageBtn
            // 
            this.generateMessageBtn.Location = new System.Drawing.Point(480, 219);
            this.generateMessageBtn.Name = "generateMessageBtn";
            this.generateMessageBtn.Size = new System.Drawing.Size(143, 23);
            this.generateMessageBtn.TabIndex = 3;
            this.generateMessageBtn.Text = "Generate Message";
            this.generateMessageBtn.UseVisualStyleBackColor = true;
            this.generateMessageBtn.Click += new System.EventHandler(this.generateMessageBtn_Click_1);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(132, 267);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 4;
            // 
            // colorDropDownBox
            // 
            this.colorDropDownBox.FormattingEnabled = true;
            this.colorDropDownBox.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Yellow",
            "Black",
            "Pink",
            "White",
            "Brown",
            "Green",
            "Orange"});
            this.colorDropDownBox.Location = new System.Drawing.Point(346, 142);
            this.colorDropDownBox.Name = "colorDropDownBox";
            this.colorDropDownBox.Size = new System.Drawing.Size(277, 21);
            this.colorDropDownBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.colorDropDownBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.generateMessageBtn);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button generateMessageBtn;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.ComboBox colorDropDownBox;
    }
}

