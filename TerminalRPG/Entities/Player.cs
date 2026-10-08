class Player
{
    public string Name { get; private set; }
    public int MaxHp { get; private set; }
    public int AttackDamage { get; private set; }
    private int _currentHp;
    public int CurrentHp { get => _currentHp; private set { _currentHp = Math.Clamp(value, 0, MaxHp); } }

    public Player(string n, int h, int a)
    {
        Name = n;
        MaxHp = h;
        CurrentHp = h;
        AttackDamage = a;
        Logger.Log($"Created: Player {Name,-15}\tMaxHp: {MaxHp,3}\tDamage: {AttackDamage,2}", ConsoleColor.Green);
    }

    public void ReduceHp(int amount)
    {
        if (amount <= 0) return;
        CurrentHp -= amount;
        if (CurrentHp == 0)
        {
            CurrentHp = 0;
            Logger.Log($"{Name} defeated!", ConsoleColor.Red);
        }

    }
}