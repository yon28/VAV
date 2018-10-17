using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Personage: Obj // Могут передвигаться по полю, но обходят препятствия
    {
        int dx;
        int dy;

        public abstract class Obstacle : Obj
        { }
        /* {
             X = X + dx;
             Y = Y + dy;
         }*/


    }
}
