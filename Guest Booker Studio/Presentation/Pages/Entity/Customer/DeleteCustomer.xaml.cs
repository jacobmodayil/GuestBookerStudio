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
using System.Threading;
using System.Windows.Threading;
using Guest_Booker_Studio.Model;
using Guest_Booker_Studio.Presentation.Controls;

namespace Guest_Booker_Studio.Presentation.Pages.Entity
{
    /// <summary>
    /// Interaction logic for DeleteCustomer.xaml
    /// </summary>
    public partial class DeleteCustomer : UserControl
    {
        public DeleteCustomer()
        {
            InitializeComponent();
           
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

        private void Search_Click(object sender, RoutedEventArgs e)
        {

            if (txtName.Text == String.Empty && txtOrganization.Text == String.Empty)
            {
                var msgbox = new BookerStudioMessageBox("MandatoryFieldNotEnteredException.", "Please enter either one of the fields as either one is mandatory!", GuestBookerMessageBoxButtons.Ok, iconType: IconType.Attention);
                msgbox.ShowDialog();
            }
            else
            {
                var context = StudioRepository.GetCustomerDetails(txtOrganization.Text, txtName.Text);
                datagrdDelContact.ItemsSource = context;
            }
        }

        private void Delete_Click_1(object sender, RoutedEventArgs e)
        {
            if (datagrdDelContact.SelectedItem == null )
            {
                var msgbox = new BookerStudioMessageBox("Attention", "Please select a particular record to be deleted!", GuestBookerMessageBoxButtons.Ok, iconType: IconType.Attention);
                msgbox.ShowDialog();
            }
            else
            {
                ECCMaster model = (ECCMaster)datagrdDelContact.SelectedItem;
                StudioRepository.DeleteCustomer(model);
                var msgbox = new BookerStudioMessageBox("Deleted Customer.", "The customer was deleted successfully!", GuestBookerMessageBoxButtons.Ok, iconType: IconType.Attention);
                msgbox.ShowDialog();
                Search_Click(sender, e);
                MainWindow.MainStatusBarMessage.Text = "The customer was deleted successfully.";
            }
        }

        private void FormFadeOut_Completed(object sender, EventArgs e)
        {
            HideHandlerDialog();
        }
    }
}
