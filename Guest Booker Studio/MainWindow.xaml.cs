using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using Guest_Booker_Studio.Presentation.Controls;
using Guest_Booker_Studio.Presentation;
using AvalonDock;
using Guest_Booker_Studio.Pages.Generic;
using Guest_Booker_Studio.Pages.Entity;
using System.Windows.Media.Animation;
using System;
using System.Windows.Controls;
using Guest_Booker_Studio.Presentation.Pages.Entity;
using Guest_Booker_Studio.Model;
using Guest_Booker_Studio;
using Guest_Booker_Studio.Commands;
using Guest_Booker_Studio.Presentation.Pages.Entity.Contact;

namespace Guest_Booker_Studio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal List<string> tabList;
        public static TextBlock MainStatusBarMessage;
        static MainWindow()
        {

        }
        public MainWindow()
        {
            InitializeComponent();
            tabList = new List<string>();
            var startPage = new StartPage();
            AddNewTab(startPage);
            BindCommands();
            MainStatusBarMessage = mainWindowStatusBarMessage;
            MainStatusBarMessage.Text = "Loading...";
            MainStatusBarMessage.Text = "Welcome to ECC Guest Booker Studio.";
        }
        private void BindCommands()
        {
            CommandBinding treeViewDoubleClick = new CommandBinding(TreeItemDoubleClick.TreeViewDoubleClick);
            treeViewDoubleClick.Executed += new ExecutedRoutedEventHandler(treeViewDoubleClick_Executed);
            this.CommandBindings.Add(treeViewDoubleClick);

            CommandBinding closeEntityForm = new CommandBinding(CustomerFormCommands.CloseTab);
            closeEntityForm.Executed += new ExecutedRoutedEventHandler(closeEntityForm_Executed);
            this.CommandBindings.Add(closeEntityForm);
            
            CommandBinding showCustomerExplorer = new CommandBinding(WindowCommands.ShowCustomerExplorer);
            showCustomerExplorer.Executed += new ExecutedRoutedEventHandler(showCustomerExplorer_Executed);
            this.CommandBindings.Add(showCustomerExplorer);

            CommandBinding showStartPage = new CommandBinding(WindowCommands.ShowStartPage);
            showStartPage.Executed += new ExecutedRoutedEventHandler(ShowStartpage_Executed);
            this.CommandBindings.Add(showStartPage);
   
        }

        private void ShowStartpage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var startPage = new StartPage();
            AddNewTab(startPage);
        }


        void showCustomerExplorer_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (this.ApplicationExplorer != null)
            {
                this.ApplicationExplorer.Show();
            }
        }
        private void LoadCustomerExplorer_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ApplicationExplorer.DataBind();
        }
        void closeEntityForm_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            tabList.Remove(Convert.ToString(e.Parameter));
        }
        public void treeViewDoubleClick_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var windowOpenMode = WindowOpenMode.DoNothing;
            string entityName = "";

            if (e.Parameter is TreeItemParams)
            {
                windowOpenMode = (e.Parameter as TreeItemParams).windowOpenMode;
                entityName = (e.Parameter as TreeItemParams).entityName;
            }
            else if (e.OriginalSource is TreeViewItem)
            {
                windowOpenMode = (WindowOpenMode)e.Parameter;
                entityName = entityName = Convert.ToString(((TreeViewItem)e.Source).Header);
            }
            else if (e.OriginalSource is Button)
            {
                windowOpenMode = (WindowOpenMode)e.Parameter;
                entityName = Convert.ToString(((Button)e.OriginalSource).Tag);
            }
            else if (e.OriginalSource is MenuItem)
            {
                windowOpenMode = (WindowOpenMode)e.Parameter;
                entityName = Convert.ToString(((MenuItem)e.OriginalSource).Tag);
            }

            DocumentContent newForm = null;
            if (windowOpenMode == WindowOpenMode.EditCustomer)
            {
                newForm = GetCustomerForm(windowOpenMode, entityName);
                AddNewTab(newForm, newForm.Title);
            }
            else if (windowOpenMode == WindowOpenMode.EditContact)
            {
                newForm = GetContactForm(windowOpenMode, entityName);
                AddNewTab(newForm, newForm.Title);
            }
        }

        private CustomerMainPage GetCustomerForm(WindowOpenMode mode,string entityName)
        {
            var datacontext = StudioRepository.GetCustomerDetails(entityName);           
            CustomerMainPage customerForm = new CustomerMainPage(entityName);
            customerForm.DataContext = datacontext;
            return customerForm;
        }

        private ContactMainPage GetContactForm(WindowOpenMode mode, string entityName)
        {
            var datacontext = StudioRepository.GetContactDetails(entityName);
            ContactMainPage contactForm = new ContactMainPage(entityName);
            contactForm.DataContext = datacontext;
            return contactForm;
        }

        public void AddNewTab(DocumentContent newTab)
        {
            if (tabList.Contains(newTab.Title))
            {
                WorkAreaWindow.FocusTab(newTab.Title);
            }
            else
            {
                tabList.Add(newTab.Title);
                WorkAreaWindow.AddNewTab(newTab);
                WorkAreaWindow.UpdateLayout();
            }
        }

        public void AddNewTab(DocumentContent newTab, string title)
        {
            if (tabList.Contains(title))
            {
                WorkAreaWindow.FocusTab(title);
            }
            else
            {
                tabList.Add(title);
                WorkAreaWindow.AddNewTab(newTab);
                WorkAreaWindow.UpdateLayout();
            }
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            var msgBox = new BookerStudioMessageBox("Quit ECC Guest Booker Studio", "Are you sure you want to quit?", GuestBookerMessageBoxButtons.YesNo, IconType.Attention);
            msgBox.ShowDialog();
            if (msgBox.DialogResult == 0)
            {
                App.Current.Shutdown();
            }
            else
            {
                e.Handled = true;
            }
        }

        private void minimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void restoreMaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
                restoreMaximizeButton.ToolTip = "Maximize";
            }
            else if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
                restoreMaximizeButton.ToolTip = "Restore";
            }
        }

        private void Part_Title_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            DragMove();
            if (e.ClickCount > 1)
            {
                restoreMaximizeButton_Click(sender,e);
            }
        }

    }
}
