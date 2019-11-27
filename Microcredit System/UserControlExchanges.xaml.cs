using GetCurrencyRates;
using Microcredit_System.Funds.ExchangeStuff;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Microcredit_System
{
    /// <summary>
    /// Interaction logic for UserControlExchanges.xaml
    /// </summary>
    public partial class UserControlExchanges : UserControl
    {
        AvailableFundsToExchange availableFundsToExchange;

        public UserControlExchanges()
        {
            InitializeComponent();

            // read from file
            // fill textboxes

            availableFundsToExchange = ReadAvailableFunds();

            txtPln.Text = availableFundsToExchange.Pln.ToString();
            txtEur.Text = availableFundsToExchange.Eur.ToString();
            txtUsd.Text = availableFundsToExchange.Usd.ToString();

            txtEurRate.Text = CurrencyRatesInformation.getCurrencyRate("eur");
            txtUsdRate.Text = CurrencyRatesInformation.getCurrencyRate("usd");
            txtPlnRate.Text = "1";
        }

        private AvailableFundsToExchange ReadAvailableFunds()
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(AvailableFundsToExchange));
            AvailableFundsToExchange availableFundsToExchange = (AvailableFundsToExchange)jsonSerializer.ReadObject(new FileStream(fundsPath(), FileMode.Open));
            return availableFundsToExchange;
        }

        private string fundsPath()
        {
            string workingDirectory = Environment.CurrentDirectory;
            return Directory.GetParent(workingDirectory).Parent.FullName + "\\CurrentFunds.txt";
        }
    }
}
