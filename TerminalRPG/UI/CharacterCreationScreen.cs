using TerminalRPG.States;

namespace TerminalRPG.UI
{
    internal class CharacterCreationScreen : IScreenState
    {
        public void Render()
        {
            Console.Clear();
            Console.WriteLine("Create Your Character");
        }

        public ScreenTransition Update(ConsoleKey key)
        {
            return new ScreenTransition(TransitionType.None);
        }
    }
}