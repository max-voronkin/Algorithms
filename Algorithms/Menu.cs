using static System.Console;

namespace Algorithms
{
    internal class Menu
    {
        private readonly string[] options;
        private int selectedIndex;

        public Menu(string[] options)
        {
            this.options = options;
            selectedIndex = 0;
        }

        private void DisplayOptions()
        {
            for (int i = 0; i < options.Length; i++)
            {
                string selector;
                if (i == selectedIndex)
                {
                    selector = "->";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    selector = "  ";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }
                WriteLine($"{selector} {options[i]}");
            }
            ResetColor();
        }

        public int Run()
        {
            ConsoleKey keyPressed;

            do
            {
                Clear();
                DisplayOptions();

                ConsoleKeyInfo keyInfo = ReadKey();
                keyPressed = keyInfo.Key;

                switch (keyPressed)
                {
                    case ConsoleKey.UpArrow:
                        selectedIndex--;
                        if (selectedIndex < 0)
                        {
                            selectedIndex = options.Length - 1;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        selectedIndex++;
                        if (selectedIndex > options.Length - 1)
                        {
                            selectedIndex = 0;
                        }
                        break;
                    default:
                        break;
                }
            } while (keyPressed != ConsoleKey.Enter);

            return selectedIndex;
        }
    }
}
