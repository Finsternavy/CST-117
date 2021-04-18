
namespace LuckyNumber
{
    partial class LuckNumberGenerator
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
            this.heightLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.headsOrTailsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.siblingsTextBox = new System.Windows.Forms.TextBox();
            this.luckyNumberButton = new System.Windows.Forms.Button();
            this.coinFlipChoice = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(256, 88);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(181, 17);
            this.heightLabel.TabIndex = 0;
            this.heightLabel.Text = "Enter your height in inches:";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(319, 132);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(118, 17);
            this.ageLabel.TabIndex = 0;
            this.ageLabel.Text = "How old are you?";
            // 
            // headsOrTailsLabel
            // 
            this.headsOrTailsLabel.AutoSize = true;
            this.headsOrTailsLabel.Location = new System.Drawing.Point(334, 178);
            this.headsOrTailsLabel.Name = "headsOrTailsLabel";
            this.headsOrTailsLabel.Size = new System.Drawing.Size(103, 17);
            this.headsOrTailsLabel.TabIndex = 0;
            this.headsOrTailsLabel.Text = "Heads or tails?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many siblings?";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(443, 83);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 22);
            this.heightTextBox.TabIndex = 1;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(443, 127);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 22);
            this.ageTextBox.TabIndex = 1;
            // 
            // siblingsTextBox
            // 
            this.siblingsTextBox.Location = new System.Drawing.Point(443, 224);
            this.siblingsTextBox.Name = "siblingsTextBox";
            this.siblingsTextBox.Size = new System.Drawing.Size(100, 22);
            this.siblingsTextBox.TabIndex = 1;
            // 
            // luckyNumberButton
            // 
            this.luckyNumberButton.Location = new System.Drawing.Point(259, 292);
            this.luckyNumberButton.Name = "luckyNumberButton";
            this.luckyNumberButton.Size = new System.Drawing.Size(284, 48);
            this.luckyNumberButton.TabIndex = 2;
            this.luckyNumberButton.Text = "What\'s my lucky number?";
            this.luckyNumberButton.UseVisualStyleBackColor = true;
            this.luckyNumberButton.Click += new System.EventHandler(this.luckyNumberButton_Click);
            // 
            // coinFlipChoice
            // 
            this.coinFlipChoice.FormattingEnabled = true;
            this.coinFlipChoice.Items.AddRange(new object[] {
            "Heads",
            "Tails"});
            this.coinFlipChoice.Location = new System.Drawing.Point(444, 178);
            this.coinFlipChoice.Name = "coinFlipChoice";
            this.coinFlipChoice.Size = new System.Drawing.Size(99, 24);
            this.coinFlipChoice.TabIndex = 3;
            // 
            // LuckNumberGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.coinFlipChoice);
            this.Controls.Add(this.luckyNumberButton);
            this.Controls.Add(this.siblingsTextBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headsOrTailsLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.heightLabel);
            this.Name = "LuckNumberGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lucky Number Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label headsOrTailsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox siblingsTextBox;
        private System.Windows.Forms.Button luckyNumberButton;
        private System.Windows.Forms.ComboBox coinFlipChoice;
    }
}

