namespace Database_project
{
    partial class MainPageForm
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
            listOfUsers = new CheckedListBox();
            LoadUsers = new Button();
            MessageButton = new Button();
            MessageTextBox = new TextBox();
            SubjectTextBox = new TextBox();
            MessageHistory = new Button();
            SuspendLayout();
            // 
            // listOfUsers
            // 
            listOfUsers.FormattingEnabled = true;
            listOfUsers.Location = new Point(39, 84);
            listOfUsers.Name = "listOfUsers";
            listOfUsers.Size = new Size(201, 202);
            listOfUsers.TabIndex = 0;
            listOfUsers.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // LoadUsers
            // 
            LoadUsers.Location = new Point(39, 29);
            LoadUsers.Name = "LoadUsers";
            LoadUsers.Size = new Size(203, 48);
            LoadUsers.TabIndex = 1;
            LoadUsers.Text = "List Users";
            LoadUsers.UseVisualStyleBackColor = true;
            LoadUsers.Click += LoadUsers_Click;
            // 
            // MessageButton
            // 
            MessageButton.Location = new Point(616, 361);
            MessageButton.Name = "MessageButton";
            MessageButton.Size = new Size(153, 64);
            MessageButton.TabIndex = 2;
            MessageButton.Text = "send message";
            MessageButton.UseVisualStyleBackColor = true;
            MessageButton.Click += MessageButton_Click;
            // 
            // MessageTextBox
            // 
            MessageTextBox.Location = new Point(388, 84);
            MessageTextBox.Multiline = true;
            MessageTextBox.Name = "MessageTextBox";
            MessageTextBox.Size = new Size(381, 202);
            MessageTextBox.TabIndex = 3;
            MessageTextBox.TextChanged += textBox1_TextChanged;
            // 
            // SubjectTextBox
            // 
            SubjectTextBox.Location = new Point(388, 48);
            SubjectTextBox.Name = "SubjectTextBox";
            SubjectTextBox.Size = new Size(381, 23);
            SubjectTextBox.TabIndex = 4;
            SubjectTextBox.TextChanged += textBox1_TextChanged_1;
            // 
            // MessageHistory
            // 
            MessageHistory.Location = new Point(388, 361);
            MessageHistory.Name = "MessageHistory";
            MessageHistory.Size = new Size(153, 64);
            MessageHistory.TabIndex = 5;
            MessageHistory.Text = "history of messages";
            MessageHistory.UseVisualStyleBackColor = true;
            MessageHistory.Click += MessageHistory_Click;
            // 
            // MainPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MessageHistory);
            Controls.Add(SubjectTextBox);
            Controls.Add(MessageTextBox);
            Controls.Add(MessageButton);
            Controls.Add(LoadUsers);
            Controls.Add(listOfUsers);
            Name = "MainPageForm";
            Text = "MainPageForm";
            Load += MainPageForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox listOfUsers;
        private Button LoadUsers;
        private Button MessageButton;
        private TextBox MessageTextBox;
        private TextBox SubjectTextBox;
        private Button MessageHistory;
    }
}