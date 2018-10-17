using System;


namespace DemoApplication
{
    public interface ISeries
    {
        double Current();
        bool Next();
        void Reset();
    }

    public interface IIndexable
    {
        double this[int index] { get; }
    }

    interface IIndexableSeries : ISeries, IIndexable
    {
    }


    public class ArifmProgression : ISeries, IIndexable
    {
        double start, step;
        private int ind;

        public ArifmProgression(double start, double step)
        {
            this.start = start;
            this.step = step;
            this.ind = 1;
        }

        public double Current()
        {
            return start * Math.Pow(step, ind - 1);
        }
        public double this[int index]
        {
            get
            {
                return start + step* (index - 1);
            }
        }
        public bool Next()
        {
            ind++;
            return true;
        }
        public void Reset()
        {
            ind = 1;
        }
    }

    public class List : ISeries, IIndexable
    {
        private double[] series;
        private int Index;
        public List(double[] series)
        {
            this.series = series;
            Index = 0;
        }
        public double Current()
        {
            return series[Index];
        }
        public bool Next()
        {
            Index = Index < series.Length - 1 ? Index + 1 : 0;
            return true;
        }
        public void Reset()
        {
            Index = 0;
        }

        public double this[int index]
        {
            get { return series[index]; }
        }
    }





    public static class InterfacesDemo
    {
        public static void Main(string[] args)
        {
            ISeries progression = new ArifmProgression(2, 2);
            Console.WriteLine("Прогрессия:");
            PrintSeries(progression);

            ISeries list = new List(new double[] { 5, 8, 6, 3, 1 });
            Console.WriteLine("Список:");
            PrintSeries(list);
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
