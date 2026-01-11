namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //system storge

            string[] titles = new string[100];
            string[] authors = new string[100];
            string[] isbns = new string[100];
            bool[] isAvailable = new bool[100];
            string[] borrowers = new string[100];

            int lastBookIndex = -1;

            //seed data
            titles[0] = "Math";
            authors[0] = "Amjed";
            isbns[0] = "ISBN001";
            isAvailable[0] = true;
            borrowers[0] = "";

            lastBookIndex++;

            titles[1] = "Physics";
            authors[1] = "Saif";
            isbns[1] = "ISBN002";
            isAvailable[1] = true;
            borrowers[1] = "";

            lastBookIndex++;

            while (true)
            {
                Console.WriteLine("Welcome to libary dystem");
                Console.WriteLine("1. Add New Book");
                Console.WriteLine("2. Borrow Book");
                Console.WriteLine("3. Return Book");
                Console.WriteLine("4. Search Book");
                Console.WriteLine("5. List Available Books");
                Console.WriteLine("6. Transfer Book");
                Console.WriteLine("7. Exit");
                Console.Write("Choose an option: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        //option1: add new book
                        Console.Write("Enter book title: ");
                        titles[lastBookIndex + 1] = Console.ReadLine();

                        Console.Write("Enter author name: ");
                        authors[lastBookIndex + 1] = Console.ReadLine();

                        Console.Write("Enter ISBN: ");
                        isbns[lastBookIndex + 1] = Console.ReadLine();

                        isAvailable[lastBookIndex + 1] = true;
                        borrowers[lastBookIndex + 1] = "";

                        lastBookIndex++;

                        Console.WriteLine("Book added successfully!");
                        break;

                        break;

                        case 2:
                    //option2:  Borrow Book
                    
                        Console.Write("Enter ISBN: ");
                        string borrowIsbn = Console.ReadLine();

                        Console.Write("Enter borrower name: ");
                        string borrowerName = Console.ReadLine();

                        bool borrowFound = false;

                        for (int i = 0; i <= lastBookIndex; i++)
                        {
                            if (isbns[i] == borrowIsbn)
                            {
                                borrowFound = true;

                                if (isAvailable[i] == true)
                                {
                                    isAvailable[i] = false;
                                    borrowers[i] = borrowerName;
                                    Console.WriteLine("Book borrowed successfully!");
                                }
                                else
                                {
                                    Console.WriteLine("Book is already borrowed.");
                                }
                                break;
                            }
                        }
                        if (borrowFound == false)
                        {
                            Console.WriteLine("Book not found.");
                        }
                        break;










                    defualt:
                        break;



                }


            }

        }
    }
}


