using System.ComponentModel;

namespace CompanyManagementSystem.Data.Enums
{
    public enum RequestStatuses
    {
        [Description("Pending acceptance")]
        PendingAcceptance = 1,
        [Description("Pending")]
        Pending = 2,
        [Description("Rejected")]
        Rejected = 3,
        [Description("Accepted")]
        Accepted = 4
    }
}