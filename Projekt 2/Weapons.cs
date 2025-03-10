public class Weapons : Item
{
    
    public string Name {get; set;}
    public int Damage {get; set;}
    public int HitChance {get; set;}
    public int WeightW {get; set;}
    
    public void Weapon(string name, int damage, int hitchance, int weightw)
    {
        name = Name;
        damage = Damage;
        hitchance = HitChance;
        weightw = WeightW;
    }
    
    
    
    
    public override void Action(Player target)
    {
        target.Hp -= 10;   
    }
}
