using DR_APIs.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetArchiver
{
    public partial class ManageUser : Form
    {

        public ManageUser()
        {
            InitializeComponent();
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {

        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            Guid newGuid = Guid.NewGuid();
            apiKeyTxt.Text = newGuid.ToString();
            saveBtn.Enabled = true;
            Clipboard.SetText(apiKeyTxt.Text);
        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            var t = User.UserExistsAsync(emailTxt.Text, Program.CurrentUser);
            t.Wait();
            bool userExists = t.Result;

            if (!userExists)
            {
                MessageBox.Show("User does not exist");
                return;
            }
            emailTxt.BackColor = Color.LightGreen;
            generateBtn.Enabled = true;
            apiKeyTxt.Enabled = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var t = User.UpdateUserAsync(apiKeyTxt.Text, emailTxt.Text, Program.CurrentUser);
            t.Wait();
            bool success = t.Result;
            if (success)
            {
                MessageBox.Show("User updated successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error updating user");
            }
        }
    }
}
