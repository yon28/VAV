using System;
using System.Text.RegularExpressions;

namespace Task2
{
    class Employee : User, IEquatable<Employee>
    {
        public string experience, position;

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

        public bool Equals(Employee other)
        {
            if (other == null)
                return false;
            if ((SSN == other.SSN) && (LastName == other.LastName) && (FirstName== other.FirstName) && (Birth == other.Birth))
                return true;
            else
                return false;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;

            Employee personObj = obj as Employee;
            if (personObj == null)
                return false;
            else
                return Equals(personObj);
        }

        public static bool operator ==(Employee person1, Employee person2)
        {
            if (((object)person1) == null || ((object)person2) == null)
                return Object.Equals(person1, person2);

            return person1.Equals(person2);
        }

        public static bool operator !=(Employee person1, Employee person2)
        {
            return !(person1 == person2);
        }
        private string uniqueSsn;
        public Employee(string lastName, string firstName, string middleName, DateTime birth, byte age, 
            string experience, string position, string ssn) : base(lastName, firstName, middleName, birth)
        {
            Experience = experience;
            Position = position;
            if (Regex.IsMatch(ssn, @"\d{9}"))
                uniqueSsn = $"{ssn.Substring(0, 3)}-{ssn.Substring(3, 2)}-{ssn.Substring(5, 4)}";
            else if (Regex.IsMatch(ssn, @"\d{3}-\d{2}-\d{4}"))
                uniqueSsn = ssn;
            else
                throw new FormatException("The social security number has an invalid format.");
        }
        public string SSN
        {
            get { return this.uniqueSsn; }
        }
        public override int GetHashCode()
        {
            return this.SSN.GetHashCode();
        }

        public override string ToString()
       => string.Format("Фамилия: {0},  Имя: {1},  Отчество: {2},  Дата Рождения: {3},  Возраст: {4}, Стаж работы: {5}, Должность: {6}",
                 LastName, FirstName, MiddleName, Birth, Age, Experience, Position);
    }
   
}