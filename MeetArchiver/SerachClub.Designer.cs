namespace MeetArchiver
{
    partial class SerachClub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerachClub));
            searchTxt = new TextBox();
            clubsLst = new ListBox();
            selectBtn = new Button();
            searchBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // searchTxt
            // 
            searchTxt.Location = new Point(24, 29);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(226, 23);
            searchTxt.TabIndex = 0;
            // 
            // clubsLst
            // 
            clubsLst.FormattingEnabled = true;
            clubsLst.ItemHeight = 15;
            clubsLst.Location = new Point(24, 65);
            clubsLst.Name = "clubsLst";
            clubsLst.Size = new Size(307, 274);
            clubsLst.TabIndex = 1;
            // 
            // selectBtn
            // 
            selectBtn.Location = new Point(337, 316);
            selectBtn.Name = "selectBtn";
            selectBtn.Size = new Size(75, 23);
            selectBtn.TabIndex = 2;
            selectBtn.Text = "Select";
            selectBtn.UseVisualStyleBackColor = true;
            selectBtn.Click += selectBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(256, 29);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(75, 23);
            searchBtn.TabIndex = 3;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 12);
            label1.Name = "label1";
            label1.Size = new Size(180, 15);
            label1.TabIndex = 4;
            label1.Text = "Enter Text (City is often effective)";
            // 
            // SerachClub
            // 
            AcceptButton = searchBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 352);
            Controls.Add(label1);
            Controls.Add(searchBtn);
            Controls.Add(selectBtn);
            Controls.Add(clubsLst);
            Controls.Add(searchTxt);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SerachClub";
            Text = "Search Club";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchTxt;
        private ListBox clubsLst;
        private Button selectBtn;
        private Button searchBtn;
        private Label label1;
    }
}