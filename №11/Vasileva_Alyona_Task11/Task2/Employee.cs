using System;


namespace Task2
{

    class Employee : User
    {
        //Поля:
        public string experience, position;

        //Свойства:
        public string Experience
        {
            get => experience;
            set
            {
                if (value != String.Empty)
                {
                    experience = value;
                }
                else
                {
                    throw new Exception("Пустые значения недопустимы!");
                }
            }
        }

        public string Position
        {
            get => position;
            set
            {
                if (value != String.Empty)
                {
                    position = value;
                }
                else
                {
                    throw new Exception("Пустые значения недопустимы!");
                }
            }
        }


        //Методы:

        public Employee(string lastName, string firstName, string middleName, DateTime birth, byte age, string experience, string position)
            : base(lastName, firstName, middleName, birth)
        {
            Experience = experience;
            Position = position;
        }

        public override string ToString()
       => string.Format("Фамилия: {0},  Имя: {1},  Отчество: {2},  Дата Рождения: {3},  Возраст: {4}, Стаж работы: {5}, Должность: {6}",
                 LastName, FirstName, MiddleName, Birth, Age, Experience, Position);
    }
   
}