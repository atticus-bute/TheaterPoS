using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSForm1
{
    public class Sale
    {
        public Sale() { }
        public Sale(double cost, string employee)
        {
            Cost= cost;
            Employee= employee;
        }
        public override string ToString()
        {
            return $"Sale # {SaleId}, {Cost:c}, {Employee}";
        }
        public int SaleId { get; set; }
        public double Cost { get; set; }
        public string Employee { get; set; }
        //private List<Product> _cart;
        //private double _subtotal;
        //private double _tax;
        //private double _total;
        //private const double TAX_RATE = .09;
        //private Employee _employee;
        //public int SaleID { get; set; }
        //public Sale() { }
        //public Sale(List<Product> cart, Employee employee)
        //{
        //    _cart = cart;
        //    _subtotal = 0;
        //    foreach (Product product in _cart)
        //    {
        //        _subtotal += product.Price;
        //    }
        //    _tax = _subtotal * TAX_RATE;
        //    _total = _subtotal + _tax;
        //    _employee = employee;
        //}
        //public override string ToString()
        //{
        //    return $"{_total:c}, {_employee.Name}";
        //}
        //public List<Product> Cart { get { return _cart; } set { _cart = value; } }
        //public double Subtotal { get { return _subtotal; } set { _subtotal = value; } }
        //public double Tax { get { return _tax; } set { _tax = value; } }
        //public double Total { get { return _total;} set { _total = value; } }
        //public Employee Employee { get { return _employee;} set { _employee = value; } }
    }
}
