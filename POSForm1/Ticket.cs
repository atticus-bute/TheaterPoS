using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSForm1
{
    public class Ticket : Product
    {
        private byte _auditoriumNo;
        public Ticket(double price, string name, byte auditoriumNo) : base(price, name)
        {
            _auditoriumNo = auditoriumNo;
        }
        public byte Auditorium { get { return _auditoriumNo; } }
    }
}
