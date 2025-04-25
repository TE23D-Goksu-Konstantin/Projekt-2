Battle battle = new Battle();
battle.StartBattle(); //Begins the battle
Console.Clear();

string consoleOutput = "The Battle has ended, you've won";
Utility.writing(consoleOutput);

Thread.Sleep(1000);
Environment.Exit(0);