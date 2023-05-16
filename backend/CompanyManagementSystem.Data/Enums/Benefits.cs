using System.ComponentModel;

namespace CompanyManagementSystem.Data.Enums
{
    public enum Benefits
    {
        [Description("Private health insurance")]
        HealthInsurance = 1,
        [Description("Foreign language lessons")]
        LanguageLesson = 2,
        [Description("Remote work")]
        RemoteWork = 3,
        [Description("Employee learning and advancement")]
        EmployeeAdvancement = 4,
        [Description("Paid courses and literature for professional development")]
        ProfessionalDevelopment = 5,
        [Description("Additional day off for one year of experience (+1 day)")]
        OneYearExperience = 6,
        [Description("Additional days off for more than three years of experience (+2 days)")]
        ThreeYearExperience = 7,
        [Description("Paid sports activities")]
        SportActivity = 8,
        [Description("Parents day off (+1 day)")]
        ParentsDayOff = 9,
        [Description("Courses for team-leader positions")]
        TeamLeadCourse = 10

    }
}