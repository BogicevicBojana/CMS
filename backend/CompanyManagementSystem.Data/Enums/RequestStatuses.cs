using System.ComponentModel;

namespace CompanyManagementSystem.Data.Enums
{
    public enum RequestStatuses
    {
        [Description("Pending")]
        Pending = 1,
        [Description("Rejected")]
        Rejected = 2,
        [Description("Accepted")]
        Accepted = 3
    }
}