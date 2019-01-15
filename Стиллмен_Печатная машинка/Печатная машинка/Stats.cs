using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Печатная_машинка
{
    class Stats
    {
        public int Total = 0;
        public int Missed = 0;
        public int Correct = 0;
        public int Accuracy = 0;
        public void Update(bool correctKey)
        {
            Total++;  //всего
            if (!correctKey)
            {
                Missed++; //пропущено
            }
            else
            {
                Correct++; //правильно
            }
            Accuracy = 100 * Correct / (Missed + Correct); // точность

        }
    }
}
