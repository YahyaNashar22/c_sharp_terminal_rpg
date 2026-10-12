class Game
{
    private bool _running = true;

    public int ScreenNumber { get; set; }
    MainScreen mainScreen = new();
    public void Run()
    {
        while (_running)
        {
            mainScreen.DisplayOptions();
            mainScreen.SelectOption();
        }
    }
}