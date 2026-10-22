namespace TerminalRPG.States
{
    internal enum TransitionType
    {
        None, Navigate, Exit
    }

    internal record ScreenTransition(
        TransitionType Type,
        IScreenState? NextScreen = null
    );
}