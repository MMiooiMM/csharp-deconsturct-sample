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

            var (p1, p2) = new TestClass();
            Console.WriteLine($"p1 = {p1}, p2 = {p2}");

            _ = Console.ReadKey();
        }

        private static void Log(int year, int month, int day)
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

    internal class TestClass
    {
        public int Property1 { get; set; }
        public int Property2 { get; set; }

        public void Deconstruct(out int p1, out int p2)
        {
            p1 = 1;
            p2 = 2;
        }
    }

    internal static class TestClassExtension
    {
        public static void Deconstruct(out int p1, out int p2)
        {
            p1 = 10;
            p2 = 20;
        }
    }
}