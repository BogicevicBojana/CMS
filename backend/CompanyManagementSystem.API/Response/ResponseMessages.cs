using System.ComponentModel;

namespace CompanyManagementSystem.API.Response
{
    public enum ResponseMessages
    {
        [Description("Action completed succesfully.")]
        OK = 1,
        [Description("Item with provided id doesn't exist")]
        DoesNotExist = 2,
        [Description("Something went wrong")]
        SomethingWentWrong = 3,
        [Description("Configuration code is wrong or not present")]
        ConfigCodeMissingOrWrong = 4,
        [Description("User with that email already exists")]
        UserAlreadyExists = 5,
        [Description("All field must contain value")]
        ValidationError = 6,
        [Description("Start date cannot be after end date")]
        StartDateError = 7,
        [Description("Vacation between those dates already exists for the user")]
        VacationAlreadyExists = 8
    }
}