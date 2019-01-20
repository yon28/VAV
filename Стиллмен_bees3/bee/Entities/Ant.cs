using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace bee
{
    [Serializable]
    public class Ant : Сharacter
    {
        public bool alive = true;

        public Ant(int ID, Point location, World world, Hive hive) : base(ID, location, world, hive)
        {
            Location = GetLocation("Start");
            MoveRate = 2;
        }

        protected override bool MoveTowardsLocation(Point destination)//599
        {
            if (alive == true )
            {
                return base.MoveTowardsLocation(destination); 
            }
            else
            {
                alive = true;
                Location = GetLocation("Start");
            }
            return false;
        }

        private Dictionary<string, Point> locations;
        public Point GetLocation(string location)
        {
            Random random = new Random();
            locations = new Dictionary<string, Point>();
            locations.Add("AntLocation", new Point(Location.X, Location.Y));
            locations.Add("Start", new Point(random.Next(520), random.Next(170)+100));
            if (locations.Keys.Contains(location))
                return locations[location];
            else
                throw new ArgumentException("Unknown location:" + location);
        }

        public override void Go(Random random)
        {
            if (MoveTowardsLocation(world.Hive.GetLocation("Entrance")))
            {
                Location = GetLocation("Start");

                if (world.Hive.Honey > 0.2)
                {
                    world.Hive.Honey -= 0.2;
                }
            }
        }
    }
}
