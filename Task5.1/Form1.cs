namespace Task5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void BubbleSort(int[] numArray){
            if (numArray != null) {
                for (int i = 0; i < numArray.Length; i++) {

                    for (int j = 0; j < numArray.Length - i - 1; j++)
                    {
                        if (numArray[j] > numArray[j + 1]) { 
                            int temp = numArray[j];
                            numArray[j] = numArray[j + 1];
                            numArray[j + 1] = temp;
                            
                        }
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 6, 2, 10, 72, 100, -8, 0, 4, 1};
            beforeSort.DataSource = numbers;
            BubbleSort(numbers);
            listBoxResults.DataSource = numbers;
        }
    }
}
