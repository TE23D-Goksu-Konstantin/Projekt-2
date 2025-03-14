public class AxeThrow : Abilities
{
    public void Action(Player target)
    {
        target.HitPoints -= 30;
        Console.WriteLine($"Threw axe and he now has " + target.HitPoints + " HP left");
    }
}

