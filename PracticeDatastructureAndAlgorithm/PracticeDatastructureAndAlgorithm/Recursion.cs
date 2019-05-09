using System;
using System.Collections.Generic;
using System.Text;


namespace PracticeDatastructureAndAlgorithm
{
    public class Recursion
    {
        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
            {
                return n * Factorial(n - 1);
            }
        }
        //Nth number in the series
        public static int NFibonacciNumber(int n)
        {
            if (n < 1)
                return 0;
            else if (n == 1 || n == 2)
                return n - 1;
            else
              return  NFibonacciNumber(n - 1) + NFibonacciNumber(n - 2);


        }
        public static void FibonacciSeries(int first, int second,int n)
        {
            int counter = 1;
            if(counter <= n)
            {
                Console.WriteLine("{0}", first);
                FibonacciSeries(second, first + second, n - 1);
            }

        }
        public static int BinarySearchOnSortedArray(int num, int[] arr, int start, int end)
        {
            if(start == end)
            {
                if (start == num)
                    return start;
                return -1;
            }else
            {
                var mid =Math.Floor((double)(end - start) / 2);
                if (arr[(int)mid] == num)
                    return (int)mid;
                else if (arr[(int)mid] < num)
                    return BinarySearchOnSortedArray(num, arr, (int)mid, end);
                else
                    return BinarySearchOnSortedArray(num, arr, start, (int)mid);
            }

        }
    }
}
