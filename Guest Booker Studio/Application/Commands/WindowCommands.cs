using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Guest_Booker_Studio.Commands
{
    class WindowCommands
    {
        private static RoutedUICommand _ShowCustomerExplorer;
        private static RoutedUICommand _ShowStartPage;
        static WindowCommands()
        {
            _ShowCustomerExplorer = new RoutedUICommand("ShowCustomerExplorer", "ShowCustomerExplorer", typeof(WindowCommands));
            _ShowStartPage = new RoutedUICommand("ShowStartPage", "ShowStartPage", typeof(WindowCommands));

        }
        public static RoutedCommand ShowCustomerExplorer
        {
            get
            {
                return _ShowCustomerExplorer;
            }
        }
        public static RoutedCommand ShowStartPage
        {
            get
            {
                return _ShowStartPage;
            }
        }
    }
}
