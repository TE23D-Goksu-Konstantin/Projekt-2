public class Axe : Weapons
{

    
    public Axe() : base("AXE", 50, 80, 10) { }

    public override void UseAbility()
    {
        Console.WriteLine("dEALT DAMAGE");
    }
}
