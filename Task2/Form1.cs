namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Main Book class
        public class Book
        {
            public string? Title { get; set; }
            public string? Author { get; set; }

            public Book(string title, string author)
            {
                Title = title;
                Author = author;
            }
            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }

        //Magazine class inheriting from Book
        public class Magazine : Book
        {
            public int IssueNumber { get; set; }

            public Magazine(string title, string author, int issueNumber) : base(title, author)
            {
                IssueNumber = issueNumber;
            }
            public override string GetInfo()
            {
                return $"{Title} - Issue {IssueNumber}";
            }
        }

        //EBook class inheriting from Book
        public class EBook : Book
        {

            public string FileFormat { get; set; }

            public EBook(string title, string author, string fileFormat) : base(title, author)
            {
                FileFormat = fileFormat;
            }

            public override string GetInfo()
            {
                return $"{Title} by {Author} - File Format: {FileFormat}";
            }
        }

        
        private void ProcessBooks(Book[] books) {

            listBox1.Items.Clear();
            foreach (Book book in books)
            {
                listBox1.Items.Add(book.GetInfo());
            }
        
        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            Book[] books = new Book[]
            {
                new Magazine("Tech Weekly", "John Doe", 45),
                new EBook("C# Programming", "Jane Smith", "PDF"),
                new Book("The Great Gatsby", "F. Scott Fitzgerald")
            };
            ProcessBooks(books);
        }
        
    }
}
