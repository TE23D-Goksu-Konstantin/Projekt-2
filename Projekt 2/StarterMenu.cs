public static class StarterMenu
{
    public static string nameP()
    {
        while (true)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name) || int.TryParse(name, out int t))
            {                                                                       //COPIED
                string consoleOutput = "Error";                                   //where the player gets to pick their name
                Utility.writing(consoleOutput);
                continue;
            }
            else
            {

                return name;
            }
        }
    }


}
