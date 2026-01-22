namespace Task5._1
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
            button1 = new Button();
            listBoxResults = new ListBox();
            label1 = new Label();
            beforeSort = new ListBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(32, 61);
            button1.Name = "button1";
            button1.Size = new Size(125, 42);
            button1.TabIndex = 0;
            button1.Text = "Sort";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(404, 61);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(207, 229);
            listBoxResults.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 27);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 2;
            label1.Text = "Bubble Sort";
            // 
            // beforeSort
            // 
            beforeSort.FormattingEnabled = true;
            beforeSort.Location = new Point(185, 61);
            beforeSort.Name = "beforeSort";
            beforeSort.Size = new Size(193, 229);
            beforeSort.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 27);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 4;
            label2.Text = "Before";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(404, 27);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "After";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 340);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(beforeSort);
            Controls.Add(label1);
            Controls.Add(listBoxResults);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBoxResults;
        private Label label1;
        private ListBox beforeSort;
        private Label label2;
        private Label label3;
    }
}
