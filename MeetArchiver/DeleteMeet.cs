using DR_APIs.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DR_APIs.Models;

namespace MeetArchiver
{
    public partial class DeleteMeet : Form
    {
        List<Meet> foundMeets;
        public DeleteMeet()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var t = Meet.SearchByTitleAsync(meetTitleTxt.Text);
            t.Wait();
            foundMeets = t.Result;
            if (foundMeets.Count == 0)
            {
                MessageBox.Show("No meets found with that title.");
                return;
            }
            meetsLst.Items.Clear();
            foreach (var meet in foundMeets)
            {
                meetsLst.Items.Add($"{meet.Title} ({meet.StartDate} to {meet.EndDate})");
            }
        }

        private void meetsLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (meetsLst.SelectedIndex == -1)
            {
                return;
            }

            var selectedMeet = foundMeets[meetsLst.SelectedIndex];
            meetCtrl.EditedMeet = selectedMeet;

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int res;
            try
            {
                var t = Meet.DeleteByIdAsync(meetCtrl.EditedMeet.MRef, Program.CurrentUser);
                t.Wait();
                res = t.Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting meet: {ex.Message}");
                return;
            }

            if (res == 1)
            {
                MessageBox.Show("Meet deleted successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error deleting meet.");
            }
        }
    }
}
