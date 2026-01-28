namespace lab2
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
            txtInput = new TextBox();
            label2 = new Label();
            lblResult = new Label();
            btnCalculateFactorial = new Button();
            txtArrayInput = new TextBox();
            btnCalculateSum = new Button();
            lblSumResult = new Label();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(151, 74);
            txtInput.Name = "txtInput";
            txtInput.PlaceholderText = "Enter number here";
            txtInput.Size = new Size(232, 23);
            txtInput.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(215, 26);
            label2.Name = "label2";
            label2.Size = new Size(112, 30);
            label2.TabIndex = 3;
            label2.Text = "Calculator";
            label2.Click += label2_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(90, 108);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(57, 15);
            lblResult.TabIndex = 4;
            lblResult.Text = "Factorial:";
            // 
            // btnCalculateFactorial
            // 
            btnCalculateFactorial.Location = new Point(401, 74);
            btnCalculateFactorial.Name = "btnCalculateFactorial";
            btnCalculateFactorial.Size = new Size(75, 23);
            btnCalculateFactorial.TabIndex = 5;
            btnCalculateFactorial.Text = "Calculate";
            btnCalculateFactorial.UseVisualStyleBackColor = true;
            btnCalculateFactorial.Click += btnCalculateFactorial_Click;
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(151, 148);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.PlaceholderText = "Enter number separately using comma";
            txtArrayInput.Size = new Size(232, 23);
            txtArrayInput.TabIndex = 6;
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(401, 148);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(75, 23);
            btnCalculateSum.TabIndex = 7;
            btnCalculateSum.Text = "Calc. Sum";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSumResult.Location = new Point(108, 183);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(38, 15);
            lblSumResult.TabIndex = 8;
            lblSumResult.Text = "Sum: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 77);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 9;
            label1.Text = "Get Factorial:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 152);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 10;
            label3.Text = "Get Sum of Array:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 254);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lblSumResult);
            Controls.Add(btnCalculateSum);
            Controls.Add(txtArrayInput);
            Controls.Add(btnCalculateFactorial);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Factorial, Sum of Array Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Label label2;
        private Label lblResult;
        private Button btnCalculateFactorial;
        private TextBox txtArrayInput;
        private Button btnCalculateSum;
        private Label lblSumResult;
        private Label label1;
        private Label label3;
    }
}
