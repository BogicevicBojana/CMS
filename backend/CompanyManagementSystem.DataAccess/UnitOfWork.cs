using CompanyManagementSystem.DataAccess.Repositories.Benefits;
using CompanyManagementSystem.DataAccess.Repositories.Languages;
using CompanyManagementSystem.DataAccess.Repositories.PublicHolidays;
using CompanyManagementSystem.DataAccess.Repositories.ReligiousHolidays;
using CompanyManagementSystem.DataAccess.Repositories.Roles;
using CompanyManagementSystem.DataAccess.Repositories.Skills;
using CompanyManagementSystem.DataAccess.Repositories.UserBenefits;
using CompanyManagementSystem.DataAccess.Repositories.UserLanguages;
using CompanyManagementSystem.DataAccess.Repositories.Users;
using CompanyManagementSystem.DataAccess.Repositories.UserSkills;
using CompanyManagementSystem.DataAccess.Repositories.UserStatuses;
using CompanyManagementSystem.DataAccess.Repositories.Vacations;
using CompanyManagementSystem.DataAccess.Repositories.WorkingPositions;
using CompanyManagementSystem.Data;
using CompanyManagementSystem.DataAccess.Repositories.UserReligiousHolidays;

namespace CompanyManagementSystem.DataAccess
{
    public class UnitOfWork : IUnitOfWork, IDisposable 
    {
        private ApplicationDbContext context;

        public IBenefitRepository benefitRepository {get; private set;}
        public ILanguageRepository languageRepository {get; private set;}
        public IPublicHolidayRepository publicHolidayRepository {get; private set;}
        public IReligiousHolidayRepository religiousHolidayRepository {get; private set;}
        public ISkillRepository skillRepository {get; private set;}
        public IUserRepository userRepository {get; private set;}
        public IUserBenefitRepository userBenefitRepository {get; private set;}
        public IUserLanguageRepository userLanguageRepository {get; private set;}
        public IUserReligiousHolidayRepository userReligiousHolidayRepository {get; private set;}
        public IUserSkillRepository userSkillRepository {get; private set;}
        public IUserStatusRepository userStatusRepository {get; private set;}
        public IVacationRepository vacationRepository {get; private set;}
        public IRoleRepository roleRepository {get; private set;}
        public IWorkingPositionRepository workingPositionRepository {get; private set;}


        public UnitOfWork( 
            ApplicationDbContext _context
        )
        {
            context = _context;

            benefitRepository = new BenefitRepository(context);
            languageRepository = new LanguageRepository(context);
            publicHolidayRepository = new PublicHolidayRepository(context);
            religiousHolidayRepository = new ReligiousHolidayRepository(context);
            skillRepository = new SkillRepository(context);
            userRepository = new UserRepository(context);
            userBenefitRepository = new UserBenefitRepository(context);
            userLanguageRepository = new UserLanguageRepository(context);
            userReligiousHolidayRepository = new UserReligiousHolidayRepository(context);
            userSkillRepository = new UserSkillRepository(context);
            userStatusRepository = new UserStatusRepository(context);
            vacationRepository = new VacationRepository(context);
            workingPositionRepository = new WorkingPositionRepository(context);
            roleRepository = new RoleRepository(context);
            
        }

        public void Complete()
        {
             context.SaveChanges();
        }

        public void Dispose()
        {
             context.Dispose();
        }
    }
}