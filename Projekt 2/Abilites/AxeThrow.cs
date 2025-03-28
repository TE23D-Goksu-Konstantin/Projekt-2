public class AxeThrow : Abilities
{
    public AxeThrow()
    {
        name = "Axe Throw";
    }

    public override void HostileAction(EnemyPlayer target)
    {        
        double i = Random.Shared.Next(0,10);

        if(i >= 8)
        {
        target.EnemyHitPoints -= 30;
        string consoleOutput = Player.Instance.Name + " threw an axe at " + target.EnemyName + 
        " and he now has " + target.EnemyHitPoints + " HP left";
        Utility.writing(consoleOutput);
        }
        else
        {
        string consoleOutput = Player.Instance.Name + " attempted to chop " + target.EnemyName + 
        " but it failed";
        Utility.writing(consoleOutput);
        }
    }
}

