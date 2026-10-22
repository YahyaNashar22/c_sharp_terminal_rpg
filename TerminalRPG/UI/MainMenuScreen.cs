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

        public ScreenTransition Update(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    _selectedOption = (_selectedOption == 0) ? 0 : _selectedOption - 1;
                    break;
                case ConsoleKey.DownArrow:
                    _selectedOption = (_selectedOption == _options.Length - 1) ? _options.Length - 1 : _selectedOption + 1;
                    break;
                case ConsoleKey.Enter:
                    return HandleSelection();
                default:
                    return new ScreenTransition(TransitionType.None);
            }

            return new ScreenTransition(TransitionType.None);
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

        private ScreenTransition HandleSelection()
        {
            return _selectedOption switch
            {
                0 => new ScreenTransition(TransitionType.Navigate, new CharacterCreationScreen()),
                1 => new ScreenTransition(TransitionType.Navigate, new OptionsScreen()),
                2 => new ScreenTransition(TransitionType.Exit),
                _ => new ScreenTransition(TransitionType.None)
            };
        }
    }
}