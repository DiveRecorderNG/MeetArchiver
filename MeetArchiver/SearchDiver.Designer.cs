namespace MeetArchiver
{
    partial class SearchDiver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DR_APIs.Models.Diver diver1 = new DR_APIs.Models.Diver();
            DR_APIs.Models.Diver diver2 = new DR_APIs.Models.Diver();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDiver));
            foundDiverCtrl = new MeetArchiver.Controls.DiverCtrl();
            searchBtn = new Button();
            upadteDiver = new Button();
            FamilyNameTxt = new TextBox();
            label1 = new Label();
            suppliedDiverCtrl = new MeetArchiver.Controls.DiverCtrl();
            label2 = new Label();
            label3 = new Label();
            searchDiverDGV = new DataGridView();
            Lastname = new DataGridViewTextBoxColumn();
            Firstname = new DataGridViewTextBoxColumn();
            Born = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)searchDiverDGV).BeginInit();
            SuspendLayout();
            // 
            // foundDiverCtrl
            // 
            foundDiverCtrl.BackColor = SystemColors.Control;
            diver1.ArchiveID = null;
            diver1.Born = null;
            diver1.Coach = null;
            diver1.FirstName = null;
            diver1.ID = 0;
            diver1.LastName = null;
            diver1.Nation = null;
            diver1.PossibleMatches = null;
            diver1.RecordStatus = DR_APIs.Models.RecordStatus.Unassigned;
            diver1.Representing = null;
            diver1.Sex = null;
            diver1.TCode = null;
            foundDiverCtrl.EditedDiver = diver1;
            foundDiverCtrl.Location = new Point(352, 47);
            foundDiverCtrl.Name = "foundDiverCtrl";
            foundDiverCtrl.Readonly = false;
            foundDiverCtrl.Size = new Size(362, 239);
            foundDiverCtrl.TabIndex = 0;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(227, 31);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(75, 23);
            searchBtn.TabIndex = 1;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // upadteDiver
            // 
            upadteDiver.Location = new Point(995, 292);
            upadteDiver.Name = "upadteDiver";
            upadteDiver.Size = new Size(75, 23);
            upadteDiver.TabIndex = 2;
            upadteDiver.Text = "Update";
            upadteDiver.UseVisualStyleBackColor = true;
            upadteDiver.Click += updateBtn_Click;
            // 
            // FamilyNameTxt
            // 
            FamilyNameTxt.Location = new Point(15, 31);
            FamilyNameTxt.Name = "FamilyNameTxt";
            FamilyNameTxt.Size = new Size(206, 23);
            FamilyNameTxt.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 4;
            label1.Text = "Family name";
            // 
            // suppliedDiverCtrl
            // 
            suppliedDiverCtrl.BackColor = SystemColors.Control;
            diver2.ArchiveID = null;
            diver2.Born = null;
            diver2.Coach = null;
            diver2.FirstName = null;
            diver2.ID = 0;
            diver2.LastName = null;
            diver2.Nation = null;
            diver2.PossibleMatches = null;
            diver2.RecordStatus = DR_APIs.Models.RecordStatus.Unassigned;
            diver2.Representing = null;
            diver2.Sex = null;
            diver2.TCode = null;
            suppliedDiverCtrl.EditedDiver = diver2;
            suppliedDiverCtrl.Location = new Point(733, 47);
            suppliedDiverCtrl.Name = "suppliedDiverCtrl";
            suppliedDiverCtrl.Readonly = false;
            suppliedDiverCtrl.Size = new Size(362, 239);
            suppliedDiverCtrl.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(741, 31);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 7;
            label2.Text = "Local Diver";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 31);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 8;
            label3.Text = "Archive Diver";
            // 
            // searchDiverDGV
            // 
            searchDiverDGV.AllowUserToAddRows = false;
            searchDiverDGV.AllowUserToDeleteRows = false;
            searchDiverDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            searchDiverDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            searchDiverDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchDiverDGV.Columns.AddRange(new DataGridViewColumn[] { Lastname, Firstname, Born });
            searchDiverDGV.Location = new Point(12, 78);
            searchDiverDGV.MultiSelect = false;
            searchDiverDGV.Name = "searchDiverDGV";
            searchDiverDGV.ReadOnly = true;
            searchDiverDGV.RowHeadersVisible = false;
            searchDiverDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            searchDiverDGV.Size = new Size(327, 290);
            searchDiverDGV.TabIndex = 9;
            searchDiverDGV.CellContentClick += dataGridView1_CellContentClick;
            searchDiverDGV.RowEnter += dataGridView1_CellContentClick;
            // 
            // Lastname
            // 
            Lastname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Lastname.FillWeight = 200F;
            Lastname.HeaderText = "Last Name";
            Lastname.Name = "Lastname";
            Lastname.ReadOnly = true;
            Lastname.SortMode = DataGridViewColumnSortMode.NotSortable;
            Lastname.Width = 69;
            // 
            // Firstname
            // 
            Firstname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Firstname.HeaderText = "First Name";
            Firstname.Name = "Firstname";
            Firstname.ReadOnly = true;
            Firstname.SortMode = DataGridViewColumnSortMode.NotSortable;
            Firstname.Width = 70;
            // 
            // Born
            // 
            Born.HeaderText = "Born";
            Born.Name = "Born";
            Born.ReadOnly = true;
            Born.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // SearchDiver
            // 
            AcceptButton = searchBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 380);
            Controls.Add(searchDiverDGV);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(suppliedDiverCtrl);
            Controls.Add(label1);
            Controls.Add(FamilyNameTxt);
            Controls.Add(upadteDiver);
            Controls.Add(searchBtn);
            Controls.Add(foundDiverCtrl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SearchDiver";
            Text = "Search Diver";
            Load += EditDiver_Load;
            ((System.ComponentModel.ISupportInitialize)searchDiverDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.DiverCtrl foundDiverCtrl;
        private Button searchBtn;
        private Button upadteDiver;
        private TextBox FamilyNameTxt;
        private Label label1;
        private Controls.DiverCtrl suppliedDiverCtrl;
        private Label label2;
        private Label label3;
        private DataGridView searchDiverDGV;
        private DataGridViewTextBoxColumn Lastname;
        private DataGridViewTextBoxColumn Firstname;
        private DataGridViewTextBoxColumn Born;
    }
}