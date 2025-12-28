namespace MeetArchiver
{
    partial class MergeDivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MergeDivers));
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            searchBtn = new Button();
            survivorDiveCtrl = new MeetArchiver.Controls.DiverCtrl();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            casualtyDiveCtrl = new MeetArchiver.Controls.DiverCtrl();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            mergeBtn = new Button();
            survivorMeets = new ListBox();
            casualtyMeets = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(377, 118);
            label4.Name = "label4";
            label4.Size = new Size(17, 21);
            label4.TabIndex = 13;
            label4.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(377, 139);
            label3.Name = "label3";
            label3.Size = new Size(17, 21);
            label3.TabIndex = 12;
            label3.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(377, 65);
            label2.Name = "label2";
            label2.Size = new Size(17, 21);
            label2.TabIndex = 11;
            label2.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(377, 39);
            label1.Name = "label1";
            label1.Size = new Size(17, 21);
            label1.TabIndex = 10;
            label1.Text = "*";
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(401, 29);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(75, 23);
            searchBtn.TabIndex = 8;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // survivorDiveCtrl
            // 
            survivorDiveCtrl.BackColor = SystemColors.Control;
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
            survivorDiveCtrl.EditedDiver = diver1;
            survivorDiveCtrl.Location = new Point(15, 22);
            survivorDiveCtrl.Name = "survivorDiveCtrl";
            survivorDiveCtrl.Readonly = false;
            survivorDiveCtrl.Size = new Size(362, 239);
            survivorDiveCtrl.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(377, 117);
            label5.Name = "label5";
            label5.Size = new Size(17, 21);
            label5.TabIndex = 19;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(377, 138);
            label6.Name = "label6";
            label6.Size = new Size(17, 21);
            label6.TabIndex = 18;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(377, 64);
            label7.Name = "label7";
            label7.Size = new Size(17, 21);
            label7.TabIndex = 17;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(377, 38);
            label8.Name = "label8";
            label8.Size = new Size(17, 21);
            label8.TabIndex = 16;
            label8.Text = "*";
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(407, 29);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // casualtyDiveCtrl
            // 
            casualtyDiveCtrl.BackColor = SystemColors.Control;
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
            casualtyDiveCtrl.EditedDiver = diver2;
            casualtyDiveCtrl.Location = new Point(14, 20);
            casualtyDiveCtrl.Name = "casualtyDiveCtrl";
            casualtyDiveCtrl.Readonly = false;
            casualtyDiveCtrl.Size = new Size(362, 239);
            casualtyDiveCtrl.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MediumSeaGreen;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(searchBtn);
            groupBox1.Controls.Add(survivorDiveCtrl);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(510, 282);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Remaining Diver";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Firebrick;
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(casualtyDiveCtrl);
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(547, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(506, 281);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Removed Diver";
            // 
            // mergeBtn
            // 
            mergeBtn.Location = new Point(946, 547);
            mergeBtn.Name = "mergeBtn";
            mergeBtn.Size = new Size(106, 31);
            mergeBtn.TabIndex = 22;
            mergeBtn.Text = "Merge";
            mergeBtn.UseVisualStyleBackColor = true;
            mergeBtn.Click += mergeBtn_Click;
            // 
            // survivorMeets
            // 
            survivorMeets.FormattingEnabled = true;
            survivorMeets.ItemHeight = 15;
            survivorMeets.Location = new Point(16, 314);
            survivorMeets.Name = "survivorMeets";
            survivorMeets.Size = new Size(506, 229);
            survivorMeets.TabIndex = 23;
            // 
            // casualtyMeets
            // 
            casualtyMeets.FormattingEnabled = true;
            casualtyMeets.ItemHeight = 15;
            casualtyMeets.Location = new Point(547, 314);
            casualtyMeets.Name = "casualtyMeets";
            casualtyMeets.Size = new Size(506, 229);
            casualtyMeets.TabIndex = 24;
            // 
            // MergeDivers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 583);
            Controls.Add(casualtyMeets);
            Controls.Add(survivorMeets);
            Controls.Add(mergeBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MergeDivers";
            Text = "Merge Divers";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button updateBtn;
        private Button searchBtn;
        private Controls.DiverCtrl survivorDiveCtrl;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private Controls.DiverCtrl casualtyDiveCtrl;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button mergeBtn;
        private ListBox survivorMeets;
        private ListBox casualtyMeets;
    }
}