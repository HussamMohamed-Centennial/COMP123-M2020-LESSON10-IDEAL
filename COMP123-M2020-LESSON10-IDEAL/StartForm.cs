using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_LESSON10_IDEAL
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {


            Program.mainForm.Show();
            this.Hide();
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            NextButton.Enabled = false;
        }

        private void FirstNameTextBox_Leave(object sender, EventArgs e)
        {
            if (FirstNameTextBox.TextLength < 2)
            {
                FirstNameTextBox.Focus();
                FirstNameTextBox.SelectAll();
            }
        }

        private void LastNameTextBox_Leave(object sender, EventArgs e)
        {
            if (LastNameTextBox.TextLength < 2)
            {
                LastNameTextBox.Focus();
                LastNameTextBox.SelectAll();
            }
        }

        private void EmailAdrTextBox_Leave(object sender, EventArgs e)
        {
            if (EmailAdrTextBox.TextLength < 8)
            {
                EmailAdrTextBox.Focus();
                EmailAdrTextBox.SelectAll();
            }
        }

        private void ContactNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (ContactNumberTextBox.TextLength < 8)
            {
                ContactNumberTextBox.Focus();
                ContactNumberTextBox.SelectAll();
            }
            else
            {
                NextButton.Enabled = true;
            }
        }

        private void ContactNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ContactNumberTextBox.TextLength >9)
            {
                NextButton.Enabled = true;
            }

        }
    }
}
