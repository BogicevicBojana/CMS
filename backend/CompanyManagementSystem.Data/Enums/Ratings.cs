using System.ComponentModel; 

namespace CompanyManagementSystem.Data.Enums
{
    public enum Ratings
    {
        [Description("Doesn't have knowledge.")] 
        R0 = 1,
        [Description("Can't work on a commercial project, doesn't have enough knowledge.")]
        R1 = 2,
        [Description("Can work on a commercial project but it needs help (mentoring, monitoring).It will need more time for each task and someone experienced must be available during the project.")]
        R2 = 3,
        [Description("Can work on a commercial project independently, but it cannot adapt the work to different contexts or unusual situations, and for complicated cases it will need help.")]
        R3 = 4,
        [Description("Works completely independently on a commercial project, adapts work to different contexts, introduces innovations, solves complicated cases.")]
        R4 = 5
    }
}