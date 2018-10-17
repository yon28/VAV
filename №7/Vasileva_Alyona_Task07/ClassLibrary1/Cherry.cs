using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Cherry : Bonus
    {
        public override string Move()
        => "Вишня: исчезает при встрече с героем, поднимает характеристики на 1";
    }
}
