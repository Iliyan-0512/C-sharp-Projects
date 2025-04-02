using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _03._24._2025
{
    internal class Employee
    {
        private string _name;
        private string _lastName;
        private string _EGN;
        private string _Dlushnost;
        private int _salary;
        public string Name
        {
            get => _name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can't be empty.");

                }
                _name = value;
            }
        }
        public string LastName
        {
            get => _lastName;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can't be empty.");

                }
                _lastName = value;
            }
        }
        public string EGN
        {
            get => _EGN;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can't be empty.");
                }
                _EGN = value;
            }
        }
        public string Dlushnost
        {
            get => _Dlushnost;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can't be empty");
                }
                _Dlushnost = value;
            }

        }
        public int Salary
        {
            get => _salary;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Salary can't be 0 or less");
                }
                _salary = value;
            }
        }
        public Employee(string name, string lastName, string egn, int salary, string dlushnost)
        {
            _salary = salary;
            _name = name;
            _lastName = lastName;
            _Dlushnost= dlushnost;
            _EGN = egn;
        }
        public override string ToString()
        {
            return $"{Name} {LastName} with {EGN} has {Salary} is {Dlushnost}";
        }

    }
}
