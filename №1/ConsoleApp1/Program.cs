using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
namespace keywords

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи адрес файла.");
            string adres = Console.ReadLine();
            adres = "../../Program.cs";
            if (Error(adres))
            {
                var AllWord = GetWithoutComment(adres);
                var Current = Find(AllWord);
                SetTop5(Current);
            }

        }

        static SortedDictionary<string, int> Find(SortedDictionary<string, int> AllWord)
        {
            string[] AllKeywords =
            { " as", "abstract", "add", "alias", "ascending", "async", "await", "base", "bool",
                "break", "byte", "case", "catch", "char", "checked", "class", "const", "continue", "decimal",
                "default", "delegate", "descending", "do", "double", "dynamic", "else", "enum", "event", "explicit",
                "extern", "false", "finally", "fixed", "float", "for", "foreach", "from", "get", "global", "goto",
                "group", "if", "implicit", "in", "int", "interface", "internal", "into", "is", "join", "let", "lock",
                "long","nameof","namespace","new","null","object","operator","orderby","out","override","params",
                "partial","private","protected","public","readonly","ref","remove","return","sbyte","sealed","select",
                "set","short","sizeof","stackalloc","static","string","struct","switch","this","throw","true","try",
                "typeof","uint","ulong","unchecked","unsafe","ushort","using","usingstatic","value","var","virtual",
                "void","volatile","when","where","while","yield"
            };
            var Current = new SortedDictionary<string, int>();
            foreach (var i in AllWord)
                foreach (var j in AllKeywords)
                    if (i.Key == j)
                        Current[i.Key] = i.Value;
            Write(Current);
            return Current;
        }


        static SortedDictionary<string, int> Write(SortedDictionary<string, int> Current)
        {
            int sum = 0;
            Console.WriteLine("Ключевые слова в отсортированном виде в таблице");
            foreach (var i in Current)
            {
                Console.WriteLine("{0} {1}", i.Key, i.Value);
                sum = sum + i.Value;
            }
            Console.WriteLine(" ");
            Console.WriteLine("Количество ключевых слов ");
            Console.WriteLine(sum);
            Console.WriteLine(" ");
            return Current;
        } 
        

            static void SetTop5(SortedDictionary<string, int> Current)
        {
            Console.WriteLine("TOP5 наиболее часто встречающихся ключевых слов");
            var count = 1;
            var Sort= Current.OrderByDescending(k => k.Value);
            foreach (var i in Sort)
                if (count <= 5)
                {
                    Console.WriteLine("{0} {1}", i.Key, i.Value);
                    count ++;
                }
            Console.WriteLine("  ");
            Console.ReadLine();
        }
   
        static bool Error(string adres)
        {
            if (!(File.Exists(adres)))
            {
                Console.WriteLine("Файл не найден.");
                Console.ReadLine();
                return false;
            }
            return true;
        }

        static SortedDictionary<string, int> GetWithoutComment(string adres)
        {
            var AllWord = new SortedDictionary<string, int>();
            var f = 1;
            string str = "";
            foreach (var line in File.ReadLines(adres))
            {
                string currentLine = line;   
                if (currentLine.Contains("/*") & currentLine.Contains("*/")) { }
                if (currentLine.Contains("/*") & !currentLine.Contains("*/")) { f = 0; str = str + currentLine;  }
                if (!currentLine.Contains("/*") & !currentLine.Contains("*/") & f == 0) { str = str + currentLine;  }
                if (!currentLine.Contains("/*") & currentLine.Contains("*/") & f == 0)
                {
                    f = 1;
                    currentLine = str + currentLine;
                }
                if (f == 1)
                {
                    str = "";
                    if (currentLine.Contains("/*") | currentLine.Contains("*/"))
                    {
                        Console.WriteLine(currentLine);
                        Regex regex = new Regex(@"/\*.*\*/");
                        currentLine = regex.Replace(currentLine, " ");

                    }
                    if (currentLine.Contains("//")) currentLine = DelComment(currentLine);
                    foreach (var word in currentLine.Split(' ', '.', ';', ',', '(', ')', '[', ']', '<', '>',
                    '+', '-', '}', '{', '/', '*', '=').Skip(1))
                    {
                        var count = 0;
                        AllWord.TryGetValue(word, out count);
                        AllWord[word] = count + 1;
                    }
                   
                } 

            }
            return AllWord;
        }

        static string DelComment(string currentLine)
        {
            Regex regex = new Regex(@"//.*");
            currentLine = regex.Replace(currentLine, " ");
            return currentLine;
        }
    }

    /*  string 
 string  */
    /*  string  string  */  // string
}

