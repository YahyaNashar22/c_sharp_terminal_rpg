using TerminalRPG.States;
using TerminalRPG.UI;
using TerminalRPG.Utils;

namespace TerminalRPG.Core
{
    internal class Game
    {
        private IScreenState _activeState = new MainMenuScreen();
        public Game()
        {
            ScreenUtils.InitialSettings();
        }

        public void Run()
        {
            Welcome();
            while (true)
            {
                Console.Clear();
                _activeState.Render();

                // Capture input without displaying typed characters
                ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

                // Pass the current state to the update method of the _activeScreen
                IScreenState nextState = _activeState;
                _activeState.Update(keyInfo.Key, ref nextState);
                _activeState = nextState;
            }
        }

        private static void Welcome()
        {
            ScreenUtils.DrawCenteredBanner("Welcome To Terminal RPG!", '#');
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}