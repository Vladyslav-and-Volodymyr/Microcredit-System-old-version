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

            var menuRegister = new List<SubItem>();
            menuRegister.Add(new SubItem("Customer"));
            menuRegister.Add(new SubItem("Providers"));
            menuRegister.Add(new SubItem("Employees"));
            menuRegister.Add(new SubItem("Products"));

            var item1 = new ItemMenu("Register", menuRegister, PackIconKind.Register);

            var menuSchedule = new List<SubItem>();
            menuSchedule.Add(new SubItem("Customer"));
            menuSchedule.Add(new SubItem("Providers"));
            menuSchedule.Add(new SubItem("Employees"));
            menuSchedule.Add(new SubItem("Products"));

            var item2 = new ItemMenu("Schedule", menuSchedule, PackIconKind.Schedule);


            var menuClient = new List<SubItem>();
            menuClient.Add(new SubItem("Client List"));
            menuClient.Add(new SubItem("Add new Client"));
            menuClient.Add(new SubItem("Debtors"));

            var item3 = new ItemMenu("Clients", menuClient, PackIconKind.Person);


            var menuFinances = new List<SubItem>();
            menuFinances.Add(new SubItem("Current balance"));
            menuFinances.Add(new SubItem("Exchange"));

            var item4 = new ItemMenu("Finances", menuFinances, PackIconKind.ScaleBalance);

            /// var dash = new List<SubItem>(); 
            /// var item0 = new ItemMenu("Dashboard", new List<SubItem>(), PackIconKind.ViewDashboard);

            // Menu.Children.Add(new UserControlMenuItem(item0));
            Menu.Children.Add(new UserControlMenuItem(item1));
            Menu.Children.Add(new UserControlMenuItem(item2));
            Menu.Children.Add(new UserControlMenuItem(item3));
            Menu.Children.Add(new UserControlMenuItem(item4));
        }
    }
}
