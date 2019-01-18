
namespace bee
{

    interface INectarCollector
    {
        void FindFlowers();
        void GatherNectar();
        void ReturnToHive();
    }

    class NectarStinger : Worker, INectarCollector, IStingPatrol
    {
        public NectarStinger(string[] jobslCanDo, int weight) : base(jobslCanDo, weight)
        {
            this.jobslCanDo = jobslCanDo;
        }

        private int alertLevel;
        public int AlertLevel
        {
            get { return alertLevel; }
        }

        public int StingerLength
        {
            get
            {
                return StingerLength;
            }
            set
            {
                StingerLength = value;
            }
        }

        public string Job => throw new System.NotImplementedException();

        public bool LookForEnemies() { return true; }//
        public int SharpenStinger(int length) { return 0; }//
        public void FindFlowers() { }
        public void GatherNectar() { }
        public void ReturnToHive() { }

        void IWorker.DoThisJob(string job, int shifts)
        {
            throw new System.NotImplementedException();
        }

        void IWorker.WorkOneShift()
        {
            throw new System.NotImplementedException();
        }
    }
}