

public class Potion : Item
{
    public override void Action(Player target)
    {
        target.HitPoints += 10;   
    }
}
