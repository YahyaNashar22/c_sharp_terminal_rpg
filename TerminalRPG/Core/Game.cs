using TerminalRPG.Settings;

namespace TerminalRPG.Core
{
    internal class Game
    {
        public Game(in ThemeSettings settings)
        {
            Console.BackgroundColor = settings.BackgroundColor;
            Console.ForegroundColor = settings.ForegroundColor;
            Console.Clear();

            Console.WriteLine("Game Initialized");
        }

        public void Run()
        {
            Console.WriteLine("Game is Running . . .");

            Console.WriteLine("Enter Your Name:");

            string? name = Console.ReadLine();

            Console.WriteLine($"Welcome! {name} Ready to explore this universe?");
        }
    }
}