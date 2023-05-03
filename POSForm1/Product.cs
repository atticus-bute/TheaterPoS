using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSForm1
{
    public class Product
    {
        public int EmployeeId { get; set; }
        private double _price;
        private string _name;
        public Product(double price, string name)
        {
            _price = price;
            _name = name;
        }
        public override string ToString()
        {
            return $"{_name}, {_price:c}";
        }
        public double Price { get { return _price; } set { _price = value; } }
        public string Name { get { return _name;} set { _name = value; } }
    }
}
