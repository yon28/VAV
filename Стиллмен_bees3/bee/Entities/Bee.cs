using System;
using System.Drawing;

namespace bee
{
    [Serializable]
    public class Bee : Сharacter
    {
        private const double HoneyConsumed = 0.5;  //528
        private const double MinimumFlowerNectar = 1.5;//цветок пригоден для сбора нектара
        private const int CareerSpan = 800;
        public BeeState CurrentState { get; set; }
        public bool InsideHive { get; private set; }
        public double NectarCollected { get; private set; }
        private Flower destinationFlower;
        public Bee(int ID, Point Location, World world, Hive hive) : base(ID, Location, world, hive)
        {
            InsideHive = true;
            destinationFlower = null; //нет цветов
            NectarCollected = 0;//нет собранного нектара
            CurrentState = BeeState.Idle;
        }

        protected override bool MoveTowardsLocation(Point destination)//599
        {
            if (CurrentState == BeeState.LookForEnemiesAndSting
                && Math.Abs(destination.X - Location.X) <= MoveRate + 5
                && Math.Abs(destination.Y - Location.Y) <= MoveRate + 5)
            {
                return true;
            }
            else
            {
                return base.MoveTowardsLocation(destination);
            }
        }

        public override void Go(Random random)
        {
            Age++;
            //потребить мед
            if (hive.Honey > 0.01) hive.Honey -= 0.0001;
            BeeState oldState = CurrentState;
            //работать
            switch (CurrentState)
            {
                case BeeState.Idle:
                    if (Age > CareerSpan)
                    {
                        CurrentState = BeeState.Retired; //а другие бессмертные?
                    }
                    else if (Age > 150||ID<4)//взрослая особь
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
                case BeeState.EggCare_BabyBeeTutoring_HiveMaintenance:
                    if (!InsideHive)
                    {
                        GetInOrGetOut();
                    }
                    if (MoveTowardsLocation(hive.GetLocation("Nursery")))
                    {
                    }
                    break;
                case BeeState.LookForEnemiesAndSting:
                    Point pEnemy = world.enemy.GetLocation("EnemyLocation");
                    Point phive = hive.GetLocation("Entrance");
                    if (InsideHive || Math.Abs(Location.X - phive.X) >= 25 && Math.Abs(phive.Y - Location.Y) >= 25)
                    {
                        GetInOrGetOut();
                    }
                    else 
                    if (Math.Abs(pEnemy.X - phive.X) <= 45 && Math.Abs(pEnemy.Y - phive.Y) <= 45)
                    {
                        if (MoveTowardsLocation(world.enemy.GetLocation("EnemyLocation")))
                        {
                            world.enemy.intrusion = false;
                            if (random.Next(10) == 1)
                            {
                                CurrentState = BeeState.Sting;
                            }
                        }
                    }
                    break;
                case BeeState.Sting:
                    world.queen.FindBee(BeeState.LookForEnemiesAndSting);
                    CurrentState = BeeState.Retired;
                    break;
                case BeeState.FlyingToFlower://546
                    if (!world.Flowers.Contains(destinationFlower))//есть ли цветок, который ещё не завянет?
                    {
                        CurrentState = BeeState.FlyToHoneyFactory;
                    }
                    else if (InsideHive)
                    {
                        GetInOrGetOut();
                    }
                    else if (MoveTowardsLocation(destinationFlower.Location))
                    {
                        CurrentState = BeeState.GatheringNectar;
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
                        CurrentState = BeeState.FlyToHoneyFactory;
                    }
                    break;
                case BeeState.FlyToHoneyFactory:
                    if (!InsideHive)
                    {
                        GetInOrGetOut();
                    }
                    else if (MoveTowardsLocation(hive.GetLocation("HoneyFactory")))
                    {
                        CurrentState = BeeState.MakingHoney;
                    }
                    break;
                case BeeState.MakingHoney:
                    if (NectarCollected < 0.5)
                    {
                        NectarCollected = 0; //меньше 0.5 фабрика не принимает
                        CurrentState = BeeState.Idle;
                    }
                    //Переработка нектара в мед, если улей может
                    else if (hive.AddHoney(0.5))
                    {
                        NectarCollected -= 0.5;
                    }
                    else
                    {
                        NectarCollected = 0;
                    }
                    break;
                case BeeState.Retired:  //Работа закончена
                    break;
            }
            if (oldState != CurrentState && MessageSender != null) //556
            {
                MessageSender(ID, CurrentState.ToString());
            }
        }

        public void GetInOrGetOut()
        {
            if (InsideHive)
            {
                if (MoveTowardsLocation(hive.GetLocation("Exit")))
                {
                    Location = hive.GetLocation("Entrance");
                    InsideHive = false;
                }
            }
            else
            {
                if (MoveTowardsLocation(hive.GetLocation("Entrance")))
                {
                    Location = hive.GetLocation("Exit");
                    InsideHive = true;
                }
            }
        }

        public virtual int ShiftsLeft { get => 0; }

        //public Bee(int weight)
        //{
        //    this.weight = weight;
        //}

        //private int weight;
        //public virtual double GetHoneyConsumption()
        //{
        //    double consumption;
        //    if (ShiftsLeft == 0)
        //        consumption = 7.5;
        //    else
        //        consumption = 9 + ShiftsLeft;
        //    if (weight > 150)
        //        consumption *= 1.35;
        //    return consumption;
        //}
    }
}
