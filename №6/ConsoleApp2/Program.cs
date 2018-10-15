using System;
using System.Globalization;
using System.Threading;

namespace ConsoleApp2
{

    class Employee : User
    {
        //Поля:
        public string experience, position;

        //Свойства:
        public string Experience
        {
            get => experience;
            set
            {
                if (value != String.Empty)
                {
                    experience = value;
                }
                else
                {
                    throw new Exception("Пустые значения недопустимы!");
                }
            }
        }

        public string Position
        {
            get => position;
            set
            {
                if (value != String.Empty)
                {
                    position = value;
                }
                else
                {
                    throw new Exception("Пустые значения недопустимы!");
                }
            }
        }


        //Методы:

        public Employee(string lastName, string firstName, string middleName, DateTime birth, byte age, string experience, string position)
            : base(lastName, firstName, middleName, birth)
        {
            Experience = experience;
            Position = position;
        }

        public override string ToString()
       => string.Format("Фамилия: {0},  Имя: {1},  Отчество: {2},  Дата Рождения: {3},  Возраст: {4}, Стаж работы: {5}, Должность: {6}",
                 LastName, FirstName, MiddleName, Birth, Age, Experience, Position);
    }






    class User
    {
        private string lastName;
        public string LastName
        {
            get => lastName;
            set
            {
                if (value != String.Empty)
                {
                    lastName = value;
                }
                else
                {
                    throw new Exception("Пустые значения недопустимы!");
                }
            }
        }
        private string firstName;
        public string FirstName
        {
            get => firstName;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    firstName = value;
                }
                else
                {
                    throw new Exception("Пустые значения недопустимы!");
                }
            }
        }
        public string MiddleName
        { get; set; }
        private DateTime birth;
        public DateTime Birth
        {
            get => birth;
            set
            {
                if (DateTime.Now > birth)
                {
                    birth = value;
                }
                else
                {
                    throw new Exception("Дата рождения не может быть в будущем!");
                }
            }
        }
        //  private byte age;
        public byte Age
        {
            get => Convert.ToByte(DateTime.Now.Year - birth.Year);
            /*set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    throw new Exception("Неположительные значения недопустимы!");
                }
            }*/
        }
        //Методы:

        public User(string lastName, string firstName, string middleName, DateTime birth/*, byte age*/)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            Birth = birth;
            //    Age = age;  
        }

        public override string ToString()
       => string.Format("Фамилия: {0},  Имя: {1},  Отчество: {2},  Дата Рождения: {3},  Возраст: {4}",
                 LastName, FirstName, MiddleName, Birth, Age);


    }

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