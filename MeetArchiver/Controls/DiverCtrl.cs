using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DR_APIs.Models;
using System.ComponentModel;

namespace MeetArchiver.Controls
{
    public partial class DiverCtrl : UserControl
    {
        // Public edited instance (a clone of the input to avoid mutating the original)
        public Diver EditedDiver { get; private set; }

        /// <summary>
        /// Create the control and optionally load values from the provided Diver.
        /// The provided Diver is cloned so the original is not modified by the control.
        /// </summary>
        public DiverCtrl(Diver? diver = null)
        {
            InitializeComponent();

            EditedDiver = diver == null ? new Diver() : CloneDiver(diver);
            PopulateControlsFromDiver();
            HookEvents();
        }

        private void HookEvents()
        {
            // Keep EditedDiver up-to-date as the user edits fields.
            txtArchiveId.Validating += (s, e) => ApplyChanges();
            txtFirstName.TextChanged += (s, e) => ApplyChanges();
            txtLastName.TextChanged += (s, e) => ApplyChanges();
            txtRepresenting.TextChanged += (s, e) => ApplyChanges();
            cmbSex.SelectedIndexChanged += (s, e) => ApplyChanges();
            nudBorn.ValueChanged += (s, e) => ApplyChanges();
            txtCoach.TextChanged += (s, e) => ApplyChanges();
            txtTCode.TextChanged += (s, e) => ApplyChanges();
            txtNation.TextChanged += (s, e) => ApplyChanges();
        }

        private void PopulateControlsFromDiver()
        {
            if (EditedDiver == null) EditedDiver = new Diver();

            txtId.Text = EditedDiver.ID.ToString();
            txtArchiveId.Text = EditedDiver.ArchiveID?.ToString() ?? string.Empty;
            txtFirstName.Text = EditedDiver.FirstName ?? string.Empty;
            txtLastName.Text = EditedDiver.LastName ?? string.Empty;
            txtRepresenting.Text = EditedDiver.Representing ?? string.Empty;
            cmbSex.SelectedItem = string.IsNullOrEmpty(EditedDiver.Sex) ? string.Empty : EditedDiver.Sex;
            nudBorn.Value = EditedDiver.Born ?? 0;
            txtCoach.Text = EditedDiver.Coach ?? string.Empty;
            txtTCode.Text = EditedDiver.TCode ?? string.Empty;
            txtNation.Text = EditedDiver.Nation ?? string.Empty;
        }

        /// <summary>
        /// Copy UI values into EditedDiver. Call this when you need a stable copy.
        /// </summary>
        public void ApplyChanges()
        {
            if (EditedDiver == null) EditedDiver = new Diver();

            // ID is readonly in UI; update only if parse succeeds (typically remains the same)
            if (int.TryParse(txtId.Text?.Trim(), out var id)) EditedDiver.ID = id;

            if (int.TryParse(txtArchiveId.Text?.Trim(), out var archiveId))
                EditedDiver.ArchiveID = archiveId;
            else
                EditedDiver.ArchiveID = null;

            EditedDiver.FirstName = NormalizeEmpty(txtFirstName.Text);
            EditedDiver.LastName = NormalizeEmpty(txtLastName.Text);
            EditedDiver.Representing = NormalizeEmpty(txtRepresenting.Text);
            EditedDiver.Sex = NormalizeEmpty(cmbSex.Text);

            EditedDiver.Born = nudBorn.Value == 0 ? (int?)null : (int)nudBorn.Value;

            EditedDiver.Coach = NormalizeEmpty(txtCoach.Text);
            EditedDiver.TCode = NormalizeEmpty(txtTCode.Text);
            EditedDiver.Nation = NormalizeEmpty(txtNation.Text);
        }

        private static string? NormalizeEmpty(string? s) => string.IsNullOrWhiteSpace(s) ? null : s.Trim();

        private static Diver CloneDiver(Diver d)
        {
            if (d == null) return new Diver();
            return new Diver
            {
                ID = d.ID,
                ArchiveID = d.ArchiveID,
                FirstName = d.FirstName,
                LastName = d.LastName,
                Representing = d.Representing,
                Sex = d.Sex,
                Born = d.Born,
                Coach = d.Coach,
                TCode = d.TCode,
                Nation = d.Nation,
                Validated = d.Validated,
                PossibleMatches = d.PossibleMatches == null ? new List<Diver>() : new List<Diver>(d.PossibleMatches)
            };
        }
    }
}