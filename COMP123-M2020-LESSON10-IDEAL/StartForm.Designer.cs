namespace COMP123_M2020_LESSON10_IDEAL
{
    partial class StartForm
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
            this.NextButton = new System.Windows.Forms.Button();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.EmailAdrLabel = new System.Windows.Forms.Label();
            this.EmailAdrTextBox = new System.Windows.Forms.TextBox();
            this.ContactNumberLabel = new System.Windows.Forms.Label();
            this.ContactNumberTextBox = new System.Windows.Forms.TextBox();
            this.ContactGroupBox = new System.Windows.Forms.GroupBox();
            this.ContactGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(462, 379);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(150, 50);
            this.NextButton.TabIndex = 6;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(6, 34);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(147, 31);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "First Name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(12, 68);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(261, 38);
            this.FirstNameTextBox.TabIndex = 2;
            this.FirstNameTextBox.Leave += new System.EventHandler(this.FirstNameTextBox_Leave);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(6, 118);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(145, 31);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Last Name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(12, 152);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(261, 38);
            this.LastNameTextBox.TabIndex = 3;
            this.LastNameTextBox.Leave += new System.EventHandler(this.LastNameTextBox_Leave);
            // 
            // EmailAdrLabel
            // 
            this.EmailAdrLabel.AutoSize = true;
            this.EmailAdrLabel.Location = new System.Drawing.Point(6, 206);
            this.EmailAdrLabel.Name = "EmailAdrLabel";
            this.EmailAdrLabel.Size = new System.Drawing.Size(188, 31);
            this.EmailAdrLabel.TabIndex = 1;
            this.EmailAdrLabel.Text = "Email Address";
            // 
            // EmailAdrTextBox
            // 
            this.EmailAdrTextBox.Location = new System.Drawing.Point(12, 240);
            this.EmailAdrTextBox.Name = "EmailAdrTextBox";
            this.EmailAdrTextBox.Size = new System.Drawing.Size(261, 38);
            this.EmailAdrTextBox.TabIndex = 4;
            this.EmailAdrTextBox.Leave += new System.EventHandler(this.EmailAdrTextBox_Leave);
            // 
            // ContactNumberLabel
            // 
            this.ContactNumberLabel.AutoSize = true;
            this.ContactNumberLabel.Location = new System.Drawing.Point(6, 292);
            this.ContactNumberLabel.Name = "ContactNumberLabel";
            this.ContactNumberLabel.Size = new System.Drawing.Size(212, 31);
            this.ContactNumberLabel.TabIndex = 1;
            this.ContactNumberLabel.Text = "Contact Number";
            // 
            // ContactNumberTextBox
            // 
            this.ContactNumberTextBox.Location = new System.Drawing.Point(12, 326);
            this.ContactNumberTextBox.Name = "ContactNumberTextBox";
            this.ContactNumberTextBox.Size = new System.Drawing.Size(261, 38);
            this.ContactNumberTextBox.TabIndex = 5;
            this.ContactNumberTextBox.TextChanged += new System.EventHandler(this.ContactNumberTextBox_TextChanged);
            this.ContactNumberTextBox.Leave += new System.EventHandler(this.ContactNumberTextBox_Leave);
            // 
            // ContactGroupBox
            // 
            this.ContactGroupBox.Controls.Add(this.FirstNameLabel);
            this.ContactGroupBox.Controls.Add(this.ContactNumberTextBox);
            this.ContactGroupBox.Controls.Add(this.LastNameLabel);
            this.ContactGroupBox.Controls.Add(this.EmailAdrTextBox);
            this.ContactGroupBox.Controls.Add(this.FirstNameTextBox);
            this.ContactGroupBox.Controls.Add(this.ContactNumberLabel);
            this.ContactGroupBox.Controls.Add(this.EmailAdrLabel);
            this.ContactGroupBox.Controls.Add(this.LastNameTextBox);
            this.ContactGroupBox.Location = new System.Drawing.Point(19, 24);
            this.ContactGroupBox.Name = "ContactGroupBox";
            this.ContactGroupBox.Size = new System.Drawing.Size(437, 376);
            this.ContactGroupBox.TabIndex = 3;
            this.ContactGroupBox.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.ContactGroupBox);
            this.Controls.Add(this.NextButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.Activated += new System.EventHandler(this.StartForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartForm_FormClosing);
            this.ContactGroupBox.ResumeLayout(false);
            this.ContactGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label EmailAdrLabel;
        private System.Windows.Forms.TextBox EmailAdrTextBox;
        private System.Windows.Forms.Label ContactNumberLabel;
        private System.Windows.Forms.TextBox ContactNumberTextBox;
        private System.Windows.Forms.GroupBox ContactGroupBox;
    }
}

