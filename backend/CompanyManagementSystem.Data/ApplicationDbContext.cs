using Microsoft.EntityFrameworkCore;
using CompanyManagementSystem.Data.Enums;
using CompanyManagementSystem.Data.Entities;
using CompanyManagementSystem.Data.Extensions;

namespace CompanyManagementSystem.Data
{
    #pragma warning disable
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options
        ) :
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Relationship definition User -> Role
            builder
                .Entity<User>()
                .HasOne(user => user.Role)
                .WithMany(role => role.Users)
                .HasForeignKey(user => user.RoleId);

            //Relationship definition User -> WorkingPosition
            builder
                .Entity<User>()
                .HasOne(user => user.WorkingPosition)
                .WithMany(position => position.Users)
                .HasForeignKey(user => user.WorkingPositionId);

            //Relationship definition User -> UserStatus
            builder
                .Entity<User>()
                .HasOne(user => user.UserStatus)
                .WithMany(status => status.Users)
                .HasForeignKey(user => user.StatusId);

            //Definition of unique property in User entity
            builder.Entity<User>().HasIndex(user => user.Email).IsUnique();

            //Relationship definition UserSkill -> User
            builder
                .Entity<UserSkill>()
                .HasOne(userSkill => userSkill.User)
                .WithMany(user => user.UserSkills)
                .HasForeignKey(userSkill => userSkill.UserId);

            //Relationship definition UserSkill -> Skill
            builder
                .Entity<UserSkill>()
                .HasOne(userSkill => userSkill.Skill)
                .WithMany(skill => skill.UserSkills)
                .HasForeignKey(userSkill => userSkill.SkillId);


            // * RELATION: USER BENEFITS and USER
            builder
                .Entity<UserBenefit>()
                .HasOne(userBenefit => userBenefit.User)
                .WithMany(UserBenefit => UserBenefit.UserBenefits)
                .HasForeignKey(userBenefit => userBenefit.UserId);

            // * RELATION: USER BENEFITS and USER
            builder
                .Entity<UserBenefit>()
                .HasOne(userBenefit => userBenefit.Benefit)
                .WithMany(userBenefit => userBenefit.UserBenefits)
                .HasForeignKey(userBenefit => userBenefit.BenefitId);

            // * RELATION: USER LANGUAGES and USER
            builder
                .Entity<UserLanguage>()
                .HasOne(userLanguage => userLanguage.User)
                .WithMany(userLanguage => userLanguage.UserLanguages)
                .HasForeignKey(userLanguage => userLanguage.UserId);

            // * RELATION: USER LANGUAGES and LANGUAGE
            builder
                .Entity<UserLanguage>()
                .HasOne(userLanguage => userLanguage.Language)
                .WithMany(userLanguage => userLanguage.UserLanguages)
                .HasForeignKey(userLanguage => userLanguage.LanguageId);

            // * RELATION:  User Religious Holiday AND USER
            builder
                .Entity<UserReligiousHoliday>()
                .HasOne(userReligiousHoliday => userReligiousHoliday.User)
                .WithMany(userReligiousHoliday =>
                    userReligiousHoliday.UserReligiousHolidays)
                .HasForeignKey(userReligiousHoliday =>
                    userReligiousHoliday.UserId);

            // * RELATION: User Religious Holiday and  Religious Holiday
            builder
                .Entity<UserReligiousHoliday>()
                .HasOne(userReligiousHoliday =>
                    userReligiousHoliday.ReligiousHoliday)
                .WithMany(userReligiousHoliday =>
                    userReligiousHoliday.UserReligiousHolidays)
                .HasForeignKey(userReligiousHoliday =>
                    userReligiousHoliday.ReligiousHolidayId);

            // * DEFINING USER STATUS 1 to Many Relation with user
            builder
                .Entity<UserStatus>()
                .HasMany<User>(u => u.Users)
                .WithOne(userStatus => userStatus.UserStatus)
                .HasForeignKey(u => u.StatusId);

            // * DEFINING WORKING POSITION 1 to Many relation with user
            builder
                .Entity<WorkingPosition>()
                .HasMany<User>(u => u.Users)
                .WithOne(u => u.WorkingPosition)
                .HasForeignKey(u => u.WorkingPositionId);

            builder
                .Entity<Vacation>()
                .HasOne(vacation => vacation.User)
                .WithMany(user => user.Vacations)
                .HasForeignKey(vacation => vacation.UserId);

            // * DEFINING User Role

            builder
                .Entity<Role>()
                .HasMany<User>(u => u.Users)
                .WithOne(u => u.Role)
                .HasForeignKey(u => u.RoleId);



            // * Enum Seeding
            builder.SeedEnum<Benefit, Benefits>(e => e);
            builder.SeedEnum<Language, Languages>(e => e);
            builder.SeedEnum<Skill, Skills>(e => e);
            builder.SeedEnum<Role, Roles>(e => e);
            builder.SeedEnum<UserStatus, UserStatuses>(e => e);
            builder.SeedEnum<WorkingPosition, WorkingPositions>(e => e);

        }

        // Override of SaveChanges() method for automatic setting of TimeStamp properties in each entity
        //SaveChanges Method has to be tested once the data has been added
        public override int SaveChanges()
        {
            var entries =
                ChangeTracker
                    .Entries()
                    .Where(e =>
                        e.Entity is TimeStamp &&
                        (
                        e.State == EntityState.Added ||
                        e.State == EntityState.Modified
                        ));

            foreach (var entry in entries)
            {
                ((TimeStamp)entry.Entity).DateModified = DateTime.UtcNow;

                if (entry.State == EntityState.Added)
                {
                    ((TimeStamp)entry.Entity).DateCreated = DateTime.UtcNow;
                }
            }
            return base.SaveChanges();
        }

        public DbSet<Benefit> Benefits { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<PublicHoliday> PublicHolidays { get; set; }

        public DbSet<ReligiousHoliday> ReligiousHolidays { get; set; }


        public DbSet<Skill> Skills { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserBenefit> UserBenefits { get; set; }

        public DbSet<UserLanguage> UserLanguages { get; set; }

        public DbSet<UserReligiousHoliday> UserReligiousHolidays { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<UserSkill> UserSkills { get; set; }

        public DbSet<UserStatus> UserStatuses { get; set; }

        public DbSet<WorkingPosition> WorkingPositions { get; set; }

        public DbSet<Vacation> Vacations { get; set; }

    }
}