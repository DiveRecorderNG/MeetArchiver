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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
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
            diverCtrl1.Readonly = false;
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
            updateBtn.Click += updateBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(357, 30);
            label1.Name = "label1";
            label1.Size = new Size(17, 21);
            label1.TabIndex = 3;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(357, 56);
            label2.Name = "label2";
            label2.Size = new Size(17, 21);
            label2.TabIndex = 4;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(357, 130);
            label3.Name = "label3";
            label3.Size = new Size(17, 21);
            label3.TabIndex = 5;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(357, 109);
            label4.Name = "label4";
            label4.Size = new Size(17, 21);
            label4.TabIndex = 6;
            label4.Text = "*";
            // 
            // EditDiver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 248);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(updateBtn);
            Controls.Add(searchBtn);
            Controls.Add(diverCtrl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditDiver";
            Text = "Edit Diver";
            Load += EditDiver_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.DiverCtrl diverCtrl1;
        private Button searchBtn;
        private Button updateBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}