using System.ComponentModel.DataAnnotations;
using CompanyManagementSystem.Data.Enums;
using CompanyManagementSystem.Data.Extensions;

namespace CompanyManagementSystem.Data.Entities
{
    #pragma warning disable
    public class Language : TimeStamp
    {
        //Constructor with Enum type parameter
        public Language(Languages languages)
        {
            this.Id = (int)languages;
            this.Name = languages.ToDescription();
            this.DateCreated = DateTime.UtcNow;
            this.DateModified = DateTime.UtcNow;
        }
        public Language()
        {
            this.UserLanguages = new HashSet<UserLanguage>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public ICollection<UserLanguage> UserLanguages { get; set; }

        // * Operators used to allow implicit conversion between Enum type data and regular classes

        public static implicit operator Language(Languages @enum) => new Language(@enum);

        public static implicit operator Languages(Language language) => (Languages)language.Id;
    }

}