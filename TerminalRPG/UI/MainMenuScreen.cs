using TerminalRPG.States;
using TerminalRPG.Utils;

namespace TerminalRPG.UI
{
    internal class MainMenuScreen : IScreenState
    {
        public void Render()
        {
            Welcome();

        }

        public void Update(ConsoleKey key, ref IScreenState nextState)
        {

        }

        private void Welcome()
        {
            ScreenUtils.DrawCenteredBanner("Welcome To Terminal RPG!", '#');
        }
    }
}