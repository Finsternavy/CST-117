
namespace Programming_Project_3
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
            this.statisticsTextBox = new System.Windows.Forms.TextBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.originalTextBox = new System.Windows.Forms.TextBox();
            this.alteredTextBox = new System.Windows.Forms.TextBox();
            this.statisticsLabel = new System.Windows.Forms.Label();
            this.originalLabel = new System.Windows.Forms.Label();
            this.alteredTextLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // statisticsTextBox
            // 
            this.statisticsTextBox.Location = new System.Drawing.Point(29, 168);
            this.statisticsTextBox.Multiline = true;
            this.statisticsTextBox.Name = "statisticsTextBox";
            this.statisticsTextBox.Size = new System.Drawing.Size(256, 223);
            this.statisticsTextBox.TabIndex = 0;
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(274, 64);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(130, 48);
            this.openFileButton.TabIndex = 1;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // originalTextBox
            // 
            this.originalTextBox.Location = new System.Drawing.Point(291, 168);
            this.originalTextBox.Multiline = true;
            this.originalTextBox.Name = "originalTextBox";
            this.originalTextBox.Size = new System.Drawing.Size(256, 223);
            this.originalTextBox.TabIndex = 0;
            // 
            // alteredTextBox
            // 
            this.alteredTextBox.Location = new System.Drawing.Point(553, 168);
            this.alteredTextBox.Multiline = true;
            this.alteredTextBox.Name = "alteredTextBox";
            this.alteredTextBox.Size = new System.Drawing.Size(256, 223);
            this.alteredTextBox.TabIndex = 0;
            // 
            // statisticsLabel
            // 
            this.statisticsLabel.AutoSize = true;
            this.statisticsLabel.Location = new System.Drawing.Point(29, 149);
            this.statisticsLabel.Name = "statisticsLabel";
            this.statisticsLabel.Size = new System.Drawing.Size(49, 13);
            this.statisticsLabel.TabIndex = 2;
            this.statisticsLabel.Text = "Statistics";
            // 
            // originalLabel
            // 
            this.originalLabel.AutoSize = true;
            this.originalLabel.Location = new System.Drawing.Point(288, 149);
            this.originalLabel.Name = "originalLabel";
            this.originalLabel.Size = new System.Drawing.Size(66, 13);
            this.originalLabel.TabIndex = 2;
            this.originalLabel.Text = "Original Text";
            // 
            // alteredTextLabel
            // 
            this.alteredTextLabel.AutoSize = true;
            this.alteredTextLabel.Location = new System.Drawing.Point(550, 149);
            this.alteredTextLabel.Name = "alteredTextLabel";
            this.alteredTextLabel.Size = new System.Drawing.Size(64, 13);
            this.alteredTextLabel.TabIndex = 2;
            this.alteredTextLabel.Text = "Altered Text";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(433, 64);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(130, 48);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save File";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 454);
            this.Controls.Add(this.alteredTextLabel);
            this.Controls.Add(this.originalLabel);
            this.Controls.Add(this.statisticsLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.alteredTextBox);
            this.Controls.Add(this.originalTextBox);
            this.Controls.Add(this.statisticsTextBox);
            this.Name = "Form1";
            this.Text = "CST-117 Programming Project 3 by Christopher Finster";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox statisticsTextBox;
        private System.Windows.Forms.Button openFileButton;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label alteredTextLabel;
        private System.Windows.Forms.Label originalLabel;
        private System.Windows.Forms.Label statisticsLabel;
        private System.Windows.Forms.TextBox alteredTextBox;
        private System.Windows.Forms.TextBox originalTextBox;
        private System.Windows.Forms.Button saveButton;

    }
}

