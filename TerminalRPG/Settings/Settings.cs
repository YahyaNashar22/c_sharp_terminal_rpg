namespace TerminalRPG.Settings
{
    public readonly struct ThemeSettings
    {
        public readonly ConsoleColor BackgroundColor, ForegroundColor;
        public ThemeSettings(ConsoleColor bg, ConsoleColor fg)
        {
            BackgroundColor = bg;
            ForegroundColor = fg;
        }

        public void Cleanup()
        {
            Console.ResetColor();
        }
    }

}