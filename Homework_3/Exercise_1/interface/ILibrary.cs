using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public interface ILibrary
    {
        void AddBook(Book book);
        void BorrowBook(string title);
        void ReturnBook(string title);
    }
}
