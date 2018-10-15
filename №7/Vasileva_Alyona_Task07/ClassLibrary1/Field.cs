using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Field
    {
        int width, height;
        public Field(int width, int height)
        {
            Width = width;
            Height  = height;
          
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
        public int Width
        {
            get => width;
            private set
            {
                ValidateValue(value, out width);
            }
        }


        public int Height
        {
            get => height;
            private set
            {
                ValidateValue(value, out height);
            }
        }



    }
}
