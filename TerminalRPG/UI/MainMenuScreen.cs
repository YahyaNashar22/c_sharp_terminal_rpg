using TerminalRPG.States;
using TerminalRPG.Utils;

namespace TerminalRPG.UI
{
    internal class MainMenuScreen : IScreenState
    {
        private int _selectedOption = 0;
        private readonly string[] _options = ["Start Game", "Options", "Exit"];
        public void Render()
        {
            ScreenUtils.ColorScreen(ConsoleColor.Gray, ConsoleColor.Green);
            ShowOptions();
        }

        public void Update(ConsoleKey key, ref IScreenState nextState)
        {
            if (key == ConsoleKey.UpArrow)
            {
                _selectedOption = (_selectedOption == 0) ? 0 : _selectedOption - 1;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                _selectedOption = (_selectedOption == _options.Length - 1) ? _options.Length - 1 : _selectedOption + 1;
            }
        }

        private void ShowOptions()
        {
            string text = "=== Terminal RPG ===";
            ScreenUtils.CenterText(text, 0);

            for (int i = 0; i < _options.Length; i++)
            {
                if (i == _selectedOption)
                {
                    text = $"> {_options[i]} <";
                    ScreenUtils.CenterText(text, i + 1);
                }
                else
                {
                    text = _options[i];
                    ScreenUtils.CenterText(text, i + 1);
                }
            }
        }
    }
}