using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSForm1
{
    public class Auditorium
    {
        private int _capacity;
        private int _morningTickets;
        private int _afternoonTickets;
        private int _eveningTickets;
        public Auditorium(int capacity, int morningTickets, int afternoonTickets, int eveningTickets)
        {
            _capacity = capacity;
            _morningTickets = morningTickets;
            _afternoonTickets = afternoonTickets;
            _eveningTickets = eveningTickets;
        }
        public int MorningTix { get { return _morningTickets; } set { _morningTickets = value; } }
        public int AfternoonTix { get { return _afternoonTickets; } set { _afternoonTickets = value; } }
        public int EveningTix { get { return _eveningTickets; } set { _eveningTickets = value; } }
        public int Capacity { get { return _capacity; } }
    }
}
