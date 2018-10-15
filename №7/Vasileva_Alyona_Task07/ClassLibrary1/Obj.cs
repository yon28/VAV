using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Obj // Где объект находится, виден или нет.
    {
        public bool Visible
        {
            get;
            set;         
        }
        bool ValidateValue(int value, out int b)
        {
            if (value > 0)
            {
                b = value;
                return true;
            }
            else
            {
                throw new Exception("Неположительные значения недопустимы!");
            }
        }
        int x;
        public int X
        {
            get => x;
            private set
            {
                //if (value <Field.Width) 
                {
                    ValidateValue(value, out x);
                }
            }
        }
        int y;
        public int Y
        {
            get => y;
            private set
            {
                //if (value <Field.Height) 
                {
                    ValidateValue(value, out y);
                }
            }
        }

    }
}
