using System;

namespace DeconsturctDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var (year, month, day) = DateTime.Now;
            Log(year, month, day);

            (year, month, day) = new DateTime(2021, 05, 16);
            Log(year, month, day);

            _ = Console.ReadKey();
        }

        static void Log(int year, int month, int day)
        {
            Console.WriteLine($"Year = {year}, Month = {month}, Day = {day}.");
        }
    }

    internal static class DateTimeExtension
    {
        /// <summary>
        /// 將日期型別解構成三個數字，分別為年、月、日。
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        public static void Deconstruct(this DateTime dateTime,
              out int year,
              out int month,
              out int day)
        {
            year = dateTime.Year;
            month = dateTime.Month;
            day = dateTime.Day;
        }
    }
}