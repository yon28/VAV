using System;
using System.IO;


namespace Task2
{
    class Program
    {
        /*Дана папка, которая является хранилищем файлов. Для всех текстовых файлов (*.txt), 
находящихся в этой папке и вложенных подпапках, 
реализовать сохранение истории изменений с возможностью отката состояния к любому моменту.

При запуске программа спрашивает пользователя, хочет ли он включить режим наблюдения, 
или отката изменений. Как вариант, можно использовать ключи командной строки.

При выборе режима наблюдения все происходящие с текстовыми файлами изменения логируются 
до момента закрытия программы. Как вариант, можно создавать на диске в отдельной 
папке копии файлов по состоянию на момент изменения.

При выборе режима отката изменений пользователь вводит дату и время, на которые должен 
быть осуществлен откат, 
после чего все текстовые файлы должны принять вид, соответствующий указанному времени. 
http://www.cyberforum.ru/csharp-net/thread681841.html  */
        //DirectoryInfo dir = new DirectoryInfo("../../..");

        private static string pathToCatalog;
        static void Main()
        {
            Current();
        }

        private static void Current()
        {
            Console.WriteLine("Введите путь к каталогу: ");
            pathToCatalog = Console.ReadLine();
            if (!Directory.Exists(pathToCatalog))
            {
                Console.WriteLine("Не удалось найти директорию. ");
                Console.ReadLine();
            }
            else
            {
                DirectoryInfo dir = new DirectoryInfo(pathToCatalog);
                dir.Create();
                Console.WriteLine("Каталог под контролем...");
                bool flagN = false;
                bool flagI = false;
                Console.WriteLine("Установить режим наблюдения(1) или осуществить откат изменений(2)?");
                string ch = Console.ReadLine();
                if (ch == "1")
                {
                    flagN = true;
                    Console.WriteLine("Режим наблюдения установлен...");
                }
                if (ch == "2")
                {
                    flagI = false;
                    Console.WriteLine("Будет осуществлён откат изменений...");
                    Info(dir);
                    Console.WriteLine();
                    Console.WriteLine("Введите время (дату и время), на которые должен быть осуществлен откат.");

                    Console.ReadLine();

                }
                Console.ReadLine();
            }

        }

        private static void Info(DirectoryInfo dir)
        {
            FileInfo[] files = dir.GetFiles("*.txt", SearchOption.AllDirectories);
            Console.WriteLine($"Найдено {files.Length} файл(а/ов):");
            foreach (FileInfo f in files)
            {
                Console.WriteLine($"Имя файла: { f.Name}, время создания файла: {f.CreationTime}");
            }
        }
    }
}
