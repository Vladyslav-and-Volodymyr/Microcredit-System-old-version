using Microcredit_System.Persons.ClientStuff;
using Microcredit_System.Persons.Identification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microcredit_System.Persons.EmployeeStuff
{
    class Employee : IPerson
    {
        public void printReceipt(Debt debt)
        {
        }

        public bool BorrowMoney(Client client, double amount)
        {
            // TODO: implement
            return false;
        }

        public void ReturnMoney(Client client, double amount)
        {
            // TODO: implement
        }

        private String _login;
        private String _password;
        private ID_Card _passport;

        public string Login { get => _login; set => _login = value; }
        public string Password { get => _password; set => _password = value; }
        internal ID_Card Passport { get => _passport; set => _passport = value; }

        // TODO: add variables

        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Pesel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        ID_Card IPerson.Passport { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
