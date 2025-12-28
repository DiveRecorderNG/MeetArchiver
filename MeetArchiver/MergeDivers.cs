using DR_APIs.Models;
using MeetArchiver.Controls;
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
    public partial class MergeDivers : Form
    {
        public MergeDivers()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var d = survivorDiveCtrl.PopulateDiverFromControls();
            if (String.IsNullOrEmpty(d.FirstName)
                || String.IsNullOrEmpty(d.LastName)
                || String.IsNullOrEmpty(d.Sex)
                || d.Born == 0)
            {
                MessageBox.Show("You must enter at least First Name, Last Name, Sex and Year of Birth to search for a diver.");
                return;
            }

            d.PossibleMatches = new List<Diver>();
            var t = Diver.CheckDiversAsync(new List<Diver> { d });
            t.Wait();
            var diverRes = t.Result;

            if (diverRes[0].RecordStatus != RecordStatus.Valid)
            {
                MessageBox.Show("No matching diver found.\nRemember you must search for the details as they are then you can correct them");
                return;
            }
            else
            {
                survivorDiveCtrl.EditedDiver = diverRes[0];
                var t2 = Meet.GetByDiverAsync((Int32)diverRes[0].ArchiveID);
                t2.Wait();
                var meets = t2.Result;
                foreach (var m in meets)
                {
                    survivorMeets.Items.Add(m.ToString());
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var d = casualtyDiveCtrl.PopulateDiverFromControls();
            if (String.IsNullOrEmpty(d.FirstName)
                || String.IsNullOrEmpty(d.LastName)
                || String.IsNullOrEmpty(d.Sex)
                || d.Born == 0)
            {
                MessageBox.Show("You must enter at least First Name, Last Name, Sex and Year of Birth to search for a diver.");
                return;
            }


            d.PossibleMatches = new List<Diver>();
            var t = Diver.CheckDiversAsync(new List<Diver> { d });
            t.Wait();
            var diverRes = t.Result;

            if (diverRes[0].RecordStatus != RecordStatus.Valid)
            {
                MessageBox.Show("No matching diver found.\nRemember you must search for the details as they are then you can correct them");
                return;
            }
            else
            {
                casualtyDiveCtrl.EditedDiver = diverRes[0];

                var t2 = Meet.GetByDiverAsync((Int32)diverRes[0].ArchiveID);
                t2.Wait();
                var meets = t2.Result;
                foreach (var m in meets)
                {
                    casualtyMeets.Items.Add(m.ToString());
                }

            }
        }

        private void mergeBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to merge these two divers? This action cannot be undone.", "Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }

            Diver survivor = survivorDiveCtrl.PopulateDiverFromControls();
            Diver casualty = casualtyDiveCtrl.PopulateDiverFromControls();
            try
            {
                var t = Diver.MergeDiversAsync(survivor, casualty, Program.CurrentUser);
                t.Wait();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error merging divers: " + ex.Message + "\nPlease try again.");
                this.Close();

            }
        }
    }
}
