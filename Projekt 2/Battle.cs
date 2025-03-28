using System.Security.Cryptography.X509Certificates;

public class Battle
{
    public int turnCounter = 0;
    // static public List<string> weaponsList = new List<string>
    // {
    //     nameof(Axe),
    //     // nameof()
    // };

    // static public List<string> weaponsAttacksList = new List<string>
    // {
    //     nameof(AxeThrow),
    //     // nameof()
    // };
    
    static string PName = StarterMenu.PName();
    static string EnemyName = StarterMenu.ENamePicker();
    EnemyPlayer enemyPlayer = new EnemyPlayer(EnemyName,100);
    Player player = new Player(PName, 100);

    Abilities axeThrow = new AxeThrow();



    public void StartBattle()
    {       
        while(player.HitPoints > 0 && enemyPlayer.EnemyHitPoints > 0) 
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

            string battleChoice = Console.ReadLine().Trim().ToLower();
            Console.Clear();
            if(battleChoice.ToLower() == "atk")
            {
                bool battleAction = BattleWeaponPick();
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
            else if(turnCounter % 2 == 0)    //checks if the number is even which means it's the enemies turn  //COPIED
            {
                
            }
            else
            {
            consoleOutput = "Error";
            Utility.writing(consoleOutput);
            continue;
            }



            Console.ReadLine();
        } 
    }



    public bool BattleWeaponPick()
    {

        BattleAbilityUse();
        
        // string battleChoice = Console.ReadLine();
        // int.TryParse(battleChoice, out int weaponsChoice);

        // if(weaponsChoice == 1)
        // {
        //     BattleAbilityUse();
        // }
        // else if(weaponsChoice == 2)
        // {

        // }
        return true;
    }

    public void BattleAbilityUse()
    {
        Axe axe = new Axe();
        axe.ListAbilities();
        Console.WriteLine("Choose your attack");
        string battleChoice = Console.ReadLine();
        int.TryParse(battleChoice, out int attackChoice);



        if(attackChoice == 1)
        {
            axeThrow.HostileAction(enemyPlayer);
        }
        else if(attackChoice == 2)
        {

        }
    }

    public bool BattleInventory()
    {
        Console.WriteLine("");
        return false;
    }
}
