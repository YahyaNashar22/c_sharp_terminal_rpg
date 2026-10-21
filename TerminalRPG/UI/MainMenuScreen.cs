using TerminalRPG.States;

namespace TerminalRPG.UI
{
    internal class MainMenuScreen : IScreenState
    {
        private int _selectedOption = 0;
        private readonly string[] _options = ["Start Game", "Options", "Exit"];
        public void Render()
        {
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
            int startX = (Console.WindowWidth - text.Length) / 2;
            int startY = Console.WindowHeight / 2;
            Console.SetCursorPosition(startX, startY);
            // Ensure no negative numbers
            startX = Math.Max(0, startX);
            startY = Math.Max(0, startY);

            Console.WriteLine(text);
            for (int i = 0; i < _options.Length; i++)
            {
                if (i == _selectedOption)
                {
                    text = $"> {_options[i]} <";
                    startX = (Console.WindowWidth - text.Length) / 2;
                    Console.SetCursorPosition(startX, startY + i + 1);
                    Console.WriteLine(text);
                }
                else
                {
                    text = _options[i];
                    startX = (Console.WindowWidth - text.Length) / 2;
                    Console.SetCursorPosition(startX, startY + i + 1);
                    Console.WriteLine(text);
                }
            }
        }
    }
}