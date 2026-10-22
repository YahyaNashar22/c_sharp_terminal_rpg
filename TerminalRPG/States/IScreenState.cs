namespace TerminalRPG.States
{
    internal interface IScreenState
    {
        // Handle the keyboard inputs
        ScreenTransition Update(ConsoleKey key);
        // Render the screen visuals
        void Render();
    }
}