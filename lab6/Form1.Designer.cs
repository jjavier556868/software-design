namespace lab6
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
            btnAddBook = new Button();
            listBoxBooks = new ListBox();
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            btnFetchBooks = new Button();
            label1 = new Label();
            label2 = new Label();
            btnUpdateBook = new Button();
            label3 = new Label();
            txtBookID = new TextBox();
            label4 = new Label();
            txtSearch = new TextBox();
            btnDeleteBook = new Button();
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // btnAddBook
            // 
            btnAddBook.Font = new Font("Segoe UI", 14.25F);
            btnAddBook.Location = new Point(25, 216);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(348, 42);
            btnAddBook.TabIndex = 0;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(407, 26);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(309, 394);
            listBoxBooks.TabIndex = 1;
            listBoxBooks.MouseDoubleClick += listBoxBooks_MouseDoubleClick;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(25, 122);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(348, 23);
            txtAuthorName.TabIndex = 2;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(25, 166);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(348, 23);
            txtBookTitle.TabIndex = 3;
            // 
            // btnFetchBooks
            // 
            btnFetchBooks.Font = new Font("Segoe UI", 14.25F);
            btnFetchBooks.Location = new Point(25, 264);
            btnFetchBooks.Name = "btnFetchBooks";
            btnFetchBooks.Size = new Size(348, 43);
            btnFetchBooks.TabIndex = 4;
            btnFetchBooks.Text = "Fetch Books";
            btnFetchBooks.UseVisualStyleBackColor = true;
            btnFetchBooks.Click += btnFetchBooks_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 104);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 5;
            label1.Text = "Author Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 148);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 6;
            label2.Text = "Book Title:";
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Font = new Font("Segoe UI", 14.25F);
            btnUpdateBook.Location = new Point(25, 313);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(348, 42);
            btnUpdateBook.TabIndex = 7;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 60);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 9;
            label3.Text = "ID:";
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(25, 78);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(348, 23);
            txtBookID.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 16);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 11;
            label4.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(25, 34);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(348, 23);
            txtSearch.TabIndex = 10;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Font = new Font("Segoe UI", 14.25F);
            btnDeleteBook.Location = new Point(25, 361);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(348, 42);
            btnDeleteBook.TabIndex = 12;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(25, 409);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(348, 23);
            progressBar.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 448);
            Controls.Add(progressBar);
            Controls.Add(btnDeleteBook);
            Controls.Add(label4);
            Controls.Add(txtSearch);
            Controls.Add(label3);
            Controls.Add(txtBookID);
            Controls.Add(btnUpdateBook);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnFetchBooks);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Controls.Add(listBoxBooks);
            Controls.Add(btnAddBook);
            Name = "Form1";
            Text = "Task6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddBook;
        private ListBox listBoxBooks;
        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private Button btnFetchBooks;
        private Label label1;
        private Label label2;
        private Button btnUpdateBook;
        private Label label3;
        private TextBox txtBookID;
        private Label label4;
        private TextBox txtSearch;
        private Button btnDeleteBook;
        private ProgressBar progressBar;
    }
}
