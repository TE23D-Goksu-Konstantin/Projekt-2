public class Potion : Item
{
    public override void FriendlyAction(Player target)
    {
        target.hitPoints += 10;   
    }

    
}
