
namespace LuckyNumber
{
    partial class LuckyNumberResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LuckyNumberResults));
            this.luckyNumberLabel = new System.Windows.Forms.Label();
            this.luckyMessageLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // luckyNumberLabel
            // 
            this.luckyNumberLabel.AutoSize = true;
            this.luckyNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.luckyNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luckyNumberLabel.Location = new System.Drawing.Point(258, 149);
            this.luckyNumberLabel.Name = "luckyNumberLabel";
            this.luckyNumberLabel.Size = new System.Drawing.Size(317, 226);
            this.luckyNumberLabel.TabIndex = 0;
            this.luckyNumberLabel.Text = "88";
            this.luckyNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // luckyMessageLabel
            // 
            this.luckyMessageLabel.AutoSize = true;
            this.luckyMessageLabel.BackColor = System.Drawing.Color.Transparent;
            this.luckyMessageLabel.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luckyMessageLabel.Location = new System.Drawing.Point(138, 89);
            this.luckyMessageLabel.Name = "luckyMessageLabel";
            this.luckyMessageLabel.Size = new System.Drawing.Size(590, 60);
            this.luckyMessageLabel.TabIndex = 1;
            this.luckyMessageLabel.Text = "YOUR LUCKY NUMBER IS";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(755, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 64);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // LuckyNumberResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(842, 488);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.luckyMessageLabel);
            this.Controls.Add(this.luckyNumberLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LuckyNumberResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lucky Number Results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label luckyNumberLabel;
        private System.Windows.Forms.Label luckyMessageLabel;
        private System.Windows.Forms.Button exitButton;
    }
}