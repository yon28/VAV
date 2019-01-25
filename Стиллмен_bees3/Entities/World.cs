using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
namespace bee
{
    [Serializable]
    public class World
    {
        private const double NectarHarvestedPerNewFlower = 20.0;
        private const int FieldMinX = 10;  //цветочное поле
        private const int FieldMinY = 70;
        private const int FieldMaxX = 450;//520
        private const int FieldMaxY = 225;//280
        public Hive Hive;
        public List<Bee> Bees { get; set; }
        public List<Flower> Flowers;
        double nectar = 0;
        public Enemy enemy;
        public Queen queen;
        private Random random = new Random();//
        private DateTime start = DateTime.Now;//
        private DateTime end;//
        public int framesRun = 0; //сколько кадров уже показано//
        public static List<string> facts;

        public List<string> listBox1Items = new List<string>();
        public string statusStrip1Items0Text;
        public void SendMessage1(int ID, string Message)//557,561
        {
            statusStrip1Items0Text = "Bee №" + ID + ":" + Message;

            var beeGroups =
                            from bee in Bees
                            group bee by bee.CurrentState into beeGroup
                            orderby beeGroup.Key
                            select beeGroup;

            listBox1Items.Clear();
            foreach (var group in beeGroups)
            {
                string s;
                if (group.Count() == 1)
                    s = "";
                else
                    s = "s";
                listBox1Items.Add(group.Key.ToString() + ":"
                + group.Count() + " bee" + s);
                if (group.Key == BeeState.Idle && group.Count() == Bees.Count() && framesRun > 0)
                {
                    listBox1Items.Add("Simulation ended: all bees are idle");
                    // toolStrip1.Items[0].Text = "Simulation ended";
                    statusStrip1Items0Text = "Simulation ended";
                    // timer1.Enabled = false;
                }
            }
        }

        public  void RunFrame(object sender) //552++ 
        {
            framesRun++;//увеличить количество кадров
            Go(random);
            end = DateTime.Now;
            TimeSpan frameDuration = end - start;
            start = end;
            UpdateStats(frameDuration);
        }
        private  void UpdateStats(TimeSpan frameDuration) //стр.549
        {
            facts = GetList();//
        }

        public World(BeeMessage messageSender)
        {
            Bees = new List<Bee>();
            Flowers = new List<Flower>();
            Hive = new Hive(this);
            queen = new Queen(this,Hive, messageSender);
            Random random = new Random();
            for (int i = 0; i < 10; i++) //10 цветов
            {
                AddFlower(random);
            }
            enemy = new Enemy(1, new Point(0, 200), this, this.Hive);
        }

        public List<string> Facts = new List<string>();
        public List<string> GetList()
        {
            Facts.Clear();
            Facts.Add(Bees.Count.ToString());
            Facts.Add(String.Format("{0:f3}", Hive.Honey));
            Facts.Add(Flowers.Count.ToString());
            nectar = 0;
            foreach (Flower flower in Flowers)
            {
                nectar += flower.Nectar;
            }
            Facts.Add(String.Format("{0:f3}", nectar));
            Facts.Add(framesRun.ToString());
            return Facts;
        }

        public void Go(Random random)
        {
            queen.Go(random); //добавит и пчёл
            enemy.Go(random);

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
