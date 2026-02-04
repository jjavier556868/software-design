namespace Task3
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
            btnShowBooks = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btnShowBooks
            // 
            btnShowBooks.Location = new Point(39, 100);
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.Size = new Size(128, 51);
            btnShowBooks.TabIndex = 3;
            btnShowBooks.Text = "Show Books";
            btnShowBooks.UseVisualStyleBackColor = true;
            btnShowBooks.Click += btnShowBooks_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(205, 48);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(631, 354);
            listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 450);
            Controls.Add(btnShowBooks);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowBooks;
        private ListBox listBox1;
    }
}
