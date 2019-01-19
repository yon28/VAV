using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace bee
{
    [Serializable]
    public class Ant
    {
        private const int MoveRate = 2;
        private Point location;
        public Point Location { get => location; set { } }//местоположение
        private int ID;
        private World world;
        public bool alive = true;
        [NonSerialized] public BeeMessage MessageSender;

        public Ant(int ID, Point location, World world)
        {
            this.ID = ID;
            this.location = location;
            this.world = world;
        }

        private bool MoveTowardsLocation(Point destination)//599
        {
            if (world.Bees[1].antAlive == true && Math.Abs(destination.X - location.X) <= MoveRate
                && Math.Abs(destination.Y - location.Y) <= MoveRate && alive)
            {
                return true;
            }
            else if (world.Bees[1].antAlive == true)
            {
                if (destination.X > location.X)
                {
                    location.X += MoveRate;
                }
                else if (destination.X < location.X)
                {
                    location.X -= MoveRate;
                }

                if (destination.Y > location.Y)
                {
                    location.Y += MoveRate;
                }
                else if (destination.Y < location.Y)
                {
                    location.Y -= MoveRate;
                }
            }
            else
            {
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
            locations.Add("Start", new Point(random.Next(20), 100 + random.Next(20)));
            if (locations.Keys.Contains(location))
                return locations[location];
            else
                throw new ArgumentException("Unknown location:" + location);
        }

        public void Go(Random random)
        {
            if (MoveTowardsLocation(world.Hive.GetLocation("Entrance")))
            {
                location = GetLocation("Start");
                if (world.Hive.Honey > 0.2)
                {
                    world.Hive.Honey -= 0.2;
                   // int rand = random.Next(world.Bees.Count());
                    if (world.Bees[1] != null)
                    {
                        world.Bees[1].CurrentState = BeeState.LookForEnemiesAndSting;
                    }
                }
            }
        }
    }
}
