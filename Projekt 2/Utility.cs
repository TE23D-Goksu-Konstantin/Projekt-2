public static class Utility                    //COPIED
{

    public static bool Proceed(bool check)
    {

        while (true)
        {
            Console.Clear();
            string consoleOutput = "Are you ready? (y/n)";        //checks user input, if y continue, if n redo the loop
            Utility.writing(consoleOutput);


            string checkC = Console.ReadLine();      
            if (checkC.ToLower() == "y")
            {
                return true;
            }
            else if (checkC.ToLower() == "n")
            {
                consoleOutput = "Whenever you're ready.";
                Utility.writing(consoleOutput);
                continue;
            }
            else
            {
                consoleOutput = "Error";
                Utility.writing(consoleOutput);
                continue;
            }
        }
    }

    public static void writing(string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            Console.Write(text[i]);              //prints each word in the string singularily
            Thread.Sleep(15);                   
        }
        Console.WriteLine();
    }

}
