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
    public partial class SerachClub : Form
    {
        public Club SelectedClub = null;

        public SerachClub()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var t = Club.FindClubAsync(searchTxt.Text);
            t.Wait();
            var suggestedClubs = t.Result;
            clubsLst.Items.Clear();
            if (suggestedClubs.Count != 0)
            {
                clubsLst.Tag = suggestedClubs;
                foreach (var club in suggestedClubs)
                {
                    clubsLst.Items.Add($"{club.Representing}       [{club.TCode}]");
                }
            }
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            if (clubsLst.SelectedIndex != -1)
            {
                var suggestedClubs = (List<Club>)clubsLst.Tag;
                SelectedClub = suggestedClubs[clubsLst.SelectedIndex];
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a club from the list.");
            }
        }
    }
}
