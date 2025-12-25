namespace Exercise_1
{
    public class Program
    {
        public Book GetNewBookDetail()
        {
            string title;
            string author;
            string isbn;

            Console.WriteLine("Enter Book Title : ");
            title = Console.ReadLine();
            Console.WriteLine("Enter Book Author : ");
            author = Console.ReadLine();
            Console.WriteLine("Enter Book ISBN : ");
            isbn = Console.ReadLine();

            return new Book(title, author, isbn);
        }

        public string GetBookTitleFromUser()
        {
            string title;
            Console.WriteLine("Enter The Book Title : ");
            title = Console.ReadLine();
            return title;
        }

        public static void Main()
        {
            bool exit = false;
            string title;

            Program program = new Program();
            Library library = new Library();

            library.AddBook(new Book("Clean Code", "Bob", "123456"));
            library.AddBook(new Book("Python", "Jhon", "56698"));
            library.AddBook(new Book("Rest Api", "Jack", "669874"));
            library.AddBook(new Book("C#", "David", "58741258"));

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("1- Add Book");
                Console.WriteLine("2- Borrow Book");
                Console.WriteLine("3- Return Book");
                Console.WriteLine("0- Exit");
                Console.WriteLine("---------------------");
                Console.Write("Enter an Option : ");
                string input = Console.ReadLine();

                int choice;

                if (!int.TryParse(input, out choice))
                {
                    Console.WriteLine("Invalid input! Please enter a number.");
                    Console.Write("Press any key to return to the menu");
                    Console.ReadKey();
                    continue;
                }

                try
                {
                    switch (choice)
                    {
                        case 0:
                            exit = true;
                            break;
                        case 1:
                            Book newBook = program.GetNewBookDetail();
                            library.AddBook(newBook);
                            Console.WriteLine($"{newBook.Title} Added to the library");
                            Console.Write("Press any key to return to the menu");
                            Console.ReadKey();
                            break;
                        case 2:
                            title = program.GetBookTitleFromUser();
                            library.BorrowBook(title);
                            Console.WriteLine($"{title} borrowed");
                            Console.Write("Press any key to return to the menu");
                            Console.ReadKey();
                            break;
                        case 3:
                            title = program.GetBookTitleFromUser();
                            library.ReturnBook(title);
                            Console.WriteLine($"{title} returned");
                            Console.Write("Press any key to return to the menu");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex.Message);
                    Console.Write("Press any key to return to the menu");
                    Console.ReadKey();
                }

            }
        }
    }
}