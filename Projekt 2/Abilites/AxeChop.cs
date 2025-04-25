public class AxeChop : Abilities
{

    int atk = 70;
    int hit = 30;
        public AxeChop()
    {
        name = $"Axe Chop:  ATK {atk}, HIT {hit}%"; //Prints out the text, used in Battle when listing all avalible abilities
    }

    public override void HostileAction(EnemyPlayer target)
    {
        int i = Random.Shared.Next(0,11);

        if(i <= 3)
        {
        target.EnemyHitPoints -= atk;
        if(EnemyPlayer.Instance.EnemyHitPoints < 0)
        {
            EnemyPlayer.Instance.EnemyHitPoints = 0; //Makes it so the enemies health can't be negative
        }
            string consoleOutput = Player.Instance.Name + " chopped " + target.EnemyName + 
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
