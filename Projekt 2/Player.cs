public class Player
{   

    public static Player Instance {get; private set;}
    public string Name { get; set; }
    public int HitPoints { get; set; }



    public Player(string name, int hitPoints)
    {
        Name = name;
        HitPoints = hitPoints;
        Instance = this;
    }

}
