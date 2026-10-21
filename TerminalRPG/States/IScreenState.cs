namespace TerminalRPG.States
{
    internal interface IScreenState
    {
        // Handle the keyboard inputs
        void Update(ConsoleKey key, ref IScreenState nextState);
        // Render the screen visuals
        void Render();
    }
}