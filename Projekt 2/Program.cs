// List<Item> inventory = new();

// inventory.Add(new Potion());


string PName = StarterMenu.PName();
string EnemyName = StarterMenu.ENamePicker();
EnemyPlayer enemyPlayer = new EnemyPlayer(EnemyName,100);
Player player = new Player(PName, 100);


Abilities axeThrow = new AxeThrow();


axeThrow.HostileAction(enemyPlayer, PName, EnemyName);
Console.ReadLine();