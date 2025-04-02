using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._24._2025
{
    internal class Product
    {
        public string Name { get; private set; }
        public int Number { get; set; }
        public int Prices { get; set; }
        public string ExpiryDate { get; set; }
        public Product(string name, int number, int prices, string expityDate)
        {
            Name = name;
            Number = number;
            Prices = prices;
            ExpiryDate = expityDate;

        }
        public override string ToString()
        {
            return $"{Name},{Number},{Prices},{ExpiryDate}";
        }

    }
}
//Дефинирайте клас Product със следните характеристики:
//наименование; брой; цена; производител; срок на годност в
//месеци.
// Класът трябва да предоставя възможност за валидиране на
//данните;
// Наименованието на продукта не трябва да може да се
//променя извън класа;
// Добавете конструктор с параметри и метод, който да
//изчислява общата сума на всички продукти;
// Предефинирайте метода ToString() така, че да извежда
//всички данни за продукта, разделени със запетая и
//интервал;
//Създайте примерна програма, която демонстрира използването
//на класа.

