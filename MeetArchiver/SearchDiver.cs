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
            searchDiverDGV.Rows.Clear();
            var t = Diver.GetDiverByNameAsync(FamilyNameTxt.Text);
            t.Wait();
            searchedDivers = t.Result;

            foreach (Diver d in searchedDivers)
            {
                searchDiverDGV.Rows.Add( d.LastName, d.FirstName, d.Born );
            }
            searchDiverDGV.ClearSelection();

        }

        private void EditDiver_Load(object sender, EventArgs e)
        {
            suppliedDiverCtrl.EditedDiver = suppliedDiver;
            FamilyNameTxt.Text = suppliedDiver.LastName.Substring(0, 3);
            searchBtn_Click(null, null);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Diver diver = foundDiverCtrl.PopulateDiverFromControls();

            suppliedDiver.ArchiveID = diver.ArchiveID;
            suppliedDiver.FirstName = diver.FirstName;
            suppliedDiver.LastName = diver.LastName;
            suppliedDiver.Sex = diver.Sex;
            suppliedDiver.Born = diver.Born;
            suppliedDiver.Representing = diver.Representing;
            suppliedDiver.TCode = diver.TCode;
            suppliedDiver.Nation = diver.Nation;
            suppliedDiver.RecordStatus = RecordStatus.Valid;
            suppliedDiver.PossibleMatches = new List<Diver>();

            this.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                foundDiverCtrl.EditedDiver = searchedDivers[e.RowIndex];
            }
        }
    }
}
