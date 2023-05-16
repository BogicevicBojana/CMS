using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CompanyManagementSystem.Data.Enums;
using CompanyManagementSystem.Data.Models;
using CompanyManagementSystem.Data.Extensions;

namespace CompanyManagementSystem.Data
{
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
            //Relationship definition User -> UserRole
            builder
                .Entity<User>()
                .HasOne(user => user.UserRole)
                .WithMany(userRole => userRole.Users)
                .HasForeignKey(user => user.RoleId);

            //Relationship definition User -> UserWorkingPosition
            builder
                .Entity<User>()
                .HasOne(user => user.UserWorkingPosition)
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

            //Relationship definition ProjectDeveloper -> User
            builder
                .Entity<ProjectDeveloper>()
                .HasOne(projectDev => projectDev.User)
                .WithMany(user => user.ProjectDevelopers)
                .HasForeignKey(projectDev => projectDev.UserId);

            //Relationship definition ProjectDeveloper -> Project
            builder
                .Entity<ProjectDeveloper>()
                .HasOne(projectDev => projectDev.Project)
                .WithMany(project => project.ProjectDevelopers)
                .HasForeignKey(projectDev => projectDev.ProjectId);

            //Relationship definition ProjectSkill -> Project
            builder
                .Entity<ProjectSkill>()
                .HasOne(projectSkill => projectSkill.Project)
                .WithMany(project => project.ProjectSkills)
                .HasForeignKey(projectSkill => projectSkill.ProjectId);

            //Relationship definition ProjectSkill -> Skill
            builder
                .Entity<ProjectSkill>()
                .HasOne(projectSkill => projectSkill.Skill)
                .WithMany(skill => skill.ProjectSkills)
                .HasForeignKey(projectSkill => projectSkill.SkillId);

            //ProjectDeveloperSkill->Relation between project developer and project skills
            //ProjectDeveloperSkill ->ProjectDeveloper
            builder
                .Entity<ProjectDeveloperSkill>()
                .HasOne(projectDeveloperSkill => projectDeveloperSkill.ProjectDeveloper)
                .WithMany(projectDeveloper => projectDeveloper.DeveloperSkills)
                .HasForeignKey(projectDeveloperSkill => projectDeveloperSkill.ProjectDeveloperId);

            //ProjectDeveloperSkill->ProjectSkill
            builder
                .Entity<ProjectDeveloperSkill>()
                .HasOne(projectDeveloperSkill => projectDeveloperSkill.ProjectSkill)
                .WithMany(projectSkills => projectSkills.DeveloperSkills)
                .HasForeignKey(projectDeveloperSkill => projectDeveloperSkill.ProjectSkillId);
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

            //Relationship definition UserSkill -> SkillRating
            builder
                .Entity<UserSkill>()
                .HasOne(userSkill => userSkill.Skill)
                .WithMany(skillRating => skillRating.UserSkills)
                .HasForeignKey(userSkill => userSkill.SkillRatingId);

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

            // * DEFINING USER WORKING POSITION 1 to Many relation with user
            builder
                .Entity<UserWorkingPosition>()
                .HasMany<User>(u => u.Users)
                .WithOne(u => u.UserWorkingPosition)
                .HasForeignKey(u => u.WorkingPositionId);

            // * DEFINING User Role

            builder
                .Entity<UserRole>()
                .HasMany<User>(u => u.Users)
                .WithOne(u => u.UserRole)
                .HasForeignKey(u => u.RoleId);

            // ? RELATION: VACATION REQUEST and USER (Requested)
            builder
                .Entity<VacationRequest>()
                .HasOne(vacationRequest => vacationRequest.RequestedBy)
                .WithMany(user => user.RequestedVacationRequests)
                .HasForeignKey(vacationRequest =>
                    vacationRequest.RequestedById);

            // ? RELATION: VACATION REQUEST and USER (Processed)
            builder
                .Entity<VacationRequest>()
                .HasOne(vacationRequest => vacationRequest.ProcessedBy)
                .WithMany(user => user.ProcessedVacationRequests)
                .HasForeignKey(vacationRequest =>
                    vacationRequest.ProcessedById);

            // ? RELATION: VACATION REQUEST and VACATION
            builder
                .Entity<VacationRequest>()
                .HasOne(vacationRequest => vacationRequest.Vacation)
                .WithMany(vacationRequest => vacationRequest.VacationRequests)
                .HasForeignKey(vacationRequest => vacationRequest.VacationId);

            // * RELATION: REQUEST STATUS and VACATION REQUESTS
            builder
                .Entity<RequestStatus>()
                .HasMany<VacationRequest>(requestStatus =>
                    requestStatus.VacationRequests)
                .WithOne(requestStatus => requestStatus.RequestStatus)
                .HasForeignKey(requestStatus => requestStatus.RequestStatusId);

            // * Relation: Note and User (CreatedBy)
            builder.Entity<Note>()
                .HasOne(note => note.CreatedBy)
                .WithMany(user => user.CreatedNotes)
                .HasForeignKey(note => note.CreatedById);

            // * Relation: Note and User (AssignedTo)
            builder.Entity<Note>()
                .HasOne(note => note.AssignedTo)
                .WithMany(user => user.AssignedNotes)
                .HasForeignKey(note => note.AssignedToId);

            // * Enum Seeding
            builder.SeedEnum<Benefit, Benefits>(e => e);
            builder.SeedEnum<Language, Languages>(e => e);
            builder.SeedEnum<Skill, Skills>(e => e);
            builder.SeedEnum<SkillRating, Ratings>(e => e);
            builder.SeedEnum<RequestStatus, RequestStatuses>(e => e);
            builder.SeedEnum<UserRole, Roles>(e => e);
            builder.SeedEnum<UserStatus, UserStatuses>(e => e);
            builder.SeedEnum<UserWorkingPosition, WorkingPositions>(e => e);

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

        public DbSet<Project> Projects { get; set; }

        public DbSet<ProjectDeveloper> ProjectDevelopers { get; set; }

        public DbSet<ProjectDeveloperSkill> ProjectDeveloperSkills { get; set; }

        public DbSet<ProjectSkill> ProjectSkills { get; set; }

        public DbSet<PublicHoliday> PublicHolidays { get; set; }

        public DbSet<ReligiousHoliday> ReligiousHolidays { get; set; }

        public DbSet<RequestStatus> RequestStatuses { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<SkillRating> SkillRatings { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserBenefit> UserBenefits { get; set; }

        public DbSet<UserLanguage> UserLanguages { get; set; }

        public DbSet<UserReligiousHoliday> UserReligiousHolidays { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<UserSkill> UserSkills { get; set; }

        public DbSet<UserStatus> UserStatuses { get; set; }

        public DbSet<UserWorkingPosition> UserWorkingPositions { get; set; }

        public DbSet<Vacation> Vacations { get; set; }

        public DbSet<VacationRequest> VacationRequests { get; set; }
        public DbSet<Note> Notes { get; set; }
    }
}