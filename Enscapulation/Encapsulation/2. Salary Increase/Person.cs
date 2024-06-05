using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public decimal Salary {  get; private set; }
        public Person(string firstName, string lastName, int age,decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {String.Format("{0:0.00}",this.Salary)} leva";
        }
        public void  Increasing(decimal persentage)
        {
            if(this.Age>30)
            {
                this.Salary += this.Salary * persentage/100;
            }
            else
            {
                this.Salary += this.Salary * persentage / 200;
            }
        }
    }
}
