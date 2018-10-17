using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Wood : Obstacle
    {
        public override string Move()
       => "Дерево: мешает перемещаться";
    }
}
