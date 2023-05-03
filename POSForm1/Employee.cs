using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSForm1
{
    public class Employee
    {
        private string _name;
        private string _pin;
        private bool _manager;
        public Employee(string name, string pin, bool manager)
        {
            _name = name;
            _pin = pin;
            _manager = manager;
        }
        public string Name {  get { return _name; } set { _name = value; } }
        public string Pin { get { return _pin; } set { _pin = value; } }
        public bool Manager { get { return _manager; } set { _manager = value; } }
    }
}
