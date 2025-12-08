namespace MeetArchiver
{
    partial class EditDiver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDiver));
            diverCtrl1 = new MeetArchiver.Controls.DiverCtrl();
            searchBtn = new Button();
            updateBtn = new Button();
            SuspendLayout();
            // 
            // diverCtrl1
            // 
            diverCtrl1.BackColor = SystemColors.Control;
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
            diverCtrl1.EditedDiver = diver1;
            diverCtrl1.Location = new Point(12, 12);
            diverCtrl1.Name = "diverCtrl1";
            diverCtrl1.Size = new Size(362, 239);
            diverCtrl1.TabIndex = 0;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(398, 28);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(75, 23);
            searchBtn.TabIndex = 1;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(398, 209);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(75, 23);
            updateBtn.TabIndex = 2;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // EditDiver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 248);
            Controls.Add(updateBtn);
            Controls.Add(searchBtn);
            Controls.Add(diverCtrl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditDiver";
            Text = "Edit Diver";
            ResumeLayout(false);
        }

        #endregion

        private Controls.DiverCtrl diverCtrl1;
        private Button searchBtn;
        private Button updateBtn;
    }
}