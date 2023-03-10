using System;


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
        string timeZoneId = GetTimeZoneId(location);;
        DateTime utcDate;
        DateTime scheduledDate;

        if (DateTime.TryParse(appointmentDateDescription, out DateTime dateReturn))
            scheduledDate = dateReturn;
        else
        {
            throw new ArgumentException("The formatted string provide is not accepted.");
        }
        
        utcDate = TimeZoneInfo.ConvertTimeToUtc(scheduledDate, TimeZoneInfo.Local);

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
        
    }

    private static string GetTimeZoneId(Location location)
    {

        string timeZoneId;

        if (location == Location.NewYork)
            timeZoneId = "New York - America/New_York";
        else if (location == Location.London)
            timeZoneId = "London - Europe/London";
        else if (location == Location.Paris)
            timeZoneId = "Paris - Europe/Paris";
        else
        {
            throw new ArgumentException("We don't have salons in this location, please select New York, London Or Paris.");
        }

        return timeZoneId;
    }
}
