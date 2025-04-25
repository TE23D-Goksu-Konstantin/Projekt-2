public class Player
{   

    public static Player Instance {get; private set;}
    public string Name { get; set; }
    public int hitPoints { get; set; }



    public Player(string name, int hitPoints)
    {
        Name = name;
        this.hitPoints = hitPoints;
        Instance = this;
    }

}
