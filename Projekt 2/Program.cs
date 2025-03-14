// List<Item> inventory = new();

// inventory.Add(new Potion());
string name = StarterMenu.nameP();


Player player = new Player(name,100);
Abilities axeThrow = new AxeThrow();
axeThrow.Action(player);
Console.ReadLine();