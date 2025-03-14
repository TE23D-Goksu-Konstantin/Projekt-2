public class EnemyPlayer
{
    public string EnemyName { get; set; }
    public int EnemyHitPoints { get; set; }



    public EnemyPlayer(string enemyName, int enemyHitPoints)
    {
        EnemyName = enemyName;
        EnemyHitPoints = enemyHitPoints;
    }

}
