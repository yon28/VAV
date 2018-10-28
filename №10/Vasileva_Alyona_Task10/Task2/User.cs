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
   
    public class User
    {

        private string lastName;
        public User(string lastName)
        {
            LastName = lastName;
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

        public string SayHi(User user, DateTime time)
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
            Console.WriteLine(string.Format(str + user.LastName +", - сказал " + LastName));
            return string.Format(str + user.LastName + ", - сказал " + LastName);
        }

        public string SayGoodbye(User user)
        { 
            Console.WriteLine(string.Format("До свидания, " + user.LastName + ", - сказал " + LastName));
            return string.Format("До свидания, " + user.LastName + ", - сказал " + LastName);
        }

     
    }
}
