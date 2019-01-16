using System;
using System.Drawing;

namespace bee
{
    [Serializable]
    class Bee
    {
        private const double HoneyConsumed = 0.5;  //528
        private const int MoveRate = 3;
        private const double MinimumFlowerNectar = 1.5;//цветок пригоден для сбора нектара
        private const int CareerSpan = 1000;

        public BeeState CurrentState { get; private set; }
        public int Age { get; private set; }
        public bool InsideHive { get; private set; }
        public double NectarCollected { get; private set; }

        private Point location;
        public Point Location { get => location; }//местоположение

        private int ID;
        private Flower destinationFlower;

        private World world;
        private Hive hive;
        [NonSerialized] public BeeMessage MessageSender;

        public Bee(int ID, Point location, World world, Hive hive)
        {
            this.ID = ID;
            this.world = world;
            this.hive = hive;
            Age = 0;
            this.location = location;
            InsideHive = true;
            destinationFlower = null; //нет цветов
            NectarCollected = 0;//нет собранного нектара
            CurrentState = BeeState.Idle;
        }

        private bool MoveTowardsLocation(Point destination)//599
        {
            if (Math.Abs(destination.X - location.X) <= MoveRate 
                && Math.Abs(destination.Y - location.Y) <= MoveRate)
            {
                return true;
            }
            else
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
            return false;
        }

        public enum BeeState
        {
            Idle,
            FlyingToFlower,
            GatheringNectar,
            ReturningToHive,
            MakingHoney,
            Retired
        }
        public void Go(Random random)
        {
            Age++;
            BeeState oldState = CurrentState;
            switch (CurrentState)
            {
                case BeeState.Idle:
                    if (Age > CareerSpan)
                    {
                        CurrentState = BeeState.Retired;
                    }
                    else
                    {
                        if (world.Flowers.Count > 0 && hive.ConsumeHoney(HoneyConsumed))//цветы с нектаром остались
                        {
                            Flower flower = world.Flowers[random.Next(world.Flowers.Count)];
                            if (flower.Nectar >= MinimumFlowerNectar && flower.Alive)//другой живой цветок с нектаром
                            {
                                destinationFlower = flower;
                                CurrentState = BeeState.FlyingToFlower;
                            }
                        }
                    }
                    break;

                case BeeState.FlyingToFlower://546
                    if (!world.Flowers.Contains(destinationFlower))//есть ли цветок, который ещё не завянет?
                    {
                        CurrentState = BeeState.ReturningToHive;
                    }
                    else if (InsideHive)
                    {
                        if (MoveTowardsLocation(hive.GetLocation("Exit")))
                        {
                            InsideHive = false;//не в улье
                            location = hive.GetLocation("Entrance");
                        }
                    }
                    else
                    {
                        if (MoveTowardsLocation(destinationFlower.Location))
                        {
                            CurrentState = BeeState.GatheringNectar;
                        }
                    }
                    break;

                case BeeState.GatheringNectar://547
                    double nectar = destinationFlower.HarvestNectar();
                    if (nectar > 0)
                    {
                        NectarCollected += nectar;
                    }
                    else
                    {

                        CurrentState = BeeState.ReturningToHive;
                    }
                    break;

                case BeeState.ReturningToHive:
                    if (!InsideHive)
                    {
                        if (MoveTowardsLocation(hive.GetLocation("Entrance")))
                        {
                            InsideHive = true;
                            location = hive.GetLocation("Exit");
                        }
                    }
                    else
                    {
                        if (MoveTowardsLocation(hive.GetLocation("HoneyFactory")))
                        {
                            CurrentState = BeeState.MakingHoney;
                        }

                    }
                    break;

                case BeeState.MakingHoney:
                    if (NectarCollected < 0.5)
                    {
                        NectarCollected = 0; //меньше 0.5 фабрика не принимает
                        CurrentState = BeeState.Idle;
                    }
                    else
                    {
                        //Переработка нектара в мед, если улей может
                        if (hive.AddHoney(0.5))
                        {
                            NectarCollected -= 0.5;
                        }
                        else
                        {
                            NectarCollected = 0;
                        }
                    }
                    break;

                case BeeState.Retired:
                    //Работа закончена
                    break;  
            }

            if (oldState != CurrentState && MessageSender!= null) //556
            {
                MessageSender(ID, CurrentState.ToString());
            }
        }

        public virtual int ShiftsLeft { get => 0; }

        public Bee(int weight)
        {
            this.weight = weight;
        }

        protected int weight;
        public virtual double GetHoneyConsumption()
        {
            double consumption;
            if (ShiftsLeft == 0)
                consumption = 7.5;
            else
                consumption = 9 + ShiftsLeft;
            if (weight > 150)
                consumption *= 1.35;
            return consumption;
        }
    }
}
