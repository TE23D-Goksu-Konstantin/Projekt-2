public class AxeChop : Abilities
{

        public AxeChop()
    {
        name = "Axe Chop";
    }

    public override void HostileAction(EnemyPlayer target)
    {
        int i = Random.Shared.Next(0,10);

        if(i <= 3)
        {
        target.EnemyHitPoints -= 70;
        string consoleOutput = Player.Instance.Name + " chopped " + target.EnemyName + 
        " and he now has " + target.EnemyHitPoints + " HP left";
        Utility.writing(consoleOutput);
        }else
        {
        string consoleOutput = Player.Instance.Name + " attempted to chop " + target.EnemyName + 
        " but it failed";
        Utility.writing(consoleOutput);
        }
    }
}
