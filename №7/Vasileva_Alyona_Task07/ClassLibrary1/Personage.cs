using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Personage: Obj // Могут передвигаться по полю, но обходят препятствия
    {
        int MoveX(int dx) => X + dx;
        int MoveY(int dy) => Y + dy;

    }
}
