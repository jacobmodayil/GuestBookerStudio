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
using System.Windows.Threading;
using System.Threading;
using Guest_Booker_Studio.ViewModel;
using Guest_Booker_Studio.Model;
using Guest_Booker_Studio.Presentation.Controls;
using Guest_Booker_Studio.ValidationCheck;

namespace Guest_Booker_Studio.Presentation.Pages.Entity.Contact
{
    /// <summary>
    /// Interaction logic for AddNewContact.xaml
    /// </summary>
    public partial class AddNewContact : UserControl
    {
        public AddNewContact()
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

        private void btnSaveContact_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = new ContactFormViewModel();
            viewModel.ContactName = txtName.Text;
            viewModel.Organization = txtOrganization.Text;
            viewModel.Designation = txtDesignation.Text;
            viewModel.DateOfBirth = DateTime.Parse(txtBirthDate.Text != "" ? txtBirthDate.Text : "12/07/1990");
            viewModel.IsSpecial = Convert.ToBoolean(chkIsSpecial.IsChecked);
            viewModel.IsIndian = Convert.ToBoolean(chkIsIndian.IsChecked);
            viewModel.IsOther = Convert.ToBoolean(chkIsOther.IsChecked);
            viewModel.PhoneNumber = txtPhoneNumber.Text; ;
            viewModel.Address = txtAddress.Text;
            viewModel.Email = txtEmail.Text;
            var chkValidation = new Validations();
            var result = chkValidation.PerformMandatoryContactValidations(viewModel);
            if (result.Result == "Success")
            {
                StudioRepository.InsertContact(viewModel);
                var msgbox = new BookerStudioMessageBox("Added contact successfully", "A new contact was added successfully!", GuestBookerMessageBoxButtons.Ok, IconType.Attention);
                msgbox.ShowDialog();
                MainWindow.MainStatusBarMessage.Text = "A new contact was added successfully.";
            }
            else if (result.Result == "Failure")
            {
                var msgBox = new BookerStudioMessageBox(result.TypeOfException, result.Message, GuestBookerMessageBoxButtons.Ok, IconType.Attention);
                msgBox.ShowDialog();
            }
        }

        private void FormFadeOut_Completed(object sender, EventArgs e)
        {
            HideHandlerDialog();
        }
    }
}
