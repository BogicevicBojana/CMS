using Models = CompanyManagementSystem.API.Models;
using CompanyManagementSystem.Data.Entities;
using CompanyManagementSystem.Data.Enums;

namespace CompanyManagementSystem.API.Utils
{
    public static class Mappers 
    {
        public static Models.User MapToUserDto(User user)
        {
            Models.User mapped = new Models.User {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                DateOfBirth = user.DateOfBirth,
                MobileNumber = user.MobileNumber,
                EmploymentDate = user.EmploymentDate,
                Email = user.Email,
                Address = user.Address,
                FreeDays = user.FreeDays,
                Skills = new List<Models.Skill> (),
                Languages = new List<Models.Language>(),
                Benefits = new List<Models.Benefit>(),
                Role = new Models.Role {
                    Id = user.RoleId,
                    Name = user.Role.Name
                },
                UserStatus = new Models.UserStatus {
                    Id = user.StatusId,
                    Name = user.UserStatus.Name
                },
                WorkingPosition = new Models.WorkingPosition {
                    Id = user.WorkingPositionId,
                    Name = user.WorkingPosition.Name
                },
                Vacations = new List<Models.BaseVacation>(),
                ReligiousHolidays = new List<Models.ReligiousHoliday>(),
                FullName = user.FirstName + " " + user.LastName
            };
            
            foreach (var item in user.UserSkills)
            {
                var skill = new Models.Skill {
                    Id = item.SkillId,
                    Name = item.Skill.Name
                };
                mapped.Skills.Add(skill);
            }
            foreach (var item in user.UserBenefits)
            {
                var benefit = new Models.Benefit {
                    Id = item.BenefitId,
                    Name = item.Benefit.Name
                };
                mapped.Benefits.Add(benefit);
            }
            foreach (var item in user.UserLanguages)
            {
                var language = new Models.Language {
                    Id = item.LanguageId,
                    Name = item.Language.Name
                };
                mapped.Languages.Add(language);
            }
            foreach (var item in user.Vacations)
            {
                var vacation = new Models.BaseVacation {
                    Id = item.Id,
                    StartDate = item.StartDate,
                    EndDate = item.EndDate
                };
                mapped.Vacations.Add(vacation);
            }
            foreach (var item in user.UserReligiousHolidays)
            {
                var holiday = new Models.ReligiousHoliday {
                    Id = item.ReligiousHolidayId,
                    Date = item.ReligiousHoliday.Date
                };
                mapped.ReligiousHolidays.Add(holiday);
            }
            return mapped;
        }

        public static User MapToUserEntity(Models.UserRegister user)
        {
            User mapped = new User {
                FirstName = user.FirstName,
                LastName = user.LastName,
                EmploymentDate = user.EmploymentDate,
                Email = user.Email,
                UserSkills = new List<UserSkill> (),
                UserLanguages = new List<UserLanguage>(),
                UserBenefits = new List<UserBenefit>(),
                RoleId = user.RoleId,
                FreeDays = 20,
                StatusId = (int)UserStatuses.Active,
                WorkingPositionId = user.WorkingPositionId,
                Vacations = new List<Vacation>(),
                UserReligiousHolidays = new List<UserReligiousHoliday>()
            };
            
            return mapped;
        }
        public static User MapToUserEntity(Models.UserUpdate user)
        {
            User mapped = new User {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                EmploymentDate = user.EmploymentDate,
                Email = user.Email,
                StatusId = (int)UserStatuses.Active,
                UserSkills = new List<UserSkill> (),
                UserLanguages = new List<UserLanguage>(),
                UserBenefits = new List<UserBenefit>(),
                RoleId = user.RoleId,
                WorkingPositionId = user.WorkingPositionId,
            };
            
            return mapped;
        }

        public static UserBenefit MapToUserBenefitEntity(Models.UserBenefit userBenefitDto)
        {
            UserBenefit mapped = new UserBenefit {
                UserId = userBenefitDto.UserId,
                BenefitId = userBenefitDto.BenefitId
            };
            return mapped;
        }

        public static Models.Benefit MapToBenefitDto(Benefit benefit)
        {
            Models.Benefit mapped  = new Models.Benefit {
                Id = benefit.Id,
                Name = benefit.Name
            };
            return mapped;
        }

        public static UserSkill mapToUserSkillEntity(int userId, int skillId)
        {
            return new UserSkill{
                SkillId = skillId,
                UserId = userId
            };
        }
        public static UserLanguage mapToUserLanguageEntity(int userId, int languageId)
        {
            return new UserLanguage{
                LanguageId = languageId,
                UserId = userId
            };
        }

        public static UserReligiousHoliday mapToUserReligiousHoliday(int userId, int holidayId)
        {
            return new UserReligiousHoliday {
                ReligiousHolidayId = holidayId,
                UserId = userId
            };
        }

        public static Models.Vacation mapToVacationDTO(Vacation vacation)
        {
            return new Models.Vacation {
                StartDate = vacation.StartDate,
                EndDate = vacation.EndDate,
                Id = vacation.Id,
                User = new Models.BaseUser {
                    Id = vacation.UserId,
                    FirstName = vacation.User.FirstName,
                    LastName = vacation.User.LastName,
                    FullName = vacation.User.FirstName + " " + vacation.User.LastName
                }
            };
        }
        public static Vacation mapToVacationEntity(Models.InsertVacation vacation)
        {
            return new Vacation {
                StartDate = vacation.StartDate,
                EndDate = vacation.EndDate,
                UserId = vacation.UserId
            };
        }
    }
}