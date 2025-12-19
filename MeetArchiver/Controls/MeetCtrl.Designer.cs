using System.Drawing;
using System.Windows.Forms;

namespace MeetArchiver.Controls
{
    partial class MeetCtrl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        private Label lblMRef;
        private TextBox txtMRef;
        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblVenue;
        private TextBox txtVenue;
        private Label lblCity;
        private TextBox txtCity;
        private Label lblNation;
        private ComboBox cmbNation;
        private Label lblStartDate;
        private DateTimePicker dtpStartDate;
        private Label lblEndDate;
        private DateTimePicker dtpEndDate;
        private Label lblInternational;
        private CheckBox chkInternational;
        private Label lblMeetGUID;
        private TextBox txtMeetGUID;
        private GroupBox grpMeetInfo;
        private GroupBox grpDates;
        private GroupBox grpLocation;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMRef = new Label();
            txtMRef = new TextBox();
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblVenue = new Label();
            txtVenue = new TextBox();
            lblCity = new Label();
            txtCity = new TextBox();
            lblNation = new Label();
            cmbNation = new ComboBox();
            lblStartDate = new Label();
            dtpStartDate = new DateTimePicker();
            lblEndDate = new Label();
            dtpEndDate = new DateTimePicker();
            lblInternational = new Label();
            chkInternational = new CheckBox();
            lblMeetGUID = new Label();
            txtMeetGUID = new TextBox();
            grpMeetInfo = new GroupBox();
            grpDates = new GroupBox();
            grpLocation = new GroupBox();
            grpMeetInfo.SuspendLayout();
            grpDates.SuspendLayout();
            grpLocation.SuspendLayout();
            SuspendLayout();
            // 
            // lblMRef
            // 
            lblMRef.Location = new Point(8, 20);
            lblMRef.Name = "lblMRef";
            lblMRef.Size = new Size(100, 23);
            lblMRef.TabIndex = 0;
            lblMRef.Text = "Meet Ref:";
            lblMRef.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMRef
            // 
            txtMRef.BackColor = SystemColors.Control;
            txtMRef.Location = new Point(115, 20);
            txtMRef.Name = "txtMRef";
            txtMRef.ReadOnly = true;
            txtMRef.Size = new Size(80, 23);
            txtMRef.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(8, 50);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(100, 23);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Title:";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(115, 50);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(350, 23);
            txtTitle.TabIndex = 5;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // lblVenue
            // 
            lblVenue.Location = new Point(8, 25);
            lblVenue.Name = "lblVenue";
            lblVenue.Size = new Size(100, 23);
            lblVenue.TabIndex = 0;
            lblVenue.Text = "Venue:";
            lblVenue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtVenue
            // 
            txtVenue.Location = new Point(115, 25);
            txtVenue.Name = "txtVenue";
            txtVenue.Size = new Size(350, 23);
            txtVenue.TabIndex = 1;
            txtVenue.TextChanged += txtVenue_TextChanged;
            // 
            // lblCity
            // 
            lblCity.Location = new Point(8, 55);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(100, 23);
            lblCity.TabIndex = 2;
            lblCity.Text = "City:";
            lblCity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(115, 55);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(200, 23);
            txtCity.TabIndex = 3;
            txtCity.TextChanged += txtCity_TextChanged;
            // 
            // lblNation
            // 
            lblNation.Location = new Point(325, 55);
            lblNation.Name = "lblNation";
            lblNation.Size = new Size(60, 23);
            lblNation.TabIndex = 4;
            lblNation.Text = "Nation:";
            lblNation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbNation
            // 
            cmbNation.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbNation.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbNation.FormattingEnabled = true;
            cmbNation.Items.AddRange(new object[] { "", "AFG", "ALA", "ALB", "DZA", "ASM", "AND", "AGO", "AIA", "ATA", "ATG", "ARG", "ARM", "ABW", "AUS", "AUT", "AZE", "BHS", "BHR", "BGD", "BRB", "BLR", "BEL", "BLZ", "BEN", "BMU", "BTN", "BOL", "BES", "BIH", "BWA", "BVT", "BRA", "IOT", "BRN", "BGR", "BFA", "BDI", "CPV", "KHM", "CMR", "CAN", "CYM", "CAF", "TCD", "CHL", "CHN", "CXR", "CCK", "COL", "COM", "COD", "COG", "COK", "CRI", "HRV", "CUB", "CUW", "CYP", "CZE", "CIV", "DNK", "DJI", "DMA", "DOM", "ECU", "EGY", "SLV", "GNQ", "ERI", "EST", "SWZ", "ETH", "FLK", "FRO", "FJI", "FIN", "FRA", "GUF", "PYF", "ATF", "GAB", "GMB", "GEO", "DEU", "GHA", "GIB", "GRC", "GRL", "GRD", "GLP", "GUM", "GTM", "GGY", "GIN", "GNB", "GUY", "HTI", "HMD", "VAT", "HND", "HKG", "HUN", "ISL", "IND", "IDN", "IRN", "IRQ", "IRL", "IMN", "ISR", "ITA", "JAM", "JPN", "JEY", "JOR", "KAZ", "KEN", "KIR", "PRK", "KOR", "KWT", "KGZ", "LAO", "LVA", "LBN", "LSO", "LBR", "LBY", "LIE", "LTU", "LUX", "MAC", "MDG", "MWI", "MYS", "MDV", "MLI", "MLT", "MHL", "MTQ", "MRT", "MUS", "MYT", "MEX", "FSM", "MDA", "MCO", "MNG", "MNE", "MSR", "MAR", "MOZ", "MMR", "NAM", "NRU", "NPL", "NLD", "NCL", "NZL", "NIC", "NER", "NGA", "NIU", "NFK", "MNP", "NOR", "OMN", "PAK", "PLW", "PSE", "PAN", "PNG", "PRY", "PER", "PHL", "PCN", "POL", "PRT", "PRI", "QAT", "MKD", "ROU", "RUS", "RWA", "REU", "BLM", "SHN", "KNA", "LCA", "MAF", "SPM", "VCT", "WSM", "SMR", "STP", "SAU", "SEN", "SRB", "SYC", "SLE", "SGP", "SXM", "SVK", "SVN", "SLB", "SOM", "ZAF", "SGS", "SSD", "ESP", "LKA", "SDN", "SUR", "SJM", "SWE", "CHE", "SYR", "TWN", "TJK", "TZA", "THA", "TLS", "TGO", "TKL", "TON", "TTO", "TUN", "TUR", "TKM", "TCA", "TUV", "UGA", "UKR", "ARE", "GBR", "UMI", "USA", "URY", "UZB", "VUT", "VEN", "VNM", "VGB", "VIR", "WLF", "ESH", "YEM", "ZMB", "ZWE" });
            cmbNation.Location = new Point(390, 55);
            cmbNation.Name = "cmbNation";
            cmbNation.Size = new Size(75, 23);
            cmbNation.TabIndex = 5;
            cmbNation.SelectedIndexChanged += cmbNation_SelectedIndexChanged;
            // 
            // lblStartDate
            // 
            lblStartDate.Location = new Point(8, 25);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(100, 23);
            lblStartDate.TabIndex = 0;
            lblStartDate.Text = "Start Date:";
            lblStartDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(115, 25);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(120, 23);
            dtpStartDate.TabIndex = 1;
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            // 
            // lblEndDate
            // 
            lblEndDate.Location = new Point(250, 25);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(100, 23);
            lblEndDate.TabIndex = 2;
            lblEndDate.Text = "End Date:";
            lblEndDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(355, 25);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(120, 23);
            dtpEndDate.TabIndex = 3;
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
            // 
            // lblInternational
            // 
            lblInternational.Location = new Point(8, 85);
            lblInternational.Name = "lblInternational";
            lblInternational.Size = new Size(100, 23);
            lblInternational.TabIndex = 6;
            lblInternational.Text = "International:";
            lblInternational.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chkInternational
            // 
            chkInternational.Location = new Point(115, 85);
            chkInternational.Name = "chkInternational";
            chkInternational.Size = new Size(200, 23);
            chkInternational.TabIndex = 7;
            chkInternational.Text = "International Competition";
            chkInternational.UseVisualStyleBackColor = true;
            chkInternational.CheckedChanged += chkInternational_CheckedChanged;
            // 
            // lblMeetGUID
            // 
            lblMeetGUID.Location = new Point(8, 80);
            lblMeetGUID.Name = "lblMeetGUID";
            lblMeetGUID.Size = new Size(100, 23);
            lblMeetGUID.TabIndex = 6;
            lblMeetGUID.Text = "Meet GUID:";
            lblMeetGUID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMeetGUID
            // 
            txtMeetGUID.Location = new Point(115, 80);
            txtMeetGUID.Name = "txtMeetGUID";
            txtMeetGUID.Size = new Size(280, 23);
            txtMeetGUID.TabIndex = 7;
            txtMeetGUID.TextChanged += txtMeetGUID_TextChanged;
            // 
            // grpMeetInfo
            // 
            grpMeetInfo.Controls.Add(lblMRef);
            grpMeetInfo.Controls.Add(txtMRef);
            grpMeetInfo.Controls.Add(lblTitle);
            grpMeetInfo.Controls.Add(txtTitle);
            grpMeetInfo.Controls.Add(lblMeetGUID);
            grpMeetInfo.Controls.Add(txtMeetGUID);
            grpMeetInfo.Location = new Point(8, 8);
            grpMeetInfo.Name = "grpMeetInfo";
            grpMeetInfo.Size = new Size(480, 118);
            grpMeetInfo.TabIndex = 0;
            grpMeetInfo.TabStop = false;
            grpMeetInfo.Text = "Meet Information";
            // 
            // grpDates
            // 
            grpDates.Controls.Add(lblStartDate);
            grpDates.Controls.Add(dtpStartDate);
            grpDates.Controls.Add(lblEndDate);
            grpDates.Controls.Add(dtpEndDate);
            grpDates.Location = new Point(8, 134);
            grpDates.Name = "grpDates";
            grpDates.Size = new Size(480, 80);
            grpDates.TabIndex = 1;
            grpDates.TabStop = false;
            grpDates.Text = "Dates";
            // 
            // grpLocation
            // 
            grpLocation.Controls.Add(lblVenue);
            grpLocation.Controls.Add(txtVenue);
            grpLocation.Controls.Add(lblCity);
            grpLocation.Controls.Add(txtCity);
            grpLocation.Controls.Add(lblNation);
            grpLocation.Controls.Add(cmbNation);
            grpLocation.Controls.Add(lblInternational);
            grpLocation.Controls.Add(chkInternational);
            grpLocation.Location = new Point(8, 224);
            grpLocation.Name = "grpLocation";
            grpLocation.Size = new Size(480, 120);
            grpLocation.TabIndex = 2;
            grpLocation.TabStop = false;
            grpLocation.Text = "Location and Settings";
            // 
            // MeetCtrl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpMeetInfo);
            Controls.Add(grpDates);
            Controls.Add(grpLocation);
            Name = "MeetCtrl";
            Size = new Size(500, 352);
            grpMeetInfo.ResumeLayout(false);
            grpMeetInfo.PerformLayout();
            grpDates.ResumeLayout(false);
            grpLocation.ResumeLayout(false);
            grpLocation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}