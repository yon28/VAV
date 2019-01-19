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
        private Dictionary<string, Point> locations;
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
        }

        private void InitializeLocations()
        {
            locations = new Dictionary<string, Point>();
            locations.Add("Entrance", new Point(440, 80));
            locations.Add("Nursery", new Point(30, 80));
            locations.Add("HoneyFactory", new Point(130, 48));
            locations.Add("Exit", new Point(135, 130));
        }

        public Point GetLocation(string location)
        {
            if (locations.Keys.Contains(location))
                return locations[location];
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
            int r1 = random.Next(40);
            int r2 = random.Next(40);
            Point startPoint = new Point(locations["Nursery"].X + r1, locations["Nursery"].Y + r2);
            Bee newBee = new Bee(beeCount, startPoint,world,this);
            newBee.MessageSender += this.MessageSender;
            world.Bees.Add(newBee);
        }

        public void Go(Random random)
        {
            if ( world.Bees.Count< MaximumBees && Honey > MinimumHoneyForCreatingBees && random.Next(10) == 1)
            {
                AddBee(random);
            }
        }
    }

}