public class Weapons : Item
{

    public string Name { get; set; }
    public int Damage { get; set; }
    public int HitChance { get; set; }
    public int WeightW { get; set; }


    protected Weapons(string name, int damage, int hitchance, int weightw)
    {
        Name = name;
        Damage = damage;
        HitChance = hitchance;
        WeightW = weightw;
    }
}


