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
     * Complete the 'countingSort' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int[] countingSort(List<int> arr)
    {
        // Find the maximum value
        int max_value = arr.Max();

        // create an arry to store the count of each value
        int[] count_arr = new int[max_value + 1];

        // Count the number of times each value appears
        foreach (int value in arr)
            count_arr[value]++;

        return count_arr;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string output_path = Environment.GetEnvironmentVariable("OUTPUT_PATH");
        TextWriter textWriter = output_path != null ? new StreamWriter(output_path, true) : Console.Out;

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(
            ' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int[] result = Result.countingSort(arr);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}