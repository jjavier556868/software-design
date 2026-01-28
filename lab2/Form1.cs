using System.Xml.Serialization;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int RecursiveFactoral(int n)
        {
            if (n == 0) return 1;
            return n * RecursiveFactoral(n - 1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnCalculateFactorial_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtInput.Text);
            int result = RecursiveFactoral(number);
            lblResult.Text = $"Factorial: {result}";
        }
        public int RecursiveSum(int[] numbers, int n)
        {
            if (n == 0) return numbers[0];
            return numbers[n] + RecursiveSum(numbers, n - 1);
        }

        private void btnCalculateSum_Click(object sender, EventArgs e)
        {
            int[] numbers = txtArrayInput.Text.Split(',').Select(int.Parse).ToArray();
            int result = RecursiveSum(numbers, numbers.Length - 1);
            lblSumResult.Text = $"Sum: {result}";
        }

        public int FibonacciRecursion(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
        }

        private void btnCalcFibonacci_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtFibo.Text);
            int result = FibonacciRecursion(number);
            lblFiboResult.Text = $"Fibonacci number: {result}";
        }

        public int PowerRecursive(int x, int n) 
        {
            if (n == 0) return 1;
            else return x * PowerRecursive(x, n - 1);
        }
        private void btnCalcPower_Click(object sender, EventArgs e)
        {
            int baseX = int.Parse(txtBaseNum.Text);
            int expN = int.Parse(txtExpNum.Text);
            int result = PowerRecursive(baseX, expN);
            lblPowerResult.Text = $"Result: {result}";
        }
    }
}
