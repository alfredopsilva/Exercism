using System;
using System.Globalization;
using System.Runtime.InteropServices.JavaScript;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        DateTime appointment = default;
        if (DateTime.TryParse(appointmentDateDescription, out DateTime appointmentDate))
        {
            appointment = appointmentDate;
        }
        return appointment;
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        return appointmentDate.CompareTo(DateTime.Now) < 0;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        if (appointmentDate.Hour >= 12 && appointmentDate.Hour < 18)
        {
            return true;
        }
        return false;
    }

    public static string Description(DateTime appointmentDate)
    {
        
        return $"You have an appointment on {appointmentDate.ToString()}.";
        
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(DateTime.Now.Year, 9, 15);
    }
}
