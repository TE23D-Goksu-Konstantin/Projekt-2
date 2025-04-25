public class AxeThrow : Abilities
{
    int atk = 30;
    int HIT = 70;

    public AxeThrow()
    {
        name = $"Axe Throw: ATK {atk}, HIT {HIT}%";    //Prints out the text, used in Battle when listing all avalible abilities
    }

    public override void HostileAction(EnemyPlayer target)
    {        
        double i = Random.Shared.Next(0,11);

        if(i <= 7)
        {
        target.EnemyHitPoints -= atk;
                if(EnemyPlayer.Instance.EnemyHitPoints < 0)  //Makes it so the enemies health can't be negative
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

