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

    /*
     * Complete the 'dayOfProgrammer' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER year as parameter.
     */

    public static string dayOfProgrammer(int year)
    {
        int dayOfYear = 0;
    bool isLeapYear = false;
    
    if (year < 1918)
    {
        isLeapYear = (year % 4 == 0);
    }
    else
    {
        isLeapYear = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
    }
    
    if (!isLeapYear)
    {
        dayOfYear = 256;
    }
    else
    {
        dayOfYear = 257;
    }

    DateTime date = new DateTime(year, 1, 1).AddDays(dayOfYear - 1);
    return date.ToString("dd.MM.yyyy");
    }

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
