public class Battle
{

    
    static string PName = StarterMenu.PName();
    static string EnemyName = StarterMenu.ENamePicker();
    EnemyPlayer enemyPlayer = new EnemyPlayer(EnemyName,100);
    Player player = new Player(PName, 100);

    Abilities axeThrow = new AxeThrow();


    public void StartBattle()
    {
        Console.Clear();
        int maxHP = 100;
        int hpBarsEnemy = (10*enemyPlayer.EnemyHitPoints)/maxHP;            //calculates remaining health bar(s)
        int hpBarsPlayer = (10*player.HitPoints)/maxHP;                      //COPIED

        string hpBarP = new string('█',hpBarsPlayer);           //creates a class that will print out the hpbars depending on the users health
        string hpBarE = new string('█',hpBarsEnemy);            //COPIED

        string consoleOutput = PName + "\nHP: " + hpBarP + "\n------------------------"
        + "\nWrite 'Atk' to view your attacks" + "\nWrite 'Inv' to view your inventory" + "\n------------------------\n\n";
        Utility.writing(consoleOutput);

        consoleOutput = EnemyName + "\nHP: " + hpBarE + "\n------------------------"
        + "\nWrite 'EAtk' to attempt to view your enemies attacks" + "\nWrite 'EInv' to attempt to view your enemies inventory" + "\n------------------------";
        Utility.writing(consoleOutput);

        axeThrow.HostileAction(enemyPlayer);
        Console.ReadLine();
    
    }
    

}
