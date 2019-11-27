using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Microcredit_System.Funds.ExchangeStuff
{
    [DataContract]
    class AvailableFundsToExchange
    {
        [DataMember]
        private double _pln;
        [DataMember]
        private double _eur;
        [DataMember]
        private double _usd;

        public double Pln { get => _pln; set => _pln = value; }
        public double Eur { get => _eur; set => _eur = value; }
        public double Usd { get => _usd; set => _usd = value; }
    }
}
