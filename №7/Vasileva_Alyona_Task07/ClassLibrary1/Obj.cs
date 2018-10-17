using System;

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
            protected set
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
            protected set
            {
                //if (value <Field.Height) 
                {
                    ValidateValue(value, out y);
                }
            }
        }
        int dx;
        int dy;

        public abstract string Move();




    }
}
