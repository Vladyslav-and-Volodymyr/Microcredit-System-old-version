using Microcredit_System.Funds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microcredit_System.Persons.ClientStuff
{
    class Debt
    {
        public void Honour()
        {
            // TODO: implement
        }

        private double _value;
        private double _interest;
        private DateTime _date;

        public double Interest { get => _interest; set => _interest = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public double Value { get => _value; set => _value = value; }
    }
}
