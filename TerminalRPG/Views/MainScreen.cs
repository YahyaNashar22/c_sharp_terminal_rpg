class MainScreen
{
    private string[] _options = { "Play", "About", "Exit" };
    public void DisplayOptions()
    {
        for (int i = 0; i < _options.Length; i++)
        {
            Console.WriteLine($"{i+1}- {_options[i]}");
        }
    }
    public void SelectOption()
    {
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int selectedOption))
        {
            switch (selectedOption)
            {
                case 1:
                Console.WriteLine($"Screen {selectedOption} selected");
                break;
                case 2:
                Console.WriteLine($"Screen {selectedOption} selected");
                break;
                case 3:
                Logger.Log("Till we meet again adventurer...", ConsoleColor.DarkMagenta);
                Environment.Exit(0);
                break;
                default:
                Console.WriteLine("Please enter a valid option");
                break;
            }
        }
        else
        {
            Logger.Log("Please enter a valid number!");
            return;
        }
    }
}