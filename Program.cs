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
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr, int n)
    {
        int rightdiagonalsum = 0;
        int leftdiagonalsum = 0;


        for (int i = 0; i < n; i++)
        {

            rightdiagonalsum += arr[i][i];

            leftdiagonalsum += arr[i][n - i - 1];
        }
        return Math.Abs(rightdiagonalsum - leftdiagonalsum);

    }



}

class Solution
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Given a square matrix, calculate the absolute difference between the sums of its diagonals.");
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr, n);
        Console.WriteLine("Return the absolute difference between the sums of the matrix's two diagonals as a single integer.");
        Console.WriteLine(result);
    }
}
