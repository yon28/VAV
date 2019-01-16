namespace bee
{
    interface IStingPatrol : IWorker
    {
        int AlertLevel { get; }
        int StingerLength { get; set; }
        bool LookForEnemies();
        int SharpenStinger(int length);
    }

    //class StingPatrol : Worker
    //{
    //    int StingerLength;
    //    bool enemyAlert;
    //    public bool SharpenStinger(int Length)
    //    { }
    //    public bool LookForEnemies()
    //    { }
    //    public void Sting(stringEnemy) { }
    //}
}
