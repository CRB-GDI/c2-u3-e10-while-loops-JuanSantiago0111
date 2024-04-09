namespace exerise_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********");
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load  Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            Console.WriteLine("***********");
            string response = Console.ReadLine();
            if (response == "1")
            {
                Console.WriteLine("Create new game");
            }
            else if (response == "2")
            {
                Console.WriteLine("Loading game");
            }
            else if (response == "3")
            {
                Console.WriteLine("setting option");
            }
            else if (response == "4")
            {
                Console.WriteLine("Back to Main menu");
            }
            while (response != "4")
            {
                Console.WriteLine("***********");
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - New Game");
                Console.WriteLine("2 - Load  Game");
                Console.WriteLine("3 - Options");
                Console.WriteLine("4 - Quit");
                Console.WriteLine("***********");
                response = Console.ReadLine();
                if (response == "1")
                {
                    Console.WriteLine("Create new game");
                }
                else if (response == "2")
                {
                    Console.WriteLine("Loading game");
                }
                else if (response == "3")
                {
                    Console.WriteLine("setting option");
                }
                else if (response == "4")
                {
                    Console.WriteLine("Back to Main menu");
                }
            }
        }
    }
}