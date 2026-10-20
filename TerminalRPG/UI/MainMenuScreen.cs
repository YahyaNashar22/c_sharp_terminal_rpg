using TerminalRPG.Utils;

namespace TerminalRPG.UI
{
    internal class MainMenuScreen : IScreen
    {
        public void Draw()
        {
            Welcome();

        }

        private void Welcome()
        {
            ScreenUtils.DrawCenteredBanner("Welcome To Terminal RPG!", '#');
        }
    }
}