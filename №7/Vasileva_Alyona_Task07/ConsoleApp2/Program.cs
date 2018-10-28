using System;

namespace DemoApplication
{
    public interface ISeries
    {
        double Current();
        bool Next();
        void Reset();
    }
    public class GeomProgression : ISeries
    {
        double start;
        double step;
        int index;
        public GeomProgression(double start, double step)
        {
            this.start = start;
            this.step = step;
            index = 1;
        }
        public double Current()
        {
            return start * Math.Pow(step, index - 1);
        }
        public bool Next()
        {
            index++;
            return true;
        }
        public void Reset()
        {
            index = 1;
        }
    }

    public static class InterfacesDemo
    {
        public static void Main(string[] args)
        {
            ISeries progression = new GeomProgression(2, 2);
            Console.WriteLine("Прогрессия:");
            PrintSeries(progression);
            Console.ReadLine();
        }
        static void PrintSeries(ISeries series)
        {
            series.Reset();
            for (int i = 0; i < 10; i++) //Десять элементов
            {
                Console.WriteLine(series.Current());
                series.Next();
            }
        }
    }
}
