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
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        long sum = 0;
        long min = long.MaxValue;
        long max = 0;

        // Calculate the sum of all elements in the list
        for (int i = 0; i < arr.Count; i++)
            sum += arr[i];

        // Find the minimum and maximum sums
        for (int i = 0; i < arr.Count; i++)
        {
            long tempSum = sum - arr[i];
            if (tempSum < min)
                min = tempSum;
            if (tempSum > max)
                max = tempSum;
        }

        // Print the results
        Console.WriteLine($"{min} {max}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
