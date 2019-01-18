using System;

namespace bee
{
    class Queen : Bee
    {
        private Worker[] workers;
        private int shiftNumber;

        public Queen(Worker[] workers) : base(275)
        {
            this.workers = workers;
        }
        public bool AssignWork(string job, int numberOfShifts)
        {
            for (int i = 0; i < workers.Length; i++)
                if (workers[i].DoThisJob(job, numberOfShifts))
                    return true;
            return false;
        }

        public string WorkTheNextShift()
        {
            double totalConsumption = 0;
            for (int і = 0; і < workers.Length; і++)
                totalConsumption += workers[і].GetHoneyConsumption();
            totalConsumption += GetHoneyConsumption();

            shiftNumber++;
            string report = "Отчет для смены №" + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].WorkOneShift())
                    report += "№" + (i + 1) + " закончил работу \r\n";
                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "№" + (i + 1) + " не работает \r\n";
                else
                if (workers[i].ShiftsLeft > 0)
                    report += "№" + (i + 1) + " выполняет " + workers[i].CurrentJob
                    + " еще " + workers[i].ShiftsLeft + " смен(ы/у) \r\n";
                else
                    report += "№" + (i + 1) + " закончит "
                    + workers[i].CurrentJob + " после этой смены \r\n";
            }
            report += "Общее потребление меда: " + totalConsumption;
            return report;
        }

        public override double GetHoneyConsumption()
        {
            double consumption = 0;
            double largestWorkerConsumption = 0;
            int workersDoingJobs = 0;
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].GetHoneyConsumption() > largestWorkerConsumption)
                    largestWorkerConsumption = workers[i].GetHoneyConsumption();
                if (workers[i].ShiftsLeft > 0)
                    workersDoingJobs++;
            }
            consumption += largestWorkerConsumption;
            if (workersDoingJobs >= 3)
                consumption += 30;
            else
                consumption += 20;
            return consumption;
        }
    }
}



