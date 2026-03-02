using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Book
        {
            public int BookID { get; set; }
            public string Title { get; set; }
            public int AuthorID { get; set; }
            public virtual Author Author { get; set; }

            public override string ToString()
            {
                return $"{Title} by {Author?.Name}";
            }
        }

        public class Author
        {
            public int AuthorID { get; set; }
            public string Name { get; set; }
            public virtual ICollection<Book> Books { get; set; }
        }

        public async Task<List<Book>> GetBooksAsync(IProgress<int> progress)
        {
            using (var context = new BookstoreContext())
            {
                var total = await context.Books.CountAsync();
                var result = new List<Book>();
                int current = 0;

                var books = context.Books.Include(b => b.Author).AsAsyncEnumerable();

                await foreach (var book in books)
                {
                    result.Add(book);
                    current++;
                    int percent = (int)((current / (double)total) * 100);
                    progress?.Report(percent);
                    await Task.Delay(50);
                }

                return result;
            }
        }

        private async Task RefreshBookListAsync()
        {
            progressBar.Value = 0;
            progressBar.Visible = true;

            var progress = new Progress<int>(value => progressBar.Value = value);
            var books = await GetBooksAsync(progress);

            listBoxBooks.DataSource = books;

            progressBar.Visible = false;
        }

        private async void btnFetchBooks_Click(object sender, EventArgs e)
        {
            await RefreshBookListAsync();
        }

        private async Task SaveBookAsync(string bookTitle, string authorName)
        {
            using (var context = new BookstoreContext())
            {
                var author = await context.Authors.FirstOrDefaultAsync(a => a.Name == authorName);
                if (author == null)
                {
                    author = new Author { Name = authorName };
                    context.Authors.Add(author);
                }

                var book = new Book { Title = bookTitle, Author = author };
                context.Books.Add(book);

                await context.SaveChangesAsync();
            }
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            var authorName = txtAuthorName.Text;
            var bookTitle = txtBookTitle.Text;

            await SaveBookAsync(bookTitle, authorName);
            MessageBox.Show("Book added successfully!");
            await RefreshBookListAsync();
        }

        private async void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookID.Text, out int bookID))
            {
                MessageBox.Show("Invalid Book ID.");
                return;
            }

            using (var context = new BookstoreContext())
            {
                var book = await context.Books
                    .FirstOrDefaultAsync(b => b.BookID == bookID);

                if (book == null)
                {
                    MessageBox.Show("Book not found.");
                    return;
                }

                var newTitle = txtBookTitle.Text.Trim();
                var newAuthorName = txtAuthorName.Text.Trim();

                book.Title = newTitle;

                var author = await context.Authors
                    .FirstOrDefaultAsync(a => a.Name == newAuthorName);

                if (author == null)
                {
                    author = new Author { Name = newAuthorName };
                    context.Authors.Add(author);
                    await context.SaveChangesAsync();
                }

                book.AuthorID = author.AuthorID;

                await context.SaveChangesAsync();
                MessageBox.Show("Book updated successfully!");
            }

            await RefreshBookListAsync();
        }

        private async void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookID.Text, out int bookID))
            {
                MessageBox.Show("Invalid Book ID.");
                return;
            }

            using (var context = new BookstoreContext())
            {
                var book = await context.Books.FindAsync(bookID);
                if (book != null)
                {
                    context.Books.Remove(book);
                    await context.SaveChangesAsync();
                    MessageBox.Show("Book deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Book not found.");
                }
            }

            await RefreshBookListAsync();
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var searchTerm = txtSearch.Text.ToLower();
            using (var context = new BookstoreContext())
            {
                var books = await context.Books
                    .Include(b => b.Author)
                    .Where(b => b.Title.ToLower().Contains(searchTerm) || b.Author.Name.ToLower().Contains(searchTerm))
                    .ToListAsync();

                listBoxBooks.DataSource = books;
            }
        }

        private void listBoxBooks_MouseDoubleClick(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedItem is Book selectedBook)
            {
                txtBookID.Text = selectedBook.BookID.ToString();
                txtBookTitle.Text = selectedBook.Title;
                txtAuthorName.Text = selectedBook.Author?.Name;
            }
        }
    }
}