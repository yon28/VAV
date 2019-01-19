namespace bee
{
    interface IStingPatrol : IWorker
    {
        int AlertLevel { get; }
        int StingerLength { get; set; }
        bool LookForEnemies();
        int SharpenStinger(int length);
    }

    //class StingPatrol : Worker, IStingPatrol
    //{
    //    int StingerLength;
    //    bool enemyAlert;

    //    public StingPatrol( string[] jobslCanDo, int weight,int stingerLength) : base(jobslCanDo, weight)
    //    {
    //        StingerLength = stingerLength;
    //        this.jobslCanDo = jobslCanDo;
    //        this.weight = weight;
    //    }

    //    public int AlertLevel => throw new System.NotImplementedException();

    //    int IStingPatrol.StingerLength { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    //    public string Job => throw new System.NotImplementedException();

    //    public bool SharpenStinger(int Length)
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //    public bool LookForEnemies()
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //    public void Sting(string Enemy)
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    int IStingPatrol.SharpenStinger(int length)
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    void IWorker.DoThisJob(string job, int shifts)
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    void IWorker.WorkOneShift()
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //}
}
