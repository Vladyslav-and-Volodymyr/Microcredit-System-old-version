﻿using MaterialDesignThemes.Wpf;
using Microcredit_System.ControlSystem.Persons.EmployeeStuff;
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
        private ControlSystem.ControlSystem control;
        private Employee employee;

        internal ControlWindow(ControlSystem.ControlSystem control, Employee employee)
        {
            InitializeComponent();

            this.control = control;
            this.employee = employee;

            var menuRegister = new List<SubItem>();
            menuRegister.Add(new SubItem("Customer", new UserControlCustomers()));
            menuRegister.Add(new SubItem("Providers", new UserControlProviders()));
            menuRegister.Add(new SubItem("Employees"));
            menuRegister.Add(new SubItem("Products"));

            var item1 = new ItemMenu("Register", menuRegister, PackIconKind.Register);

            var menuClient = new List<SubItem>();
            menuClient.Add(new SubItem("Client List"));
            menuClient.Add(new SubItem("Add new Client"));
            menuClient.Add(new SubItem("Debtors"));

            var item3 = new ItemMenu("Clients", menuClient, PackIconKind.Person);

            var menuFinances = new List<SubItem>();
            menuFinances.Add(new SubItem("Current balance"));
            menuFinances.Add(new SubItem("Exchange", new UserControlExchanges()));

            var item4 = new ItemMenu("Finances", menuFinances, PackIconKind.ScaleBalance);

            /// var dash = new List<SubItem>(); 
            /// var item0 = new ItemMenu("Dashboard", new List<SubItem>(), PackIconKind.ViewDashboard);

            // Menu.Children.Add(new UserControlMenuItem(item0));

            if (employee is Admin)
            {
                Menu.Children.Add(new UserControlMenuItem(item1, this));
                Menu.Children.Add(new UserControlMenuItem(item3, this));
            }
            Menu.Children.Add(new UserControlMenuItem(item4, this));
        }

        internal void SwitchScreen(object sender)
        {
            var screen = ((UserControl) sender);

            if (screen != null)
            {
                StackPanelMain.Children.Clear();
                StackPanelMain.Children.Add(screen);

            }
        }

        private void Button_LogOut_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }
    }
}
