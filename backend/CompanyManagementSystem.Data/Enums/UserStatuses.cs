using System.ComponentModel;

namespace CompanyManagementSystem.Data.Enums
{
    public enum UserStatuses
    {
        [Description("Pending")]
        Pending = 1,
        [Description("Active")]
        Active = 2,
        [Description("Inactive")]
        Inactive = 3
    }

}