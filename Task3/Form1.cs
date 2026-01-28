namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
