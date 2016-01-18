using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guest_Booker_Studio.ViewModel
{
   public class ContactFormViewModel : BaseFormViewModel
    {
        private int _contactID;
        private string _organization;
        private string _contactName;
        private string _phoneNumber;
        private string _address;
        private DateTime _birthDate;
        private bool _isspecial;
        private string _designation;
        private string _email;
        private bool _isIndian;
        private bool _isOther;

        public int ContactId
        {
            get
            {
                return _contactID;
            }
            set
            {
                _contactID = value;
                onPropertyChanged("ContactId");
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
      
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                onPropertyChanged("Address");
            }
        }
        public DateTime DateOfBirth
        {
            get
            {
                return _birthDate;
            }
            set
            {
                _birthDate = value;
                onPropertyChanged("DateOfBirth");
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
        public bool IsIndian
        {
            get
            {
                return _isIndian;
            }
            set
            {
                _isIndian = value;
                onPropertyChanged("IsIndian");
            }
        }
        public bool IsOther
        {
            get
            {
                return _isOther;
            }
            set
            {
                _isOther = value;
                onPropertyChanged("IsOther");
            }
        }
        public string Designation
        {
            get
            {
                return _designation;
            }
            set
            {
                _designation = value;
                onPropertyChanged("Designation");
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
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                onPropertyChanged("Email");
            }
        }
    }
}
