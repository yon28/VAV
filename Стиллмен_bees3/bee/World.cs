using System;
using System.Collections.Generic;
using System.Drawing;

namespace bee
{
    [Serializable]
    public class World
    {
        private const double NectarHarvestedPerNewFlower = 50.0;
        private const int FieldMinX = 15;  //цветочное поле
        private const int FieldMinY = 77;
        private const int FieldMaxX = 450;
        private const int FieldMaxY = 290;
        public Hive Hive;
        public List<Bee> Bees;
        public List<Flower> Flowers;

        public World(BeeMessage messageSender)
        {
            Bees = new List<Bee>();
            Flowers = new List<Flower>();
            Hive = new Hive(this, messageSender);
            Random random = new Random();
            for (int i = 0; i < 20; i++) //20 цветов
            {
                AddFlower(random);
            }
        }

        public void Go(Random random)
        {
            Hive.Go(random); //добавит и пчёл

            for (int і = Bees.Count - 1; і >= 0; і--)
            {
                Bee bee = Bees[і];
                bee.Go(random);
                if (bee.CurrentState == BeeState.Retired)
                    Bees.Remove(bee);
            }

            double totalNectarHarvested = 0;
            for (int i = Flowers.Count - 1; i >= 0; i--)
            {
                Flower flower = Flowers[i];
                flower.Go();
                totalNectarHarvested += flower.NectarHarvested;
                if (!flower.Alive)
                {
                    Flowers.Remove(flower);
                }
            }
            if (totalNectarHarvested > NectarHarvestedPerNewFlower)//опыление->появление нового цветка
            {
                foreach (Flower flower in Flowers)
                {
                    flower.NectarHarvested = 0;
                }
                AddFlower(random);
            }
        }

        private void AddFlower(Random random)
        {
            Point location = new Point(random.Next(FieldMinX, FieldMaxX), random.Next(FieldMinY, FieldMaxY));
            Flower newFlower = new Flower(location, random);
            Flowers.Add(newFlower);
        }
    }
}
