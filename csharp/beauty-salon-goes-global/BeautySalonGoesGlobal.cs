using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography;


public enum Location
{
    NewYork,
    London,
    Paris
}

public enum AlertLevel
{
    Early,
    Standard,
    Late
}

public static class Appointment
{
    public static DateTime ShowLocalTime(DateTime dtUtc)
    {
        return dtUtc.ToLocalTime();
    }

    public static DateTime Schedule(string appointmentDateDescription, Location location)
    {
        // Getting TimeZone ID as a String and Creating a TimeZoneInfo
        string timeZoneId = GetTimeZoneId(location);
        var timezone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
        
        // Utc DateTime to be returned
        DateTime utcDate;
        
        // The appointments are made in localtime, so for that we need to try to parse.
        DateTime scheduledDate;

        if (DateTime.TryParse(appointmentDateDescription, out DateTime dateReturn))
            scheduledDate = dateReturn;
        else
        {
            throw new ArgumentException("The formatted string provide is not accepted.");
        }
        
        utcDate = TimeZoneInfo.ConvertTimeToUtc(scheduledDate, timezone);

        return utcDate;
    }


    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel)
    {
        DateTime? alertDate = null;
        
        if (alertLevel == AlertLevel.Early)
            alertDate = appointment.AddDays(-1);
        else if (alertLevel == AlertLevel.Standard)
            alertDate = appointment.AddMinutes(-105);
        else if (alertLevel == AlertLevel.Late)
            alertDate = appointment.AddMinutes(-30);

        return (DateTime)alertDate;
    }

    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        bool flag = false;
        string timezoneId = GetTimeZoneId(location);
        var locationTimeZone = TimeZoneInfo.FindSystemTimeZoneById(timezoneId);

        for (var i = 1; i <= 7; i++)
        {
            if(locationTimeZone.IsDaylightSavingTime(dt) != locationTimeZone.IsDaylightSavingTime(dt.AddDays(-i)))
            {
                flag = true;
            }
        }
        
        return flag;
    }

    public static DateTime NormalizeDateTime(string dtStr, Location location)
    {
        string cultureLocation;
        if (location == Location.London)
            cultureLocation = "en-GB";
        else if (location == Location.Paris)
            cultureLocation = "fr-FR";
        else if (location == Location.NewYork)
            cultureLocation = "en-US";
        else
        {
            throw new ArgumentException("We don't have salons in this loWe don't have salons in this location, please select New York, London Or Paris.");
        }
        
        var culture = new CultureInfo(cultureLocation);

        DateTime scheduleDate;
        
        if (DateTime.TryParse(dtStr, culture, out DateTime correctDate))
        {
            scheduleDate = correctDate;
        }
        else
        {
            scheduleDate = new DateTime(1, 1, 1, 0, 0, 0);
        }

        return scheduleDate;

    }

    private static string GetTimeZoneId(Location location)
    {

        string timeZoneId;

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            if (location == Location.NewYork)
                timeZoneId = "Eastern Standard Time";
            else if (location == Location.London)
                timeZoneId = "GMT Standard Time";
            else if (location == Location.Paris)
                timeZoneId = "W. Europe Standard Time";
            else
            {
                throw new ArgumentException("We don't have salons in this loWe don't have salons in this location, please select New York, London Or Paris.");
            }
        }
        else
        {
            if (location == Location.NewYork)
                timeZoneId = "America/New_York";
            else if (location == Location.London)
                timeZoneId = "Europe/London";
            else if (location == Location.Paris)
                timeZoneId = "Europe/Paris";
            else
            {
                throw new ArgumentException("We don't have salons in this loWe don't have salons in this location, please select New York, London Or Paris.");
            }
        }

        return timeZoneId;
    }
}
