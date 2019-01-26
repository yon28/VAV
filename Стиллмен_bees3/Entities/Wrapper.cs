using bee;
using System.Collections.Generic;
//using System.Threading;
//http://qaru.site/questions/516837/how-to-call-function-on-timer-aspnet-mvc
namespace Entities
{
    public class Wrapper
    {
        public static World world;
        private static int framesRun = 0;
        public static System.Timers.Timer timer1 = new System.Timers.Timer(100);

        static Wrapper()
        {
            world = new World(new BeeMessage(SendMessage));
            ResetSimulator();
            framesRun = world.framesRun;
            ResetSimulator();//+
            timer1.Enabled = true;
            timer1.Elapsed += new System.Timers.ElapsedEventHandler(RunFrame); 
            UpdateStats();
        }

        private static void SendMessage(int ID, string Message)//557,561
        {
            //listBox1.Items.Clear();
            world.SendMessage1(ID, Message);
            //foreach (var message in world.listBox1Items)
            //{
            //    listBox1.Items.Add(message);
            //}
            //statusStrip1.Items[0].Text = world.statusStrip1Items0Text;
        }

        public static void RunFrame(object sender, System.Timers.ElapsedEventArgs e) //552
        {
            world.RunFrame(sender);
            UpdateStats();
        }

        public static List<string> Facts = new List<string>();
        private static  void UpdateStats() //стр.549      
        {
            Facts = world.GetList();

        }

        private static void ResetSimulator()
        {
            world = new World(new BeeMessage(SendMessage));
        }
    }
}
