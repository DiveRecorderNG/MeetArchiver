namespace MeetArchiver
{
    partial class DiverMatcher
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
            label1 = new Label();
            label2 = new Label();
            matchLst = new ListBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 25);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Current Diver";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(610, 25);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Archive Diver";
            // 
            // matchLst
            // 
            matchLst.FormattingEnabled = true;
            matchLst.ItemHeight = 15;
            matchLst.Location = new Point(412, 53);
            matchLst.Name = "matchLst";
            matchLst.Size = new Size(177, 109);
            matchLst.TabIndex = 2;
            matchLst.SelectedIndexChanged += matchLst_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(412, 25);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 3;
            label3.Text = "Possible matches";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(412, 186);
            button1.Name = "button1";
            button1.Size = new Size(177, 29);
            button1.TabIndex = 4;
            button1.Text = "<<     Take archive diver";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Location = new Point(412, 221);
            button2.Name = "button2";
            button2.Size = new Size(177, 29);
            button2.TabIndex = 5;
            button2.Text = "Overwrite archive diver   >>";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.Location = new Point(412, 301);
            button3.Name = "button3";
            button3.Size = new Size(177, 29);
            button3.TabIndex = 6;
            button3.TabStop = false;
            button3.Text = "Create new diver";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(473, 283);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 7;
            label4.Text = "No match";
            // 
            // DiverMatcher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 342);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(matchLst);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DiverMatcher";
            Text = "Match Diver";
            Load += DiverMatcher_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox matchLst;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
    }
}