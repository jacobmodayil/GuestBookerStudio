using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guest_Booker_Studio.ViewModel
{
    public class CustomerFormViewModel : BaseFormViewModel
    {
        private int _customerID;
        private string _organization;
        private string _contactName;
        private string _phoneNumber;
        private int _noofppl;
        private string _purpose;
        private DateTime _fromdate;
        private DateTime _todate;
        private bool _isspecial;
        private string _miscdetails;
        private string _roomdetails;
        private string _idProof;
        private int _estimatedCost;
        private bool _isActive;

        public int CustomerId
        {
            get
            {
                return _customerID;
            }
            set
            {
                _customerID = value;
                onPropertyChanged("CustomerId");
            }
        }
        public string Organization
        {
            get
            {
                return _organization;
            }
            set
            {
                _organization = value;
                onPropertyChanged("Organization");
            }
        }
        public string ContactName
        {
            get
            {
                return _contactName;
            }
            set
            {
                _contactName = value;
                onPropertyChanged("ContactName");
            }
        }
        public int NumOfPeople
        {
            get
            {
                return _noofppl;
            }
            set
            {
                _noofppl = value;
                onPropertyChanged("NumOfPeople");
            }
        }
        public string Purpose
        {
            get
            {
                return _purpose;
            }
            set
            {
                _purpose = value;
                onPropertyChanged("Purpose");
            }
        }
        public DateTime FromDate
        {
            get
            {
                return _fromdate;
            }
            set
            {
                _fromdate = value;
                onPropertyChanged("FromDate");
            }
        }
        public DateTime ToDate
        {
            get
            {
                return _todate;
            }
            set
            {
                _todate = value;
                onPropertyChanged("ToDate");
            }
        }
        public bool IsSpecial
        {
            get
            {
                return _isspecial;
            }
            set
            {
                _isspecial = value;
                onPropertyChanged("IsSpecial");
            }
        }
        public string MiscDetails
        {
            get
            {
                return _miscdetails;
            }
            set
            {
                _miscdetails = value;
                onPropertyChanged("MiscDetails");
            }
        }
        public string RoomDetails
        {
            get
            {
                return _roomdetails;
            }
            set
            {
                _roomdetails = value;
                onPropertyChanged("RoomDetails");
            }
        }
        public string IDProof
        {
            get
            {
                return _idProof;
            }
            set
            {
                _idProof = value;
                onPropertyChanged("IDProof");
            }
        }
        public int EstimatedCost
        {
            get
            {
                return _estimatedCost;
            }
            set
            {
                _estimatedCost = value;
                onPropertyChanged("EstimatedCost");
            }
        }
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
                onPropertyChanged("PhoneNumber");
            }
        }
        public bool IsActive
        {
            get
            {
                return _isActive;
            }
            set
            {
                _isActive = value;
                onPropertyChanged("IsActive");
            }
        }
    }
}
namespace Guest_Booker_Studio
{
    public enum WindowOpenMode
    {
        EditCustomer,
        EditContact,
        DoNothing
    }

    public class TreeItemParams
    {
        public TreeItemParams(string entityName, WindowOpenMode mode)
        {
            this.entityName = entityName;
            this.windowOpenMode = mode;
        }

        public string entityName;
        public WindowOpenMode windowOpenMode;
    }
}
