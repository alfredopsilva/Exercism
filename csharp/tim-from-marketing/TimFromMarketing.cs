using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {

  
        if (id == null && department == null)
            return $"{name} - OWNER";

        if (id == null && department != null)
            return $"{name} - {department.ToUpper()}";

        if(department == null)
            return $"[{id}] - {name} - OWNER";

        if(id == null && string.IsNullOrEmpty(department))
            return $"{name} - OWNER";


        return $"[{id}] - {name} - {department.ToUpper()}";
    }
}
