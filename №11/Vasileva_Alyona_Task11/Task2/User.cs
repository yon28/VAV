using System;

namespace Task2
{
    class User
    {
        private string lastName;
        public string LastName
        {
            get => lastName;
            set
            {
                if (value != String.Empty)
                {
                    lastName = value;
                }
                else
                {
                    throw new Exception("Пустые значения недопустимы!");
                }
            }
        }
        private string firstName;
        public string FirstName
        {
            get => firstName;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    firstName = value;
                }
                else
                {
                    throw new Exception("Пустые значения недопустимы!");
                }
            }
        }
        public string MiddleName
        { get; set; }
        private DateTime birth;
        public DateTime Birth
        {
            get => birth;
            set
            {
                if (DateTime.Now > birth)
                {
                    birth = value;
                }
                else
                {
                    throw new Exception("Дата рождения не может быть в будущем!");
                }
            }
        }

        public byte Age
        {
            get => Convert.ToByte(DateTime.Now.Year - birth.Year);
        }

        public User(string lastName, string firstName, string middleName, DateTime birth/*, byte age*/)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            Birth = birth;
        }

        public override string ToString()
       => string.Format("Фамилия: {0},  Имя: {1},  Отчество: {2},  Дата Рождения: {3},  Возраст: {4}",
                 LastName, FirstName, MiddleName, Birth, Age);
    }
}