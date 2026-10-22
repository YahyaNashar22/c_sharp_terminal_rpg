using TerminalRPG.States;
using TerminalRPG.UI;
using TerminalRPG.Utils;

namespace TerminalRPG.Core
{
    internal class Game
    {
        private IScreenState _activeState = new MainMenuScreen();
        private bool _isRunning = true;
        private static readonly object _shutdownLock = new();
        private static bool _hasShutDown;
        public Game()
        {
            Console.CancelKeyPress += (_, e) =>
            {
                ShutDown();
                e.Cancel = false; // Allow the process to terminate afterward.
            };

            AppDomain.CurrentDomain.ProcessExit += (_, _) => ShutDown();
            ScreenUtils.InitialSettings();
        }

        public void Run()
        {
            try
            {
                Welcome();
                while (_isRunning)
                {
                    Console.Clear();
                    _activeState.Render();

                    // Capture input without displaying typed characters
                    ConsoleKeyInfo input = Console.ReadKey(intercept: true);

                    ScreenTransition transition = _activeState.Update(input.Key);

                    switch (transition.Type)
                    {
                        case TransitionType.None:
                            break;
                        case TransitionType.Navigate:
                            if (transition.NextScreen is not null)
                            {
                                _activeState = transition.NextScreen;
                            }
                            break;
                        case TransitionType.Exit:
                            _isRunning = false;
                            break;
                    }
                }
            }
            finally
            {
                ShutDown();
            }
        }

        private static void Welcome()
        {
            ScreenUtils.DrawCenteredBanner("Welcome To Terminal RPG!", '#');
            Thread.Sleep(2000);
            Console.Clear();
        }

        private static void ShutDown()
        {
            lock (_shutdownLock)
            {
                if (_hasShutDown) return;

                _hasShutDown = true;
                ScreenUtils.Cleanup();
                ScreenUtils.DrawCenteredBanner("See you later!", '-');
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
    }
}