using System.Windows.Forms;
using static Task3.Form1;

namespace Task3
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

        //TextBook class inheriting from Book
        public class TextBook: Book
        {
            public string Subject { get; set; }
            public TextBook(string title, string author, string subject) : base(title, author)
            {
                Subject = subject;
            }
            public override string GetInfo()
            {
                return $"{Title} by {Author} - Subject: {Subject}";
            }
        }

        //AudioBook class inheriting from Book
        public class AudioBook: Book
        {
           public double Duration { get; set; }
           public string Narrator { get; set; }

           public AudioBook(string title, string author, double duration, string narrator) : base(title, author)
              {
                Duration = duration;
                Narrator = narrator;
            }

           public override string GetInfo()
            {
                return $"{Title} by {Author} - Duration: {Duration} mins, Narrator: {Narrator}";
            }
        }

        //Method to process and display book information
        private void ProcessBooks(Book[] books)
        {

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
                new Book("Normal Book", "Author A"),
                new Magazine("Boring Magazine", "Editor B", 45),
                new EBook("Digital Guide for C#", "Writer C", "EPUB"),
                new TextBook("Software Design", "John Doe", "Programming"),      
                new AudioBook("Mystery Story", "Writer E", 8.5, "Narrator F") 
            };
            ProcessBooks(books);
        }

        
    }
}
