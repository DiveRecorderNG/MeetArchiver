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
    public partial class EditDiver : Form
    {
        public EditDiver()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var d = diverCtrl1.PopulateDiverFromControls();
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
                diverCtrl1.EditedDiver = diverRes[0];
                updateBtn.Enabled = true;
            }

        }

        private void EditDiver_Load(object sender, EventArgs e)
        {
            updateBtn.Enabled = false;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Diver diver = diverCtrl1.PopulateDiverFromControls();
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
    }
}
