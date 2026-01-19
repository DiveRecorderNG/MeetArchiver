namespace MeetArchiver
{
    partial class MergeClubs
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
            groupBox1 = new GroupBox();
            remainingBtn = new Button();
            remainingTxt = new TextBox();
            groupBox2 = new GroupBox();
            removedBtn = new Button();
            removedTxt = new TextBox();
            nergeBtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MediumSeaGreen;
            groupBox1.Controls.Add(remainingBtn);
            groupBox1.Controls.Add(remainingTxt);
            groupBox1.Location = new Point(10, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 51);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Remaining Club";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // remainingBtn
            // 
            remainingBtn.Location = new Point(351, 19);
            remainingBtn.Name = "remainingBtn";
            remainingBtn.Size = new Size(30, 23);
            remainingBtn.TabIndex = 1;
            remainingBtn.Text = ". . .";
            remainingBtn.UseVisualStyleBackColor = true;
            remainingBtn.Click += remainingBtn_Click;
            // 
            // remainingTxt
            // 
            remainingTxt.Location = new Point(6, 19);
            remainingTxt.Name = "remainingTxt";
            remainingTxt.Size = new Size(342, 23);
            remainingTxt.TabIndex = 0;
            remainingTxt.TextChanged += remainingTxt_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Firebrick;
            groupBox2.Controls.Add(removedBtn);
            groupBox2.Controls.Add(removedTxt);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.Location = new Point(10, 69);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(386, 53);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Removed Club";
            // 
            // removedBtn
            // 
            removedBtn.ForeColor = SystemColors.ActiveCaptionText;
            removedBtn.Location = new Point(351, 20);
            removedBtn.Name = "removedBtn";
            removedBtn.Size = new Size(30, 23);
            removedBtn.TabIndex = 2;
            removedBtn.Text = ". . .";
            removedBtn.UseVisualStyleBackColor = true;
            removedBtn.Click += removedBtn_Click;
            // 
            // removedTxt
            // 
            removedTxt.Location = new Point(6, 20);
            removedTxt.Name = "removedTxt";
            removedTxt.Size = new Size(342, 23);
            removedTxt.TabIndex = 1;
            // 
            // nergeBtn
            // 
            nergeBtn.Location = new Point(321, 128);
            nergeBtn.Name = "nergeBtn";
            nergeBtn.Size = new Size(75, 23);
            nergeBtn.TabIndex = 2;
            nergeBtn.Text = "Merge";
            nergeBtn.UseVisualStyleBackColor = true;
            nergeBtn.Click += nergeBtn_Click;
            // 
            // MergeClubs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 157);
            Controls.Add(nergeBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MergeClubs";
            Text = " Merge Clubs";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox remainingTxt;
        private Button remainingBtn;
        private TextBox removedTxt;
        private Button removedBtn;
        private Button nergeBtn;
    }
}