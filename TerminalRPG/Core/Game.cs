using TerminalRPG.Settings;
using TerminalRPG.UI;

namespace TerminalRPG.Core
{
    internal class Game
    {
        IScreen mainMenu = new MainMenuScreen();
        public Game(in ThemeSettings settings)
        {
            Console.BackgroundColor = settings.BackgroundColor;
            Console.ForegroundColor = settings.ForegroundColor;
            Console.Clear();

            Console.WriteLine("Game Initialized");
        }

        public void Run()
        {
            mainMenu.Draw();
        }
    }
}