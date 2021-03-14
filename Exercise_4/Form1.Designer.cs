
namespace Exercise_4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// This application will convert seconds to the appropriate metric based on the following arguments:
        /// If the number of seconds is greater than or equal to 60, display the number of minutes in that many seconds
        /// If the number of seconds is greater than or equal to 3600, display the number of hours in that many seconds
        /// If the number of seconds is greater than or equal to 86,400, display the number of days in that many second
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
            this.secondsTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.daysLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // secondsTextBox
            // 
            this.secondsTextBox.Location = new System.Drawing.Point(415, 123);
            this.secondsTextBox.Multiline = true;
            this.secondsTextBox.Name = "secondsTextBox";
            this.secondsTextBox.Size = new System.Drawing.Size(116, 20);
            this.secondsTextBox.TabIndex = 0;
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.Color.Transparent;
            this.convertButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.convertButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.convertButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertButton.Location = new System.Drawing.Point(284, 170);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(107, 37);
            this.convertButton.TabIndex = 2;
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(406, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 37);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.complexConvertButton_Click);
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.BackColor = System.Drawing.Color.Transparent;
            this.daysLabel.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysLabel.ForeColor = System.Drawing.Color.Purple;
            this.daysLabel.Location = new System.Drawing.Point(128, 278);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(141, 62);
            this.daysLabel.TabIndex = 3;
            this.daysLabel.Text = "000";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.BackColor = System.Drawing.Color.Transparent;
            this.hoursLabel.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursLabel.ForeColor = System.Drawing.Color.Aqua;
            this.hoursLabel.Location = new System.Drawing.Point(331, 278);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(141, 62);
            this.hoursLabel.TabIndex = 3;
            this.hoursLabel.Text = "000";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.BackColor = System.Drawing.Color.Transparent;
            this.minutesLabel.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesLabel.ForeColor = System.Drawing.Color.Lime;
            this.minutesLabel.Location = new System.Drawing.Point(533, 278);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(141, 62);
            this.minutesLabel.TabIndex = 3;
            this.minutesLabel.Text = "000";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(771, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 20);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.xButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.secondsTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox secondsTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Button button2;
    }
}

