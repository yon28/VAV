using System;
using System.Globalization;
using System.Threading;

namespace ConsoleApp2
{

    class User
    {
        //Поля:
        public string lastName, firstName, middleName;
        private DateTime birth;
        private byte age;

        //Свойства:
        public string FirstName
        {
            get => firstName;
            set                                 
            {
                if (value != String.Empty)
                {
                    firstName = value;
                }
                else
                {
                    throw new Exception("Пустые значения недопустимы!");
                }
            }
        }

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

        public string MiddleName
        { get; set; }

        public byte Age
        {
            get => age;
            set
            {
                if (value > 0)  
                {
                    age = value;
                }
                else
                {
                    throw new Exception("Неположительные значения недопустимы!");
                }
            }
        }

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
       
        //Методы:
            
        public User(string lastName, string firstName, string middleName, DateTime birth, byte age)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            Birth = birth;
            Age = age;  
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
            users[0] = new User("Alyona", "Vasileva", "Valerevna", DateTime.Now, 35);   //
         //   users[1] = AddUser();
        //    Write(users);
         //   Console.ReadLine();
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
            DateTime birthDay = DateTime.Parse(string.Format("d", Console.ReadLine()));  //
            Console.Write("Возраст (целое количество лет):  ");
            byte age_ = Convert.ToByte(Console.ReadLine()); 
            User user = new User(lName, fName, mName, birthDay, age_);
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
