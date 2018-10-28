using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<EventArgs> users = Create();
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
        static List<EventArgs> Create()
        {
            List<EventArgs> users = new List<EventArgs>
            {
               new EventArgs("Александр", DateTime.Now),
               new EventArgs("Борис", DateTime.Now),
               new EventArgs("Валерий", DateTime.Now),
               new EventArgs("Геннадий", DateTime.Now)
            };
            return users;
        }
    }
   
}
