namespace CompanyManagementSystem.API.Utils
{
    public static class ValidationUtils
    {
        public static bool isNullOrEmpty(this string value)
        {
            return value is null || value == "";
        }

        public static bool isNull(this object value)
        {
            return value is null;
        }

        public static bool isNullOrEmpty<T>(this List<T> value)
        {
            return value is null || value.Count() is 0;
        }
    }
}