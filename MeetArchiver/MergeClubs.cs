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
    public partial class MergeClubs : Form
    {
        public MergeClubs()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void remainingTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void remainingBtn_Click(object sender, EventArgs e)
        {
            SerachClub frm = new SerachClub();
            frm.ShowDialog();
            if (frm.SelectedClub == null)
            {
                return;
            }
            remainingTxt.Tag = frm.SelectedClub;
            remainingTxt.Text = frm.SelectedClub.Representing + "  -  " + frm.SelectedClub.TCode;

        }

        private void removedBtn_Click(object sender, EventArgs e)
        {
            SerachClub frm = new SerachClub();
            frm.ShowDialog();
            if (frm.SelectedClub == null)
            {
                return;
            }
            removedTxt.Tag = frm.SelectedClub;
            removedTxt.Text = frm.SelectedClub.Representing + "  -  " + frm.SelectedClub.TCode;
        }

        private void nergeBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
