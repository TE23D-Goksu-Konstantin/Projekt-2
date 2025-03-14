// List<Item> inventory = new();

// inventory.Add(new Potion());
string name = StarterMenu.nameP();


EnemyPlayer enemyPlayer = new EnemyPlayer("ee",100);
Abilities axeThrow = new AxeThrow();
axeThrow.HostileAction(enemyPlayer);
Console.ReadLine();