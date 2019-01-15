using System;

namespace bee
{

    interface IWorker
    {
        string Job { get; }
        int ShiftsLeft { get; }
        void DoThisJob(string job, int shifts);
        void WorkOneShift();
    }

    class Worker : Bee
    {
        enum Job
        {
            NectarCollector,
            HoneyManufacturing,
            EggCare,
            BabyBeeTutoring,
            HiveMaintenance,
            StingPatrol,
        }


        public Worker(string[] jobslCanDo, int weight) : base(weight)
        {
            this.jobslCanDo = jobslCanDo;
        }

        private string currentJob = "";
        public string CurrentJob
        {
            get => currentJob;
        }

        public override int ShiftsLeft { get => shiftsToWork - shiftsWorked; }
        protected string[] jobslCanDo;
        private int shiftsToWork;
        private int shiftsWorked;

        public bool DoThisJob(string job, int numberOfShifts)
        {
            if (!String.IsNullOrEmpty(currentJob))
                return false;
            for (int i = 0; i < jobslCanDo.Length; i++)
                if (jobslCanDo[i] == job)
                {
                    currentJob = job;
                    this.shiftsToWork = numberOfShifts;
                    shiftsWorked = 0;
                    return true;
                }
            return false;
        }

        public bool WorkOneShift()
        {
            if (String.IsNullOrEmpty(currentJob))
                return false;
            shiftsWorked++;
            if (shiftsWorked > shiftsToWork)
            {
                shiftsWorked = 0;
                shiftsToWork = 0;
                currentJob = "";
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
