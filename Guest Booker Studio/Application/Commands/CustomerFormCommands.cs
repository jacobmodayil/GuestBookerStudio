using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Guest_Booker_Studio.Commands
{
    public class CustomerFormCommands : RoutedUICommand
    {
        private static RoutedUICommand _closeTab;
        private static RoutedUICommand _addNewCustomer;
        private static RoutedUICommand _delCustomer;
        private static RoutedUICommand _viewAllCustomers;
        static CustomerFormCommands()
        {
            _closeTab = new RoutedUICommand("closeTab", "_closeTab", typeof(CustomerFormCommands));
            _addNewCustomer = new RoutedUICommand("addNewCustomer", "addNewCustomer", typeof(CustomerFormCommands));
            _delCustomer = new RoutedUICommand("deleteCustomer", "deleteCustomer", typeof(CustomerFormCommands));
            _viewAllCustomers = new RoutedUICommand("viewAllCustomers", "viewAllCustomers", typeof(CustomerFormCommands));
        }
        public static RoutedUICommand CloseTab
        {
            get
            {
                return _closeTab;
            }
        }
        public static RoutedUICommand AddNewCustomer
        {
            get
            {
                return _addNewCustomer;
            }
        }
        public static RoutedUICommand DeleteCustomer
        {
            get
            {
                return _delCustomer;
            }
        }
        public static RoutedUICommand ViewAllCustomers
        {
            get
            {
                return _viewAllCustomers;
            }
        }

    }
}
