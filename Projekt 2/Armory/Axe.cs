public class Axe : Weapons
{

    
    public Axe() : base("Axe", 50, 80, 10){
        abilities.Add(new AxeThrow());
        abilities.Add(new AxeChop());
        abilities.Add(new AxeSlash());
        // abilities.Add();
    }

    

    public override void HostileAction(EnemyPlayer target)
    {
        Console.WriteLine("dEALT DAMAGE to " + target.EnemyHitPoints);
    }
}
