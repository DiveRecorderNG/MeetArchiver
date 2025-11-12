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
    public partial class DiverMatcher : Form
    {
        public DiverMatcher()
        {
            InitializeComponent();
        }

        private void DiverMatcher_Load(object sender, EventArgs e)
        {
            DiverCtrl diverCtrl = new DiverCtrl();
            this.Controls.Add(diverCtrl);
            diverCtrl.Location = new Point(10, 10);
        }
    }
}
