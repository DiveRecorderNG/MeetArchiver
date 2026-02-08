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
    public partial class SearchDiver : Form
    {
        Diver suppliedDiver;
        List<Diver> searchedDivers;

        public SearchDiver()
        {
            InitializeComponent();
        }
        public SearchDiver(Diver _suppliedDiver)
        {
            InitializeComponent();
            suppliedDiver = _suppliedDiver;
        }


        private void searchBtn_Click(object sender, EventArgs e)
        {

            var t = Diver.GetDiverByNameAsync(FamilyNameTxt.Text);
            t.Wait();
            searchedDivers = t.Result;

            foreach (Diver d in searchedDivers)
            {
                searchResultsLst.Items.Add(d.FullName + " - " + d.Born);
            }


        }

        private void EditDiver_Load(object sender, EventArgs e)
        {
            suppliedDiverCtrl.EditedDiver = suppliedDiver;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Diver diver = foundDiverCtrl.PopulateDiverFromControls();
            diver.RecordStatus = RecordStatus.Updated;

            try
            {
                var t = Diver.UpdateDiversAsync(new List<Diver> { diver }, Program.CurrentUser);
                t.Wait();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating diver: " + ex.Message + "\nPlease try again.");
                this.Close();
            }
        }

        private void searchResultsLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchResultsLst.SelectedIndex >= 0 && searchResultsLst.SelectedIndex < searchedDivers.Count)
            {
                foundDiverCtrl.EditedDiver = searchedDivers[searchResultsLst.SelectedIndex];
            }
        }
    }
}
