using System;
using System.IO;
using System.Text;

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
 */
        //DirectoryInfo dir = new DirectoryInfo("../../..");
        private const string pathForLog = @"C:\test2";
        private static string pathToCatalog;
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            FileSystemWatcher watcher;
            DirectoryInfo dirForLog = new DirectoryInfo(pathForLog);
            dirForLog.Create();
            Console.WriteLine("Path. Введите путь к каталогу: ");
            pathToCatalog = Console.ReadLine();
            if (!Directory.Exists(pathToCatalog))
            {
                Console.WriteLine("Where? Не удалось найти директорию. ");
                Console.ReadKey();
            }
            else
            {
                DirectoryInfo dir = new DirectoryInfo(pathToCatalog);
                dir.Create();
                Console.WriteLine("Ok. Каталог под контролем...");
                Console.WriteLine("Установить режим наблюдения(1) или осуществить откат изменений(2)?");
                string ch = Console.ReadLine();
                if (ch == "1")
                {
                    Console.WriteLine("Ok1. Режим наблюдения установлен. Чтобы выйти из него, нажмите любую клавишу.");
                    watcher = new FileSystemWatcher(dir.FullName);
                    watcher.Filter = "*.txt";
                    watcher.Created += new FileSystemEventHandler(OnChanged);
                    watcher.Renamed += new RenamedEventHandler(OnRenamed);
                    watcher.Changed += new FileSystemEventHandler(OnChanged);
                    watcher.Deleted += new FileSystemEventHandler(OnChanged);
                 //   var watcherStruct = watcher.WaitForChanged(WatcherChangeTypes.All);
                    watcher.EnableRaisingEvents = true;
                }
                if (ch == "2")
                {
                    Console.WriteLine("Ok2. Будет осуществлён откат изменений...");
                 // Info(dir);
                    Recoil();
                }
                Console.ReadKey();
            }
        }

        private static void Info(DirectoryInfo dir)
        {
            FileInfo[] files = dir.GetFiles("*.txt", SearchOption.AllDirectories);
            Console.WriteLine($"Find. Найдено {files.Length} файл(а/ов):");
            foreach (FileInfo f in files)
            {
                Console.WriteLine($"файл: { f.Name}, время создания: {f.CreationTime}, время последнего изменения: {f.LastWriteTime}");
            }
        }
        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Copy. Создана идентичная структура папок. Скопированы все файлы.");
            DateTime t = DateTime.Now;
            string pathDate = pathForLog + "\\" + t.ToString().Replace(":", "+");
            DirectoryInfo dirDate = new DirectoryInfo(pathDate);
            dirDate.Create();
            foreach (string dirPath in Directory.GetDirectories(pathToCatalog, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(pathToCatalog, pathDate));
            }
            foreach (string newPath in Directory.GetFiles(pathToCatalog, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(pathToCatalog, pathDate), true);  
            }
        }
        private static void OnRenamed(object sender, RenamedEventArgs e)
        {
            OnChanged(sender, e);
        }



        private static void Recoil()
        {
            foreach (string dirPath in Directory.GetDirectories(pathForLog, "*", SearchOption.AllDirectories))
            {
                Console.WriteLine(dirPath.ToString().Replace(pathForLog.ToString(),"").Replace("+", ":"));
            }
            Console.WriteLine("Time. Введите время (дату и время), на которые должен быть осуществлен откат.");
            var inpput = Console.ReadLine();
            DateTime date = DateTime.Parse(inpput);
            DateTime t = date;
            string pathDate = pathForLog + "\\" + t.ToString().Replace(":", "+");
            DirectoryInfo dirDate = new DirectoryInfo(pathDate);//
            dirDate.Create();
            foreach (string oldPath in Directory.GetFiles(pathToCatalog, "*.*", SearchOption.AllDirectories))
            {
                File.Delete(oldPath);
            }
            foreach (string dirPath in Directory.GetDirectories(pathDate, "*", SearchOption.AllDirectories))//
            {
                Directory.CreateDirectory(dirPath.Replace( pathDate, pathToCatalog));//
            }
            foreach (string newPath in Directory.GetFiles(pathDate, "*.*", SearchOption.AllDirectories))//
            {
                File.Copy(newPath, newPath.Replace( pathDate, pathToCatalog), true); //
            }
            Console.WriteLine("Откат осуществлён.");
        }
    }
}
