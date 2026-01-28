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
            lblPowerResult = new Label();
            btnCalcPower = new Button();
            label7 = new Label();
            label6 = new Label();
            txtExpNum = new TextBox();
            txtBaseNum = new TextBox();
            label5 = new Label();
            lblFiboResult = new Label();
            btnCalcFibonacci = new Button();
            txtFibo = new TextBox();
            label4 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblPowerResult
            // 
            lblPowerResult.AutoSize = true;
            lblPowerResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPowerResult.Location = new Point(92, 237);
            lblPowerResult.Name = "lblPowerResult";
            lblPowerResult.Size = new Size(65, 21);
            lblPowerResult.TabIndex = 32;
            lblPowerResult.Text = "Result: ";
            // 
            // btnCalcPower
            // 
            btnCalcPower.Location = new Point(413, 177);
            btnCalcPower.Name = "btnCalcPower";
            btnCalcPower.Size = new Size(75, 52);
            btnCalcPower.TabIndex = 31;
            btnCalcPower.Text = "Calculate";
            btnCalcPower.UseVisualStyleBackColor = true;
            btnCalcPower.Click += btnCalcPower_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(95, 209);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 30;
            label7.Text = "Exponent:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(121, 180);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 29;
            label6.Text = "Base:";
            // 
            // txtExpNum
            // 
            txtExpNum.Location = new Point(161, 206);
            txtExpNum.Name = "txtExpNum";
            txtExpNum.PlaceholderText = "Enter exponent number here";
            txtExpNum.Size = new Size(234, 23);
            txtExpNum.TabIndex = 28;
            // 
            // txtBaseNum
            // 
            txtBaseNum.Location = new Point(161, 177);
            txtBaseNum.Name = "txtBaseNum";
            txtBaseNum.PlaceholderText = "Enter base number here";
            txtBaseNum.Size = new Size(234, 23);
            txtBaseNum.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 146);
            label5.Name = "label5";
            label5.Size = new Size(126, 21);
            label5.TabIndex = 26;
            label5.Text = "Power Recursion";
            // 
            // lblFiboResult
            // 
            lblFiboResult.AutoSize = true;
            lblFiboResult.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFiboResult.Location = new Point(32, 95);
            lblFiboResult.Name = "lblFiboResult";
            lblFiboResult.Size = new Size(138, 20);
            lblFiboResult.TabIndex = 25;
            lblFiboResult.Text = "Fibonacci number:";
            // 
            // btnCalcFibonacci
            // 
            btnCalcFibonacci.Location = new Point(413, 60);
            btnCalcFibonacci.Name = "btnCalcFibonacci";
            btnCalcFibonacci.Size = new Size(75, 23);
            btnCalcFibonacci.TabIndex = 24;
            btnCalcFibonacci.Text = "Calculate";
            btnCalcFibonacci.UseVisualStyleBackColor = true;
            btnCalcFibonacci.Click += btnCalcFibonacci_Click;
            // 
            // txtFibo
            // 
            txtFibo.Location = new Point(163, 60);
            txtFibo.Name = "txtFibo";
            txtFibo.PlaceholderText = "Enter number here";
            txtFibo.Size = new Size(232, 23);
            txtFibo.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 63);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 22;
            label4.Text = "Find Fibonacci:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 24);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 33;
            label1.Text = "Fibonacci";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 293);
            Controls.Add(label1);
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
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPowerResult;
        private Button btnCalcPower;
        private Label label7;
        private Label label6;
        private TextBox txtExpNum;
        private TextBox txtBaseNum;
        private Label label5;
        private Label lblFiboResult;
        private Button btnCalcFibonacci;
        private TextBox txtFibo;
        private Label label4;
        private Label label1;
    }
}
