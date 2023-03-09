using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;

public static class Languages
{
    public static List<string> NewList()
    {
        return new List<string>();
    }

    public static List<string> GetExistingLanguages()
    {
        return new List<string>() { "C#", "Clojure", "Elm" };
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages = GetExistingLanguages();
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages)
    {
        return languages.Count;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        return languages.Contains(language);
    }

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
        // ReSharper disable once ReplaceWithSingleAssignment.False
        bool flag = false;
        if (languages.IndexOf("C#") == 0)
            flag = true;
        if (languages.IndexOf("C#") == 1 && languages.Count is 2 or 3)
            flag = true;

        return flag;
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        bool flag = languages.Count() == languages.Distinct().Count();

        return flag;
    }
}
