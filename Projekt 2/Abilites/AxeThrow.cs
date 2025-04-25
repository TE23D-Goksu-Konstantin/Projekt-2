public class AxeThrow : Abilities
{
    int ATK = 30;
    int HIT = 70;

    public AxeThrow()
    {
        name = $"Axe Throw: ATK {ATK}, HIT {HIT}%";
    }

    public override void HostileAction(EnemyPlayer target)
    {        
        double i = Random.Shared.Next(0,11);

        if(i <= 7)
        {
        target.EnemyHitPoints -= ATK;
                if(EnemyPlayer.Instance.EnemyHitPoints < 0)
        {
            EnemyPlayer.Instance.EnemyHitPoints = 0;
        }
        string consoleOutput = Player.Instance.Name + " threw an axe at " + target.EnemyName + 
        " and he now has " + target.EnemyHitPoints + " HP left";
        Utility.writing(consoleOutput);
        }
        else
        {
        string consoleOutput = Player.Instance.Name + " attempted to throw an axe towards " + target.EnemyName + 
        " but it missed";
        Utility.writing(consoleOutput);
        }
    }
}

