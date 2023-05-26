using System.ComponentModel;
using Microsoft.EntityFrameworkCore;

namespace CompanyManagementSystem.Data.Extensions
{
    #pragma warning disable
    public static class EnumExtensions
    {
        // *Generic method for getting Description Attribute
        public static string ToDescription<TEnum>(this TEnum value)
        => value.GetType()
               .GetField(value.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false)
               .Cast<DescriptionAttribute>()
               .FirstOrDefault()?.Description ?? string.Empty;

        //*Generic method for Enum Seed
        public static void SeedEnum<T, TEnum>(this ModelBuilder modelBuilder, Func<TEnum, T> converter) where T : class 
        => Enum.GetValues(typeof(TEnum))
                .Cast<object>()
                .Select(value => converter((TEnum)value))
                .ToList()
                .ForEach(instance => modelBuilder.Entity<T>().HasData(instance));
    
    }
    
}