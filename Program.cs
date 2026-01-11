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
            authors[0] = "Hiba";
            isbns[0] = "ISBN001";
            isAvailable[0] =true;
            borrowers[0] = "";

            lastBookIndex++;

            titles[1] = "Physics";
            authors[1] = "Saif";
            isbns[1] = "ISBN002";
            isAvailable[1] = true;
            borrowers[1] = "";

            lastBookIndex++;

        }
    }
}
