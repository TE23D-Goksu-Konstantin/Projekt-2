public class EnemyPlayer
{
    public static EnemyPlayer Instance {get; private set;}
    public string EnemyName { get; set; }
    public int EnemyHitPoints { get; set; }



    public EnemyPlayer(string enemyName, int enemyHitPoints)
    {
        EnemyName = enemyName;
        EnemyHitPoints = enemyHitPoints;
        Instance = this;
    }

}
