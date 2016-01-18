using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Guest_Booker_Studio.Commands
{
    public class ContactFormCommands:RoutedUICommand
    {
        private static RoutedUICommand _addNewContact;
        private static RoutedUICommand _delContact;
        private static RoutedUICommand _viewAllContacts;
        static ContactFormCommands()
        {
            _addNewContact = new RoutedUICommand("AddNewContact", "AddNewContact", typeof(ContactFormCommands));
            _delContact = new RoutedUICommand("DeleteContact", "DeleteContact", typeof(ContactFormCommands));
            _viewAllContacts = new RoutedUICommand("ViewAllContacts", "ViewAllContacts", typeof(ContactFormCommands));
        }
        
        public static RoutedUICommand AddNewContact
        {
            get
            {
                return _addNewContact;
            }
        }
        public static RoutedUICommand DeleteContact
        {
            get
            {
                return _delContact;
            }
        }
        public static RoutedUICommand ViewAllContacts
        {
            get
            {
                return _viewAllContacts;
            }
        }

    }
}
