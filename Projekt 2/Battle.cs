public class Battle
{

    
    static string PName = StarterMenu.PName();
    static string EnemyName = StarterMenu.ENamePicker();
    EnemyPlayer enemyPlayer = new EnemyPlayer(EnemyName,100);
    Player player = new Player(PName, 100);

    Abilities axeThrow = new AxeThrow();


    public void StartBattle()
    {

        axeThrow.HostileAction(enemyPlayer);
        Console.ReadLine();
    
    }
    

}
