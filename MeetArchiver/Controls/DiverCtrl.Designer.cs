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
            clubSearchBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)nudBorn).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(163, 228);
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
            lblFirstName.ForeColor = SystemColors.ActiveCaptionText;
            lblFirstName.Location = new Point(8, 14);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(104, 26);
            lblFirstName.TabIndex = 4;
            lblFirstName.Text = "First Name";
            lblFirstName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = SystemColors.ControlLightLight;
            txtFirstName.ForeColor = SystemColors.ControlText;
            txtFirstName.Location = new Point(118, 17);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(220, 23);
            txtFirstName.TabIndex = 5;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // lblLastName
            // 
            lblLastName.ForeColor = SystemColors.ControlText;
            lblLastName.Location = new Point(8, 43);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(104, 26);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "Last Name";
            lblLastName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = SystemColors.ControlLightLight;
            txtLastName.ForeColor = SystemColors.ControlText;
            txtLastName.Location = new Point(118, 43);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(220, 23);
            txtLastName.TabIndex = 7;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // lblRepresenting
            // 
            lblRepresenting.ForeColor = SystemColors.ControlText;
            lblRepresenting.Location = new Point(8, 69);
            lblRepresenting.Name = "lblRepresenting";
            lblRepresenting.Size = new Size(104, 26);
            lblRepresenting.TabIndex = 8;
            lblRepresenting.Text = "Representing";
            lblRepresenting.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtRepresenting
            // 
            txtRepresenting.BackColor = SystemColors.ControlLightLight;
            txtRepresenting.ForeColor = SystemColors.ControlText;
            txtRepresenting.Location = new Point(118, 69);
            txtRepresenting.Name = "txtRepresenting";
            txtRepresenting.Size = new Size(220, 23);
            txtRepresenting.TabIndex = 9;
            txtRepresenting.TextChanged += txtRepresenting_TextChanged;
            // 
            // lblSex
            // 
            lblSex.ForeColor = SystemColors.ControlText;
            lblSex.Location = new Point(8, 95);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(104, 26);
            lblSex.TabIndex = 10;
            lblSex.Text = "Sex";
            lblSex.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbSex
            // 
            cmbSex.BackColor = SystemColors.ControlLightLight;
            cmbSex.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSex.ForeColor = SystemColors.ControlText;
            cmbSex.Items.AddRange(new object[] { "", "M", "F" });
            cmbSex.Location = new Point(118, 95);
            cmbSex.Name = "cmbSex";
            cmbSex.Size = new Size(80, 23);
            cmbSex.TabIndex = 11;
            // 
            // lblBorn
            // 
            lblBorn.ForeColor = SystemColors.ControlText;
            lblBorn.Location = new Point(8, 121);
            lblBorn.Name = "lblBorn";
            lblBorn.Size = new Size(104, 26);
            lblBorn.TabIndex = 12;
            lblBorn.Text = "Born (year)";
            lblBorn.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudBorn
            // 
            nudBorn.BackColor = SystemColors.ControlLightLight;
            nudBorn.ForeColor = SystemColors.ControlText;
            nudBorn.Location = new Point(118, 121);
            nudBorn.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudBorn.Name = "nudBorn";
            nudBorn.ReadOnly = true;
            nudBorn.Size = new Size(80, 23);
            nudBorn.TabIndex = 13;
            // 
            // lblCoach
            // 
            lblCoach.ForeColor = SystemColors.ControlText;
            lblCoach.Location = new Point(8, 147);
            lblCoach.Name = "lblCoach";
            lblCoach.Size = new Size(104, 26);
            lblCoach.TabIndex = 14;
            lblCoach.Text = "Coach";
            lblCoach.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCoach
            // 
            txtCoach.BackColor = SystemColors.ControlLightLight;
            txtCoach.ForeColor = SystemColors.ControlText;
            txtCoach.Location = new Point(118, 147);
            txtCoach.Name = "txtCoach";
            txtCoach.Size = new Size(220, 23);
            txtCoach.TabIndex = 15;
            txtCoach.TextChanged += txtCoach_TextChanged;
            // 
            // lblTCode
            // 
            lblTCode.ForeColor = SystemColors.ControlText;
            lblTCode.Location = new Point(8, 173);
            lblTCode.Name = "lblTCode";
            lblTCode.Size = new Size(104, 26);
            lblTCode.TabIndex = 16;
            lblTCode.Text = "Team Code";
            lblTCode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTCode
            // 
            txtTCode.BackColor = SystemColors.ControlLightLight;
            txtTCode.ForeColor = SystemColors.ControlText;
            txtTCode.Location = new Point(118, 173);
            txtTCode.Name = "txtTCode";
            txtTCode.Size = new Size(80, 23);
            txtTCode.TabIndex = 17;
            txtTCode.TextChanged += txtTCode_TextChanged;
            // 
            // lblNation
            // 
            lblNation.ForeColor = SystemColors.ControlText;
            lblNation.Location = new Point(8, 199);
            lblNation.Name = "lblNation";
            lblNation.Size = new Size(104, 26);
            lblNation.TabIndex = 18;
            lblNation.Text = "Nation";
            lblNation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNation
            // 
            txtNation.BackColor = SystemColors.ControlLightLight;
            txtNation.ForeColor = SystemColors.ControlText;
            txtNation.Location = new Point(118, 199);
            txtNation.Name = "txtNation";
            txtNation.Size = new Size(220, 23);
            txtNation.TabIndex = 19;
            txtNation.TextChanged += txtNation_TextChanged;
            // 
            // clubSearchBtn
            // 
            clubSearchBtn.Location = new Point(332, 70);
            clubSearchBtn.Name = "clubSearchBtn";
            clubSearchBtn.Size = new Size(30, 23);
            clubSearchBtn.TabIndex = 20;
            clubSearchBtn.Text = ". . .";
            clubSearchBtn.UseVisualStyleBackColor = true;
            clubSearchBtn.Click += clubSearchBtn_Click;
            // 
            // DiverCtrl
            // 
            BackColor = SystemColors.Control;
            Controls.Add(clubSearchBtn);
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
        private Button clubSearchBtn;
    }
}