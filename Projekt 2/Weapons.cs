public abstract class Weapons : Item
{
    private string v1;
    private int v2;
    private int v3;
    private int v4;

    protected Weapons(string v1, int v2, int v3, int v4)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
        this.v4 = v4;
    }

    public string Name {get; set;}
    public int Damage {get; set;}
    public int HitChance {get; set;}
    public int WeightW {get; set;}
    
    public void Weapon(string name, int damage, int hitchance, int weightw)
    {
        Name = name;
        Damage = damage;
        HitChance = hitchance;
        WeightW = weightw;
    }
    
    public abstract void UseAbility();
}


