class Program
{
    public static void Main(string[] args)
    {
        Player p1 = new("Asylios", 100, 15);
        Player p2 = new("Montecrisios", 100, 23);

        while (p1.CurrentHp > 0 && p2.CurrentHp > 0)
        {
            Attack.MakeAttack(p1, p2);
            Thread.Sleep(100);
        }
    }
}