using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessTrip
{
    public class BusinessTrip
    {
        private string name;
        private string lastName;



        public string NameOfEmploy
        {
            get { return name; }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Невалидна стойност");
                }
                name = value;
            }

        }
        public string LastNameOfEmploy
        {
            get { return lastName; }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Невалидна стойност");
                }
                lastName = value;
            }


        }
        public string Travel { get; set; }
        public double SumForTr { get; set; }
        public int CountDay { get; set; }
        public BusinessTrip(string name, string lastName, string travel, double sum, int countDat)
        {
            NameOfEmploy = name;
            LastNameOfEmploy = lastName;
            Travel = travel;
            SumForTr = sum;
            CountDay = countDat;
        }
        public double TotalSum()
        {
            return SumForTr+(CountDay*40);
        } 
        public override string ToString()
        {
            return $"{NameOfEmploy} {LastNameOfEmploy} will go {Travel} with {SumForTr:F2}" +
                $" for {CountDay}. Total sum is {TotalSum():f2}";
        }
    }
}
