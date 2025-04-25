public class Battle
{

    public int turnCounter = 0;
    
    static string PName = StarterMenu.PName();
    static string EnemyName = StarterMenu.ENamePicker();
    EnemyPlayer enemyPlayer = new EnemyPlayer(EnemyName, 100);
    Player player = new Player(PName, 100);

    Abilities axeThrow = new AxeThrow();



    public void StartBattle()
    {    

        while(player.hitPoints > 0 && enemyPlayer.EnemyHitPoints > 0) 
        {

            Console.Clear();

            int maxHP = 100;
            int hpBarsEnemy = (10*enemyPlayer.EnemyHitPoints)/maxHP;            //calculates remaining health bar(s)
            int hpBarsPlayer = (10*player.hitPoints)/maxHP;                      //COPIED
            int lostHpBarsEnemy = 10 - hpBarsEnemy;
            int lostHpBarsPlayer = 10 - hpBarsPlayer;

            string hpBarP = new string('█',hpBarsPlayer) + new string('░', lostHpBarsPlayer);           //creates a class that will print out the hp-bars depending on the users health
            string hpBarE = new string('█',hpBarsEnemy) + new string('░', lostHpBarsEnemy);            //COPIED

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
                if(battleAction == true)
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
                
                if(turnCounter % 2 == 0)    //checks if the number is even which means it's the enemies turn  //COPIED
                {
                    
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

            Console.ReadLine();
        } 
    }



    public bool BattleWeaponPick()
    {

        BattleAbilityUse();
        return true;
    }

    public void BattleAbilityUse()
    {
        Axe axe = new Axe();
        string consoleOutput = "Choose your attack:";    
        Utility.writing(consoleOutput);

        for(int i = 0; i < axe.abilities.Count; i++)
        {
            consoleOutput = $"{i+1}:  {axe.abilities[i].name}";        //Prints out all abilities bound to axe
            Utility.writing(consoleOutput);
        }
        
        
        string battleChoice = Console.ReadLine();
        if(int.TryParse(battleChoice, out int attackChoice))
            {
                int realIndex = attackChoice - 1;
                if(realIndex >= 0 && realIndex < axe.abilities.Count)
                {

                    Abilities chosenAbility = axe.abilities[realIndex];     //Makes it so the user input is accurate to the ability chosen
                    chosenAbility.HostileAction(enemyPlayer);
                if(enemyPlayer.EnemyHitPoints <= 0) 
                {
                    enemyPlayer.EnemyHitPoints = 0;

                    bool statusCheck = HeartRateMonitor.StatusCheck(enemyPlayer.EnemyName, enemyPlayer.EnemyHitPoints); //Checks if someone has died

                    if (statusCheck)
                    {
                        EnemyName = StarterMenu.ENamePicker();
                        return;
                    }

                }
                }
                else
                {
                    consoleOutput = "Error";
                    Utility.writing(consoleOutput);
                }
            }            
            else
            {
                consoleOutput = "Error";
                Utility.writing(consoleOutput);
            }

    }

    public bool BattleInventory()
    {
        return false;
    }
}
