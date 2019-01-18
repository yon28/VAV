using System;
using System.Drawing;
using System.Windows.Forms;

namespace bee
{
    public partial class BeeControl : UserControl
    {
        private int cell = 0;
        public BeeControl()
        {
            InitializeComponent();
            BackColor = System.Drawing.Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            ResizeCells();
        }

        private void animationTimer1_Tick(object sender, EventArgs e)
        {
            cell++;
            switch (cell)
            {
                case 1: BackgroundImage = cells[0]; break;
                case 2: BackgroundImage = cells[1]; break;
                case 3: BackgroundImage = cells[2]; break;
                case 4: BackgroundImage = cells[3]; break;
                case 5: BackgroundImage = cells[2]; break;
                default: BackgroundImage = cells[1];
                    cell = 0; break;
            }
        }

        private Bitmap[] cells = new Bitmap[4];
        private void ResizeCells()
        {
            cells[0] = Renderer.ResizeImage(Properties.Resources._1, Width, Height);
            cells[1] = Renderer.ResizeImage(Properties.Resources._2, Width, Height);
            cells[2] = Renderer.ResizeImage(Properties.Resources._3, Width, Height);
            cells[3] = Renderer.ResizeImage(Properties.Resources._4, Width, Height);
        }

        private void BeeControl_Load(object sender, EventArgs e)
        {

        }

        public void DrawBee(Graphics g, Rectangle rect)
        {
            g.DrawImage(Properties.Resources._1, rect);
        }
    }
}
