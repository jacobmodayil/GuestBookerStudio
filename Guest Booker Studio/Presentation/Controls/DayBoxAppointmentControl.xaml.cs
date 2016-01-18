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

namespace Guest_Booker_Studio.Presentation.Controls
{
    /// <summary>
    /// Interaction logic for DayBoxAppointmentControl.xaml
    /// </summary>
    public partial class DayBoxAppointmentControl : UserControl
    {
        public DayBoxAppointmentControl()
        {
            InitializeComponent();
        }

        private void btnAptSave_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = new ECCAppointmentsViewModel();
            viewModel.AppointmentName = DisplayText.Text;
            viewModel.Date = Convert.ToDateTime(datetxtBlk.Text);
            StudioRepository.SaveAppointment(viewModel);
            var msgBox = new BookerStudioMessageBox("Saved successfully.", "The appointment is saved successfully!", GuestBookerMessageBoxButtons.Ok, IconType.Attention);
            msgBox.ShowDialog();
        }

        private void btnAptDelete_Click(object sender, RoutedEventArgs e)
        {
            var model = StudioRepository.GetAppointmentFromRepository(DisplayText.Text, Convert.ToDateTime(datetxtBlk.Text));
            foreach (var item in model)
            {
                StudioRepository.DeleteAppointment(item);
            }
            var msgBox = new BookerStudioMessageBox("Deleted successfully.", "The appointment was deleted successfully!", GuestBookerMessageBoxButtons.Ok, IconType.Attention);
            msgBox.ShowDialog();

        }

        
    }
}
