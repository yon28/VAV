using bee;
using Entities;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class BeeController : Controller
    {
        World world;
        Renderer rendererForWeb; 
        public BeeController()
        {
            world = Wrapper.world;

        }
        public ActionResult Index()
        {
            rendererForWeb = new Renderer(world);
            using (Bitmap image = new Bitmap(175, 150))
            {
                using (Graphics g = Graphics.FromImage(image))//изображение появляется на объекте, создавшем этот экземпляр
                {
                    rendererForWeb.PaintHive(g);
                    image.Save(Url.Content(@"I:\VAV\Стиллмен_bees3\Web\Content\img\hive.png"), ImageFormat.Png);
                }
            }
            using (Bitmap image = new Bitmap(520, 280))
            {
                using (Graphics g = Graphics.FromImage(image))//изображение появляется на объекте, создавшем этот экземпляр
                {
                    rendererForWeb.PaintField(g);
                    image.Save(Url.Content(@"I:\VAV\Стиллмен_bees3\Web\Content\img\field.png"), ImageFormat.Png);
                }
            }
            return View(world.GetList());
        }
    }
}