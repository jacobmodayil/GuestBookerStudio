using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AvalonDock;
using Guest_Booker_Studio.ViewModel;
using Guest_Booker_Studio.Model;
using Guest_Booker_Studio;
using Guest_Booker_Studio.Commands;

namespace Guest_Booker_Studio.Presentation.Controls
{
    /// <summary>
    /// Interaction logic for CustomerExplorerControl.xaml
    /// </summary>
    public partial class CustomerExplorerControl : DockableContent
    {
        private int TreeMatchCount { get; set; }
        private TreeViewItem SelectedItem;
        private MouseBinding CustomerDoubleClick;
        private MouseBinding ContactDoubleClick;
        public CustomerExplorerControl()
        {
            InitializeComponent();
            BindCommands();
            CustomerDoubleClick = new MouseBinding();
            CustomerDoubleClick.MouseAction = MouseAction.LeftDoubleClick;
            CustomerDoubleClick.Command = TreeItemDoubleClick.TreeViewDoubleClick;
            CustomerDoubleClick.CommandParameter = WindowOpenMode.EditCustomer;

            ContactDoubleClick = new MouseBinding();
            ContactDoubleClick.MouseAction = MouseAction.LeftDoubleClick;
            ContactDoubleClick.Command = TreeItemDoubleClick.TreeViewDoubleClick;
            ContactDoubleClick.CommandParameter = WindowOpenMode.EditContact;

        }
        private void BindCommands()
        {
            CommandBinding loadCustomerExplorer = new CommandBinding(CustomerExplorerCommands.LoadCustomerExplorer);
            loadCustomerExplorer.Executed += new ExecutedRoutedEventHandler(LoadCustomerExplorer_Executed);
            this.CommandBindings.Add(loadCustomerExplorer);
        }
        public void LoadCustomerExplorer_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            DataBind();
        }
        public void DataBind()
        {
            var customerViewModel = StudioRepository.GetAllCustomers();
            var contactViewModel = StudioRepository.GetAllContacts();
            BuildCustomerTree(customerViewModel,contactViewModel);
        }
        private void BuildCustomerTree(IList<ECCMaster> viewModel,IList<ECCContact> contactViewModel)
        {
            CustomersTreeItem.Items.Clear();
            ContactsTreeItems.Items.Clear();
            foreach (var item in viewModel)
            {
                var customerItem = new TreeViewItem();
                customerItem.Header = item.Organization;
                customerItem.InputBindings.Add(CustomerDoubleClick);
                CustomersTreeItem.Items.Add(customerItem);
            }
            foreach (var item in contactViewModel)
            {
                var contactItem = new TreeViewItem();
                contactItem.Header = item.Name;
                contactItem.InputBindings.Add(ContactDoubleClick);
                ContactsTreeItems.Items.Add(contactItem);
            }
        }
        private void txtSearchTree_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtSearchTree.Text == "SearchTree:")
            {
                txtSearchTree.Text = "";
            }
        }

        private void txtSearchTree_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtSearchTree.Text == "")
            {
                txtSearchTree.Text = "SearchTree:";
            }

        }

        //This method highlights the tree item with the text entered in the textBox.
        private void txtSearchTree_TextChanged(object sender, TextChangedEventArgs e)
        {

            TreeMatchCount = 0;
            if (txtSearchTree.Text != "SearchTree:" && txtSearchTree.Text != "")
            {
                foreach (var childItem in CustomerTree.Items)
                {

                    if (childItem is TreeViewItem)
                    {
                        var item = (TreeViewItem)childItem;
                        item.IsExpanded = false;
                        if (item.IsVisible)
                        {
                            foreach (TreeViewItem treeViewItem in item.Items)
                            {
                                treeViewItem.IsExpanded = false;
                                treeViewItem.Background = new SolidColorBrush(Colors.Transparent);
                                if (Convert.ToString(treeViewItem.Header).IndexOf(txtSearchTree.Text, 0, StringComparison.CurrentCultureIgnoreCase) != -1)
                                {
                                    treeViewItem.Background = new SolidColorBrush(Colors.Yellow);
                                    item.ExpandSubtree();
                                    TreeMatchCount++;
                                    SelectedItem = treeViewItem;
                                }
                                //if (treeViewItem.Items.Count > 0)
                                //{
                                //    SearchHierarchialTree(treeViewItem);
                                //}
                            }
                        }
                    }
                }

            }
            if (txtSearchTree.Text == "" || TreeMatchCount == 0)
            {
                if (CustomerTree != null)
                {
                    foreach (var item in CustomerTree.Items)
                    {
                        if (item is TreeViewItem)
                        {
                            ((TreeViewItem)item).IsExpanded = false;
                        }
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            DataBind();
        }

        private void txtSearchTree_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && TreeMatchCount == 1)
            {
                if (SelectedItem.Parent == CustomersTreeItem)
                {
                    SelectedItem.IsSelected = true;
                    TreeItemDoubleClick.TreeViewDoubleClick.Execute(WindowOpenMode.EditCustomer, SelectedItem);
                    SelectedItem.IsSelected = false;
                    SelectedItem.Background = new SolidColorBrush(Colors.Transparent);
                }
                else if (SelectedItem.Parent == ContactsTreeItems)
                {
                    SelectedItem.IsSelected = true;
                    TreeItemDoubleClick.TreeViewDoubleClick.Execute(WindowOpenMode.EditContact, SelectedItem);
                    SelectedItem.IsSelected = false;
                    SelectedItem.Background = new SolidColorBrush(Colors.Transparent);
                }
            }
        }

        
        

    }
}
