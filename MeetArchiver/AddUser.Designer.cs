namespace MeetArchiver
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            label1 = new Label();
            emailTxt = new TextBox();
            label2 = new Label();
            apiKeyTxt = new TextBox();
            generateBtn = new Button();
            saveBtn = new Button();
            checkBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 27);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(15, 45);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(231, 23);
            emailTxt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 89);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 4;
            label2.Text = "API Key";
            // 
            // apiKeyTxt
            // 
            apiKeyTxt.Enabled = false;
            apiKeyTxt.Location = new Point(15, 107);
            apiKeyTxt.Name = "apiKeyTxt";
            apiKeyTxt.Size = new Size(231, 23);
            apiKeyTxt.TabIndex = 5;
            // 
            // generateBtn
            // 
            generateBtn.Enabled = false;
            generateBtn.Location = new Point(260, 106);
            generateBtn.Name = "generateBtn";
            generateBtn.Size = new Size(75, 23);
            generateBtn.TabIndex = 7;
            generateBtn.Text = "Generate";
            generateBtn.UseVisualStyleBackColor = true;
            generateBtn.Click += generateBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Enabled = false;
            saveBtn.Location = new Point(15, 158);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 23);
            saveBtn.TabIndex = 8;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // checkBtn
            // 
            checkBtn.Location = new Point(260, 44);
            checkBtn.Name = "checkBtn";
            checkBtn.Size = new Size(75, 23);
            checkBtn.TabIndex = 9;
            checkBtn.Text = "Check";
            checkBtn.UseVisualStyleBackColor = true;
            checkBtn.Click += verifyBtn_Click;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 195);
            Controls.Add(checkBtn);
            Controls.Add(saveBtn);
            Controls.Add(generateBtn);
            Controls.Add(apiKeyTxt);
            Controls.Add(label2);
            Controls.Add(emailTxt);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddUser";
            Text = "Add User";
            Load += ManageUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox emailTxt;
        private Label label2;
        private TextBox apiKeyTxt;
        private Button generateBtn;
        private Button saveBtn;
        private Button checkBtn;
    }
}