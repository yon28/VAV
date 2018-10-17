using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Apple : Bonus
    {
        public override string Move()
        => "Яблоко: исчезает при встрече с героем, поднимает характеристики на 1";
    }
}
