using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GetCurrencyRates
{
    /// <summary>
    /// Information about currency according to Narodowy Bank Polski
    /// </summary>
    [DataContract]
    public class CurrencyInformation
    {
        [DataMember]
        private String _table;
        [DataMember]
        private String _currency;
        [DataMember]
        private String _code;
        [DataMember]
        private RatesInformation[] _rates;

        public string Table { get => _table; set => _table = value; }
        public string Currency { get => _currency; set => _currency = value; }
        public string Code { get => _code; set => _code = value; }
        public RatesInformation[] Rates { get => _rates; set => _rates = value; }

        [DataContract]
        public class RatesInformation
        {
            [DataMember]
            private double _mid;
            [DataMember]
            private string _no;
            [DataMember]
            private string _effectiveDate;

            public double Mid { get => _mid; set => _mid = value; }
            public string No { get => _no; set => _no = value; }
            public string EffectiveDate { get => _effectiveDate; set => _effectiveDate = value; }
        }
    }
}
