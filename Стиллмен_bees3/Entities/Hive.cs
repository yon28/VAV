using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace bee
{
    [Serializable]
    public class Hive//533
    {

        private const double InitialHoney = 3.2;
        private const double MaximumHoney = 15.0;
        private const double NectarHoneyRatio = .25;
        public const int MaximumBees = 8;
        private Dictionary<string, Point> Locations;
        public int beeCount = 0;
        public double Honey { get; set; }
        private World world;
        [NonSerialized] public BeeMessage MessageSender;

        public Hive(World world)
        {
            this.world = world;
            Honey = InitialHoney;
            InitializeLocations();
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



    }

}