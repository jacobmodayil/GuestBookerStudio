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
using Guest_Booker_Studio;
using Guest_Booker_Studio.ViewModel;
using Guest_Booker_Studio.Model;
using Guest_Booker_Studio.Presentation.Controls;
using Guest_Booker_Studio.Commands;

namespace Guest_Booker_Studio.Presentation.Pages.Entity
{
    /// <summary>
    /// Interaction logic for CustomerMainPage.xaml
    /// </summary>
    public partial class CustomerMainPage : DocumentContent
    {
        public List<ECCAssetsStructure> _listAccomodation;
        public List<ECCMiscellaneousStructure> _listMiscellaneous;
        public CustomerMainPage()
        {
            InitializeComponent();
            PopulateAccDetailsListbox();
            PopulateMiscDetailsListbox();
            SetDefaultValues();
        }
        public CustomerMainPage(string customerName) : this()
        {
            this.Title = customerName;
        }

        #region Accomodation
        private void PopulateAccDetailsListbox()
        {
            _listAccomodation = new List<ECCAssetsStructure>()  
            {
                new ECCAssetsStructure(){ AssetName ="Hostel 1"},
                new ECCAssetsStructure(){ AssetName ="Hostel 2"},
                new ECCAssetsStructure(){ AssetName ="Hostel 3"},
                new ECCAssetsStructure(){ AssetName ="Hostel 4"},
                new ECCAssetsStructure(){ AssetName ="Hostel 5"},
                new ECCAssetsStructure(){ AssetName ="Dialogue House 1"},
                new ECCAssetsStructure(){ AssetName ="House 3"},
                new ECCAssetsStructure(){ AssetName ="House 7"},
                new ECCAssetsStructure(){ AssetName ="House 16 A"},
                new ECCAssetsStructure(){ AssetName ="House 16 B"},
                new ECCAssetsStructure(){ AssetName ="Guest House"},
                new ECCAssetsStructure(){ AssetName ="Common Lounge"},
                new ECCAssetsStructure(){ AssetName ="Seminar Hall"},
                new ECCAssetsStructure(){ AssetName ="Conference Hall"}
            };
            AccLeftListBox.ItemsSource =_listAccomodation;
        }

        private void btnAddAcc_Click(object sender, RoutedEventArgs e)
        {
            if (AccLeftListBox.SelectedItems != null)
            {
                for (int i = 0; i <= AccLeftListBox.SelectedItems.Count - 1;i++ )
                {
                    AccRightListBox.Items.Add(AccLeftListBox.SelectedItems[i]);
                    _listAccomodation.Remove((ECCAssetsStructure)AccLeftListBox.SelectedItems[i]);
                    
                }
                ApplyDataBinding();
            }        
        }

        private void ApplyDataBinding()
        {           
            if (_listAccomodation != null)
            {
                AccLeftListBox.ItemsSource = _listAccomodation.OrderBy(c => c.AssetName);
            }
            else { AccLeftListBox.ItemsSource = null; }
        }

        private void btnRemoveAcc_Click(object sender, RoutedEventArgs e)
        {
            if (AccRightListBox.SelectedItems != null)
            {
                int count = AccRightListBox.SelectedItems.Count - 1;
                for (int i = count; i >= 0; i--)
                {
                    _listAccomodation.Add((ECCAssetsStructure)AccRightListBox.SelectedItems[i]);
                    AccRightListBox.Items.Remove(AccRightListBox.SelectedItems[i]);
                    
                }
                ApplyDataBinding();
            }
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            txtAccDetail.Text = "";
            var list = PrepareFinalList();
            foreach (var item in list)
            {
                txtAccDetail.Text += item.AssetName + ": " + "  ,";
            }
            list.Clear();
        }

        private List<ECCAssetsStructure> PrepareFinalList()
        {
            List<ECCAssetsStructure> mylist = new List<ECCAssetsStructure>();
            foreach (var item in AccRightListBox.Items)
            {
                mylist.Add((ECCAssetsStructure)item);
            }
            return mylist;            
        }

        private void btnResetAcc_Click(object sender, RoutedEventArgs e)
        {
            txtAccDetail.Text = "";
            btnRemoveAcc_Click(sender, e);
        }
        #endregion Accomodation

        # region Miscellaneous
        private void PopulateMiscDetailsListbox()
        {
            _listMiscellaneous = new List<ECCMiscellaneousStructure>()  
            {
                new ECCMiscellaneousStructure(){ ItemName ="PA System"},
                new ECCMiscellaneousStructure(){ ItemName ="LCD Projector"},
                new ECCMiscellaneousStructure(){ ItemName ="Laptop"},
                new ECCMiscellaneousStructure(){ ItemName ="Cordless Mikes"},
                new ECCMiscellaneousStructure(){ ItemName ="Television"},
                new ECCMiscellaneousStructure(){ ItemName ="DVD Player"},
                new ECCMiscellaneousStructure(){ ItemName ="Additional Programmes"}
            };
            MiscLeftListBox.ItemsSource = _listMiscellaneous;
        }

        private void btnAddMiscDetail_Click(object sender, RoutedEventArgs e)
        {
            if (MiscLeftListBox.SelectedItems != null)
            {
                for (int i = 0; i <= MiscLeftListBox.SelectedItems.Count - 1; i++)
                {
                    MiscRightListBox.Items.Add(MiscLeftListBox.SelectedItems[i]);
                    _listMiscellaneous.Remove((ECCMiscellaneousStructure)MiscLeftListBox.SelectedItems[i]);

                }
                ApplyMiscDataBinding();
            }
        }

        private void ApplyMiscDataBinding()
        {
            if (_listMiscellaneous != null)
            {
                MiscLeftListBox.ItemsSource = _listMiscellaneous.OrderBy(c => c.ItemName);
            }
            else { MiscLeftListBox.ItemsSource = null; }
        }

        private void btnRemoveMisc_Click(object sender, RoutedEventArgs e)
        {
            if (MiscRightListBox.SelectedItems != null)
            {
                int count = MiscRightListBox.SelectedItems.Count - 1;
                for (int i = count; i >= 0; i--)
                {
                    _listMiscellaneous.Add((ECCMiscellaneousStructure)MiscRightListBox.SelectedItems[i]);
                    MiscRightListBox.Items.Remove(MiscRightListBox.SelectedItems[i]);

                }
                ApplyMiscDataBinding();
            }
        }

        private void btnConfirmMiscDetail_Click(object sender, RoutedEventArgs e)
        {
            txtMiscDetail.Text = "";
            var list = PrepareFinalMiscList();
            foreach (var item in list)
            {
                txtMiscDetail.Text += item.ItemName + ": " + "  ,";
            }
            list.Clear();
        }

        private List<ECCMiscellaneousStructure> PrepareFinalMiscList()
        {
            List<ECCMiscellaneousStructure> myMisclist = new List<ECCMiscellaneousStructure>();
            foreach (var item in MiscRightListBox.Items)
            {
                myMisclist.Add((ECCMiscellaneousStructure)item);
            }
            return myMisclist;
        }

        private void btnResetMisc_Click(object sender, RoutedEventArgs e)
        {
            txtMiscDetail.Text = "";
            btnRemoveMisc_Click(sender, e);
        }
        # endregion Miscellaneous

        #region Cost Calcuation
        private void SetDefaultValues()
        {
            chkIndian.IsChecked = true;
            txtGeneralCost.Text = "1000";
            txtDiscount.Text = "0";
            txtOtherCosts.Text = "0";
            txtNoOfDays.Text = "0";
            txtStaffBenefitFund.Text = "0";
        }
        private void chkOthers_Checked(object sender, RoutedEventArgs e)
        {
            lblCurrency.Visibility = Visibility.Visible;
            txtCurrencyValue.Visibility = Visibility.Visible;
            lblInDollars.Visibility = Visibility.Visible;
        }


        private void btnCalculateCost_Click(object sender, RoutedEventArgs e)
        {
            if (chkIndian.IsChecked.Value == true)
            {
                var numofPpl = int.Parse(txtCostNumOfPpl.Text);
                int cost = int.Parse(txtNoOfDays.Text)*(numofPpl * int.Parse(txtGeneralCost.Text) + int.Parse(txtOtherCosts.Text) - int.Parse(txtDiscount.Text) + int.Parse(txtStaffBenefitFund.Text));
                txtTotalAmount.Text = cost.ToString();
            }
            else
            {

                var numofPpl = int.Parse(txtCostNumOfPpl.Text);
                int cost = int.Parse(txtNoOfDays.Text)*(numofPpl * (int.Parse(txtGeneralCost.Text) * int.Parse(txtCurrencyValue.Text)) + int.Parse(txtOtherCosts.Text) - int.Parse(txtDiscount.Text));
                txtTotalAmount.Text = cost.ToString();
            }
        }
        #endregion Cost Caluculation

        private void DocumentContent_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CustomerFormCommands.CloseTab.Execute(((DocumentContent)sender).Title, (DocumentContent)sender);
        }

        private void cmdSaveCustomer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var viewModel = new CustomerFormViewModel();
                viewModel.ContactName = txtName.Text;
                viewModel.Organization = txtOrganization.Text;
                var culInfo = new System.Globalization.CultureInfo("en-US");
                viewModel.EstimatedCost = int.Parse(txtTotalAmount.Text);
                viewModel.MiscDetails = txtMiscDetail.Text;
                viewModel.FromDate = DateTime.Parse(txtFromDate.Text, culInfo);
                viewModel.IDProof = txtIDProof.Text;
                viewModel.IsActive = chkIsActive.IsChecked.Value;
                viewModel.IsSpecial = chkIsSpecial.IsChecked.Value;
                viewModel.NumOfPeople = int.Parse(txtNumOfPpl.Text);
                viewModel.PhoneNumber = txtPhoneNumber.Text;
                viewModel.Purpose = txtPurpose.Text;
                viewModel.RoomDetails = txtAccDetail.Text;
                viewModel.ToDate = DateTime.Parse(txtToDate.Text, culInfo);
                StudioRepository.UpdateCustomer(viewModel);

                var msgbox = new BookerStudioMessageBox("Saved successfully", "The customer has been saved successfully!", GuestBookerMessageBoxButtons.Ok, IconType.Attention);
                msgbox.ShowDialog();
                MainWindow.MainStatusBarMessage.Text = "The changes made were saved successfully.";
            }
            catch(Exception ex)
            {
                var msgbox = new BookerStudioMessageBox("Exception!",ex.Message, GuestBookerMessageBoxButtons.Ok, IconType.Attention);
                msgbox.ShowDialog();
            }
         }

        private void cmdExportCustomer_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void chkOthers_Unchecked(object sender, RoutedEventArgs e)
        {
            lblCurrency.Visibility = Visibility.Hidden;
            txtCurrencyValue.Visibility = Visibility.Hidden;
            lblInDollars.Visibility = Visibility.Hidden;
        }

       

      
    }
}
