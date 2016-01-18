using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guest_Booker_Studio.ViewModel
{
    public class StartPageViewModel:BaseFormViewModel
    {
        private string _thingsToDo;
        public string ThingsToDo
        {
            get { return _thingsToDo; }
            set
            {
                _thingsToDo = value;
                onPropertyChanged("ThingsToDo");
            }
        }
    }
    public class ECCAppointmentsViewModel : BaseFormViewModel
    {
        private string _appointmentName;
        private DateTime _date;
        public string AppointmentName
        {
            get { return _appointmentName; }
            set
            {
                _appointmentName = value;
                onPropertyChanged("AppointmentName");
            }
        }
        public DateTime Date
        {
            get { return _date; }
            set
            {
                _date = value;
                onPropertyChanged("Date");
            }
        }
    }
}
