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
                Vacations = new List<Models.BaseVacationRequest>(),
                ReligiousHolidays = new List<Models.ReligiousHoliday>()
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
            foreach (var item in user.RequestedVacationRequests)
            {
                var vacation = new Models.BaseVacationRequest {
                    Id = item.Id,
                    Vacation = new Models.Vacation {
                        Id = item.VacationId,
                        StartDate = item.Vacation.StartDate,
                        EndDate = item.Vacation.EndDate
                    },
                    RequestStatus = new Models.RequestStatus {
                        Id = item.RequestStatusId,
                        Name = item.RequestStatus.Name
                    }
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
                RequestedVacationRequests = new List<VacationRequest>(),
                ProcessedVacationRequests = new List<VacationRequest>(),
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
                UserSkills = new List<UserSkill> (),
                UserLanguages = new List<UserLanguage>(),
                UserBenefits = new List<UserBenefit>(),
                RoleId = user.RoleId,
                FreeDays = user.FreeDays,
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
    }
}