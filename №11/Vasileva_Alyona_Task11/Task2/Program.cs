using System;

using System.Threading;

namespace Task2
{
    class Program
    {
        public static void Main(string[] args)
        {
            User[] users = new User[2];
            users[0] = new User("Alyona", "Vasileva", "Valerevna", DateTime.Now/*, 35*/);   //
            users[1] = AddUser();
            Write(users);
            Console.ReadLine();
        }

        public static User AddUser()
        {
            Console.WriteLine("Добавь нового пользователя.");
            Console.Write("Введи фамилию:  ");
            string lName = Console.ReadLine();
            Console.Write("Введи имя:  ");
            string fName = Console.ReadLine();
            Console.Write("Введи отчество:  ");
            string mName = Console.ReadLine();
            Console.Write("Дату рождения (формат ##.##.####):  ");
            var inpput = Console.ReadLine();
            DateTime birthDay = DateTime.Parse(inpput);
            /*      Console.Write("Возраст (целое количество лет):  ");
                  byte age_ = Convert.ToByte(Console.ReadLine()); */

            User user = new User(lName, fName, mName, birthDay/*, age_*/);
            return user;
        }

        public static void Write(User[] users)
        {
            Console.WriteLine("Итого: ");
            foreach (User user in users)
            {
                Console.WriteLine(user.ToString());
                Console.WriteLine();
            }
        }
    }
}
