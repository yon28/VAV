using System;
using System.Collections.Generic;

namespace Entities
{
    public class Employee : IEquatable<Employee>
    {
        public int ID
        {
            get;
            set;
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
            get => Convert.ToByte(DateTime.Now.Year - Birth.Year);
        }

        public List<Reward> Rewards
        {
            get;
            set;
        }

        string RewardsToString_ = null;
        public string RewardsToString
        {
            get
            {
                List<string> RewardsTitleList = new List<string> { };
                if (Rewards != null)
                
                {
                    for (int i = 0; i < Rewards.Count; i++)
                    {
                        RewardsTitleList.Add(Rewards[i].Title);
                    }
                    
                    if (RewardsTitleList != null)
                    {
                        RewardsToString_ = string.Join(", ", RewardsTitleList);
                    }
                }
                return RewardsToString_;
            }
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
