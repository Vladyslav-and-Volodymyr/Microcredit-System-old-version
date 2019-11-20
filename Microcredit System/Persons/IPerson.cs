using Microcredit_System.Persons.Identification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microcredit_System.Persons
{
    interface IPerson
    {
        String FirstName
        {
            get;
            set;
        }

        String LastName
        {
            get;
            set;
        }

        String Pesel
        {
            get;
            set;
        }

        ID_Card Passport
        {
            get;
            set;
        }
    }
}
