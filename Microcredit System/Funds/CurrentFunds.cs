using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microcredit_System.Funds
{
    class CurrentFunds
    {
        public static void Update(double delta)
        {
            // TODO: implement
        }

        private double _availableFunds;

        public double AvailableFunds { get => _availableFunds; set => _availableFunds = value; }
    }
}
