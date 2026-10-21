using TerminalRPG.States;
using TerminalRPG.UI;
using TerminalRPG.Utils;

namespace TerminalRPG.Core
{
    internal class Game
    {
        IScreenState activeScreen = new MainMenuScreen();
        public Game()
        {
            ScreenUtils.InitialSettings();
        }

        public void Run()
        {
            activeScreen.Render();
        }
    }
}