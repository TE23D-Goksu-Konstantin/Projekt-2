public class HeartRateMonitor
{

    public static bool StatusCheck(string eName, int eHealth)
    {
        if(eHealth <= 0)
        {
            string consoleOutput = eName + " has been defeated!";
            Console.WriteLine(consoleOutput);
            return true;
        }
        else
        {
            return false;
        }

    }

}
