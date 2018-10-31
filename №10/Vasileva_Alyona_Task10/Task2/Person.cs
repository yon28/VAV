using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{

    /*Объекты класса Person, обладающие полем имя (Name). 
   1. Приветствие сотрудника, пришедшего на работу 
   (принимает в качестве аргументов объект сотрудника и время его прихода)
   2. Прощание с ним (принимает только объект сотрудника)*/

    /* Вызов процедуры приветствия/прощания производить через групповые делегаты. 
    Факт прихода и ухода сотрудника отслеживается через генерируемые им события. 
    Событие прихода описывается делегатом, передающим в числе параметров 
     наследника EventArgs, явно содержащего поле с временем прихода.*/

    public class Person: EventArgs
    {
        public event ECome Come;
        public delegate string ECome(Person user, DateTime Arrival);
        public void OnCome()
        {
            if (Come != null)
            {
                Come?.Invoke(this, DateTime.Now);
            }
        }
        public event ELeft Left;
        public delegate string ELeft(Person user);
        public void OnLeft()
        {
            if (Left != null)
            {
                Left?.Invoke(this);
            }
        }

        private string lastName;
        public Person(string lastName, DateTime arrival)
        {
            LastName = lastName;
            Arrival = arrival;
        }
        public DateTime Arrival
        {
            get;
            set;
        }
 
        public string LastName
        {
            get
            {
                return lastName;
            }
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

        public string SayHi(Person user, DateTime time)
        {
            string str;
            if (time.Hour < 12)
            { str = "Доброе утро, "; }
            else if (time.Hour < 17)
            {
                str = "Добрый день, ";
            }
            else
            {
                str = "Добрый вечер, ";
            }
            Console.WriteLine(string.Format(str + user.LastName + ", - сказал " + LastName));
            return string.Format(str + user.LastName + ", - сказал " + LastName);
        }

        public string SayGoodbye(Person user)
        {
            Console.WriteLine(string.Format("До свидания, " + user.LastName + ", - сказал " + LastName));
            return string.Format("До свидания, " + user.LastName + ", - сказал " + LastName);
        }
    }
}
