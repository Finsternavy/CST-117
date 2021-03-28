
namespace Exercise_6
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
            this.rollButton = new System.Windows.Forms.Button();
            this.die1Label = new System.Windows.Forms.Label();
            this.die2Label = new System.Windows.Forms.Label();
            this.diceSideAssignmentLabel = new System.Windows.Forms.Label();
            this.diceSideAssignmentTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rollButton
            // 
            this.rollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollButton.Location = new System.Drawing.Point(99, 158);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(190, 190);
            this.rollButton.TabIndex = 0;
            this.rollButton.Text = "Roll Dice";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // die1Label
            // 
            this.die1Label.AutoSize = true;
            this.die1Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.die1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.die1Label.ForeColor = System.Drawing.SystemColors.Control;
            this.die1Label.Location = new System.Drawing.Point(323, 158);
            this.die1Label.MaximumSize = new System.Drawing.Size(190, 190);
            this.die1Label.MinimumSize = new System.Drawing.Size(190, 190);
            this.die1Label.Name = "die1Label";
            this.die1Label.Size = new System.Drawing.Size(190, 190);
            this.die1Label.TabIndex = 1;
            this.die1Label.Text = "20";
            this.die1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // die2Label
            // 
            this.die2Label.AutoSize = true;
            this.die2Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.die2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.die2Label.ForeColor = System.Drawing.SystemColors.Control;
            this.die2Label.Location = new System.Drawing.Point(534, 158);
            this.die2Label.MaximumSize = new System.Drawing.Size(190, 190);
            this.die2Label.MinimumSize = new System.Drawing.Size(190, 190);
            this.die2Label.Name = "die2Label";
            this.die2Label.Size = new System.Drawing.Size(190, 190);
            this.die2Label.TabIndex = 1;
            this.die2Label.Text = "20";
            this.die2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diceSideAssignmentLabel
            // 
            this.diceSideAssignmentLabel.AutoSize = true;
            this.diceSideAssignmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceSideAssignmentLabel.Location = new System.Drawing.Point(94, 70);
            this.diceSideAssignmentLabel.Name = "diceSideAssignmentLabel";
            this.diceSideAssignmentLabel.Size = new System.Drawing.Size(419, 25);
            this.diceSideAssignmentLabel.TabIndex = 2;
            this.diceSideAssignmentLabel.Text = "How many sides should the dice have? (4 - 20)";
            // 
            // diceSideAssignmentTextbox
            // 
            this.diceSideAssignmentTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceSideAssignmentTextbox.Location = new System.Drawing.Point(537, 64);
            this.diceSideAssignmentTextbox.Multiline = true;
            this.diceSideAssignmentTextbox.Name = "diceSideAssignmentTextbox";
            this.diceSideAssignmentTextbox.Size = new System.Drawing.Size(187, 40);
            this.diceSideAssignmentTextbox.TabIndex = 3;
            this.diceSideAssignmentTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.diceSideAssignmentTextbox);
            this.Controls.Add(this.diceSideAssignmentLabel);
            this.Controls.Add(this.die2Label);
            this.Controls.Add(this.die1Label);
            this.Controls.Add(this.rollButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "How Many Rolls to Snake Eyes?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Label die1Label;
        private System.Windows.Forms.Label die2Label;
        private System.Windows.Forms.Label diceSideAssignmentLabel;
        private System.Windows.Forms.TextBox diceSideAssignmentTextbox;
    }
}

