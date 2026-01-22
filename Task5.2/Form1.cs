namespace Task5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSortDescending_Click(object sender, EventArgs e)
        {
            int[] numbers = { 6, 2, 10, 72, 100, -8, 0, 4, 1 };
            beforeSort.DataSource = numbers;
            DescendOrder d = new DescendOrder();
            d.DescendSort(numbers);
            listBoxResults.DataSource = numbers;
        }
    }
}
