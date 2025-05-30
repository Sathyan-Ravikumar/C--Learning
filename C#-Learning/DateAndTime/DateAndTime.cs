using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.DateAndTime
{
    public class DateAndTime : ILearnInterface
    {

        public void Run()
        {
            var date = DateTime.Now;
            DateTime date1 = DateTime.UtcNow;
            Console.WriteLine($"DateTime Now : {date.ToShortDateString()}");
            Console.WriteLine($"DateTime UtcNow : {date1}");

            //convert string to date time
            var parse = DateTime.Parse("21.3.2024");
            Console.WriteLine($"String to datetime : {parse}");


            Console.WriteLine();
            // all the time zones..
            ReadOnlyCollection<TimeZoneInfo> tz;
            tz = TimeZoneInfo.GetSystemTimeZones();
            foreach (TimeZoneInfo timeZone in tz)
            {
                Console.WriteLine($"{timeZone.Id} | {timeZone.DisplayName} | UTC Offset: {timeZone.BaseUtcOffset}");
            }

            TimeZoneInfo time = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            Console.WriteLine($"\nID : {time.Id}, \nDaylightName: {time.DaylightName}, \nDisplayName : {time.DisplayName}, \nBaseUtcOffset : {time.BaseUtcOffset}," +
                $"\nSupportsDaylightSavingTime : {time.SupportsDaylightSavingTime}, \nStandardName : {time.StandardName}");


            // DayLightSaving (DST) - add 1 hour in summar, sub 1 hour in winter because of more daylight in evening 
            // supports - USA, Europe, Uk, Canada
            // notsupports - Asian countries, UAE, Japan

            DateTime convertFromUtc = TimeZoneInfo.ConvertTimeFromUtc(date1, time);
            Console.WriteLine($"UTC to timeZone : {convertFromUtc} Time: {time.DisplayName}");

            
            date = DateTime.SpecifyKind(date, DateTimeKind.Unspecified); // mark it explicitly
            DateTime ConvertToUtc = TimeZoneInfo.ConvertTimeToUtc(date, time);
            Console.WriteLine($"TimeZone to UTC  : {ConvertToUtc}");


        }
    }
}
