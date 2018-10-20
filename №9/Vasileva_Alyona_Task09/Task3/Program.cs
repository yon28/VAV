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
            if (NotError(adres))
            {
                var AllWord = Create(adres);
                Write(AllWord);
            }
            Console.ReadLine();
        }

        static bool NotError(string adres)
        {
            if (!(File.Exists(adres)))
            {
                Console.WriteLine("Файл не найден.");
                Console.ReadLine();
                return false;
            }
            return true;
        }

        static SortedDictionary<string, int> Write(SortedDictionary<string, int> Current)
        {
            Console.WriteLine("Слова и частота их встречаемости");
            foreach (var i in Current)
            {
                Console.WriteLine("{0} {1}", i.Key, i.Value);
            }
            Console.WriteLine(" ");
            return Current;
        }
        
        static string[] Splited(string str)
        {
            Regex regex = new Regex(@"\W");
            string[] words = regex.Split(str);
            return words;
        }
    
        static SortedDictionary<string, int> Create(string adres)
        {
            var AllWord = new SortedDictionary<string, int>();
            foreach (var line in File.ReadLines(adres))
            {
                foreach (string word in Splited(line))
                {
                    var count = 0;
                    AllWord.TryGetValue(word.ToLower(), out count);
                    AllWord[word.ToLower()] = count + 1;
                }
            }
            return AllWord;
        }
    }
}

