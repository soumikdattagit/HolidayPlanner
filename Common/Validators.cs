using HolidayPlanner.Constants;

namespace HolidayPlanner.Common
{
    public class Validators
    {
        HolidayRules _objHolidayRules;
        DateOnly _startDate;
        DateOnly _endDate;

        public Validators(DateOnly startDate, DateOnly endDate)
        {
            _startDate = startDate;
            _endDate = endDate;
            _objHolidayRules = new HolidayRules();
        }

        /// <summary>
        /// Calculates the employee holidays within the boundary 
        /// of these 2 years for the sake of this solution.
        /// It can be further refined to accept any range based on
        /// the Public Holidays list.
        /// </summary>
        /// <returns></returns>
        public bool IsWithinSameHolidayCalendar()
        {
            if (_startDate.CompareTo(new DateOnly(2023, 03, 31)) <= 0 &&
                _endDate.CompareTo(new DateOnly(2023, 03, 31)) <= 0)
            {
                return true;
            }

            if (_startDate.CompareTo(new DateOnly(2023, 04, 1)) >= 0 &&
                _endDate.CompareTo(new DateOnly(2024, 03, 31)) <= 0)
            {
                return true;
            }

            if (_startDate.CompareTo(new DateOnly(2024, 04, 1)) >= 0 &&
                _endDate.CompareTo(new DateOnly(2024, 12, 31)) <= 0)
            {
                return true;
            }

            Console.WriteLine(Messages.INVALID_TIME_SPAN_HOLIDAY_YEAR);
            Console.ReadLine();

            return false;
        }

        /// <summary>
        /// Checks for allowed duration as per Finnish rules (ex: 50 days)
        /// </summary>
        /// <returns></returns>
        public bool IsLengthWithinAllowedRange()
        {
            int DaySpan = _endDate.DayNumber - _startDate.DayNumber;

            if (DaySpan > _objHolidayRules.AllowedDays)
            {
                Console.WriteLine(Messages.INVALID_TIME_SPAN_DURATION_FINLAND);
                Console.ReadLine();

                return false;
            }

            return true;
        }

        /// <summary>
        /// Checks if start date is on or after
        /// 01.01.2023 & also if at least same 
        /// or before the end date
        /// </summary>
        /// <returns></returns>
        public bool IsValidStartDate()
        {
            if (!(_startDate.CompareTo(new DateOnly(2023, 1, 1)) >= 0
                && _startDate.CompareTo(_endDate) <= 0))
            {
                Console.WriteLine(Messages.INVALID_START_DATE);
                Console.ReadLine();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Checks if end date is on or before
        /// 31.12.2024 & also if at least same 
        /// or after the start date
        /// </summary>
        /// <returns></returns>
        public bool IsValidEndDate()
        {
            if (!(_endDate.CompareTo(new DateOnly(2024, 12, 31)) <= 0
                && _endDate.CompareTo(_startDate) >= 0))
            {
                Console.WriteLine(Messages.INVALID_END_DATE);
                Console.ReadLine();
                return false;
            }

            return true;
        }
    }
}
