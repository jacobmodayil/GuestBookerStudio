using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Guest_Booker_Studio.ViewModel;

namespace Guest_Booker_Studio.Model
{
    public static class StudioRepository
    {
        public static GuestBookerStudioRepositoryDataContext Repository;
        static StudioRepository()
        {
            Repository = new GuestBookerStudioRepositoryDataContext();
        }
        #region ThingsToDo
      
        public static void SaveThingsToDo(StartPageViewModel viewModel)
        {
            var model = Repository.ThingsToDos.Where(c => c.ID == 1).SingleOrDefault();
            if (model != null)
            {
                model.ThingsToDo1 = viewModel.ThingsToDo;
                Repository.SubmitChanges();
            }
            else
            {
                var newModel = new ThingsToDo();
                newModel.ThingsToDo1 = viewModel.ThingsToDo;
                Repository.ThingsToDos.InsertOnSubmit(newModel);
                Repository.SubmitChanges();
            }
        }
        public static IQueryable GetThingsToDoListFromRepository()
        {
            var list = from thingsToDo in Repository.ThingsToDos select thingsToDo;
            return list;
        }
        #endregion ThingsToDo

        #region Customer

        public static void InsertCustomer(CustomerFormViewModel viewModel)
        {
            var model = new ECCMaster();
            model.ContactName = viewModel.ContactName;
            model.Organization = viewModel.Organization;
            model.EstimatedCost = viewModel.EstimatedCost;
            model.MiscDetails = viewModel.MiscDetails;
            model.FromDate = viewModel.FromDate;
            model.IDProof = viewModel.IDProof;
            model.IsActive = viewModel.IsActive;
            model.IsSpecial = viewModel.IsSpecial;
            model.NoOfPeople = viewModel.NumOfPeople;
            model.PhoneNumber = viewModel.PhoneNumber;
            model.Purpose = viewModel.Purpose;
            model.RoomDetails = viewModel.RoomDetails;
            model.ToDate = viewModel.ToDate;
            Repository.ECCMasters.InsertOnSubmit(model);
            Repository.SubmitChanges();
        }
        public static void UpdateCustomer(CustomerFormViewModel viewModel)
        {
            var model = Repository.ECCMasters.Where(c => c.Organization == viewModel.Organization && c.ContactName == viewModel.ContactName).SingleOrDefault();
            model.ContactName = viewModel.ContactName;
            model.Organization = viewModel.Organization;
            model.EstimatedCost = viewModel.EstimatedCost;
            model.MiscDetails = viewModel.MiscDetails;
            model.FromDate = viewModel.FromDate;
            model.IDProof = viewModel.IDProof;
            model.IsActive = viewModel.IsActive;
            model.IsSpecial = viewModel.IsSpecial;
            model.NoOfPeople = viewModel.NumOfPeople;
            model.PhoneNumber = viewModel.PhoneNumber;
            model.Purpose = viewModel.Purpose;
            model.RoomDetails = viewModel.RoomDetails;
            model.ToDate = viewModel.ToDate;
            Repository.SubmitChanges();
        }
        public static IQueryable<ECCMaster> GetCustomersByDate(DateTime fromDate, DateTime toDate)
        {
            IQueryable<ECCMaster> customers = Repository.ECCMasters.Where(c => c.FromDate.Date >= fromDate && c.ToDate <= toDate); 
            return customers;

        }
        public static IList<ECCMaster> GetAllCustomers()
        {
            var customers = from list in Repository.ECCMasters select list;
            return customers.ToList();
        }
        public static IQueryable GetCustomerDetails(string organizationName)
        {
            return Repository.ECCMasters.Where(c => c.Organization == organizationName);
        }
        public static IQueryable GetCustomerDetails(string organizationName,string contactname)
        {
            return Repository.ECCMasters.Where(c => c.Organization == organizationName || c.ContactName==contactname);
        }
        public static void DeleteCustomer(ECCMaster model)
        {
            //var model = Repository.ECCMasters.Where(c => c.Organization == organizationName || c.ContactName == contactName).SingleOrDefault();         
            Repository.ECCMasters.DeleteOnSubmit(model);
            Repository.SubmitChanges();            
        }
        public static IQueryable<ECCMaster> GetAllActiveCustomers()
        {
            var list = Repository.ECCMasters.Where(c => c.IsActive == true);
            return list;
        }
        public static IQueryable<ECCMaster> GetAllInActiveCustomers()
        {
            var list = Repository.ECCMasters.Where(c => c.IsActive == false);
            return list;
        }
        public static IQueryable<string> GetCurrentCustomer()
        {
            var customers = from list in Repository.ECCMasters where list.FromDate == DateTime.Now.Date select list.ContactName;
            return customers;
        }

        #endregion Customer

        #region Contact

        public static void InsertContact(ContactFormViewModel viewModel)
        {
            var model = new ECCContact();
            model.Name = viewModel.ContactName;
            model.Organization = viewModel.Organization;
            model.Designation = viewModel.Designation;
            model.DateOfBirth = viewModel.DateOfBirth;
            model.IsOther = viewModel.IsOther;
            model.IsIndian = viewModel.IsIndian;
            model.IsSpecial = viewModel.IsSpecial;
            model.PhoneNumber = viewModel.PhoneNumber;
            model.Address = viewModel.Address;
            model.Email = viewModel.Email;
            Repository.ECCContacts.InsertOnSubmit(model);
            Repository.SubmitChanges();
        }
        public static void UpdateContact(ContactFormViewModel viewModel)
        {
            var model = Repository.ECCContacts.Where(c => c.Organization == viewModel.Organization && c.Name == viewModel.ContactName).SingleOrDefault();
            model.Name = viewModel.ContactName;
            model.Organization = viewModel.Organization;
            model.Designation = viewModel.Designation;
            model.DateOfBirth = viewModel.DateOfBirth;
            model.IsOther = viewModel.IsOther;
            model.IsIndian = viewModel.IsIndian;
            model.IsSpecial = viewModel.IsSpecial;
            model.PhoneNumber = viewModel.PhoneNumber;
            model.Address = viewModel.Address;
            model.Email = viewModel.Email;
            Repository.SubmitChanges();
        }
        public static IList<ECCContact> GetAllContacts()
        {
            var contacts = from list in Repository.ECCContacts select list;
            return contacts.ToList();
        }
        public static IQueryable GetContactDetails(string contactName)
        {
            return Repository.ECCContacts.Where(c => c.Name == contactName);
        }
        public static IQueryable GetContactDetails(string organizationName, string contactname)
        {
            return Repository.ECCContacts.Where(c => c.Organization == organizationName || c.Name == contactname);
        }
        public static void DeleteContact(ECCContact model)
        {
            Repository.ECCContacts.DeleteOnSubmit(model);
            Repository.SubmitChanges();
        }
        #endregion Contact

        #region ECCAppointments
        public static void SaveAppointment(ECCAppointmentsViewModel viewModel)
        {
            var model = Repository.ECCAppointments.Where(c => c.FromDate == viewModel.Date).SingleOrDefault();
            if (model != null)
            {
                model.AppointmentName = viewModel.AppointmentName;
                model.FromDate = viewModel.Date;
                model.AptDate = viewModel.Date.Day + "-" + viewModel.Date.Month + "-" + viewModel.Date.Year; 
                Repository.SubmitChanges();
            }
            else
            {
                var newModel = new ECCAppointment();
                newModel.AppointmentName = viewModel.AppointmentName;
                newModel.FromDate = viewModel.Date;
                newModel.AptDate = viewModel.Date.Day + "-" + viewModel.Date.Month + "-" + viewModel.Date.Year;
                Repository.ECCAppointments.InsertOnSubmit(newModel);
                Repository.SubmitChanges();
            }
        }
        public static IList<ECCAppointment> GetAppointmentDayFromRepository(DateTime date)
        {
            var list = from aptlist in Repository.ECCAppointments where aptlist.FromDate.Date == date select aptlist;
            return list.ToList();
        }
        public static IList<ECCAppointment> GetAppointmentFromRepository(string name,DateTime date)
        {
            var list = from aptlist in Repository.ECCAppointments where aptlist.FromDate.Date == date && aptlist.AppointmentName==name select aptlist;
            return list.ToList();
        }
        public static IList<ECCAppointment> GetAllAppointmnents()
        {
            var list = from aptlist in Repository.ECCAppointments select aptlist;
            return list.ToList();
        }
        public static void DeleteAppointment(ECCAppointment model)
        {
            Repository.ECCAppointments.DeleteOnSubmit(model);
            Repository.SubmitChanges();
        }
        public static void UpdateAppointment(ECCAppointmentsViewModel viewModel)
        {
       
        }

        #endregion ECCAppointments
    }
}
