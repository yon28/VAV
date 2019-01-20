using System.Drawing;

//471
namespace bee
{
    public class Renderer//визуализатор
    {
        private World world;
        private HiveForm hiveForm;
        private FieldForm fieldForm;

        Bitmap HiveInside;
        Bitmap HiveOutside;
        Bitmap Flower;
        Bitmap[] BeeAnimationLarge;
        Bitmap[] BeeAnimationSmall;
        Bitmap Ant;
        public Renderer(World world, HiveForm hiveForm, FieldForm fieldForm)
        {
            this.world = world;
            this.hiveForm = hiveForm;
            this.fieldForm = fieldForm;
            hiveForm.Renderer = this;
            fieldForm.Renderer = this;
            InitializeImages();
        }

        private void InitializeImages()
        {
            HiveOutside = ResizeImage(Properties.Resources._6, 45,60);
            Flower = ResizeImage(Properties.Resources._8, 25, 35);
            HiveInside = ResizeImage(Properties.Resources._5, hiveForm.ClientRectangle.Width, hiveForm.ClientRectangle.Height);
            Ant = ResizeImage(Properties.Resources.ant, 15, 15);

            BeeAnimationLarge = new Bitmap[4];
            BeeAnimationLarge[0] = ResizeImage(Properties.Resources._1, 20, 20);
            BeeAnimationLarge[1] = ResizeImage(Properties.Resources._2, 20, 20);
            BeeAnimationLarge[2] = ResizeImage(Properties.Resources._3, 20, 20);
            BeeAnimationLarge[3] = ResizeImage(Properties.Resources._4, 20, 20);
            BeeAnimationSmall = new Bitmap[4];
            BeeAnimationSmall[0] = ResizeImage(Properties.Resources._1, 20, 20);
            BeeAnimationSmall[1] = ResizeImage(Properties.Resources._2, 20, 20);
            BeeAnimationSmall[2] = ResizeImage(Properties.Resources._3, 20, 20);
            BeeAnimationSmall[3] = ResizeImage(Properties.Resources._4, 20, 20);
        }

        public static Bitmap ResizeImage(Bitmap picture, int width, int height)
        {
            Bitmap resizedPicture = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedPicture))
            {
                // graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
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
            hiveForm.Invalidate();
            fieldForm.Invalidate();
        }

        public void PaintHive(Graphics g)
        {
            g.FillRectangle(Brushes.SkyBlue, hiveForm.ClientRectangle);
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
                g.FillRectangle(Brushes.SkyBlue, 0, 0, fieldForm.ClientSize.Width, fieldForm.ClientSize.Height / 4);
                g.FillEllipse(Brushes.Yellow, new RectangleF(50, 15, 30, 30));
                g.FillRectangle(Brushes.Green, 0, fieldForm.ClientSize.Height /4, fieldForm.ClientSize.Width, fieldForm.ClientSize.Height /4* 3);
                g.DrawImageUnscaled(HiveOutside, 420, 30);
                foreach (Flower flower in world.Flowers)
                {
                    g.DrawImageUnscaled(Flower, flower.Location.X, flower.Location.Y);
                }
                g.DrawImageUnscaled(Ant, world.ant.Location.X, world.ant.Location.Y);
                foreach (Bee bee in world.Bees)
                {
                    if (!bee.InsideHive)
                    {
                        g.DrawImageUnscaled(BeeAnimationSmall[cell], bee.Location.X, bee.Location.Y);
                    }
                }
            }
        }
    }
}


