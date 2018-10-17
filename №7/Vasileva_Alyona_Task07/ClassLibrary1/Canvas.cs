using System;


namespace ClassLibrary1
{
    public interface IPrint
    {
        void Print(Obj obj);
    }

    public class Canvas : IPrint
    {
        public Canvas()
        {

        }
        public void ConsolePrint(Obj obj)
        {
            Console.WriteLine(obj.Move());
        }

        public void FilePrint(Obj obj)
        {
            System.IO.File.WriteAllText("output.txt", obj.Move());
        }

        public void Print(Obj obj)
        {
            ConsolePrint(obj);
        }
    }
}
