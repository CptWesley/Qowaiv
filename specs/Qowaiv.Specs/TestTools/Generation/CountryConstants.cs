﻿namespace Qowaiv.TestTools.Generation;

public static class CountryConstants
{
    public static void Generate()
    {
        var all = Country.All.OrderBy(c => c.Name.Length).ThenBy(c => c.Name).ToArray();
        using var w = new StreamWriter(Solution.Root.File("src/Qowaiv/Generated/Globalization/Country.consts.generated.cs").FullName);

        w.WriteLine(@"// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------");
        w.WriteLine();
        w.WriteLine("namespace Qowaiv.Globalization;");
        w.WriteLine();
        w.WriteLine("public readonly partial struct Country");
        w.WriteLine("{");

        foreach (var country in all)
        {
            if (country != all[0]) w.WriteLine();

            w.WriteLine($"    /// <summary>Describes the country {country.EnglishName} ({country.Name}).</summary>");
            if (country.EndDate is { } enddate)
            {
                w.WriteLine($"    /// <remarks>End date is {enddate:yyyy-MM-dd}.</remarks>");
            }
            w.WriteLine($"    public static readonly Country {country.Name} = new(\"{country.Name}\");");
        }
        w.WriteLine("}");
        w.Flush();
    }
}
