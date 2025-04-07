public class Weapons : Item
{

    public string Name { get; set; }
    public int Damage { get; set; }
    public int HitChance { get; set; }
    public int WeightW { get; set; }

    public List<Abilities> abilities = new();

    public void ListAbilities()
    {
        if (abilities.Count == 0)
        {
            Console.Write("No abilities avalible");
        }

        foreach(Abilities ability in abilities)
        {
            string consoleOutput = ability.name;
            Utility.writing(consoleOutput);
        }
    }

    protected Weapons(string name, int damage, int hitchance, int weightw)
    {
        Name = name;
        Damage = damage;
        HitChance = hitchance;
        WeightW = weightw;
    }
}


