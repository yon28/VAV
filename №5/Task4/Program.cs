using System;
using System.Text;


namespace Task4
{
    internal class MyString
    {
        private char[] ch;
        // класс MyString, описывает строку как массив символов. 
        public MyString(char[] ch)
        {
            this.ch = ch;
        }

        int length() => ch.Length;

        // метод «ToString»
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < ch.Length; i++)
            {
                result.Append(ch[i]);
            }
            return result.ToString();
        }

        // ‘+’ – добавляет строку в конец текущей
        public static MyString operator +(MyString str1, MyString str2)
        {
            return new MyString((str1.ToString()+ str2.ToString()).ToCharArray());
        }

        // ‘==’ – сравнивает два объекта MyString
        public static bool operator ==(MyString str1, MyString str2)
        {
            return !(str1 != str2);
        }

        //	‘!=’ – сравнивает два объекта MyString
        public static bool operator !=(MyString str1, MyString str2)
        {
            if (str2.ch.Length != str2.ch.Length)
            {
                return true;
            }

            for (int i = 0; i < str2.ch.Length; i++)
            {
                if (str1.ch[i] != str2.ch[i])
                {
                    return true;
                }
            }

            return false;
        }

        // ‘-’ – удаляет подстроку из текущей строки
        public static MyString operator -(MyString str, MyString substr)
        {
            StringBuilder result = new StringBuilder();
            result.Insert(1, str.ToString(), 0);
            int n = str.ToString().LastIndexOfAny(substr.ch);
            str.ToString().Remove(n, substr.ch.Length);

            return new MyString(result.ToString().ToCharArray());
        }
    }

 /*   class Program
    {
        public static void Main(string[] args)
        {
            MyString MyString1 = new MyString("32".ToCharArray());
            MyString MyString2 = new MyString("3, 4, 1".ToCharArray());
            MyString result = MyString1 + MyString2;
            Console.WriteLine("Первая строка: " + MyString1);
            Console.WriteLine("Вторая строка: " + MyString2);
            Console.WriteLine("Результат сложения: " + result);
            Console.ReadLine();
        }
    }*/
}







