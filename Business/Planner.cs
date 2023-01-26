using HolidayPlanner.Common;
using HolidayPlanner.Constants;
using HolidayPlanner.Models;

namespace HolidayPlanner.Business
{
    public class Planner
    {
        Validators _objValidators;
        int _calculatedHoliDays = 0;
        List<DateOnly> _lstPublicHolidays;
        DateOnly _startDate;
        DateOnly _endDate;

        public Planner(DateOnly startDate, DateOnly endDate)
        {
            _startDate = startDate;
            _endDate = endDate;
            _objValidators = new Validators(startDate, endDate);
            _lstPublicHolidays = new List<DateOnly>();
        }

        /// <summary>
        /// Calculates holidays based on given start date & end date
        /// </summary>
        /// <returns></returns>
        public int CalculateHolidays(int inputCountry)
        {
            if (_objValidators.IsValidStartDate() &&
                _objValidators.IsValidEndDate() &&
                IsWithinCurrentHolidayPeriod() &&
                IsLengthWithinAllowedRange())
            {
                _calculatedHoliDays = DoCalculation(inputCountry);
            }

            return _calculatedHoliDays;
        }

        /// <summary>
        /// Checks if requested dates fall within same holiday calendar year
        /// </summary>
        /// <returns></returns>
        public bool IsWithinCurrentHolidayPeriod()
        {
            if (!_objValidators.IsWithinSameHolidayCalendar())
            {
                _calculatedHoliDays = 0;
                return false;
            }

            return true;
        }

        /// <summary>
        /// Checks for allowed duration as per Finnish rules (ex: 50 days)
        /// </summary>
        /// <returns></returns>
        public bool IsLengthWithinAllowedRange()
        {
            if (!_objValidators.IsLengthWithinAllowedRange())
            {
                _calculatedHoliDays = 0;
                return false;
            }

            return true;
        }

        /// <summary>
        /// Removes public holidays & Sundays from requested dates
        /// </summary>
        /// <returns></returns>
        public int DoCalculation(int inputCountry)
        {
            List<DateOnly> lstRequestedDates = new List<DateOnly>();
            GetPublicHolidaysByCountry(inputCountry);

            for (DateOnly date = _startDate; _endDate.CompareTo(date) >= 0; date = date.AddDays(1))
            {
                lstRequestedDates.Add(date);
            }

            var lstPublicHolidaysWithinRequest = lstRequestedDates.Intersect(_lstPublicHolidays);

            if (lstPublicHolidaysWithinRequest.Any())
            {
                lstRequestedDates = lstRequestedDates.Except(lstPublicHolidaysWithinRequest).ToList();
            }
            
            lstRequestedDates = lstRequestedDates.Where(item => item.DayOfWeek != DayOfWeek.Sunday).ToList();

            return lstRequestedDates.Count();
        }

        /// <summary>
        /// Gets public holiday list by country code provided by user input
        /// If nothing matches Finland public holidays are accepted by default
        /// </summary>
        /// <param name="inputCountry"></param>
        /// <returns></returns>
        public void GetPublicHolidaysByCountry(int inputCountry)
        {
            switch (inputCountry)
            {
                //Finland - found in Countries.cs
                case 1:
                    _lstPublicHolidays = PublicHolidaysFinland.GetHolidays();
                    break;
                
                default:
                    _lstPublicHolidays = PublicHolidaysFinland.GetHolidays();
                    break;
            }
        }
    }
}
