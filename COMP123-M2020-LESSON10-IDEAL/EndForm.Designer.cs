namespace COMP123_M2020_LESSON10_IDEAL
{
    partial class EndForm
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
            this.EndFormLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EndFormLabel
            // 
            this.EndFormLabel.Location = new System.Drawing.Point(6, 183);
            this.EndFormLabel.Name = "EndFormLabel";
            this.EndFormLabel.Size = new System.Drawing.Size(600, 45);
            this.EndFormLabel.TabIndex = 5;
            this.EndFormLabel.Text = "End Form";
            this.EndFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 379);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(150, 50);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.EndFormLabel);
            this.Controls.Add(this.BackButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "EndForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "End Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EndForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label EndFormLabel;
        private System.Windows.Forms.Button BackButton;
    }
}