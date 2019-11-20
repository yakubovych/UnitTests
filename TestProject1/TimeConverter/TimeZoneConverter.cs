using System;

namespace TestProject1.TimeConverter
{
  public class TimeZoneConverter
  {
    public static DateTime ConvertToEst(DateTime dateTime)
    {
      TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

      return TimeZoneInfo.ConvertTime(dateTime, TimeZoneInfo.Local, easternZone);
    }

    public static DateTime ConvertToUtc(DateTime dateTime)
    {
      return TimeZoneInfo.ConvertTimeToUtc(dateTime);
    }
  }
}