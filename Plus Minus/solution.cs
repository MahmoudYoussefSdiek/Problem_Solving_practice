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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
{
    int positive_count = 0;
    int negative_count = 0;
    int zero_count = 0;

    foreach (int num in arr)
    {
        if (num > 0)
            positive_count++;
        else if (num < 0)
            negative_count++;
        else
            zero_count++;
    }

    Console.WriteLine("{0:F6}", (double) positive_count / arr.Count);
    Console.WriteLine("{0:F6}", (double) negative_count / arr.Count);
    Console.WriteLine("{0:F6}", (double) zero_count / arr.Count);
}

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
