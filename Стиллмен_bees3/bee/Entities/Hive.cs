using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace bee
{
    [Serializable]
    public class Hive//533
    {
        private const int InitialBees = 6;
        private const double InitialHoney = 3.2;
        private const double MaximumHoney = 15.0;
        private const double NectarHoneyRatio = .25;
        private const double MinimumHoneyForCreatingBees = 4.0;
        private const int MaximumBees = 8;
        private Dictionary<string, Point> Locations;
        private int beeCount = 0;
        public double Honey { get; set; }
        private World world;
        [NonSerialized] public BeeMessage MessageSender;

        public Hive(World world, BeeMessage MessageSender)
        {
            this.world = world;
            this.MessageSender = MessageSender;
            Honey = InitialHoney;
            InitializeLocations();
            Random random = new Random();
            for (int i = 0; i < InitialBees; i++)
            {
                AddBee(random);
            }
            //вызови защитника улья
            FindBee(BeeState.LookForEnemiesAndSting);
            //вызови няню
            FindBee(BeeState.EggCareAndBabyBeeTutoring);
        }

        private void InitializeLocations()
        {
            Locations = new Dictionary<string, Point>();
            Locations.Add("Entrance", new Point(440, 80));
            Locations.Add("Nursery", new Point(30, 80));
            Locations.Add("HoneyFactory", new Point(130, 48));
            Locations.Add("Exit", new Point(135, 130));
        }

        public Point GetLocation(string location)
        {
            if (Locations.Keys.Contains(location))
                return Locations[location];
            else
                throw new ArgumentException("Unknown location:" + location);
        }

        public bool AddHoney(double nectar)
        {
            double honeyToAdd = nectar * NectarHoneyRatio;
            if (honeyToAdd + Honey > MaximumHoney)
            {
                return false;
            }
            Honey += honeyToAdd;
            return true;
        }

        public bool ConsumeHoney(double amount)
        {
            if (amount > Honey)
            {
                return false;
            }
            else
            {
                Honey -= amount;
                return true;
            }
        }

        private void AddBee(Random random)
        {
            beeCount++;
            int r1 = random.Next(30);
            int r2 = random.Next(30);
            Point startPoint = new Point(Locations["Nursery"].X + r1, Locations["Nursery"].Y + r2);
            Bee newBee = new Bee(beeCount, startPoint, world, this);
            newBee.MessageSender += this.MessageSender;
            world.Bees.Add(newBee);
        }

        public void Go(Random random)
        {
            if (world.Bees.Count < MaximumBees && Honey > MinimumHoneyForCreatingBees /*&& random.Next(10) == 1*/)
            {
                AddBee(random);
            }
        }

        public void FindBee(BeeState beeState)
        {
            for (int i = 0; i < world.Bees.Count; i++)
            {
                if (world.Bees[i].CurrentState == BeeState.Idle|| world.Bees[i].CurrentState == BeeState.FlyingToFlower)
                {
                    world.Bees[i].CurrentState = beeState;
                    break;
                }
            }
        }
    }

}