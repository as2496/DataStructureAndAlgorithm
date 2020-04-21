using System;

namespace PracticeDatastructureAndAlgorithm
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Recursion.FibonacciSeries(0,1,5);
            var arr = new int[] { 10, 8, 9, 7, 6 };
            //var result = Recursion.BinarySearchOnSortedArray(5,arr, 0, 4);

            // var res = Sorting.BullbleSort(arr);
            var res = Sorting.BucketSort(arr);
            Console.WriteLine("Result found in position {0}",res);
            Console.ReadLine();
        }
       
    }
}
