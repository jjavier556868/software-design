namespace Task5._2
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
            label3 = new Label();
            label2 = new Label();
            beforeSort = new ListBox();
            label1 = new Label();
            listBoxResults = new ListBox();
            btnSortDescending = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(407, 45);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 11;
            label3.Text = "After";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 45);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 10;
            label2.Text = "Before";
            // 
            // beforeSort
            // 
            beforeSort.FormattingEnabled = true;
            beforeSort.Location = new Point(188, 79);
            beforeSort.Name = "beforeSort";
            beforeSort.Size = new Size(193, 229);
            beforeSort.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 45);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 8;
            label1.Text = "Descending Order";
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(407, 79);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(207, 229);
            listBoxResults.TabIndex = 7;
            // 
            // btnSortDescending
            // 
            btnSortDescending.Location = new Point(35, 79);
            btnSortDescending.Name = "btnSortDescending";
            btnSortDescending.Size = new Size(114, 51);
            btnSortDescending.TabIndex = 12;
            btnSortDescending.Text = "Sort";
            btnSortDescending.UseVisualStyleBackColor = true;
            btnSortDescending.Click += btnSortDescending_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 357);
            Controls.Add(btnSortDescending);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(beforeSort);
            Controls.Add(label1);
            Controls.Add(listBoxResults);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private ListBox beforeSort;
        private Label label1;
        private ListBox listBoxResults;
        private Button btnSortDescending;
    }
}
