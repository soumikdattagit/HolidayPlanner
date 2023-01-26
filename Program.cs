// See https://aka.ms/new-console-template for more information
using HolidayPlanner;
using HolidayPlanner.Business;

ProcessHolidays();

static void ProcessHolidays()
{
    // At present only 1 country code is present in the Countries
    // Later, it can be made dynamic to accept different countries
    // holiday list
    int countryCode = 1;
    DateOnly startDate = new DateOnly(2023, 12, 10);
    DateOnly endDate = new DateOnly(2024, 1, 10);
    int consumedHolidays = 0;

    Planner objPlanner = new Planner(startDate, endDate);
    consumedHolidays = objPlanner.CalculateHolidays(countryCode);

    Console.WriteLine("\n \nTotal number of consumed holidays: " + consumedHolidays);
    Console.ReadLine();

}




// Starting calendar year & Ending calendar year are considered
// From 01.01.2023 to 31.12.2024
// within which we have data for public holidays.
// Hence, we calculate the employee holidays within the boundary 
// of these 2 years for the sake of this solution.
// A more generic & finer solution can be achieved in a more dynamic scenario


