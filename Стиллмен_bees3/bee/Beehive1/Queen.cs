using System;

namespace bee
{
    class Queen 
    {
        //private Worker[] workers;
        //private int shiftNumber;

        //public Queen(Worker[] workers) 
        //{
        //    this.workers = workers;
        //}
        //public bool AssignWork(string job, int numberOfShifts)
        //{
        //    for (int i = 0; i < workers.Length; i++)
        //        if (workers[i].DoThisJob(job, numberOfShifts))
        //            return true;
        //    return false;
        //}

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



