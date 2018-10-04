using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace keywords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи адрес файла.");
            string adres = Console.ReadLine();
            //  adres = "../../Program.cs";
            if (Error(adres))
            {
                var AllWord = N1_Get(adres);
                var Vybor = N2_Table(AllWord);
                N3_Top5(Vybor);
            }

        }

        static SortedDictionary<string, int> N1_Get(string adres)
        {
            var AllWord = new SortedDictionary<string, int>();
            var f = 1;
            foreach (var line in File.ReadLines(adres))
            {
                string x = line;
                if (x.Replace(" ", "").Replace("\t", "").StartsWith("//"))
                    x = "";
                if (x.Replace(" ","").Replace("\t", "").StartsWith("/*")& x.EndsWith("*/"))
                   x = "";
                if (x.Replace(" ", "").Replace("\t", "").StartsWith("/*"))
                {
                    x = "";
                    f = 0;
                }
                if (x.EndsWith("*/"))
                {
                    x = "";
                    f = 1;
                }
                if (f==0)
                    x = "";
                if (f == 1)
                {
                    foreach (var word in x.Split(' ', '.', ';', ',', '(', ')', '[', ']', '<', '>',
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

        static SortedDictionary<string, int> N2_Table(SortedDictionary<string, int> AllWord)
        {
            string[] b =
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
            Console.WriteLine("Ключевые слова в отсортированном виде в таблице");
            var Vybor = new SortedDictionary<string, int>();
            foreach (var i in AllWord)
                foreach (var j in b)
                    if (i.Key == j)
                        Vybor[i.Key] = i.Value;
            int sum = 0;
            foreach (var i in Vybor)
            {
                Console.WriteLine("{0} {1}", i.Key, i.Value);
                sum = sum + i.Value;
            }
            Console.WriteLine(" ");
            Console.WriteLine("Количество ключевых слов ");
            Console.WriteLine(sum);
            Console.WriteLine(" ");
            return Vybor;
        }

        static void N3_Top5(SortedDictionary<string, int> Vybor)
        {
            Console.WriteLine("TOP5 наиболее часто встречающихся ключевых слов");
            var count = 1;
            var Sort= Vybor.OrderByDescending(k => k.Value);
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
    }


}
// N5_Komment
// Считается,что комментарий должен быть выделен в отдельные строки

