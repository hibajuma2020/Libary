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

           bool exit=false;

            while (true)
            {
                Console.WriteLine("Welcome to libary system");
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

                    case 3:
                        // Option 3: Return Book
                        Console.Write("Enter ISBN: ");
                        string returnIsbn = Console.ReadLine();

                        bool returnFound = false;

                        for (int i = 0; i <= lastBookIndex; i++)
                        {
                            if (isbns[i] == returnIsbn)
                            {
                                returnFound = true;
                                isAvailable[i] = true;
                                borrowers[i] = "";
                                Console.WriteLine("Book returned successfully!");

                                break;
                            }
                        }

                        if (returnFound == false)
                        {
                            Console.WriteLine("Book not found.");
                        }
                        break;

                    case 4:
                        // Option 4: Search Book

                        Console.Write("Enter ISBN or Title: ");
                        string searchInput = Console.ReadLine();

                        bool searchFound = false;

                        for (int i = 0; i <= lastBookIndex; i++)
                        {
                            if (isbns[i] == searchInput || titles[i] == searchInput)
                            {
                                searchFound = true;
                                Console.WriteLine("Title: " + titles[i]);
                                Console.WriteLine("Author: " + authors[i]);
                                Console.WriteLine("ISBN: " + isbns[i]);
                                Console.WriteLine("Available: " + isAvailable[i]);

                                if (isAvailable[i] == false)
                                {
                                    Console.WriteLine("Borrowed by: " + borrowers[i]);
                                }
                                break;
                            }
                        }

                        if (searchFound == false)
                        {
                            Console.WriteLine("Book not found.");
                        }
                
                        break;


                    case 5:
                        //List All Available Books 
                        Console.WriteLine("List All Available Books: ");
                        for(int i = 0;i<=lastBookIndex;i++)
                        {
                            if (isAvailable[i] ==true)
                            {
                                Console.WriteLine("Available book: " + titles[i] + authors[i] + isbns[i] +borrowers[i]);

                            }
                        }

                        break;


                        case 6:
                        //transfer books
;
                        Console.WriteLine("Enter current  borrower:");
                        string currentBorrower = Console.ReadLine();
                        Console.WriteLine("Enter new  borrower:");
                        string newBorrower = Console.ReadLine();

                        bool currentBorrowerFound = false;
                        int currentBorrowerIndex = 0;

                        for (int i = 0; i <= lastBookIndex; i++)
                        {

                            if (currentBorrower == borrowers[i])
                            {
                                currentBorrowerIndex = i;
                                currentBorrowerFound = true;

                                break;
                            }
                        }
                        if (currentBorrowerFound == false) 
                        {
                            Console.WriteLine("current borrower name not found");

                        }
                        else
                        {
                            bool newBorrowerFound = false;
                            int newBorrowerIndex = 0;
                            for (int i = 0; i <= lastBookIndex; i++)
                            {
                                if (newBorrower == borrowers[i])
                                {
                                    newBorrowerIndex = i;
                                    newBorrowerFound = true;

                                    break;
                                }
                            }
                            if (newBorrowerFound == false) 
                            {
                                Console.WriteLine("new borrower name not found");

                            }
                            else
                            {
                                string temp = "";
                                temp = borrowers[currentBorrowerIndex];
                                borrowers[currentBorrowerIndex] = borrowers[newBorrowerIndex];
                                borrowers[newBorrowerIndex] = temp;
                            }
                        }
                        break;
                       

                    case 7:
                                //EXIT

                                exit = true;
                                break;

                            default:
                                Console.WriteLine("Invalid option.");
                                break;
                            }

                if (exit == true)
                {
                    break;
                }

                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
                Console.Clear();
            }



        }


            }

        }
  

