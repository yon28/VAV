using System;
using System.Drawing;

namespace bee
{
    [Serializable]
    public class Сharacter
    {
        protected int MoveRate;
        public int Age { get; protected set; }
        public Point Location; //местоположение
        protected int ID;
        protected World world;
        protected Hive hive;
        [NonSerialized] public BeeMessage MessageSender;

        public Сharacter(int ID, Point location, World world, Hive hive)
        {
            this.ID = ID;
            this.Location = location;
            this.world = world;
            this.hive = hive;
            MoveRate = 3;
        }

        protected virtual bool MoveTowardsLocation(Point destination)//599
        {
            if (Math.Abs(destination.X - Location.X) <= MoveRate && Math.Abs(destination.Y - Location.Y) <= MoveRate)
            {
                return true;
            }
            else
            if (destination.X > Location.X)
            {
                Location.X += MoveRate;
            }
            else if (destination.X < Location.X)
            {
                Location.X -= MoveRate;
            }

            if (destination.Y > Location.Y)
            {
                Location.Y += MoveRate;
            }
            else if (destination.Y < Location.Y)
            {
                Location.Y -= MoveRate;
            }
            return false;
        }

        public virtual void Go(Random random)
        {
        }
    }
}
