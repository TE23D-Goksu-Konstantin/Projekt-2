public class AxeSlash : Abilities
{
    int ATK = 20;
    int HIT = 90;
    public AxeSlash()
    {
        name = $"Axe Slash: ATK {ATK}, HIT {HIT}%";
    }

    public override void HostileAction(EnemyPlayer target)
    {        
        double i = Random.Shared.Next(0,10);

        if(i <= 9)
        {
        target.EnemyHitPoints -= ATK;
        if(EnemyPlayer.Instance.EnemyHitPoints < 0)
        {
            EnemyPlayer.Instance.EnemyHitPoints = 0;
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


