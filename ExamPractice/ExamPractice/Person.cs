using System;
using System.Collections.Generic;
using System.Text;

namespace ExamPractice
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
       

        public static int Count { get; set; }

        public Person()
        {
            Count++;
        }

        public Person(string first, string last, string city)
        {
            FirstName = first;
            LastName = last;
            City = city;
            Count++;
        }

        public override string ToString()
        {
            return string.Format($"{FirstName} {LastName} {City} ");
        }

        public bool Equals(Person other)
        {
            if(this.LastName.Equals(other.LastName))
            {
                return this.City == other.City;
            }
            else
            {
                return false;
            }
            return false;
        }

        public int CompareTo(Person other)
        {
            if (this.LastName.Equals(other.LastName))
            {
                if (this.FirstName.Equals(other.FirstName))
                {
                    return this.City.CompareTo(other.City);
                }
                else
                {
                    return this.FirstName.CompareTo(other.FirstName);
                }
            }
            return this.LastName.CompareTo(other.LastName);
        }
        
    }
}
