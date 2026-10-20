using TerminalRPG.Core;
using TerminalRPG.Utils;

namespace TerminalRPG
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Game game = new Game();
                    game.Run();
                    
                    Console.ReadLine();
                }
                finally
                {
                    ScreenUtils.Cleanup();
                }
            }
        }
    }
}