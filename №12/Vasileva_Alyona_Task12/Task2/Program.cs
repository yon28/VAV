using System;
using System.IO;
using System.Text;
using System.Xml;

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
        private const string pathForLog = @"C:\temp.xml";
        private static string pathToCatalog;
        static void Main()
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
                Console.WriteLine("Установить режим наблюдения(1) или осуществить откат изменений(2)?");
                string ch = Console.ReadLine();
                if (ch == "1")
                {
                    Console.WriteLine("Режим наблюдения установлен...");
                    FileSystemWatcher watcher = new FileSystemWatcher(dir.FullName);
                    XmlTextWriter xmlWriter = new XmlTextWriter(pathForLog, Encoding.UTF8);//
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("Program");
                    xmlWriter.WriteEndElement();
                    xmlWriter.Close();

                    watcher.Changed += OnChanged;
                    watcher.Created += OnCreated;
                    watcher.Deleted += OnDeleted;
                    watcher.Renamed += OnRenamed;
                }
                if (ch == "2")
                {
                    Console.WriteLine("Будет осуществлён откат изменений...");
                    Info(dir);
                    Console.WriteLine();
                    Console.WriteLine("Введите время (дату и время), на которые должен быть осуществлен откат.");
                    var inpput = Console.ReadLine();
                    DateTime date = DateTime.Parse(inpput);
                    //
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
                Console.WriteLine($"файл: { f.Name}, время создания: {f.CreationTime}, время последнего изменения: {f.LastWriteTime}," +
                    $"имя {f.Name}, полный путь {f.FullName}");
            }
        }

        private static void OnRenamed(object sender, RenamedEventArgs e)
        {
            Recording("Renamed", e);
        }
        private static void OnDeleted(object sender, FileSystemEventArgs e)
        {
            Recording("Deleted", e);
        }
        private static void OnCreated(object sender, FileSystemEventArgs e)
        {
            Recording("Created", e);
        }
        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            Recording("Changed", e);
        }

        public static void Recording(string eventName, FileSystemEventArgs e)
        {
            string changeType = e.ChangeType.ToString();
            string fullPath = e.FullPath;
            string name = e.Name;
            string oldName = "";
            Console.WriteLine(eventName);

            var doc = new XmlDocument();
            doc.Load(pathForLog);
            var el = doc.CreateElement(eventName);
            doc.DocumentElement.AppendChild(el);
            var attribute = doc.CreateAttribute("DateTime");
            attribute.Value = DateTime.Now.ToString();
            el.Attributes.Append(attribute);

            if (oldName != "")
            {
                XmlNode subE1 = doc.CreateElement("OldName");
                subE1.InnerText = oldName;
                el.AppendChild(subE1);
            }
            if (name != "")
            {
                XmlNode subE2 = doc.CreateElement("NewName");
                subE2.InnerText = name;
                el.AppendChild(subE2);
            }
            if (fullPath != "")
            {
                XmlNode subE3 = doc.CreateElement("FullPath");
                subE3.InnerText = fullPath;
                el.AppendChild(subE3);
                if (Directory.Exists(fullPath))
                {
                    var elFullPath = doc.CreateElement(eventName);
                    doc.DocumentElement.AppendChild(elFullPath);

                    XmlNode subE3_1 = doc.CreateElement("CreationTime");
                    subE3_1.InnerText = Directory.GetCreationTime(fullPath).ToString();
                    elFullPath.AppendChild(subE3_1);
                    XmlNode subE3_2 = doc.CreateElement("LastAccessTime");
                    subE3_2.InnerText = Directory.GetLastAccessTime(fullPath).ToString();
                    elFullPath.AppendChild(subE3_2);
                    XmlNode subE3_3 = doc.CreateElement("LastWriteTime");
                    subE3_3.InnerText = Directory.GetLastWriteTime(fullPath).ToString();
                    elFullPath.AppendChild(subE3_3);
                    XmlNode subE3_4 = doc.CreateElement("LogicalDrives");
                    subE3_4.InnerText = Directory.GetLogicalDrives().ToString();
                    elFullPath.AppendChild(subE3_4);
                }
            }
            if (changeType != "")
            {
                XmlNode subE4 = doc.CreateElement("ChangeType");
                subE4.InnerText = changeType;
                el.AppendChild(subE4);
            }
            doc.Save(pathForLog);
        }
    }
}
