using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Author
        {
            public int AuthorID { get; set; }
            public string Name { get; set; }
            public virtual ICollection<Book> Books { get; set; }
        }

        public class Book
        {
            public int BookID { get; set; }
            public string Title { get; set; }
            public int AuthorID { get; set; }
            public virtual Author Author { get; set; }
        }

        public void AddAuthorWithBook(string authorName, string bookTitle)
        {
            using (var context = new BookstoreContextClass())
            {
                var author = new Author { Name = authorName };

                var book = new Book { Title = bookTitle, Author = author };
                context.Authors.Add(author);
                context.Books.Add(book);
                context.SaveChanges();
            }
        }

        public List<string> GetBooksByAuthors()
        {
            using (var context = new BookstoreContextClass())
            {
                var booksWithAuthors = context.Books
                    .Include(b => b.Author)
                    .Select(b => $"{b.Title} by {b.Author.Name}").
                    ToList();

                return booksWithAuthors;
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddAuthorWithBook(txtAuthorName.Text, txtBoxTitle.Text);
        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            var books = GetBooksByAuthors();
            listBoxBooks.DataSource = books;
        }

        public void UpdateBookAndAuthor(int bookId, string newTitle, string newAuthorName)
        {
            using (var context = new BookstoreContextClass())
            {
                var book = context.Books.Include(b => b.Author).FirstOrDefault(b => b.BookID == bookId);
                if (book != null)
                {
                    book.Title = newTitle;
                    book.Author.Name = newAuthorName;
                    context.SaveChanges();
                }
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(txtBookID.Text);
            UpdateBookAndAuthor(bookId, txtBoxTitle.Text, txtAuthorName.Text);
            MessageBox.Show("Book and Author updated successfully!");
        }

        public void DeleteBookAndAuthor(int bookId)
        {
            using (var context = new BookstoreContextClass())
            {
                var book = context.Books.Include(b => b.Author).FirstOrDefault(b => b.BookID == bookId);
                if (book != null)
                {
                    context.Authors.Remove(book.Author);
                    context.Books.Remove(book);
                    context.SaveChanges();
                }
            }
        }
        private void btnDeleteBook_Click(object sender, EventArgs e)
        { 
            int bookId;
            if (int.TryParse(txtBookID.Text, out bookId))
            {
                DeleteBookAndAuthor(bookId);
                MessageBox.Show("Book and Author deleted successfully!");
            }
            else
            {
                MessageBox.Show("Invalid Book ID. Please enter a valid number.");
            }
        }

        public void SearchBooksByTitle(string searchTerm)
        {
            using (var context = new BookstoreContextClass())
            {
                var books = context.Books
                    .Where(b => b.Title.Contains(searchTerm))
                    .Include(b => b.Author)
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToList();
                listBoxBooks.DataSource = books;
            }
        }
        private void txtSearchBook_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchBook.Text))
            {
                SearchBooksByTitle(txtSearchBook.Text);
            }
            else
            {
                listBoxBooks.DataSource = GetBooksByAuthors();
            }
            }
    }
}
