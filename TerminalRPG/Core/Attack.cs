static class Attack
{
    public static void MakeAttack(Player attacker, Player defender)
    {
        Logger.Log($"{attacker.Name} attacking {defender.Name}", ConsoleColor.Yellow);
        defender.ReduceHp(attacker.AttackDamage);
        Logger.Log($"{attacker.Name}-{attacker.CurrentHp-15}\t{defender.Name}-{defender.CurrentHp}");
    }
}