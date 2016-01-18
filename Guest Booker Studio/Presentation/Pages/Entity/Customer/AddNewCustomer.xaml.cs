using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using System.Threading;
using Guest_Booker_Studio.ViewModel;
using System;
using Guest_Booker_Studio.Model;
using Guest_Booker_Studio.Presentation.Controls;
using Guest_Booker_Studio.Presentation;
using Guest_Booker_Studio.ValidationCheck;
using Guest_Booker_Studio.Pages.Generic;

namespace Guest_Booker_Studio.Pages.Entity
{
    /// <summary>
    /// Interaction logic for AddNewCustomer.xaml
    /// </summary>
    public partial class AddNewCustomer : UserControl
    {
        public AddNewCustomer()
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


        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void cmdSaveCustomer_Click(object sender, RoutedEventArgs e)
        {
                var viewModel = new CustomerFormViewModel();
                viewModel.Organization = txtOrganization.Text;
                viewModel.ContactName = txtName.Text;
                viewModel.NumOfPeople = Convert.ToInt32(txtNumOfPpl.Text!="" ? txtNumOfPpl.Text:"0");
                viewModel.Purpose = txtPurpose.Text;
                viewModel.PhoneNumber = txtPhoneNumber.Text;
                viewModel.FromDate = Convert.ToDateTime(txtFromDate.Text != "" ? txtFromDate.Text : DateTime.Now.ToString());
                viewModel.ToDate = Convert.ToDateTime(txtToDate.Text != "" ? txtToDate.Text : DateTime.Now.ToString());
                viewModel.IsActive = Convert.ToBoolean(chkIsActive.IsChecked);
                viewModel.IsSpecial = Convert.ToBoolean(chkIsSpecial.IsChecked);
                var validationCheck = new Validations();
                var result = validationCheck.PerformMandatoryCustomerValidations(viewModel);
                if (result.Result == "Success")
                {
                    StudioRepository.InsertCustomer(viewModel);
                    var msgBox = new BookerStudioMessageBox(result.Result, result.Message, GuestBookerMessageBoxButtons.Ok, IconType.Attention);
                    msgBox.ShowDialog();
                    MainWindow.MainStatusBarMessage.Text = "A new customer was added successfully!";
                    new StartPage().GetCurrentCustomer();
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