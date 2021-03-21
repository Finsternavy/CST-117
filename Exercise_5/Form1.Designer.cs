
namespace Exercise_5
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
            this.termsLabel = new System.Windows.Forms.Label();
            this.termsTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.approximateInputLabel = new System.Windows.Forms.Label();
            this.piEqualsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // termsLabel
            // 
            this.termsLabel.AutoSize = true;
            this.termsLabel.Location = new System.Drawing.Point(41, 47);
            this.termsLabel.Name = "termsLabel";
            this.termsLabel.Size = new System.Drawing.Size(85, 13);
            this.termsLabel.TabIndex = 0;
            this.termsLabel.Text = "Enter # of terms:";
            // 
            // termsTextBox
            // 
            this.termsTextBox.Location = new System.Drawing.Point(154, 44);
            this.termsTextBox.Name = "termsTextBox";
            this.termsTextBox.Size = new System.Drawing.Size(100, 20);
            this.termsTextBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(44, 85);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(90, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "CALCULATE";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // approximateInputLabel
            // 
            this.approximateInputLabel.AutoSize = true;
            this.approximateInputLabel.Location = new System.Drawing.Point(41, 133);
            this.approximateInputLabel.Name = "approximateInputLabel";
            this.approximateInputLabel.Size = new System.Drawing.Size(120, 13);
            this.approximateInputLabel.TabIndex = 0;
            this.approximateInputLabel.Text = "Approximate value of pi ";
            // 
            // piEqualsLabel
            // 
            this.piEqualsLabel.AutoSize = true;
            this.piEqualsLabel.Location = new System.Drawing.Point(41, 165);
            this.piEqualsLabel.Name = "piEqualsLabel";
            this.piEqualsLabel.Size = new System.Drawing.Size(16, 13);
            this.piEqualsLabel.TabIndex = 0;
            this.piEqualsLabel.Text = "= ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 275);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.termsTextBox);
            this.Controls.Add(this.piEqualsLabel);
            this.Controls.Add(this.approximateInputLabel);
            this.Controls.Add(this.termsLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Approximate Pi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label termsLabel;
        private System.Windows.Forms.TextBox termsTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label approximateInputLabel;
        private System.Windows.Forms.Label piEqualsLabel;
    }
}

