public class AxeThrow : Abilities
{

    public void HostileAction(EnemyPlayer target, string name, string ename)
    {
        target.EnemyHitPoints -= 30;
        Console.WriteLine(name + " threw an axe at " + ename + " and he now has" + target.EnemyHitPoints + " HP left");
    }

}

