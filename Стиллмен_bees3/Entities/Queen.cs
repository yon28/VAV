using System;
using System.Drawing;

namespace bee
{
    [Serializable]
    public class Queen 
    {
        private World world;
        private Hive hive;
        private const int InitialBees = 6;
        private const double MinimumHoneyForCreatingBees = 4.0;
        [NonSerialized] public BeeMessage MessageSender;

        public Queen(World world, Hive hive, BeeMessage MessageSender)
        {
            this.world = world;
            this.hive = hive;
            this.MessageSender = MessageSender;
            Random random = new Random();
            for (int i = 0; i < InitialBees; i++)
            {
                AddBee(random);
            }
            //вызови защитника улья
            FindBee(BeeState.LookForEnemiesAndSting);
            //вызови няню
            FindBee(BeeState.EggCare_BabyBeeTutoring_HiveMaintenance);
        }

        public void AddBee(Random random)
        {
            hive.beeCount++;
            int r1 = random.Next(30);
            int r2 = random.Next(30);
            Point startPoint = new Point(hive.GetLocation("Nursery").X + r1, hive.GetLocation("Nursery").Y + r2);
            Bee newBee = new Bee(hive.beeCount, startPoint, world, hive);
            newBee.MessageSender += this.MessageSender;
            world.Bees.Add(newBee);
        }

        public void FindBee(BeeState beeState)
        {
            for (int i = 0; i < world.Bees.Count; i++)
            {
                if (world.Bees[i].CurrentState != BeeState.LookForEnemiesAndSting
                    && world.Bees[i].CurrentState != BeeState.Sting
                    && world.Bees[i].CurrentState != BeeState.EggCare_BabyBeeTutoring_HiveMaintenance  )
                {
                    world.Bees[i].CurrentState = beeState;
                    break;
                }
            }
        }

        public void Go(Random random)
        {
            if (world.Bees.Count < Hive.MaximumBees && hive.Honey > MinimumHoneyForCreatingBees && random.Next(10) == 1)
            {
                AddBee(random);
            }
        }

        //public  double GetHoneyConsumption()
        //{
        //    double consumption = 0;
        //    double largestWorkerConsumption = 0;
        //    int workersDoingJobs = 0;
        //    for (int i = 0; i < workers.Length; i++)
        //    {
        //        if (workers[i].GetHoneyConsumption() > largestWorkerConsumption)
        //            largestWorkerConsumption = workers[i].GetHoneyConsumption();
        //        if (workers[i].ShiftsLeft > 0)
        //            workersDoingJobs++;
        //    }
        //    consumption += largestWorkerConsumption;
        //    if (workersDoingJobs >= 3)
        //        consumption += 30;
        //    else
        //        consumption += 20;
        //    return consumption;
        //}
    }
    enum Job
    {
        NectarCollector,
        MakingHoney_,
        EggCare,
        BabyBeeTutoring,
        HiveMaintenance,
        StingPatrol,
    }

    class Worker //270
    {
    }

    interface IWorker
    {
        string Job { get; }
        int ShiftsLeft { get; }
        void DoThisJob(string job, int shifts);
        void WorkOneShift();
    }

    interface INectarCollector
    {
        void FindFlowers();
        void GatherNectar();
        void ReturnToHive();
    }

    interface IStingPatrol : IWorker
    {
        int AlertLevel { get; }
        int StingerLength { get; set; }
        bool LookForEnemies();
        int SharpenStinger(int length);
    }
}



