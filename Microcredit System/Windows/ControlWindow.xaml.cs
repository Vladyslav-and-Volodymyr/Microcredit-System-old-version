using MaterialDesignThemes.Wpf;
using Microcredit_System.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Microcredit_System.Windows
{
    /// <summary>
    /// Interaction logic for ControlWindow.xaml
    /// </summary>
    public partial class ControlWindow : Window
    {
        public ControlWindow()
        {
            InitializeComponent();

            var _menuClient = new List<SubItem>();
            _menuClient.Add(new SubItem("Client List"));
            _menuClient.Add(new SubItem("Add new Client", new UserControlAddClient()));
            _menuClient.Add(new SubItem("Debtors"));

            var _itemClient = new ItemMenu("Clients", _menuClient, PackIconKind.Person);


            var _menuFinances = new List<SubItem>();
            _menuFinances.Add(new SubItem("Current balance", new UserControlCurrentBalance()));
            _menuFinances.Add(new SubItem("Exchange", new UserControlExchanges()));
            _menuFinances.Add(new SubItem("Give credit", new UserControlGiveCredit()));
            _menuFinances.Add(new SubItem("Debt recovery"));

            var _itemFinances = new ItemMenu("Finances", _menuFinances, PackIconKind.ScaleBalance);

            /// var dash = new List<SubItem>(); 
            /// var item0 = new ItemMenu("Dashboard", new List<SubItem>(), PackIconKind.ViewDashboard);

            // Menu.Children.Add(new UserControlMenuItem(item0));

            Menu.Children.Add(new UserControlMenuItem(_itemClient, this));
            Menu.Children.Add(new UserControlMenuItem(_itemFinances, this));
        }

        internal void SwitchScreen(object sender)
        {
            var screen = ((UserControl)sender);

            if (screen != null)
            {
                StackPanelMain.Children.Clear();
                StackPanelMain.Children.Add(screen);

            }
        }

      
   
        private void ButtonPopUpLogout_Click(object sender, RoutedEventArgs e)
        {
            // System.Windows.Application.Current.Shutdown();
            Application.Current.Shutdown();

        }
    }
}
