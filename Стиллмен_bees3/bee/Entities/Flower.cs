using System;
using System.Drawing;
namespace bee
{
    [Serializable]//563
    public class Flower //524
    {
        private const int LifeSpanMin = 15000;
        private const int LifeSpanMax = 30000;
        private const double InitialNectar = 1.5;
        private const double MaxNectar = 5.0;
        private const double NectarAddedPerTurn = 0.01; //количество нектара, добавляемое по мере роста цветка
        private const double NectarGatheredPerTurn = 0.3; //количество нектара, собранного за один цикл

        public Point Location { get; private set; }
        public int Age { get; private set; }
        public bool Alive { get; private set; }
        public double Nectar { get; private set; }
        public double NectarHarvested { get; set; }//cобранный нектар
        private int lifeSpan;// продолжительность жизни цветка

        public Flower(Point location, Random random)
        {
            Location = location;
            Age = 0;
            Alive = true;
            Nectar = InitialNectar;
            NectarHarvested = 0;
            lifeSpan = random.Next(LifeSpanMin, LifeSpanMax + 1);
        }

        public double HarvestNectar()
        {
            if (NectarGatheredPerTurn > Nectar)
            {
                return 0;
            }
            else
            {
                Nectar -= NectarGatheredPerTurn;
                NectarHarvested += NectarGatheredPerTurn;
                return NectarGatheredPerTurn;
            }
        }

        public void Go()
        {
            Age++;
            if (Age > lifeSpan)
            {
                Alive = false;
            }
            else
            {
                Nectar += NectarAddedPerTurn;
                if (Nectar > MaxNectar)
                {
                    Nectar = MaxNectar;
                }
            }
        }
    }
}
