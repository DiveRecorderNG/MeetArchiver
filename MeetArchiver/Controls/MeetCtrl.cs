using System;
using System.Windows.Forms;
using DR_APIs.Models;

namespace MeetArchiver.Controls
{
    public partial class MeetCtrl : UserControl
    {
        private Meet _editedMeet = new Meet();
        private bool _isUpdating = false;

        /// <summary>
        /// The Meet being edited. Setting this property will populate all controls.
        /// </summary>
        public Meet EditedMeet
        {
            get { return _editedMeet; }
            set
            {
                _editedMeet = value ?? new Meet();
                PopulateControlsFromMeet();
            }
        }

        /// <summary>
        /// Gets or sets whether the control is in read-only mode
        /// </summary>
        public bool ReadOnly
        {
            get => _readOnly;
            set
            {
                _readOnly = value;
                SetControlsReadOnly(value);
            }
        }
        private bool _readOnly = false;

        /// <summary>
        /// Event fired when any field in the meet is changed
        /// </summary>
        public event EventHandler? MeetChanged;

        public MeetCtrl()
        {
            InitializeComponent();
            SetDefaults();
        }

        public MeetCtrl(Meet? meet = null)
        {
            InitializeComponent();
            SetDefaults();
            if (meet != null)
                EditedMeet = meet;
        }

        private void SetDefaults()
        {
            // Set default dates to today
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
            
            // Pre-select current country if available
            if (!string.IsNullOrEmpty(Program.CountryCode))
            {
                cmbNation.Text = Program.CountryCode;
            }
        }

        private void PopulateControlsFromMeet()
        {
            if (_editedMeet == null) 
            {
                _editedMeet = new Meet();
                return;
            }

            _isUpdating = true;
            try
            {
                txtMRef.Text = _editedMeet.MRef.ToString();
                txtTitle.Text = _editedMeet.Title ?? string.Empty;
                txtVenue.Text = _editedMeet.Venue ?? string.Empty;
                txtCity.Text = _editedMeet.City ?? string.Empty;
                cmbNation.Text = _editedMeet.Nation ?? string.Empty;
                txtMeetGUID.Text = _editedMeet.MeetGUID ?? string.Empty;
                chkInternational.Checked = _editedMeet.International;

                // Handle DateOnly to DateTime conversion for DateTimePickers
                if (_editedMeet.StartDate != default)
                {
                    dtpStartDate.Value = _editedMeet.StartDate.ToDateTime(TimeOnly.MinValue);
                }
                else
                {
                    dtpStartDate.Value = DateTime.Today;
                }

                if (_editedMeet.EndDate != default)
                {
                    dtpEndDate.Value = _editedMeet.EndDate.ToDateTime(TimeOnly.MinValue);
                }
                else
                {
                    dtpEndDate.Value = DateTime.Today;
                }
            }
            finally
            {
                _isUpdating = false;
            }
        }

        /// <summary>
        /// Updates the EditedMeet object with current control values
        /// </summary>
        public Meet PopulateMeetFromControls()
        {
            if (_editedMeet == null) _editedMeet = new Meet();

            // MRef and ArchiveMRef are read-only, don't update from controls
            _editedMeet.Title = string.IsNullOrWhiteSpace(txtTitle.Text) ? null : txtTitle.Text.Trim();
            _editedMeet.Venue = string.IsNullOrWhiteSpace(txtVenue.Text) ? null : txtVenue.Text.Trim();
            _editedMeet.City = string.IsNullOrWhiteSpace(txtCity.Text) ? null : txtCity.Text.Trim();
            _editedMeet.Nation = string.IsNullOrWhiteSpace(cmbNation.Text) ? null : cmbNation.Text.Trim();
            _editedMeet.MeetGUID = string.IsNullOrWhiteSpace(txtMeetGUID.Text) ? null : txtMeetGUID.Text.Trim();
            _editedMeet.International = chkInternational.Checked;

            // Convert DateTime back to DateOnly
            _editedMeet.StartDate = DateOnly.FromDateTime(dtpStartDate.Value);
            _editedMeet.EndDate = DateOnly.FromDateTime(dtpEndDate.Value);

            return _editedMeet;
        }

        private void SetControlsReadOnly(bool readOnly)
        {
            txtTitle.ReadOnly = readOnly;
            txtVenue.ReadOnly = readOnly;
            txtCity.ReadOnly = readOnly;
            cmbNation.Enabled = !readOnly;
            txtMeetGUID.ReadOnly = readOnly;
            chkInternational.Enabled = !readOnly;
            dtpStartDate.Enabled = !readOnly;
            dtpEndDate.Enabled = !readOnly;

            if (readOnly)
            {
                txtTitle.BackColor = SystemColors.Control;
                txtVenue.BackColor = SystemColors.Control;
                txtCity.BackColor = SystemColors.Control;
                txtMeetGUID.BackColor = SystemColors.Control;
            }
            else
            {
                txtTitle.BackColor = SystemColors.Window;
                txtVenue.BackColor = SystemColors.Window;
                txtCity.BackColor = SystemColors.Window;
                txtMeetGUID.BackColor = SystemColors.Window;
            }
        }

        /// <summary>
        /// Validates the current meet data
        /// </summary>
        public ValidationResult ValidateMeet()
        {
            var result = new ValidationResult();

            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                result.AddError("Title is required");
            }

            if (string.IsNullOrWhiteSpace(txtMeetGUID.Text))
            {
                result.AddError("Meet GUID is required");
            }

            if (dtpEndDate.Value < dtpStartDate.Value)
            {
                result.AddError("End date must be on or after start date");
            }

            return result;
        }

        #region Event Handlers

        private void OnMeetChanged()
        {
            if (!_isUpdating)
            {
                PopulateMeetFromControls();
                MeetChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            OnMeetChanged();
        }

        private void txtVenue_TextChanged(object sender, EventArgs e)
        {
            OnMeetChanged();
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            OnMeetChanged();
        }

        private void cmbNation_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnMeetChanged();
        }

        private void txtMeetGUID_TextChanged(object sender, EventArgs e)
        {
            OnMeetChanged();
        }

        private void chkInternational_CheckedChanged(object sender, EventArgs e)
        {
            OnMeetChanged();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            OnMeetChanged();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            OnMeetChanged();
        }


        #endregion
    }

    /// <summary>
    /// Simple validation result class
    /// </summary>
    public class ValidationResult
    {
        public List<string> Errors { get; } = new List<string>();
        public bool IsValid => Errors.Count == 0;

        public void AddError(string error)
        {
            if (!string.IsNullOrWhiteSpace(error))
                Errors.Add(error);
        }

        public string GetErrorsAsString()
        {
            return string.Join(Environment.NewLine, Errors);
        }
    }
}