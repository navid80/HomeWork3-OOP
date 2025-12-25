using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class Library : ILibrary
    {
        private List<Book> _books;

        public Library()
        {
            _books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            if (book == null)
                throw new ArgumentNullException(nameof(book));

            _books.Add(book);
        }

        public void BorrowBook(string title)
        {
            Book book = FindBook(title) ??
                throw new InvalidOperationException("The Book Was Not Found!");

            book.Borrow();
        }

        public void ReturnBook(string title)
        {
            Book book = FindBook(title) ??
                throw new InvalidOperationException("The Book Was Not Found!");

            book.Return();
        }

        private Book FindBook(string title)
        {
            return _books.FirstOrDefault(b => b.Title == title);
        }
    }
}
