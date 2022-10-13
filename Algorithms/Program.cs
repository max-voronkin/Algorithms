using static System.Console;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Title = "Having fun with algorithms";
            RunMainMenu();
        }

        private static void RunMainMenu()
        {
            string[] options =
    {
                "Linear search",
                "Better linear search",
                "Exit"
                };

            var mainMenu = new Menu(options);
            int selectedIndex = mainMenu.Run();    

            switch (selectedIndex)
            {
                case 0:
                    Clear();
                    Search.LinearSearch(Utility.UnsortedArray, 8);
                    ReadKey();
                    RunMainMenu();
                    break;
                case 1:
                    Clear();
                    Search.BetterLinearSearch(Utility.UnsortedArray, 8);
                    ReadKey();
                    RunMainMenu();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
            }
        }

    }
}