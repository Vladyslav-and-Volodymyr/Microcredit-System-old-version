using Microcredit_System.Persons.Identification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microcredit_System.Persons.EmployeeStuff
{
    class Admin : Employee
    {
        public bool PayIn(double amount)
        {
            // TODO: implement
            return false;
        }

        public bool PayOut(double amount)
        {
            // TODO: implement
            return false;
        }

        public Employee CreateEmployee(ID_Card passport, string login, string password, string firstName, string lastName, string adress)
        {
            // TODO: implement
            return null;
        }

        private String _pesel;

        public string Pesel { get => _pesel; set => _pesel = value; }
    }
}
