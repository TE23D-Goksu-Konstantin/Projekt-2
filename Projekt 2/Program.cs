// List<Item> inventory = new();

// inventory.Add(new Potion());
string name = StarterMenu.nameP();
string eName = StarterMenu.eNamePicker();

EnemyPlayer enemyPlayer = new EnemyPlayer(eName,100);
Abilities axeThrow = new AxeThrow();
axeThrow.HostileAction(enemyPlayer);
Console.ReadLine();