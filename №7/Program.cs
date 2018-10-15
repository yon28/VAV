using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    
    public class  Canvas
    {
 
//List <figure> _figure = new  List <figure>
// вместо figure можно интерфейс, если фигура наследовалась от интерфейса

//Методы AddFigure (.Add)  и Write

    }

    abstract class Figure
    {
        public abstract string Draw();
    }

    public class Circle : Figure
    {

        public override string Draw() => " Это окружность";
    }


    public class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
