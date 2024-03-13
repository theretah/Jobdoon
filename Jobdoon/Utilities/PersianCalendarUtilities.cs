using System.Globalization;

namespace Jobdoon.Utilities
{
    public static class PersianCalendarUtilities
    {
        public static string YearMonthDate(DateTime date)
        {
            var pc = new PersianCalendar();
            return pc.GetYear(date) + "/" + pc.GetMonth(date) + "/" + pc.GetDayOfMonth(date);
        }
    }
}
