using CompanyManagementSystem.Data.Entities;
using CompanyManagementSystem.Data.Enums;
using Microsoft.EntityFrameworkCore;

namespace CompanyManagementSystem.Data.Extensions
{
    public static class DataSeedExtensions 
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { 
                    Id = 1,
                    FirstName = "Nikola", 
                    LastName = "Nikolić",
                    Address = "Vojvode Putnika 34", 
                    MobileNumber = "0601112233", 
                    WorkingPositionId = (int)WorkingPositions.SoftwareDeveloper, 
                    RoleId = (int)Roles.Administrator, 
                    EmploymentDate = new DateOnly(2022,1,1),
                    DateOfBirth = new DateOnly(2000,2,1),
                    Email = "nikola.nikolic@gmail.com",
                    FreeDays = 14,
                    StatusId = (int)UserStatuses.Active
                },
                new User { 
                    Id = 2,
                    FirstName = "Jovan", 
                    LastName = "Jovanović",
                    Address = "Heroja Maričića 12", 
                    MobileNumber = "0601112222", 
                    WorkingPositionId = (int)WorkingPositions.SoftwareDeveloper, 
                    RoleId = (int)Roles.Administrator, 
                    EmploymentDate = new DateOnly(2020,12,20),
                    DateOfBirth = new DateOnly(2000,5,17),
                    Email = "jovan.jovanovic@gmail.com",
                    FreeDays = 7,
                    StatusId = (int)UserStatuses.Active
                },
                new User { 
                    Id = 3,
                    FirstName = "Jelena", 
                    LastName = "Matić",
                    Address = "Zlatarska BB", 
                    MobileNumber = "0612233234", 
                    WorkingPositionId = (int)WorkingPositions.Designer, 
                    RoleId = (int)Roles.Employee, 
                    EmploymentDate = new DateOnly(2012,1,1),
                    DateOfBirth = new DateOnly(1988,2,1),
                    Email = "jelena.matic@gmail.com",
                    FreeDays = 13,
                    StatusId = (int)UserStatuses.Active
                },
                new User { 
                    Id = 4,
                    FirstName = "Stefan", 
                    LastName = "Jovanović",
                    Address = "Svetozara Markovića 21", 
                    MobileNumber = "0667811223", 
                    WorkingPositionId = (int)WorkingPositions.SoftwareDeveloper, 
                    RoleId = (int)Roles.Employee, 
                    EmploymentDate = new DateOnly(2018,3,17),
                    DateOfBirth = new DateOnly(1998,2,13),
                    Email = "stefan.jovanovic@gmail.com",
                    FreeDays = 17,
                    StatusId = (int)UserStatuses.Active
                },
                new User { 
                    Id = 5,
                    FirstName = "Nemanja", 
                    LastName = "Novaković",
                    Address = "Beogradska 117", 
                    MobileNumber = "0652221112", 
                    WorkingPositionId = (int)WorkingPositions.SoftwareDeveloper, 
                    RoleId = (int)Roles.Employee, 
                    EmploymentDate = new DateOnly(2017,1,1),
                    DateOfBirth = new DateOnly(2000,2,13),
                    Email = "nemanja.novakovic@gmail.com",
                    FreeDays = 20,
                    StatusId = (int)UserStatuses.Inactive
                },
                new User { 
                    Id = 6,
                    FirstName = "Jovana", 
                    LastName = "Nikolić",
                    Address = "Cara Dušana 12", 
                    MobileNumber = "0630001123", 
                    WorkingPositionId = (int)WorkingPositions.Designer, 
                    RoleId = (int)Roles.Employee, 
                    EmploymentDate = new DateOnly(2016,10,1),
                    DateOfBirth = new DateOnly(1999,5,19),
                    Email = "jovana.nikolic@gmail.com",
                    FreeDays = 15,
                    StatusId = (int)UserStatuses.Active
                },
                new User { 
                    Id = 7,
                    FirstName = "Vladimir", 
                    LastName = "Vasić",
                    Address = "Cara Lazara 92", 
                    MobileNumber = "0645566123", 
                    WorkingPositionId = (int)WorkingPositions.SoftwareDeveloper, 
                    RoleId = (int)Roles.Employee, 
                    EmploymentDate = new DateOnly(2013,7,1),
                    DateOfBirth = new DateOnly(1995,8,14),
                    Email = "vladimir.vasic@gmail.com",
                    FreeDays = 20,
                    StatusId = (int)UserStatuses.Active
                },
                new User { 
                    Id = 8,
                    FirstName = "Jakov", 
                    LastName = "Jović",
                    Address = "Vojvode Stepe 51", 
                    MobileNumber = "0665647999", 
                    WorkingPositionId = (int)WorkingPositions.Designer, 
                    RoleId = (int)Roles.Administrator, 
                    EmploymentDate = new DateOnly(2014,1,1),
                    DateOfBirth = new DateOnly(1997,2,1),
                    Email = "jakov.jovic@gmail.com",
                    FreeDays = 10,
                    StatusId = (int)UserStatuses.Inactive
                },
                new User { 
                    Id = 9,
                    FirstName = "Nataša", 
                    LastName = "Lotić",
                    Address = "Stefana Prvovenčanog 45", 
                    MobileNumber = "0667800123", 
                    WorkingPositionId = (int)WorkingPositions.SoftwareDeveloper, 
                    RoleId = (int)Roles.Administrator, 
                    EmploymentDate = new DateOnly(2012,1,1),
                    DateOfBirth = new DateOnly(1990,4,15),
                    Email = "natasa.lotic@gmail.com",
                    FreeDays = 20,
                    StatusId = (int)UserStatuses.Active
                },
                new User { 
                    Id = 10,
                    FirstName = "Nikola", 
                    LastName = "Stefanović",
                    Address = "Dositejeva 41", 
                    MobileNumber = "0656661123", 
                    WorkingPositionId = (int)WorkingPositions.Designer, 
                    RoleId = (int)Roles.Employee, 
                    EmploymentDate = new DateOnly(2010,1,1),
                    DateOfBirth = new DateOnly(1975,2,14),
                    Email = "nikola.stefanovic@gmail.com",
                    FreeDays = 17,
                    StatusId = (int)UserStatuses.Active
                },
                new User { 
                    Id = 11,
                    FirstName = "Petar", 
                    LastName = "Petrović",
                    Address = "Cara Lazara 17", 
                    MobileNumber = "0617788931", 
                    WorkingPositionId = (int)WorkingPositions.SoftwareDeveloper, 
                    RoleId = (int)Roles.Employee, 
                    EmploymentDate = new DateOnly(2021,1,1),
                    DateOfBirth = new DateOnly(1995,5,19),
                    Email = "petar.petrovic@gmail.com",
                    FreeDays = 20,
                    StatusId = (int)UserStatuses.Active
                },
                new User { 
                    Id = 12,
                    FirstName = "Nevena", 
                    LastName = "Matijević",
                    Address = "Vojvode Mišića 31", 
                    MobileNumber = "0645412345", 
                    WorkingPositionId = (int)WorkingPositions.SoftwareDeveloper, 
                    RoleId = (int)Roles.Employee, 
                    EmploymentDate = new DateOnly(2019,1,1),
                    DateOfBirth = new DateOnly(1996,5,22),
                    Email = "nevena.matijevic@gmail.com",
                    FreeDays = 20,
                    StatusId = (int)UserStatuses.Inactive
                },
                new User { 
                    Id = 13,
                    FirstName = "Miloš", 
                    LastName = "Milošević",
                    Address = "Dimitrija Tucovića 45", 
                    MobileNumber = "0656612342", 
                    WorkingPositionId = (int)WorkingPositions.SoftwareDeveloper, 
                    RoleId = (int)Roles.Employee, 
                    EmploymentDate = new DateOnly(2012,1,1),
                    DateOfBirth = new DateOnly(1978,8,15),
                    Email = "milos.milosevic@gmail.com",
                    FreeDays = 20,
                    StatusId = (int)UserStatuses.Active
                },
                new User { 
                    Id = 14,
                    FirstName = "Jana", 
                    LastName = "Petrović",
                    Address = "Sinđelićeva 21", 
                    MobileNumber = "0641237634", 
                    WorkingPositionId = (int)WorkingPositions.SoftwareDeveloper, 
                    RoleId = (int)Roles.Administrator, 
                    EmploymentDate = new DateOnly(2020,5,1),
                    DateOfBirth = new DateOnly(1997,10,2),
                    Email = "jana.petrovic@gmail.com",
                    FreeDays = 20,
                    StatusId = (int)UserStatuses.Inactive
                }
                );
                Random random = new Random();
                List<UserBenefit> benefits = new List<UserBenefit>();
                var counter = 1;

                for (int i = 1; i < 15; i++)
                {
                    for(int j = 0; j< 2; j++)
                    {
                        benefits.Add(new UserBenefit{
                            Id = counter++,
                            UserId = i,
                            BenefitId = random.Next(1,8)
                        });
                    }
                }
                List<UserLanguage> languages = new List<UserLanguage>();
                counter = 1;

                for (int i = 1; i < 15; i++)
                {
                    for(int j = 0; j< random.Next(1,4); j++)
                        languages.Add(new UserLanguage{
                            Id = counter++,
                            UserId = i,
                            LanguageId = random.Next(1,10)
                        });
                }
                List<UserSkill> skills = new List<UserSkill>();
                counter = 1;

                for (int i = 1; i < 15; i++)
                {
                    for(int j = 0; j< random.Next(1,4); j++)
                        skills.Add(new UserSkill{
                            Id = counter++,
                            UserId = i,
                            SkillId = random.Next(1,30)
                        });
                }
                modelBuilder.Entity<UserBenefit>().HasData(benefits);
                modelBuilder.Entity<UserLanguage>().HasData(languages);
                modelBuilder.Entity<UserSkill>().HasData(skills);

                List<Vacation> vacations = new List<Vacation>();
                counter = 1;

                for (int i = 1; i < 15; i++)
                {
                    for (int j = 0; j < random.Next(1,4); j++)
                    {
                        var month = random.Next(1,12);
                        var day = random.Next(1,26);
                        vacations.Add(
                            new Vacation {
                                Id = counter++,
                                UserId = i,
                                StartDate = new DateOnly(2023, month, day),
                                EndDate = new DateOnly(2023, month, day == 26 ? day + 1 : day + random.Next(1,4))
                            }
                        );
                    }
                }

                modelBuilder.Entity<Vacation>().HasData(vacations);
        }
    }
}