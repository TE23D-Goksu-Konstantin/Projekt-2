public class Battle
{
            int maxHP = 100;
            int hpBarsP = (10*hpP)/maxHP;            //KOLLA IGENOM
            int hpBarsE = (10*hpE)/maxHP; 

            string hpBarP = new string('█',hpBarsP);           //creates a class that will print out the hpbars depending on the users health
            string hpBarE = new string('█',hpBarsE);           


            consoleOutput = $"{pName}'s HP: " + $"{hpBarP}" + "\n----------------" + "\nWrite 'Atk' to view your attacks"
            + "\nWrite 'Inv' to view your inventory" + "\n----------------";
            Utility.writing(consoleOutput);

            consoleOutput = $"\n\n\n{eName}'s HP: " + $"{hpBarE}" + "\n----------------";            //player and enemies hp + instructions for attacks + viewing inv
            Utility.writing(consoleOutput);




}
