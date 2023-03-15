namespace Database_project
{
    partial class History
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
            LoadHistory = new Button();
            listOfMessages = new CheckedListBox();
            DeleteMessages = new Button();
            listOfRecievedMessages = new CheckedListBox();
            loadRecievedMessages = new Button();
            SuspendLayout();
            // 
            // LoadHistory
            // 
            LoadHistory.Location = new Point(12, 12);
            LoadHistory.Name = "LoadHistory";
            LoadHistory.Size = new Size(174, 52);
            LoadHistory.TabIndex = 0;
            LoadHistory.Text = "Load sent messages";
            LoadHistory.UseVisualStyleBackColor = true;
            LoadHistory.Click += LoadHistory_Click;
            // 
            // listOfMessages
            // 
            listOfMessages.FormattingEnabled = true;
            listOfMessages.HorizontalScrollbar = true;
            listOfMessages.Location = new Point(12, 90);
            listOfMessages.Name = "listOfMessages";
            listOfMessages.Size = new Size(322, 292);
            listOfMessages.TabIndex = 1;
            listOfMessages.SelectedIndexChanged += listOfMessages_SelectedIndexChanged;
            // 
            // DeleteMessages
            // 
            DeleteMessages.Location = new Point(589, 388);
            DeleteMessages.Name = "DeleteMessages";
            DeleteMessages.Size = new Size(174, 52);
            DeleteMessages.TabIndex = 2;
            DeleteMessages.Text = "Delete messages";
            DeleteMessages.UseVisualStyleBackColor = true;
            DeleteMessages.Click += DeleteMessages_Click;
            // 
            // listOfRecievedMessages
            // 
            listOfRecievedMessages.FormattingEnabled = true;
            listOfRecievedMessages.HorizontalScrollbar = true;
            listOfRecievedMessages.Location = new Point(441, 90);
            listOfRecievedMessages.Name = "listOfRecievedMessages";
            listOfRecievedMessages.Size = new Size(322, 292);
            listOfRecievedMessages.TabIndex = 3;
            // 
            // loadRecievedMessages
            // 
            loadRecievedMessages.Location = new Point(441, 12);
            loadRecievedMessages.Name = "loadRecievedMessages";
            loadRecievedMessages.Size = new Size(174, 52);
            loadRecievedMessages.TabIndex = 4;
            loadRecievedMessages.Text = "Load recieved messages";
            loadRecievedMessages.UseVisualStyleBackColor = true;
            loadRecievedMessages.Click += loadRecievedMessages_Click;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loadRecievedMessages);
            Controls.Add(listOfRecievedMessages);
            Controls.Add(DeleteMessages);
            Controls.Add(listOfMessages);
            Controls.Add(LoadHistory);
            Name = "History";
            Text = "History";
            ResumeLayout(false);
        }

        #endregion

        private Button LoadHistory;
        private CheckedListBox listOfMessages;
        private Button DeleteMessages;
        private CheckedListBox listOfRecievedMessages;
        private Button loadRecievedMessages;
    }
}