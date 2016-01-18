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
using Guest_Booker_Studio.Pages.Entity;
using System.Windows.Media.Animation;
using Guest_Booker_Studio.ViewModel;
using Guest_Booker_Studio.Model;
using Guest_Booker_Studio.Presentation.Pages.Entity;
using Guest_Booker_Studio.Commands;
using Guest_Booker_Studio.Presentation.Pages.Entity.Contact;

namespace Guest_Booker_Studio.Pages.Generic
{
    /// <summary>
    /// Interaction logic for StartPage.xaml
    /// </summary>
    public partial class StartPage : DocumentContent
    {
        public StartPage()
        {
            InitializeComponent();
            GetCurrentCustomer();
            GetThingsToDoList();
            BindCommands();
            txtblkVerse.Text = "\"God is good, all the time :)\"";
            txtblkVerse.FontSize = 14;
            txtblkVerse.FontStyle = FontStyles.Italic;           
        }
        public void GetCurrentCustomer()
        {
            var customersList = StudioRepository.GetCurrentCustomer();
            if (customersList.Count() == 0)
            {
                txtCurrentCustomerName.Text = "Nobody on campus today. Have a nice day.";
            }
            else
            {
              
                foreach (var customer in customersList)
                {
                    txtCurrentCustomerName.Text += customer + ". ";
                }
               
            }
        }
        private void BindCommands()
        {
            CommandBinding showAddNewCustomerDialog = new CommandBinding(CustomerFormCommands.AddNewCustomer);
            showAddNewCustomerDialog.Executed += new ExecutedRoutedEventHandler(AddNewCustomer_Executed);
            this.CommandBindings.Add(showAddNewCustomerDialog);

            CommandBinding showDelCustomerDialog = new CommandBinding(CustomerFormCommands.DeleteCustomer);
            showDelCustomerDialog.Executed += new ExecutedRoutedEventHandler(DelCustomer_Executed);
            this.CommandBindings.Add(showDelCustomerDialog);

            CommandBinding showViewAllCustomerDialog = new CommandBinding(CustomerFormCommands.ViewAllCustomers);
            showViewAllCustomerDialog.Executed += new ExecutedRoutedEventHandler(ViewAllCustomers_Executed);
            this.CommandBindings.Add(showViewAllCustomerDialog);

            CommandBinding showAddNewContactDialog = new CommandBinding(ContactFormCommands.AddNewContact);
            showAddNewContactDialog.Executed += new ExecutedRoutedEventHandler(AddNewContact_Executed);
            this.CommandBindings.Add(showAddNewContactDialog);

            CommandBinding showDeleteContactDialog = new CommandBinding(ContactFormCommands.DeleteContact);
            showDeleteContactDialog.Executed += new ExecutedRoutedEventHandler(DelContact_Executed);
            this.CommandBindings.Add(showDeleteContactDialog);

            CommandBinding showViewAllContactsDialog = new CommandBinding(ContactFormCommands.ViewAllContacts);
            showViewAllContactsDialog.Executed += new ExecutedRoutedEventHandler(ViewAllContacts_Executed);
            this.CommandBindings.Add(showViewAllContactsDialog);

        }
        private void AddNewContact_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var addContactDialog = new AddNewContact();
            addContactDialog.SetParent(StartGrid);
        }
        private void DelContact_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var delContactDialog = new DeleteContact();
            delContactDialog.SetParent(StartGrid);
        }
        private void ViewAllContacts_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var viewAllContactDialog = new ViewAllContacts();
            viewAllContactDialog.SetParent(StartGrid);
        }

        private void AddNewCustomer_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var addCustomerDialog = new AddNewCustomer();
            addCustomerDialog.SetParent(StartGrid);
        }
        private void DelCustomer_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var delCustomerDialog = new DeleteCustomer();
            delCustomerDialog.SetParent(StartGrid);
        }
        private void ViewAllCustomers_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var viewAllCustomerDialog = new ViewAllCustomers();
            viewAllCustomerDialog.SetParent(StartGrid);
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void AddCustomerLink_Click(object sender, MouseButtonEventArgs e)
        {
            var res = new AddNewCustomer();
            res.SetParent(StartGrid);
        }

        private void btnSaveThingsToDo_Click(object sender, RoutedEventArgs e)
        {
            var viewmodel = new StartPageViewModel();
            viewmodel.ThingsToDo = txtThingsToDo.Text;
            StudioRepository.SaveThingsToDo(viewmodel);
        }

        private void GetThingsToDoList()
        {
            var thingsToDoList = StudioRepository.GetThingsToDoListFromRepository();
            txtThingsToDo.DataContext = thingsToDoList;
        }

        private void btnResetThingsToDo_Click(object sender, RoutedEventArgs e)
        {
            txtThingsToDo.Text = "";
        }

        

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void LoadCustomerExplorer_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void DeleteCustomerLink_Click(object sender, MouseButtonEventArgs e)
        {
            var delWindow = new DeleteCustomer();
            delWindow.SetParent(StartGrid);
        }

        private void ViewAllCustomerLink_Click(object sender, MouseButtonEventArgs e)
        {
            var viewAllWindow = new ViewAllCustomers();
            viewAllWindow.SetParent(StartGrid);
        }

        private void DocumentContent_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CustomerFormCommands.CloseTab.Execute(((DocumentContent)sender).Title, (DocumentContent)sender);
        }

        private void AddNewContactLink_Click(object sender, MouseButtonEventArgs e)
        {
            var addContactDialog = new AddNewContact();
            addContactDialog.SetParent(StartGrid);
        }

        private void TextBlock_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {

        }

        private void DeleteContactLink_Click(object sender, MouseButtonEventArgs e)
        {
            var delContactDialog = new DeleteContact();
            delContactDialog.SetParent(StartGrid);
        }

        private void ViewAllContactLink_Click(object sender, MouseButtonEventArgs e)
        {
            var viewAllContactsDialog = new ViewAllContacts();
            viewAllContactsDialog.SetParent(StartGrid);
        }


       
    }
}
