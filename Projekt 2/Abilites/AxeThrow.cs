public class AxeThrow : Abilities
{
    public void AbilityUse()
    {
        throw new NotImplementedException();
    }

    public void Action(Player target)
    {
        target.Hp -= 50;   
    }
}

