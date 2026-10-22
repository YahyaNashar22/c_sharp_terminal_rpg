using TerminalRPG.States;

namespace TerminalRPG.UI
{
    internal class OptionsScreen : IScreenState
    {
        public void Render()
        {
            Console.Clear();
            Console.WriteLine("Options Screen");
        }

        public ScreenTransition Update(ConsoleKey key)
        {
            return new ScreenTransition(TransitionType.None);
        }
    }
}