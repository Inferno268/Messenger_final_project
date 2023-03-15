namespace Database_project
{
    partial class Login_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            userNameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            reggisterButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(191, 273);
            button1.Name = "button1";
            button1.Size = new Size(177, 51);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(63, 84);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(432, 23);
            userNameTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(63, 141);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(432, 23);
            PasswordTextBox.TabIndex = 2;
            // 
            // reggisterButton
            // 
            reggisterButton.Location = new Point(191, 347);
            reggisterButton.Name = "reggisterButton";
            reggisterButton.Size = new Size(177, 51);
            reggisterButton.TabIndex = 3;
            reggisterButton.Text = "Register";
            reggisterButton.UseVisualStyleBackColor = true;
            reggisterButton.Click += reggisterButton_Click;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 427);
            Controls.Add(reggisterButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(button1);
            Name = "Login_Form";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox userNameTextBox;
        private TextBox PasswordTextBox;
        private Button reggisterButton;
    }
}