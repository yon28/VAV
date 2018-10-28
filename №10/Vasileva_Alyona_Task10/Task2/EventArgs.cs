using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /* Вызов процедуры приветствия/прощания производить через групповые делегаты. 
       Факт прихода и ухода сотрудника отслеживается через генерируемые им события. 
       Событие прихода описывается делегатом, передающим в числе параметров 
        наследника EventArgs, явно содержащего поле с временем прихода.*/
    public class EventArgs : User
    {
        public EventArgs(string lastName, DateTime arrival) : base(lastName)
        {
            Arrival = arrival;
        }
        public DateTime Arrival
        {
            get;
            set;
        }
        public event ECome Come;
        public delegate string ECome(EventArgs user, DateTime arrival);
        public void OnCome()
        {
            if (Come != null)
            {
                Come(this, DateTime.Now);
            }
        }
        public event ELeft Left;
        public delegate string ELeft(EventArgs user);
        public void OnLeft()
        {
            if (Left != null)
            {
                Left(this);
            }
        }
    }
}
