using bee;
using Entities;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class BeeController : Controller
        {
        World world;
        private int framesRun = 0; //сколько кадров уже показано//+
        public BeeController()
        {
            world = Wrapper.world;
        }

        public ActionResult Index()
            {
                return View(world.GetList());
            }

            public ActionResult Save()
            {
                return RedirectToAction("Index");//...
            }
        }
    }