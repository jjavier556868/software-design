namespace lab5
{
	partial class Form1
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
            txtAuthorName = new TextBox();
            txtBoxTitle = new TextBox();
            btnAddBook = new Button();
            listBoxBooks = new ListBox();
            label1 = new Label();
            label2 = new Label();
            btnShowBooks = new Button();
            label3 = new Label();
            txtBookID = new TextBox();
            btnUpdateBook = new Button();
            btnDeleteBook = new Button();
            label4 = new Label();
            txtSearchBook = new TextBox();
            SuspendLayout();
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(45, 93);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(284, 23);
            txtAuthorName.TabIndex = 0;
            // 
            // txtBoxTitle
            // 
            txtBoxTitle.Location = new Point(45, 148);
            txtBoxTitle.Name = "txtBoxTitle";
            txtBoxTitle.Size = new Size(284, 23);
            txtBoxTitle.TabIndex = 1;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(45, 194);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(284, 34);
            btnAddBook.TabIndex = 2;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(351, 88);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(381, 259);
            listBoxBooks.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 75);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 4;
            label1.Text = "Author Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 130);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 5;
            label2.Text = "Book Title";
            // 
            // btnShowBooks
            // 
            btnShowBooks.Location = new Point(45, 234);
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.Size = new Size(284, 34);
            btnShowBooks.TabIndex = 6;
            btnShowBooks.Text = "Show Book";
            btnShowBooks.UseVisualStyleBackColor = true;
            btnShowBooks.Click += btnShowBooks_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 30);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 8;
            label3.Text = "ID";
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(45, 48);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(284, 23);
            txtBookID.TabIndex = 7;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(45, 275);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(284, 34);
            btnUpdateBook.TabIndex = 9;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(45, 315);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(284, 34);
            btnDeleteBook.TabIndex = 10;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(351, 30);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 13;
            label4.Text = "Search:";
            // 
            // txtSearchBook
            // 
            txtSearchBook.Location = new Point(351, 48);
            txtSearchBook.Name = "txtSearchBook";
            txtSearchBook.Size = new Size(381, 23);
            txtSearchBook.TabIndex = 12;
            txtSearchBook.TextChanged += txtSearchBook_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 409);
            Controls.Add(label4);
            Controls.Add(txtSearchBook);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnUpdateBook);
            Controls.Add(label3);
            Controls.Add(txtBookID);
            Controls.Add(btnShowBooks);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxBooks);
            Controls.Add(btnAddBook);
            Controls.Add(txtBoxTitle);
            Controls.Add(txtAuthorName);
            Name = "Form1";
            Text = "Task5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAuthorName;
        private TextBox txtBoxTitle;
        private Button btnAddBook;
        private ListBox listBoxBooks;
        private Label label1;
        private Label label2;
        private Button btnShowBooks;
        private Label label3;
        private TextBox txtBookID;
        private Button btnUpdateBook;
        private Button btnDeleteBook;
        private Label label4;
        private TextBox txtSearchBook;
    }
}
