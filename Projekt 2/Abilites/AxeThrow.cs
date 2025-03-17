public class AxeThrow : Abilities
{

    public void HostileAction(EnemyPlayer target)
    {
        target.EnemyHitPoints -= 30;
        string consoleOutput = Player.Instance.Name + " threw an axe at " + target.EnemyName + 
        " and he now has " + target.EnemyHitPoints + " HP left";
        Utility.writing(consoleOutput);
    }

}

