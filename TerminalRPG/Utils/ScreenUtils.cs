namespace TerminalRPG.Utils
{
    static internal class ScreenUtils
    {
        public static void DrawCenteredBanner(string text, char pattern)
        {
            // 1. Core text and box calculations
            int textLength = text.Length;
            int padding = 2; // spaces between the text and borders
            int boxWidth = textLength + (padding * 2) + 2; // total width
            int boxHeight = 3; // 1 row for top border, 1 for text, 1 for bottom border

            // 2. Find center position of terminal window
            int startX = (Console.WindowWidth - boxWidth) / 2;
            int startY = (Console.WindowHeight - boxHeight) / 2;

            // Ensure calculations don't go negative on small windows
            startX = Math.Max(0, startX);
            startY = Math.Max(0, startY);

            // 3. Draw top border
            Console.SetCursorPosition(startX, startY);
            Console.WriteLine(new string(pattern, boxWidth));

            // 4. Draw middle row ( border + padding + text )
            Console.SetCursorPosition(startX, startY + 1);
            string leftPadding = new string(' ', padding);
            string rightPadding = new string(' ', padding);
            Console.WriteLine($"#{leftPadding}{text}{rightPadding}#");

            // 5. Draw bottom border
            Console.SetCursorPosition(startX, startY + 2);
            Console.WriteLine(new string(pattern, boxWidth));
        }
    }
}