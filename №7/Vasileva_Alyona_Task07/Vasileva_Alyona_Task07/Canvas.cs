using System;

namespace Vasileva_Alyona_Task07
{
    public interface IPrint
    {
        void Print(Figure figure);
    }
    public class Canvas : IPrint
    {
        public void ConsolePrint(Figure figure)
        {
            Console.WriteLine(figure.ToString());
            Console.ReadLine();
        }
        public void FilePrint(Figure figure)
        {
            System.IO.File.WriteAllText("output.txt", figure.ToString());
        }
        public  void Print(Figure figure)
        {
            ConsolePrint(figure);
        }
     }
}
