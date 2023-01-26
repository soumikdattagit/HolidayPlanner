
namespace HolidayPlanner
{
    public static class Countries
    {
        public static Dictionary<int, string> GetCountries()
        {
            Dictionary<int, string> dictCountries = new Dictionary<int, string>();
            dictCountries.Add(1, "FINLAND");
            return dictCountries;
        }
    }
}
