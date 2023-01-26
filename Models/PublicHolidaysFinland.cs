namespace HolidayPlanner.Models
{
    public static class PublicHolidaysFinland
    {
        public static List<DateOnly> GetHolidays()
        {
            List<DateOnly> lstPublicHolidays = new List<DateOnly>();

            lstPublicHolidays.Add(new DateOnly(2023, 1, 1));
            lstPublicHolidays.Add(new DateOnly(2023, 1, 6));
            lstPublicHolidays.Add(new DateOnly(2023, 4, 10));
            lstPublicHolidays.Add(new DateOnly(2023, 4, 13));
            lstPublicHolidays.Add(new DateOnly(2023, 5, 1));
            lstPublicHolidays.Add(new DateOnly(2023, 5, 21));
            lstPublicHolidays.Add(new DateOnly(2023, 6, 19));
            lstPublicHolidays.Add(new DateOnly(2023, 12, 24));
            lstPublicHolidays.Add(new DateOnly(2023, 12, 25));
            
            lstPublicHolidays.Add(new DateOnly(2024, 1, 1));
            lstPublicHolidays.Add(new DateOnly(2024, 1, 6));
            lstPublicHolidays.Add(new DateOnly(2024, 4, 2));
            lstPublicHolidays.Add(new DateOnly(2024, 4, 5));
            lstPublicHolidays.Add(new DateOnly(2024, 5, 13));
            lstPublicHolidays.Add(new DateOnly(2024, 6, 20));
            lstPublicHolidays.Add(new DateOnly(2024, 12, 6));
            lstPublicHolidays.Add(new DateOnly(2024, 12, 24));

            return lstPublicHolidays;
        }
    }
}
