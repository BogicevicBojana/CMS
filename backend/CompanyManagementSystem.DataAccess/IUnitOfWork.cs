using CompanyManagementSystem.DataAccess.Repositories.Benefits;
using CompanyManagementSystem.DataAccess.Repositories.Languages;
using CompanyManagementSystem.DataAccess.Repositories.PublicHolidays;
using CompanyManagementSystem.DataAccess.Repositories.ReligiousHolidays;
using CompanyManagementSystem.DataAccess.Repositories.RequestStatuses;
using CompanyManagementSystem.DataAccess.Repositories.Roles;
using CompanyManagementSystem.DataAccess.Repositories.Skills;
using CompanyManagementSystem.DataAccess.Repositories.UserBenefits;
using CompanyManagementSystem.DataAccess.Repositories.UserLanguages;
using CompanyManagementSystem.DataAccess.Repositories.Users;
using CompanyManagementSystem.DataAccess.Repositories.UserSkills;
using CompanyManagementSystem.DataAccess.Repositories.UserStatuses;
using CompanyManagementSystem.DataAccess.Repositories.VacationRequests;
using CompanyManagementSystem.DataAccess.Repositories.Vacations;
using CompanyManagementSystem.DataAccess.Repositories.WorkingPositions;
using CompanyManagementSystem.DataAccess.Repositories.UserReligiousHolidays;

namespace CompanyManagementSystem.DataAccess
{
    public interface IUnitOfWork
    {
        IBenefitRepository benefitRepository {get;}
        ILanguageRepository languageRepository{get;}
        IPublicHolidayRepository publicHolidayRepository {get;}
        IReligiousHolidayRepository religiousHolidayRepository {get;}
        IRequestStatusRepository requestStatusRepository{get;}
        ISkillRepository skillRepository{get;}
        IUserRepository userRepository{get;}
        IUserBenefitRepository userBenefitRepository{get;}
        IUserLanguageRepository userLanguageRepository{get;}
        IUserReligiousHolidayRepository userReligiousHolidayRepository {get;}
        IRoleRepository roleRepository{get;}
        IUserSkillRepository userSkillRepository{get;}
        IUserStatusRepository userStatusRepository{get;}
        IWorkingPositionRepository workingPositionRepository{get;}
        IVacationRepository vacationRepository {get;}
        IVacationRequestRepository vacationRequestRepository {get;}
        
        void Complete();
        
    }
}