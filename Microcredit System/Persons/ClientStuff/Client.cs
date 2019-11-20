using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcredit_System.Persons.Identification;

namespace Microcredit_System.Persons.ClientStuff
{
    class Client : IPerson
    {
        public bool BorrowMoney(double amount)
        {
            // TODO: implement
            return false;
        }

        public void ReturnMoney(double amount)
        {
            // TODO: implement
        }

        public bool CheckBlackListed()
        {
            // TODO: implement
            return false;
        }

        private String _pesel;
        private Debt _debt;

        // TODO: add variables
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ID_Card Passport { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Pesel { get => _pesel; set => _pesel = value; }
        public Debt Debt { get => _debt; set => _debt = value; }
    }
}
