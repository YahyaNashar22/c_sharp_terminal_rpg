using TerminalRPG.Core;
using TerminalRPG.Settings;

namespace TerminalRPG
{
    class Program
    {
        private static ThemeSettings _settings = new ThemeSettings(ConsoleColor.DarkBlue, ConsoleColor.Yellow);
        public static void Main(string[] args)
        {
            try
            {

                Game game = new Game(settings: _settings);
            
                game.Run();
            }
            finally
            {
                _settings.Cleanup();
            }
        }
    }
}