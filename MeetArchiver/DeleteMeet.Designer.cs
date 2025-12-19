namespace MeetArchiver
{
    partial class DeleteMeet
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
            DR_APIs.Models.Meet meet2 = new DR_APIs.Models.Meet();
            searchBtn = new Button();
            label1 = new Label();
            meetTitleTxt = new TextBox();
            meetCtrl = new MeetArchiver.Controls.MeetCtrl();
            meetsLst = new ListBox();
            DeleteBtn = new Button();
            SuspendLayout();
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(289, 34);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(75, 23);
            searchBtn.TabIndex = 0;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 15);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter meet title :";
            // 
            // meetTitleTxt
            // 
            meetTitleTxt.Location = new Point(24, 35);
            meetTitleTxt.Name = "meetTitleTxt";
            meetTitleTxt.Size = new Size(259, 23);
            meetTitleTxt.TabIndex = 2;
            // 
            // meetCtrl
            // 
            meet2.ArchiveMRef = null;
            meet2.City = null;
            meet2.EndDate = new DateOnly(2025, 12, 18);
            meet2.International = false;
            meet2.MeetGUID = null;
            meet2.MRef = 0;
            meet2.Nation = null;
            meet2.StartDate = new DateOnly(2025, 12, 18);
            meet2.Title = null;
            meet2.Venue = null;
            meetCtrl.EditedMeet = meet2;
            meetCtrl.Location = new Point(380, 15);
            meetCtrl.Name = "meetCtrl";
            meetCtrl.ReadOnly = false;
            meetCtrl.Size = new Size(500, 350);
            meetCtrl.TabIndex = 3;
            // 
            // meetsLst
            // 
            meetsLst.FormattingEnabled = true;
            meetsLst.ItemHeight = 15;
            meetsLst.Location = new Point(28, 86);
            meetsLst.Name = "meetsLst";
            meetsLst.Size = new Size(336, 304);
            meetsLst.TabIndex = 4;
            meetsLst.SelectedIndexChanged += meetsLst_SelectedIndexChanged;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Tomato;
            DeleteBtn.ForeColor = Color.AliceBlue;
            DeleteBtn.Location = new Point(794, 365);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 30);
            DeleteBtn.TabIndex = 5;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // DeleteMeet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 407);
            Controls.Add(DeleteBtn);
            Controls.Add(meetsLst);
            Controls.Add(meetCtrl);
            Controls.Add(meetTitleTxt);
            Controls.Add(label1);
            Controls.Add(searchBtn);
            Name = "DeleteMeet";
            Text = "DeleteMeet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchBtn;
        private Label label1;
        private TextBox meetTitleTxt;
        private Controls.MeetCtrl meetCtrl;
        private ListBox meetsLst;
        private Button DeleteBtn;
    }
}