public class Battle
{
    public int turnCounter = 0;
    static public List<string> weaponsList = new List<string>
    {
        nameof(Axe)
    };

    
    static string PName = StarterMenu.PName();
    static string EnemyName = StarterMenu.ENamePicker();
    EnemyPlayer enemyPlayer = new EnemyPlayer(EnemyName,100);
    Player player = new Player(PName, 100);

    Abilities axeThrow = new AxeThrow();



    public void StartBattle()
    {       
        weaponsList.Add("Axe");

        while(player.HitPoints > 0 || enemyPlayer.EnemyHitPoints > 0) 
        {
            Console.Clear();

            int maxHP = 100;
            int hpBarsEnemy = (10*enemyPlayer.EnemyHitPoints)/maxHP;            //calculates remaining health bar(s)
            int hpBarsPlayer = (10*player.HitPoints)/maxHP;                      //COPIED

            string hpBarP = new string('█',hpBarsPlayer);           //creates a class that will print out the hp-bars depending on the users health
            string hpBarE = new string('█',hpBarsEnemy);            //COPIED

            string consoleOutput = PName + "\nHP: " + hpBarP + "\n------------------------"
            + "\nWrite 'Atk' to view your attacks" + "\nWrite 'Inv' to view your inventory" + "\n------------------------\n\n";
            Utility.writing(consoleOutput);

            consoleOutput = EnemyName + "\nHP: " + hpBarE + "\n------------------------"
            + "\nWrite 'EAtk' to attempt to view your enemies attacks" + "\nWrite 'EInv' to attempt to view your enemies inventory" + "\n------------------------";
            Utility.writing(consoleOutput);

            string battleChoice = Console.ReadLine();
            if(turnCounter % 2 == 0)    //checks if the number is even which means it's the enemies turn
            {
                
            }
            else if(battleChoice.ToLower() == "atk")
            {
                System.Console.WriteLine("hejasig");
                Console.ReadLine();
                bool battleAction = BattleAttacks();
                if(battleAction == false)
                {
                    turnCounter++;
                }
            }
            else if(battleChoice.ToLower() == "inv")
            {
                if(BattleInventory() == true)
                {
                    turnCounter++;
                }
            }
            else if(battleChoice.ToLower() == "EAtk")
            {

            }
            else if(battleChoice.ToLower() == "EInv")
            {

            }
            else
            {
            consoleOutput = "Error";
            Utility.writing(consoleOutput);
            continue;
            }


            axeThrow.HostileAction(enemyPlayer);
            Console.ReadLine();
        } 
    }



    public static bool BattleAttacks()
    {
        Console.WriteLine(weaponsList[0]);
        string e = Console.ReadLine();
        if(e == "e")
        {
        return true;
        } else {
           return false; 
        }

    }



    public bool BattleInventory()
    {
        Console.WriteLine("");
        return false;
    }
}
