public class AxeThrow : Abilities
{
    public void HostileAction(EnemyPlayer target)
    {
        target.EnemyHitPoints -= 30;
        Console.WriteLine($"Threw axe and he now has " + target.EnemyHitPoints + " HP left");
    }
}

