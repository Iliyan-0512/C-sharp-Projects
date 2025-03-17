using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_27
{
    internal class Family : Person
    {
        List<Person> family = new List<Person>();
        public void AddMember(string name, int age)
        {
            Person person = new Person();
            person.Name = name;
            person.Age = age;
            family.Add(person);
        }
        public void print()
        {
            foreach (Person person in family)
            {
                Console.WriteLine(person.ToString());
            }
           

            Console.WriteLine(family);
        }
        public void sort()
        {
            family.Sort();
        }

    }
}

