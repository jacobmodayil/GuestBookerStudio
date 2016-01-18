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

namespace Guest_Booker_Studio.Presentation.Controls
{
    /// <summary>
    /// Interaction logic for DayBoxControl.xaml
    /// </summary>
    public partial class DayBoxControl : UserControl
    {
        public DayBoxControl()
        {
            InitializeComponent();
        }

        private void DayAppointmentsStack_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount > 1)
            {
                var date = new DateTime(MonthView.displayYear, MonthView.displayMonth, Convert.ToInt32(DayNumberLabel.Content));
                var apt = new DayBoxAppointmentControl();
                apt.datetxtBlk.Text = date.ToShortDateString();
                DayAppointmentsStack.Children.Add(apt);
            }
        }

        private void btnAptSave_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
