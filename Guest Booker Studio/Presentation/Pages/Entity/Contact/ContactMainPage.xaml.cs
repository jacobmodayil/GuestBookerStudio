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
using Guest_Booker_Studio.ViewModel;
using Guest_Booker_Studio.Model;
using AvalonDock;
using Guest_Booker_Studio.Presentation.Controls;
using Guest_Booker_Studio.Commands;

namespace Guest_Booker_Studio.Presentation.Pages.Entity.Contact
{
    /// <summary>
    /// Interaction logic for ContactMainPage.xaml
    /// </summary>
    public partial class ContactMainPage : DocumentContent
    {
        public ContactMainPage()
        {
            InitializeComponent();
        }
        public ContactMainPage(string contactName) : this()
        {
            this.Title = contactName;
        }
        private void DocumentContent_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CustomerFormCommands.CloseTab.Execute(((DocumentContent)sender).Title, (DocumentContent)sender);
        }

        private void cmdSaveContact_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = new ContactFormViewModel();
            viewModel.ContactName = txtName.Text;
            viewModel.Organization = txtOrganization.Text;
            viewModel.DateOfBirth = DateTime.Parse(txtBirthDate.Text);
            viewModel.Designation = txtDesignation.Text;
            viewModel.IsIndian = chkIndian.IsChecked.Value;
            viewModel.IsOther = chkOther.IsChecked.Value;
            viewModel.IsSpecial = chkIsSpecial.IsChecked.Value;
            viewModel.PhoneNumber = txtPhoneNumber.Text;
            viewModel.Address = txtAddress.Text;
            viewModel.Email = txtEmail.Text;
            StudioRepository.UpdateContact(viewModel);

            var msgbox = new BookerStudioMessageBox("Saved successfully", "The contact has been saved successfully!", GuestBookerMessageBoxButtons.Ok, IconType.Info);
            msgbox.ShowDialog();
            MainWindow.MainStatusBarMessage.Text = "The changes made were saved successfully.";
        }

    }
}
