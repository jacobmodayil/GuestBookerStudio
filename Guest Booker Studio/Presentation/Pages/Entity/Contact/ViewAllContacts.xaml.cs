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
using Guest_Booker_Studio.Model;
using System.Windows.Threading;
using System.Threading;
using ExcelGeneration;
using Guest_Booker_Studio.Presentation.Controls;

namespace Guest_Booker_Studio.Presentation.Pages.Entity.Contact
{
    /// <summary>
    /// Interaction logic for ViewAllContacts.xaml
    /// </summary>
    public partial class ViewAllContacts : UserControl
    {
        public List<ECCContact> currentDataContext{get;set;}
        public ViewAllContacts()
        {
            InitializeComponent();
            DataBind();
        }
        private void DataBind()
        {
            var CustomerList = StudioRepository.GetAllContacts();
            currentDataContext = CustomerList.ToList();
            datagrdViewContact.ItemsSource = CustomerList;
        }
        private bool _hideRequest = false;
        private bool _result = false;
        public void SetParent(Grid parent)
        {

            parent.Children.Add(this);
            ShowHandlerDialog(this);
            parent.Children.Remove(this);

        }

        public bool ShowHandlerDialog(UIElement parent)
        {
            Visibility = Visibility.Visible;
            _hideRequest = false;
            while (!_hideRequest)
            {
                // HACK: Stop the thread if the application is about to close
                if (this.Dispatcher.HasShutdownStarted ||
                    this.Dispatcher.HasShutdownFinished)
                {
                    break;
                }
                // HACK: Simulate "DoEvents"
                this.Dispatcher.Invoke(
                    DispatcherPriority.Background,
                    new ThreadStart(delegate { }));
                Thread.Sleep(20);
            }
            return _result;
        }

        private void HideHandlerDialog()
        {
            _hideRequest = true;
            Visibility = Visibility.Hidden;
        }

        private void cmdCancelButton_Click(object sender, RoutedEventArgs e)
        {
            FormFadeOut.Begin();
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {

            var CustomerList = StudioRepository.GetAllContacts();
            currentDataContext = CustomerList.ToList();
            datagrdViewContact.ItemsSource = CustomerList;
        }

        private void Export_Click(object sender, RoutedEventArgs e)
        {
            if (currentDataContext == null)
            {
                var msgbox = new BookerStudioMessageBox("Attention", "Please specify records to be exported either by clicking on Refresh or Searching for specific customers!", GuestBookerMessageBoxButtons.Ok, iconType: IconType.Attention);
                msgbox.ShowDialog();
            }
            else
            {
                new GetGridValues().PrepareContactData(currentDataContext);
                MainWindow.MainStatusBarMessage.Text = "The data was exported successfully.";
            }
            
        }

        private void FormFadeOut_Completed(object sender, EventArgs e)
        {
            HideHandlerDialog();
        }

    }
}
