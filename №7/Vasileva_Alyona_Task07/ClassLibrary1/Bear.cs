using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Bear : Monster
    {
        public override string Move()
        => "Медведь: исчезает при встрече с героем, наносит урон 3";
    }
}
