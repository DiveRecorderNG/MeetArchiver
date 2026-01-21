using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DR_APIs.Models;
using System.ComponentModel;
using Org.BouncyCastle.Pqc.Crypto.Frodo;
using System.Linq.Expressions;

namespace MeetArchiver.Controls
{
    public partial class DiverCtrl : UserControl
    {
        private Diver _editedDiver = new Diver();
        // Public edited instance (a clone of the input to avoid mutating the original)
        public Diver EditedDiver
        {
            get
            {
                return _editedDiver;
            }
            set
            {
                _editedDiver = value;
                PopulateControlsFromDiver();
            }
        }

        public bool Readonly
        {
            get => _readonly;
            set
            {
                _readonly = value;
                nudBorn.ReadOnly = value;
                if (_editedDiver != null)
                {
                    clubSearchBtn.Visible = !value;
                }

            }
        }

        bool _readonly;
        static bool resetting = false;

        /// <summary>
        /// Create the control and optionally load values from the provided Diver.
        /// The provided Diver is cloned so the original is not modified by the control.
        /// </summary>
        public DiverCtrl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create the control and optionally load values from the provided Diver.
        /// The provided Diver is cloned so the original is not modified by the control.
        /// </summary>
        public DiverCtrl(Diver? diver = null)
        {
            InitializeComponent();

            _editedDiver = diver;
            PopulateControlsFromDiver();
        }

        private void PopulateControlsFromDiver()
        {
            if (_editedDiver == null) _editedDiver = new Diver();

            txtId.Text = _editedDiver.ID.ToString();
            txtArchiveId.Text = _editedDiver.ArchiveID?.ToString() ?? string.Empty;
            txtFirstName.Text = _editedDiver.FirstName ?? string.Empty;
            txtLastName.Text = _editedDiver.LastName ?? string.Empty;
            txtRepresenting.Text = _editedDiver.Representing ?? string.Empty;
            cmbSex.SelectedItem = string.IsNullOrEmpty(_editedDiver.Sex) ? string.Empty : _editedDiver.Sex;
            nudBorn.Value = _editedDiver.Born ?? 0;
            txtCoach.Text = _editedDiver.Coach ?? string.Empty;
            txtTCode.Text = _editedDiver.TCode ?? string.Empty;
            txtNation.Text = _editedDiver.Nation ?? string.Empty;
        }

        public Diver PopulateDiverFromControls()
        {
            if (_editedDiver == null) _editedDiver = new Diver();
            Diver diver = _editedDiver;

            diver.FirstName = txtFirstName.Text;
            diver.LastName = txtLastName.Text;
            diver.Representing = txtRepresenting.Text;
            diver.Sex = cmbSex.SelectedItem.ToString();
            diver.Born = (int)nudBorn.Value;
            diver.TCode = txtTCode.Text;
            diver.Coach = txtCoach.Text;
            diver.Nation = "";
            diver.PossibleMatches = new List<Diver>();
            return diver;

        }

        private static string? NormalizeEmpty(string? s) => string.IsNullOrWhiteSpace(s) ? null : s.Trim();

        private void DiverCtrl_Load(object sender, EventArgs e)
        {

        }

        public void HighlightMismatches(Diver dr)
        {
            try
            {

                if (_editedDiver.FirstName.ToLower() != dr.FirstName.ToLower())
                {
                    txtFirstName.BackColor = Color.Orange;
                }
                else
                {
                    txtFirstName.BackColor = SystemColors.ControlLightLight;
                }

                if (_editedDiver.LastName.ToLower() != dr.LastName.ToLower())
                {
                    txtLastName.BackColor = Color.Orange;
                }
                else
                {
                    txtLastName.BackColor = SystemColors.ControlLightLight;
                }

                if (_editedDiver.Born != dr.Born)
                {
                    nudBorn.BackColor = Color.Orange;
                }
                else
                {
                    nudBorn.BackColor = SystemColors.ControlLightLight;
                }

                if (_editedDiver.Representing.ToLower() != dr.Representing.ToLower())
                {
                    txtRepresenting.BackColor = Color.Orange;
                }
                else
                {
                    txtRepresenting.BackColor = SystemColors.ControlLightLight;
                }

                if (_editedDiver.Sex != dr.Sex)
                {
                    cmbSex.BackColor = Color.Orange;
                }
                else
                {
                    cmbSex.BackColor = SystemColors.ControlLightLight;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error highlighting mismatches: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (Readonly)
            {
                if (resetting == true)
                    return;
                else
                {
                    resetting = true;
                    txtFirstName.Text = EditedDiver.FirstName;
                    Thread.Sleep(100);
                    resetting = false;
                }
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (Readonly)
            {
                if (resetting == true)
                    return;
                else
                {
                    resetting = true;
                    txtLastName.Text = EditedDiver.LastName;
                    Thread.Sleep(100);
                    resetting = false;
                }
            }
        }

        private void txtRepresenting_TextChanged(object sender, EventArgs e)
        {

                if (resetting == true)
                    return;
                else
                {
                    resetting = true;
                    txtRepresenting.Text = EditedDiver.Representing;
                    Thread.Sleep(100);
                    resetting = false;
                }
        }

        private void txtCoach_TextChanged(object sender, EventArgs e)
        {
            if (Readonly)
            {
                if (resetting == true)
                    return;
                else
                {
                    resetting = true;
                    txtCoach.Text = EditedDiver.Coach;
                    Thread.Sleep(100);
                    resetting = false;
                }
            }
        }

        private void txtTCode_TextChanged(object sender, EventArgs e)
        {
                if (resetting == true)
                    return;
                else
                {
                    resetting = true;
                    txtTCode.Text = EditedDiver.TCode;
                    Thread.Sleep(100);
                    resetting = false;
                }
        }

        private void txtNation_TextChanged(object sender, EventArgs e)
        {
            if (Readonly)
            {
                if (resetting == true)
                    return;
                else
                {
                    resetting = true;
                    txtNation.Text = EditedDiver.Nation;
                    Thread.Sleep(100);
                    resetting = false;
                }
            }
        }

        private void nudBorn_ValueChanged(object sender, EventArgs e)
        {
            if (Readonly)
            {
                if (resetting == true)
                    return;
                else
                {
                    resetting = true;
                    Thread.Sleep(100);
                    nudBorn.Value = (Decimal)EditedDiver.Born;
                    Thread.Sleep(100);
                    resetting = false;
                }
            }
        }

        private void clubSearchBtn_Click(object sender, EventArgs e)
        {
            SerachClub frm = new SerachClub();
            frm.ShowDialog();
            if(frm.SelectedClub == null)
            {
                return;
            }
            EditedDiver.Representing = frm.SelectedClub.Representing;
            EditedDiver.TCode= frm.SelectedClub.TCode;
            txtRepresenting.Text = frm.SelectedClub.Representing;
            txtTCode.Text = frm.SelectedClub.TCode;
        }
    }
}