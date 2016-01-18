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
using System.Globalization;
using Guest_Booker_Studio.Model;
using ExcelGeneration;

namespace Guest_Booker_Studio.Presentation.Controls
{
    /// <summary>
    /// Interaction logic for MonthView.xaml
    /// </summary>
    public partial class MonthView : UserControl
    {
        public static DateTime displayDate { get; set; }
        public static int displayMonth{get;set;}
            public static int displayYear{get;set;} 
        public static int iOffsetDays{get;set;}
        public static int endOffsetDays{get;set;}
        CultureInfo cultureInfo;
        public delegate void DisplayMonthChangedEventHandler(MonthChangedEventArgs e);
        public event DisplayMonthChangedEventHandler DisplayMonthChanged;
        System.Globalization.Calendar sysCal;
        public MonthView()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MonthView_Loaded);

        }
        private void MonthView_Loaded(object sender, RoutedEventArgs e)
        {
            BuildCalendarUI();
        }

        public void BuildCalendarUI()
        {
            displayDate = DateTime.Now.AddDays(-1 * (DateTime.Now.Day - 1));
            displayMonth = displayDate.Month;
            displayYear = displayDate.Year;
            cultureInfo = new CultureInfo(CultureInfo.CurrentUICulture.LCID);
            sysCal = cultureInfo.Calendar;
            int iDaysInMonth = sysCal.GetDaysInMonth(displayDate.Year, displayDate.Month);
            iOffsetDays = (int)displayDate.DayOfWeek;
            int iWeekCount = 0;
            var weekControl = new DaysOfWeekControl();

            MonthViewGrid.Children.Clear();
            AddRowsToMonthGrid(iDaysInMonth, iOffsetDays);
            switch (displayDate.Month)
            {
                case 1:
                    MonthYearLabel.Content = "January" + " " + displayYear;
                    break;
                case 2:
                    MonthYearLabel.Content = "February" + " " + displayYear;
                    break;
                case 3:
                    MonthYearLabel.Content = "March" + " " + displayYear;
                    break;
                case 4:
                    MonthYearLabel.Content = "April" + " " + displayYear;
                    break;
                case 5:
                    MonthYearLabel.Content = "May" + " " + displayYear;
                    break;
                case 6:
                    MonthYearLabel.Content = "June" + " " + displayYear;
                    break;
                case 7:
                    MonthYearLabel.Content = "July" + " " + displayYear;
                    break;
                case 8:
                    MonthYearLabel.Content = "August" + " " + displayYear;
                    break;
                case 9:
                    MonthYearLabel.Content = "September" + " " + displayYear;
                    break;
                case 10:
                    MonthYearLabel.Content = "October" + " " + displayYear;
                    break;
                case 11:
                    MonthYearLabel.Content = "November" + " " + displayYear;
                    break;
                case 12:
                    MonthYearLabel.Content = "December" + " " + displayYear;
                    break;
            }


            for (int i = 1; i <= iDaysInMonth; i++)
            {
                if ((i != 1) && ((i + iOffsetDays - 1) % 7 == 0))
                {
                    //Add existing weekrow to month Grid
                    Grid.SetRow(weekControl, iWeekCount);
                    MonthViewGrid.Children.Add(weekControl);
                    //Add new Week Row Control
                    weekControl = new DaysOfWeekControl();
                    iWeekCount += 1;
                }
                //load each weekrow with a DayBoxControl whose label is set to day number
                var dayBox = new DayBoxControl();
                dayBox.DayNumberLabel.Content = i.ToString();
                dayBox.Tag = i;
                //Customize DayBox for today
                if (new DateTime(displayYear, displayMonth, i) == DateTime.Today)
                {
                    dayBox.DayNumberLabel.Background = dayBox.TryFindResource("OrangeGradientBrush") as Brush;
                }
             
                DateTime iday = new DateTime(displayYear,displayMonth,i);

                List<ECCAppointment> aptList = StudioRepository.GetAppointmentDayFromRepository(iday).ToList();
                if(aptList.Count > 0)
                {
                    foreach (var item in aptList)
                    {
                        DayBoxAppointmentControl apt = new DayBoxAppointmentControl();
                        apt.DisplayText.Text = item.AppointmentName;
                        apt.datetxtBlk.Text = iday.ToString();
                        dayBox.DayAppointmentsStack.Children.Add(apt);
                    }
                }

                Grid.SetColumn(dayBox, (i - (iWeekCount * 7) + iOffsetDays));
                weekControl.WeekRowGrid.Children.Add(dayBox);
            }
            Grid.SetRow(weekControl, iWeekCount);
            MonthViewGrid.Children.Add(weekControl);
        }
        public void BuildCalendarUI(DateTime newDisplayDate)
        {
            displayMonth = newDisplayDate.Month;
            displayYear = newDisplayDate.Year;
            cultureInfo = new CultureInfo(CultureInfo.CurrentUICulture.LCID);
            sysCal = cultureInfo.Calendar;
            int iDaysInMonth = sysCal.GetDaysInMonth(newDisplayDate.Year, newDisplayDate.Month);
            iOffsetDays = (int)newDisplayDate.DayOfWeek;
            int iWeekCount = 0;
            var weekControl = new DaysOfWeekControl();

            MonthViewGrid.Children.Clear();
            AddRowsToMonthGrid(iDaysInMonth, iOffsetDays);
            switch (newDisplayDate.Month)
            {
                case 1:
                    MonthYearLabel.Content = "January" + " " + displayYear;
                    break;
                case 2:
                    MonthYearLabel.Content = "February" + " " + displayYear;
                    break;
                case 3:
                    MonthYearLabel.Content = "March" + " " + displayYear;
                    break;
                case 4:
                    MonthYearLabel.Content = "April" + " " + displayYear;
                    break;
                case 5:
                    MonthYearLabel.Content = "May" + " " + displayYear;
                    break;
                case 6:
                    MonthYearLabel.Content = "June" + " " + displayYear;
                    break;
                case 7:
                    MonthYearLabel.Content = "July" + " " + displayYear;
                    break;
                case 8:
                    MonthYearLabel.Content = "August" + " " + displayYear;
                    break;
                case 9:
                    MonthYearLabel.Content = "September" + " " + displayYear;
                    break;
                case 10:
                    MonthYearLabel.Content = "October" + " " + displayYear;
                    break;
                case 11:
                    MonthYearLabel.Content = "November" + " " + displayYear;
                    break;
                case 12:
                    MonthYearLabel.Content = "December" + " " + displayYear;
                    break;
            }


            for (int i = 1; i <= iDaysInMonth; i++)
            {
                if ((i != 1) && ((i + iOffsetDays - 1) % 7 == 0))
                {
                    //Add existing weekrow to month Grid
                    Grid.SetRow(weekControl, iWeekCount);
                    MonthViewGrid.Children.Add(weekControl);
                    //Add new Week Row Control
                    weekControl = new DaysOfWeekControl();
                    iWeekCount += 1;
                }
                //load each weekrow with a DayBoxControl whose label is set to day number
                var dayBox = new DayBoxControl();
                dayBox.DayNumberLabel.Content = i.ToString();
                dayBox.Tag = i;
                //Customize DayBox for today
                if (new DateTime(displayYear, displayMonth, i) == DateTime.Today)
                {
                    dayBox.DayNumberLabel.Background = dayBox.TryFindResource("OrangeGradientBrush") as Brush;
                }
 
                DateTime iday = new DateTime(displayYear, displayMonth, i);
                List<ECCAppointment> aptList = StudioRepository.GetAppointmentDayFromRepository(iday).ToList();
                if (aptList.Count > 0)
                {
                    foreach (var item in aptList)
                    {
                        DayBoxAppointmentControl apt = new DayBoxAppointmentControl();
                        apt.DisplayText.Text = item.AppointmentName;
                        apt.datetxtBlk.Text = iday.ToShortDateString();
                        dayBox.DayAppointmentsStack.Children.Add(apt);
                    }
                }

                Grid.SetColumn(dayBox, (i - (iWeekCount * 7) + iOffsetDays));
                weekControl.WeekRowGrid.Children.Add(dayBox);
            }
            Grid.SetRow(weekControl, iWeekCount);
            MonthViewGrid.Children.Add(weekControl);
        }

        public void AddRowsToMonthGrid(int DaysInMonth, int OffSetDays)
        {
            MonthViewGrid.RowDefinitions.Clear();
            var rowHeight = new System.Windows.GridLength(60, System.Windows.GridUnitType.Star);

            //int EndOffSetDays = 7 - int.Parse(Enum.ToObject(typeof(DayOfWeek),displayDate.AddDays(DaysInMonth - 1).DayOfWeek).ToString()) + 1;
            endOffsetDays = 7 - (int)(displayDate.AddDays(DaysInMonth - 1).DayOfWeek) + 1;
            for (int i = 1; i <= Convert.ToInt32((DaysInMonth + OffSetDays + endOffsetDays) / 7); i++)
            {
                var rowDef = new RowDefinition();
                rowDef.Height = rowHeight;
                MonthViewGrid.RowDefinitions.Add(rowDef);
            }
        }
        public void UpdateMonth(int MonthsToAdd)
        {
            var ev = new MonthChangedEventArgs();
            ev.OldDisplayStartDate = displayDate;
            displayDate = displayDate.AddMonths(MonthsToAdd);
            ev.NewDisplayStartDate = displayDate;
            DisplayMonthChanged(ev);
        }
        private void MonthGoPrev_Click(object sender, RoutedEventArgs e)
        {
            displayDate = displayDate.AddMonths(-1);
            BuildCalendarUI(displayDate);
        }

        private void MonthGoNext_Click(object sender, RoutedEventArgs e)
        {
            displayDate = displayDate.AddMonths(1);
            BuildCalendarUI(displayDate);
        }

        private void cmdExportCustomer_Click(object sender, RoutedEventArgs e)
        {
            List<ECCAppointment> list = StudioRepository.GetAllAppointmnents().ToList();
            new GetGridValues().PrepareAppointmentData(list);
            MainWindow.MainStatusBarMessage.Text = "List of all appointments successfully exported.";
        }



    }
    
public struct MonthChangedEventArgs
{
    public DateTime OldDisplayStartDate; 
    public DateTime NewDisplayStartDate;
}

}
