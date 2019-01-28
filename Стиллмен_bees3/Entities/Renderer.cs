using System.Drawing;

namespace bee
{
    public class Renderer//471
    {
        private World world;
        Bitmap HiveInside;
        Bitmap HiveOutside;
        Bitmap Flower;
        Bitmap[] BeeAnimationLarge;
        Bitmap[] BeeAnimationEnemy;
        Bitmap Ant;

        public Renderer(World world)
        {
            this.world = world;
            InitializeImages();
        }

        protected void InitializeImages()
        {
            string path = "I:/VAV/Стиллмен_bees3/bee/Resources/";
            HiveInside = ResizeImage(new Bitmap(path+"5.png"), 175, 150);
            HiveOutside = ResizeImage(new Bitmap(path + "6.png"), 45, 60);
            Flower = ResizeImage(new Bitmap(path + "8.png"), 35, 45);
            Ant = ResizeImage(new Bitmap(path + "ant.png"), 15, 15);
            BeeAnimationLarge = new Bitmap[4];
            BeeAnimationLarge[0] = ResizeImage(new Bitmap(path + "1.png"), 20, 20);
            BeeAnimationLarge[1] = ResizeImage(new Bitmap(path + "2.png"), 20, 20);
            BeeAnimationLarge[2] = ResizeImage(new Bitmap(path + "3.png"), 20, 20);
            BeeAnimationLarge[3] = ResizeImage(new Bitmap(path + "4.png"), 20, 20);
            BeeAnimationEnemy = new Bitmap[4];
            BeeAnimationEnemy[0] = ResizeImage(new Bitmap(path + "11.png"), 20, 20);
            BeeAnimationEnemy[1] = ResizeImage(new Bitmap(path + "22.png"), 20, 20);
            BeeAnimationEnemy[2] = ResizeImage(new Bitmap(path + "33.png"), 20, 20);
            BeeAnimationEnemy[3] = ResizeImage(new Bitmap(path + "44.png"), 20, 20);
        }

        public static Bitmap ResizeImage(Bitmap picture, int width, int height)
        {
            Bitmap resizedPicture = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedPicture))
            {
                graphics.DrawImage(picture, 0, 0, width, height);
            }
            return resizedPicture;
        }

        private int cell = 0;
        private int frame = 0;

        public void AnimateBees()
        {
            frame++;
            if (frame >= 6)
                frame = 0;
            switch (frame)
            {
                case 0: cell = 0; break;
                case 1: cell = 1; break;
                case 2: cell = 2; break;
                case 3: cell = 3; break;
                case 4: cell = 2; break;
                case 5: cell = 1; break;
                default: cell = 0; break;
            }
        }

        public void PaintHive(Graphics g)
        {
            g.FillRectangle(Brushes.SkyBlue, 0,0,175,150);
            g.DrawImageUnscaled(HiveInside, 0, 0);
            foreach (Bee bee in world.Bees)
            {
                if (bee.InsideHive)
                {
                    g.DrawImageUnscaled(BeeAnimationLarge[cell], bee.Location.X, bee.Location.Y);
                }
            }
        }

        public void PaintField(Graphics g)
        {
            using (Pen brownPen = new Pen(Color.Brown, 6.0F))
            {
                g.FillRectangle(Brushes.SkyBlue, 0, 0,520,280 / 4);
                g.FillEllipse(Brushes.Yellow, new RectangleF(50, 15, 30, 30));
                g.FillRectangle(Brushes.Green, 0,280 / 4, 520, 280 / 4 * 3);
                g.DrawImageUnscaled(HiveOutside, 420, 30);
                foreach (Flower flower in world.Flowers)
                {
                    g.DrawImageUnscaled(Flower, flower.Location.X, flower.Location.Y);
                }
                g.DrawImageUnscaled(BeeAnimationEnemy[cell], world.enemy.Location.X, world.enemy.Location.Y);
                foreach (Bee bee in world.Bees)
                {
                    if (!bee.InsideHive)
                    {
                        g.DrawImageUnscaled(BeeAnimationLarge[cell], bee.Location.X, bee.Location.Y);
                    }
                }
            }
        }
    }
}


