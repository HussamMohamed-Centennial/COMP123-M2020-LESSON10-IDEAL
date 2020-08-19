using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_LESSON10_IDEAL
{
    public partial class EndForm : Form
    {
        public EndForm()
        {
            InitializeComponent();
        }

        private void SetContactData(StreamReader streamReaderreader)
        {
            Program.contact.FirstName = streamReaderreader.ReadLine();
            Program.contact.LastName = streamReaderreader.ReadLine();
            Program.contact.EmailAddress = streamReaderreader.ReadLine();
            Program.contact.ContactNumber = streamReaderreader.ReadLine();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.mainForm.Show();
            this.Hide();
        }

        private void EndForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ShowContactdata()
        {
            FirstNameTextBox.Text = Program.contact.FirstName;
            LastNameTextBox.Text = Program.contact.LastName;
            EmailAdrTextBox.Text = Program.contact.EmailAddress;
            ContactNumberTextBox.Text = Program.contact.ContactNumber;
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            //Configure 
            ContactInfoOopenFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            ContactInfoOopenFileDialog1.FileName = "Contact_Info";
            ContactInfoOopenFileDialog1.Title = "Load a Contact";


            //open the dialog
            DialogResult opeDialogResult = ContactInfoOopenFileDialog1.ShowDialog();

            if (opeDialogResult != DialogResult.Cancel)
            {
                StreamReader streamReader = new StreamReader(ContactInfoOopenFileDialog1.FileName);
                SetContactData(streamReader);
                ShowContactdata();
                streamReader.Close();
            }
        }
    }
}
