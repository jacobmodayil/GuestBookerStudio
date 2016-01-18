using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Guest_Booker_Studio.Commands
{
    public class TreeItemDoubleClick: RoutedUICommand
    {
         private static RoutedUICommand _TreeViewDoubleClick;

        static TreeItemDoubleClick()
        {
            _TreeViewDoubleClick = new RoutedUICommand("TreeViewDoubleClick", "TreeViewDoubleClick", typeof(TreeItemDoubleClick));
        }

        public static RoutedUICommand TreeViewDoubleClick
        {
            get
            {
                return _TreeViewDoubleClick;
            }
        }
    }
    public class CustomerExplorerCommands: RoutedCommand
    {
        private static RoutedUICommand _loadCustomerExplorer;
        static CustomerExplorerCommands()
        {
            _loadCustomerExplorer = new RoutedUICommand("LoadCustomerExplorer", "LoadCustomerExplorer", typeof(CustomerExplorerCommands));
        }

        public static RoutedUICommand LoadCustomerExplorer
        {
            get
            {
                return _loadCustomerExplorer;
            }
        }

    }
}
