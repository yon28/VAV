using System;
namespace Entities
{
	public class Employee : IEquatable<Employee>
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
        public string Rewards
        {
            get;
            set;
        }


        private DateTime birth;
        public DateTime Birth
        {
            get => birth;
            set
            {
                if ((DateTime.Now.Year > birth.Year)|| (DateTime.Now.Month > birth.Month)|| (DateTime.Now.Day > birth.Day))
                {
                    birth = value;
                }
                else
                {
                    throw new Exception("Дата рождения не может быть в будущем!");
                }
            }
        }
        public int ID
        {
            get => Math.Abs(GetHashCode());
        }
        public byte Age
        {
            get => Convert.ToByte(DateTime.Now.Year - Birth.Year);
        }

        public bool Equals(Employee other)
        {
            if (other == null)
                return false;
            if ((LastName == other.LastName) && (FirstName == other.FirstName) && (Birth == other.Birth))
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

        public override int GetHashCode()
        {
            return this.LastName.GetHashCode()+ this.FirstName.GetHashCode()+this.Birth.GetHashCode();
        }
    }
}
