using bee;
//http://www.cyberguru.ru/microsoft-net/asp-net/ajax-timer.html?showall=1 Таймер
namespace Entities
{
    public class Wrapper
    {
        public static World world;
     //   public static TimerCallback tm = new TimerCallback(RunFrame);
     //   public static Timer timer= new Timer(tm, framesRun, 0, 100);

        static Wrapper()
        {
            world = new World(new BeeMessage(SendMessage));
            ResetSimulator();
           // UpdateStats(new TimeSpan());//новый отсчет времени
        }

        private static void ResetSimulator()
        {
            //framesRun = 0;
            world = new World(new BeeMessage(SendMessage));
            //renderer
        }
        
        private static void SendMessage(int ID, string Message)//557,561--
        {
          //  facts = world.GetList();
        }
    }
}
