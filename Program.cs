
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

// See https://aka.ms/new-console-template for more information
List<int> arr = new List<int> { -4, 3, -9, 0, 4, 1 };
Result.plusMinus(arr);

Console.WriteLine("Hello, world!");
class Result
{
    public static void plusMinus(List<int> arr)
    {
        float posNum = (float)arr.Where(x => x > 0).Count();
        float negNum = (float)arr.Where(x => x < 0).Count();
        float zerNum = (float)arr.Where(x => x == 0).Count();
        float total = (float)arr.Count();
        float posRatio = posNum / total;
        float negRatio = negNum / total;
        float zerRatio = zerNum / total;

        Console.WriteLine(posRatio.ToString("F6"));
        Console.WriteLine(negRatio.ToString("F6"));
        Console.WriteLine(zerRatio.ToString("F6"));
    }

}
