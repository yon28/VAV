using System;

namespace ConsoleApp2
{

    class User
    {
        public string lastName, firstName, middleName, birth, age;

        public User(string lastName, string firstName, string middleName, string birth, string age)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.middleName = middleName;
            this.birth = birth;
            this.age = age;
        }
    }

    class Program
    {
        static public void Main(string[] args)
        {
            User[] users = new User[2];
            users[0] = new User("Alyona", "Vasilva", "Valerevna", "28.05", "35");
            users[1] = AddUser();
            Write(users);
            Console.ReadLine();
        }

        static public void Write(User[] users)
        {
            Console.WriteLine("Итого: ");
            foreach (User user in users)
            {
                Console.WriteLine("Фамилия: {0},  Имя: {1},  Отчество: {2}, ", user.lastName, user.firstName, user.middleName);
                Console.WriteLine("Дата Рождения: {0},  Возраст: {1}", user.birth, user.age);
                Console.WriteLine();
            }
        }

            static public User AddUser()
        {
            Console.WriteLine("Добавь нового пользователя.");
            string lName, fName, mName, birthDay, age_;         
            Console.Write("Введи фамилию:  ");
            lName = Console.ReadLine();
            Console.Write("Введи имя:  ");
            fName = Console.ReadLine();
            Console.Write("Введи очтчество:  ");
            mName = Console.ReadLine();
            Console.Write("Дату рождения:  ");
            birthDay = Console.ReadLine();
            Console.Write("Возраст:  ");
            age_ = Console.ReadLine();
            User user = new User(lName, fName, mName, birthDay, age_);
            return user;
        }
    }
}
