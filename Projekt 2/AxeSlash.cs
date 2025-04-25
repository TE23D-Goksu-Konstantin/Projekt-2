public class AxeSlash : Abilities
{
    int atk = 20;
    int hit = 90;
    public AxeSlash()
    {
        name = $"Axe Slash: ATK {atk}, HIT {hit}%";  //Prints out the text, used in Battle when listing all avalible abilities
    }

    public override void HostileAction(EnemyPlayer target)
    {        
        double i = Random.Shared.Next(0,11);

        if(i <= 9)
        {
        target.EnemyHitPoints -= atk;
        if(EnemyPlayer.Instance.EnemyHitPoints < 0)
        {
            EnemyPlayer.Instance.EnemyHitPoints = 0; //Makes it so the enemies health can't be negative
        }
        string consoleOutput = Player.Instance.Name + " slashed " + target.EnemyName + 
        " and he now has " + target.EnemyHitPoints + " HP left";
        Utility.writing(consoleOutput);
        }
        else
        {
        string consoleOutput = Player.Instance.Name + " attempted to slash " + target.EnemyName + 
        " but it missed";
        Utility.writing(consoleOutput);
        }
    }
}


