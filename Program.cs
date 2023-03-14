using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    int day = 256;
    int month = 9;
    int dayInMonth;

    if (year == 1918)
    {
        // special case for year 1918, when the transition from Julian to Gregorian calendar occurred
        dayInMonth = 26;
    }
    else if (year < 1918 && year % 4 == 0 ||                     // Julian calendar
             year > 1918 && (year % 400 == 0 ||                  // Gregorian calendar
                            year % 4 == 0 && year % 100 != 0))
    {
        // leap year
        dayInMonth = day - 244;
    }
    else
    {
        // regular year
        dayInMonth = day - 243;
    }

    return $"{dayInMonth:00}.{month:00}.{year:0000}";
}

class Solution
{
    public static void Main(string[] args)
    {

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.dayOfProgrammer(year);

        Console.WriteLine(result);

    }
}
