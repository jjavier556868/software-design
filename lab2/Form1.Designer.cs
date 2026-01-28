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
            label4 = new Label();
            txtFibo = new TextBox();
            btnCalcFibonacci = new Button();
            lblFiboResult = new Label();
            label5 = new Label();
            txtBaseNum = new TextBox();
            txtExpNum = new TextBox();
            label6 = new Label();
            label7 = new Label();
            btnCalcPower = new Button();
            lblPowerResult = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(151, 74);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(232, 23);
            txtInput.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 23);
            label2.Name = "label2";
            label2.Size = new Size(447, 30);
            label2.TabIndex = 3;
            label2.Text = "Factorial, Sum of Array, Fibonacci Calculator";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 221);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 11;
            label4.Text = "Find Fibonacci:";
            // 
            // txtFibo
            // 
            txtFibo.Location = new Point(151, 218);
            txtFibo.Name = "txtFibo";
            txtFibo.Size = new Size(232, 23);
            txtFibo.TabIndex = 12;
            // 
            // btnCalcFibonacci
            // 
            btnCalcFibonacci.Location = new Point(401, 218);
            btnCalcFibonacci.Name = "btnCalcFibonacci";
            btnCalcFibonacci.Size = new Size(75, 23);
            btnCalcFibonacci.TabIndex = 13;
            btnCalcFibonacci.Text = "Calculate";
            btnCalcFibonacci.UseVisualStyleBackColor = true;
            btnCalcFibonacci.Click += btnCalcFibonacci_Click;
            // 
            // lblFiboResult
            // 
            lblFiboResult.AutoSize = true;
            lblFiboResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFiboResult.Location = new Point(39, 253);
            lblFiboResult.Name = "lblFiboResult";
            lblFiboResult.Size = new Size(108, 15);
            lblFiboResult.TabIndex = 14;
            lblFiboResult.Text = "Fibonacci number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 280);
            label5.Name = "label5";
            label5.Size = new Size(126, 21);
            label5.TabIndex = 15;
            label5.Text = "Power Recursion";
            // 
            // txtBaseNum
            // 
            txtBaseNum.Location = new Point(149, 311);
            txtBaseNum.Name = "txtBaseNum";
            txtBaseNum.Size = new Size(234, 23);
            txtBaseNum.TabIndex = 16;
            // 
            // txtExpNum
            // 
            txtExpNum.Location = new Point(149, 340);
            txtExpNum.Name = "txtExpNum";
            txtExpNum.Size = new Size(234, 23);
            txtExpNum.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(109, 314);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 18;
            label6.Text = "Base:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(83, 343);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 19;
            label7.Text = "Exponent:";
            // 
            // btnCalcPower
            // 
            btnCalcPower.Location = new Point(401, 306);
            btnCalcPower.Name = "btnCalcPower";
            btnCalcPower.Size = new Size(75, 52);
            btnCalcPower.TabIndex = 20;
            btnCalcPower.Text = "Calculate";
            btnCalcPower.UseVisualStyleBackColor = true;
            btnCalcPower.Click += btnCalcPower_Click;
            // 
            // lblPowerResult
            // 
            lblPowerResult.AutoSize = true;
            lblPowerResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPowerResult.Location = new Point(80, 371);
            lblPowerResult.Name = "lblPowerResult";
            lblPowerResult.Size = new Size(65, 21);
            lblPowerResult.TabIndex = 21;
            lblPowerResult.Text = "Result: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 424);
            Controls.Add(lblPowerResult);
            Controls.Add(btnCalcPower);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtExpNum);
            Controls.Add(txtBaseNum);
            Controls.Add(label5);
            Controls.Add(lblFiboResult);
            Controls.Add(btnCalcFibonacci);
            Controls.Add(txtFibo);
            Controls.Add(label4);
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
            Text = "Form1";
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
        private Label label4;
        private TextBox txtFibo;
        private Button btnCalcFibonacci;
        private Label lblFiboResult;
        private Label label5;
        private TextBox txtBaseNum;
        private TextBox txtExpNum;
        private Label label6;
        private Label label7;
        private Button btnCalcPower;
        private Label lblPowerResult;
    }
}
