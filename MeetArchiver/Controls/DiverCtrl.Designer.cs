using System.Drawing;
using System.Windows.Forms;

namespace MeetArchiver.Controls
{
    partial class DiverCtrl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TextBox txtId;
        private TextBox txtArchiveId;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblRepresenting;
        private TextBox txtRepresenting;
        private Label lblSex;
        private ComboBox cmbSex;
        private Label lblBorn;
        private NumericUpDown nudBorn;
        private Label lblCoach;
        private TextBox txtCoach;
        private Label lblTCode;
        private TextBox txtTCode;
        private Label lblNation;
        private TextBox txtNation;

        /// <summary> 
        /// Initialize component with static (absolute) layout so the control is editable in the designer.
        /// </summary>
        private void InitializeComponent()
        {
            txtId = new TextBox();
            txtArchiveId = new TextBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblRepresenting = new Label();
            txtRepresenting = new TextBox();
            lblSex = new Label();
            cmbSex = new ComboBox();
            lblBorn = new Label();
            nudBorn = new NumericUpDown();
            lblCoach = new Label();
            txtCoach = new TextBox();
            lblTCode = new Label();
            txtTCode = new TextBox();
            lblNation = new Label();
            txtNation = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudBorn).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(229, 264);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(220, 23);
            txtId.TabIndex = 1;
            txtId.Visible = false;
            // 
            // txtArchiveId
            // 
            txtArchiveId.Location = new Point(365, 98);
            txtArchiveId.Name = "txtArchiveId";
            txtArchiveId.Size = new Size(120, 23);
            txtArchiveId.TabIndex = 3;
            txtArchiveId.Visible = false;
            // 
            // lblFirstName
            // 
            lblFirstName.Location = new Point(8, 14);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(104, 26);
            lblFirstName.TabIndex = 4;
            lblFirstName.Text = "First Name";
            lblFirstName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(118, 17);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(220, 23);
            txtFirstName.TabIndex = 5;
            // 
            // lblLastName
            // 
            lblLastName.Location = new Point(8, 43);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(104, 26);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "Last Name";
            lblLastName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(118, 46);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(220, 23);
            txtLastName.TabIndex = 7;
            // 
            // lblRepresenting
            // 
            lblRepresenting.Location = new Point(8, 69);
            lblRepresenting.Name = "lblRepresenting";
            lblRepresenting.Size = new Size(104, 26);
            lblRepresenting.TabIndex = 8;
            lblRepresenting.Text = "Representing";
            lblRepresenting.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtRepresenting
            // 
            txtRepresenting.Location = new Point(118, 72);
            txtRepresenting.Name = "txtRepresenting";
            txtRepresenting.Size = new Size(220, 23);
            txtRepresenting.TabIndex = 9;
            // 
            // lblSex
            // 
            lblSex.Location = new Point(8, 95);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(104, 26);
            lblSex.TabIndex = 10;
            lblSex.Text = "Sex";
            lblSex.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbSex
            // 
            cmbSex.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSex.Items.AddRange(new object[] { "", "M", "F" });
            cmbSex.Location = new Point(118, 98);
            cmbSex.Name = "cmbSex";
            cmbSex.Size = new Size(80, 23);
            cmbSex.TabIndex = 11;
            // 
            // lblBorn
            // 
            lblBorn.Location = new Point(8, 121);
            lblBorn.Name = "lblBorn";
            lblBorn.Size = new Size(104, 26);
            lblBorn.TabIndex = 12;
            lblBorn.Text = "Born (year)";
            lblBorn.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudBorn
            // 
            nudBorn.Location = new Point(118, 124);
            nudBorn.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudBorn.Name = "nudBorn";
            nudBorn.Size = new Size(80, 23);
            nudBorn.TabIndex = 13;
            // 
            // lblCoach
            // 
            lblCoach.Location = new Point(8, 147);
            lblCoach.Name = "lblCoach";
            lblCoach.Size = new Size(104, 26);
            lblCoach.TabIndex = 14;
            lblCoach.Text = "Coach";
            lblCoach.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCoach
            // 
            txtCoach.Location = new Point(118, 150);
            txtCoach.Name = "txtCoach";
            txtCoach.Size = new Size(220, 23);
            txtCoach.TabIndex = 15;
            // 
            // lblTCode
            // 
            lblTCode.Location = new Point(8, 173);
            lblTCode.Name = "lblTCode";
            lblTCode.Size = new Size(104, 26);
            lblTCode.TabIndex = 16;
            lblTCode.Text = "Team Code";
            lblTCode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTCode
            // 
            txtTCode.Location = new Point(118, 176);
            txtTCode.Name = "txtTCode";
            txtTCode.Size = new Size(80, 23);
            txtTCode.TabIndex = 17;
            // 
            // lblNation
            // 
            lblNation.Location = new Point(8, 199);
            lblNation.Name = "lblNation";
            lblNation.Size = new Size(104, 26);
            lblNation.TabIndex = 18;
            lblNation.Text = "Nation";
            lblNation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNation
            // 
            txtNation.Location = new Point(118, 199);
            txtNation.Name = "txtNation";
            txtNation.Size = new Size(220, 23);
            txtNation.TabIndex = 19;
            // 
            // DiverCtrl
            // 
            BackColor = SystemColors.Control;
            Controls.Add(txtId);
            Controls.Add(txtArchiveId);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblRepresenting);
            Controls.Add(txtRepresenting);
            Controls.Add(lblSex);
            Controls.Add(cmbSex);
            Controls.Add(lblBorn);
            Controls.Add(nudBorn);
            Controls.Add(lblCoach);
            Controls.Add(txtCoach);
            Controls.Add(lblTCode);
            Controls.Add(txtTCode);
            Controls.Add(lblNation);
            Controls.Add(txtNation);
            Name = "DiverCtrl";
            Size = new Size(362, 239);
            Load += DiverCtrl_Load;
            ((System.ComponentModel.ISupportInitialize)nudBorn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        /// <summary> 
        /// Dispose resources.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}