using System;
using System.Collections.Generic;

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
        //    public List<Reward> Rewards { get;set; }
        public List<Reward> Rewards
        {
            get;
            set;
        }

        public List<int> RewardsIdList
        {
            get
            {
                var rewardsIdList = new List<int>();
                foreach (var reward in Rewards)
                {
                    rewardsIdList.Add(reward.ID);
                }
                return rewardsIdList;
            }
        }

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
        public int ID
        {
            get;
            set;
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

            Employee employeeObj = obj as Employee;
            if (employeeObj == null)
                return false;
            else
                return Equals(employeeObj);
        }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (((object)employee1) == null || ((object)employee2) == null)
                return Object.Equals(employee1, employee2);

            return employee1.Equals(employee2);
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }

        public override int GetHashCode()
        {
            return this.LastName.GetHashCode() + this.FirstName.GetHashCode() + this.Birth.GetHashCode();
        }
    }
}
