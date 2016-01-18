using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Data;
using System.Reflection;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using Guest_Booker_Studio.ViewModel;
using Guest_Booker_Studio.Model;

namespace ExcelGeneration
{
    public class GetGridValues
    {
        public void PrepareData(List<ECCMaster> attributescollection)
        {
            List<string> attributescolumns = new List<string>() { "Organization", "ContactName", "FromDate", "ToDate", "Num Of people", "Purpose", "PhoneNumber", "Accomodation", "Miscellaneous", "EstimatedAmount", "IDProof", "IsActive", "IsSpecial" };

            object[,] attributesdata = new object[attributescollection.Count + 1, attributescolumns.Count];

            for (int attributescolumnIndex = 0; attributescolumnIndex < attributescolumns.Count; attributescolumnIndex++)
            {
                string attributegridColumns = attributescolumns[attributescolumnIndex];

                attributesdata[0, attributescolumnIndex] = attributegridColumns;
                for (int attributesrowIndex = 0; attributesrowIndex < attributescollection.Count; attributesrowIndex++)
                {
                    switch (attributescolumnIndex)
                    {
                        case 0:
                            attributesdata[attributesrowIndex + 1, attributescolumnIndex] = attributescollection[attributesrowIndex].Organization;
                            break;
                        case 1:
                            attributesdata[attributesrowIndex + 1, attributescolumnIndex] = attributescollection[attributesrowIndex].ContactName;
                            break;
                        case 2:
                            attributesdata[attributesrowIndex + 1, attributescolumnIndex] = attributescollection[attributesrowIndex].FromDate.Day + "-" + attributescollection[attributesrowIndex].FromDate.Month + "-" + attributescollection[attributesrowIndex].FromDate.Year;
                            break;
                        case 3:
                            attributesdata[attributesrowIndex + 1, attributescolumnIndex] = attributescollection[attributesrowIndex].ToDate.Day + "-" + attributescollection[attributesrowIndex].ToDate.Month + "-" + attributescollection[attributesrowIndex].ToDate.Year;
                            break;
                        case 4:
                            attributesdata[attributesrowIndex + 1, attributescolumnIndex] = attributescollection[attributesrowIndex].NoOfPeople;
                            break;
                        case 5:
                            attributesdata[attributesrowIndex + 1, attributescolumnIndex] = attributescollection[attributesrowIndex].Purpose;
                            break;
                        case 6:
                            attributesdata[attributesrowIndex + 1, attributescolumnIndex] = attributescollection[attributesrowIndex].PhoneNumber;
                            break;
                        case 7:
                            attributesdata[attributesrowIndex + 1, attributescolumnIndex] = attributescollection[attributesrowIndex].RoomDetails;
                            break;
                        case 8:
                            attributesdata[attributesrowIndex + 1, attributescolumnIndex] = attributescollection[attributesrowIndex].MiscDetails;
                            break;
                        case 9:
                            attributesdata[attributesrowIndex + 1, attributescolumnIndex] = attributescollection[attributesrowIndex].EstimatedCost;
                            break;
                        case 10:
                            attributesdata[attributesrowIndex + 1, attributescolumnIndex] = attributescollection[attributesrowIndex].IDProof;
                            break;
                        case 11:
                            attributesdata[attributesrowIndex + 1, attributescolumnIndex] = attributescollection[attributesrowIndex].IsActive;
                            break;
                        case 12:
                            attributesdata[attributesrowIndex + 1, attributescolumnIndex] = attributescollection[attributesrowIndex].IsSpecial;
                            break;
                    }
                }
            }

            Manager m = new Manager();
            m.ExportToExcel(attributesdata as object[,]);
        }      
            
        public void PrepareContactData(List<ECCContact> attributescollection)
        {
            List<string> attributescolumns = new List<string>() { "Name", "Organization", "Designation", "Phone number", "Address", "Email ID", "Date Of Birth", "Is Special", "Indian" };
           
            object[,] attributesdata = new object[attributescollection.Count + 1, attributescolumns.Count];
         
            for (int attributescolumnIndex = 0; attributescolumnIndex < attributescolumns.Count; attributescolumnIndex++)
            {
                string attributegridColumns = attributescolumns[attributescolumnIndex];

                attributesdata[0, attributescolumnIndex] = attributegridColumns;
                for (int attributesrowIndex = 0; attributesrowIndex < attributescollection.Count; attributesrowIndex++)
                {
                    switch (attributescolumnIndex)
                    {
                        case 0:
                            attributesdata[attributesrowIndex + 1, attributescolumnIndex] = attributescollection[attributesrowIndex].Name;
                            break;
                        case 1:
                            attributesdata[attributesrowIndex + 1, attributescolumnIndex] = attributescollection[attributesrowIndex].Organization;
                            break;
                        case 2:
                            attributesdata[attributesrowIndex + 1, attributescolumnIndex] = attributescollection[attributesrowIndex].Designation;                   
                            break;
                        case 3:
                            attributesdata[attributesrowIndex + 1, attributescolumnIndex] = attributescollection[attributesrowIndex].PhoneNumber;

                            break;
                        case 4:
                            attributesdata[attributesrowIndex + 1, attributescolumnIndex] = attributescollection[attributesrowIndex].Address;
                            break;
                        case 5:
                            attributesdata[attributesrowIndex + 1, attributescolumnIndex] = attributescollection[attributesrowIndex].Email;
                            break;
                        case 6:
                            attributesdata[attributesrowIndex + 1, attributescolumnIndex] = attributescollection[attributesrowIndex].DateOfBirth.Day + "-" + attributescollection[attributesrowIndex].DateOfBirth.Month + "-" + attributescollection[attributesrowIndex].DateOfBirth.Year;
                            break;
                        case 7:
                            attributesdata[attributesrowIndex + 1, attributescolumnIndex] = attributescollection[attributesrowIndex].IsSpecial;
                            break;
                        case 8:
                            attributesdata[attributesrowIndex + 1, attributescolumnIndex] = attributescollection[attributesrowIndex].IsIndian;
                            break;
                       
                    }
                }
            }
     
            Manager m = new Manager();
            m.ExportToExcel(attributesdata as object[,]);

        }

        public void PrepareAppointmentData(List<ECCAppointment> attributescollection)
        {
            List<string> attributescolumns = new List<string>() { "Organization", "Date of Appointment" }; 
            object[,] attributesdata = new object[attributescollection.Count + 1, attributescolumns.Count];

            for (int attributescolumnIndex = 0; attributescolumnIndex < attributescolumns.Count; attributescolumnIndex++)
            {
                string attributegridColumns = attributescolumns[attributescolumnIndex];

                attributesdata[0, attributescolumnIndex] = attributegridColumns;
                for (int attributesrowIndex = 0; attributesrowIndex < attributescollection.Count; attributesrowIndex++)
                {
                    switch (attributescolumnIndex)
                    {
                        case 0:
                            attributesdata[attributesrowIndex + 1, attributescolumnIndex] = attributescollection[attributesrowIndex].AppointmentName;
                            break;
                        
                        case 1:
                            attributesdata[attributesrowIndex + 1, attributescolumnIndex] = attributescollection[attributesrowIndex].AptDate;
                            break;   
                    }
                }
            }

            Manager m = new Manager();
            m.ExportToExcel(attributesdata as object[,]);

        }
    }
}

       