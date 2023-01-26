using HolidayPlanner.Constants;

namespace HolidayPlanner.Constants
{
    public static class Messages
    {
        public static string INVALID_TIME_SPAN_DURATION_FINLAND => "Time Span is more than allowed duration of 50 days";
        public static string INVALID_TIME_SPAN_HOLIDAY_YEAR => "Holidays should be in the same holiday calendar year";
        public static string INVALID_START_DATE => "Start date is not valid. It cannot be before 01.01.2023 or after the end date";
        public static string INVALID_END_DATE => "End date is not valid. It cannot be after 31.12.2024 or before the start date";

    }
}
