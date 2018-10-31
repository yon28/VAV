using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> users = Create();
            var office = new Office();
            foreach (var user in users)
            {
                Console.WriteLine("[На работу пришёл " + user.LastName + "]");
                office.AddUser(user);
            }
            foreach (var user in users)
            {
                Console.WriteLine("[" + user.LastName + " ушёл домой]");
                office.LeftUser(user);
            }
            Console.ReadLine();
        }
        static List<Person> Create()
        {
            List<Person> users = new List<Person>
            {
               new Person("Александр", DateTime.Now),
               new Person("Борис", DateTime.Now),
               new Person("Валерий", DateTime.Now),
               new Person("Геннадий", DateTime.Now)
            };
            return users;
        }
    }
   
}
