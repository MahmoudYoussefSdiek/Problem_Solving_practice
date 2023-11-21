using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int testCases = int.Parse(Console.ReadLine());

        for (int cs = 0; cs < testCases; cs++) {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int[] result = FindZigZagSequence(a, n);

            Console.WriteLine(string.Join(" ", result));
        }
    }

    static int[] FindZigZagSequence(int[] a, int n) {
        Array.Sort(a);
        int mid = n / 2;
        Swap(ref a[mid], ref a[n - 1]);

        int st = mid + 1;
        int ed = n - 2;
        while (st <= ed) {
            Swap(ref a[st], ref a[ed]);
            st++;
            ed--;
        }

        return a;
    }

    static void Swap(ref int a, ref int b) {
        int temp = a;
        a = b;
        b = temp;
    }
}