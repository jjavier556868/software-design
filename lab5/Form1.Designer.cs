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
            SuspendLayout();
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(39, 91);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(284, 23);
            txtAuthorName.TabIndex = 0;
            // 
            // txtBoxTitle
            // 
            txtBoxTitle.Location = new Point(39, 146);
            txtBoxTitle.Name = "txtBoxTitle";
            txtBoxTitle.Size = new Size(284, 23);
            txtBoxTitle.TabIndex = 1;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(39, 192);
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
            listBoxBooks.Location = new Point(351, 28);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(282, 289);
            listBoxBooks.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 73);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 4;
            label1.Text = "Author Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 128);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 5;
            label2.Text = "Book Title";
            // 
            // btnShowBooks
            // 
            btnShowBooks.Location = new Point(39, 232);
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
            label3.Location = new Point(39, 28);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 8;
            label3.Text = "ID";
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(39, 46);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(284, 23);
            txtBookID.TabIndex = 7;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(39, 273);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(284, 34);
            btnUpdateBook.TabIndex = 9;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 341);
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
    }
}
