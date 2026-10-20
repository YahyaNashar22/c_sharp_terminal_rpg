using TerminalRPG.UI;
using TerminalRPG.Utils;

namespace TerminalRPG.Core
{
    internal class Game
    {
        IScreen activeScreen = new MainMenuScreen();
        public Game()
        {
            ScreenUtils.InitialSettings();
        }

        public void Run()
        {
            activeScreen.Draw();
        }
    }
}