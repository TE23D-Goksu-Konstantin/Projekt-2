public class Axe : Weapons
{

    
    public Axe() : base("Axe", 50, 80, 10) { }

    public override void HostileAction(EnemyPlayer target)
    {
        Console.WriteLine("dEALT DAMAGE to " + target.EnemyHitPoints);
    }
}
