

public class Potion : Item
{
    public override void Action(Player target)
    {
        target.Hp += 10;   
    }
}
