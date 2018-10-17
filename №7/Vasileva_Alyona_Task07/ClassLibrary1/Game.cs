using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Game
    {
        

        public void MakeMove(Obj[] obj)
        {

            for (int i = 0; i < obj.Length; i++)
            {
                obj[i].Move();
            }
        }

    }
}


