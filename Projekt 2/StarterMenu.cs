public class StarterMenu
{
    public static string PName()                    //COPIED
    {
        while (true)
        {
            string consoleOutput = "Enter your name: ";
            Utility.writing(consoleOutput);
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name) || int.TryParse(name, out int t))
            {                                                                       
                consoleOutput = "Error";                                   //where the player gets to pick their name
                Utility.writing(consoleOutput);
                continue;
            }
            else
            {

                return name;
            }
        }
    }



    public static string ENamePicker()                    //COPIED
    {
        List<string> eNames = new List<string> {
    "Venom Reaper Jacob",
    "Doom Fang",
    "Goonie Howler Anton",
    "Brainrot Brute Richard",
    "Cursed Stalker",
    "Inferno Wraith Calle",
    "Iron Specter",
    "Night Titan Ludvig",
    "Rotting Ghoul Konstantin",
    "Obsidian Warlock"};
        int eNameRan = Random.Shared.Next(0, eNames.Count+1);      //randomizes an int that later picks one from the list and returns it
        return eNames[eNameRan];
    }

}
