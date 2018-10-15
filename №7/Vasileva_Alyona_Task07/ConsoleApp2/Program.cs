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
        double start, step;
        int Index;

        public GeomProgression(double start, double step)
        {
            this.start = start;
            this.step = step;
            this.Index = 1;
        }

        public double Current()
        {
            return start * Math.Pow(step, Index - 1);
        }
       
        public bool Next()
        {
            Index++;
            return true;
        }
        public void Reset()
        {
            Index = 1;
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
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(series.Current());
                series.Next();
            }
        }
    }
}
