
using System;
using System.IO;
using System.Text;
using System.Threading;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Из файла «disposable_task_file.txt» прочитать все содержимое. 
            //Затем в этом же файле заменить каждое число квадратом этого числа.
            DirectoryInfo dir = new DirectoryInfo("../../..");
            dir.Create();
            string filePath = Path.Combine(dir.FullName, "disposable_task_file.txt");
            string[] lines = File.ReadAllLines(filePath, Encoding.Default);
            for (int i = 0; i < lines.Length; i++)
            {
                int a;
                int.TryParse(lines[i], out a); //
                lines[i] = (a * a).ToString() + "\n";
            }
            File.WriteAllLines(filePath, lines, Encoding.Default);
            Console.WriteLine("Файл перезаписан.");
            Console.ReadLine();
        }
    }
}
