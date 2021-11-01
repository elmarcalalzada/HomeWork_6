using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_6
{
    class Product
    {
        public Product(int No, string name, double price, int count)
        {
            this.No = No;
            this.Name = name;
            this.Price = price;
            this.Count = count;
        }
        public int No;
        public string Name;
        public double Price;
        public int Count;
    }
}