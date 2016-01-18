using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Guest_Booker_Studio.ViewModel;

namespace Guest_Booker_Studio.ValidationCheck
{
    public class Validations : ValidationsStructure
    {
        #region CustomerValidations
        public ValidationsStructure PerformMandatoryCustomerValidations(CustomerFormViewModel viewModel)
        {
            var validationResult = new ValidationsStructure();
            if (viewModel.Organization != String.Empty && viewModel.FromDate != null && viewModel.FromDate <= viewModel.ToDate && viewModel.ToDate != null && viewModel.PhoneNumber != String.Empty && viewModel.NumOfPeople != 0)
            {
                validationResult.Result = "Success";
                validationResult.Message = "A new customer has been added successfully!";
                validationResult.TypeOfException = String.Empty;
                return validationResult;
            }
            else
            {
                validationResult.Result = "Failure";
                validationResult.Message = "Some fields are mandatory. Please provide values for all the fields and try again. Or the entered from date is greater than the to date. Please re-check.";
                validationResult.TypeOfException = "MandatoryFieldsNotEnteredException";
                return validationResult;
            }        
        }

        public ValidationsStructure PerformMandatoryContactValidations(ContactFormViewModel viewModel)
        {
            var validationResult = new ValidationsStructure();
            if (viewModel.Organization != String.Empty && viewModel.ContactName!=String.Empty && viewModel.PhoneNumber != String.Empty)
            {
                validationResult.Result = "Success";
                validationResult.Message = "A new contact has been added successfully!";
                validationResult.TypeOfException = String.Empty;
                return validationResult;
            }
            else
            {
                validationResult.Result = "Failure";
                validationResult.Message = "Some fields are mandatory. Please provide values for all the fields and try again.";
                validationResult.TypeOfException = "MandatoryFieldsNotEnteredException";
                return validationResult;
            }
        }
        #endregion CustomerValidations
    }
}
