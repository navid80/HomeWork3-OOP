using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }
        
        public string Author { get; set; }
        
        public string ISBN { get; set; }

        public bool IsAvailable { get; private set; }

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsAvailable = true;
        }

        public void Borrow()
        {
            if (!IsAvailable)
                throw new InvalidOperationException("This Book Is Not Available!");
            
            IsAvailable = false;
        }
        
        public void Return()
        {
            if (IsAvailable)
                throw new InvalidOperationException("Book Was Not Borrowed.");

            IsAvailable = true;
        }
    }
}
