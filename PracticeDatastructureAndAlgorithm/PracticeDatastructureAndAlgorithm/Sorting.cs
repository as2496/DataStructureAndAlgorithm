using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PracticeDatastructureAndAlgorithm
{
    public class Sorting
    {
        public static int[] BullbleSort(int[] arr)
        {
            for(int i= 0; i<arr.Length-1; i++)
            {
                for(int j = 0; j < arr.Length-i-1; j++)
                {
                    if(arr[j] > arr[j+1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
            return arr;
        }
        public static int[] SelectionSort(int[] arr)
        {
            for(int i = 0; i<arr.Length-1; i++)
            {
                var min = i;
                for(int j= i+1; j < arr.Length; j++)
                {

                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
            return arr;
        }
        public static int[] InsertionSort(int[] arr)
        {
            for(int i = 0; i<arr.Length; i++)
            {
                var temp = arr[i];
                var j = i;
                while(j>0 && arr[j - 1]>temp)
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = temp;
            }
            return arr;
        }
        public static int[] BucketSort(int[] arr)
        {
            var n = arr.Length;
            var index = 0;
            var numOfbucket = (int)Math.Ceiling(Math.Sqrt(n));
            var min = int.MinValue;
            var max = int.MinValue;
            foreach(var value in arr)
            {
                if(value < min)
                {
                    min = value;
                }else if(value > max)
                {
                    max = value;
                }
            }
            var ListOfBucket = new List<List<int>>();
            for(int i= 1;i<= numOfbucket; i++)
            {
                ListOfBucket.Add(new List<int>());
            }
            
            //placing element in bucket
            foreach(var item in arr)
            {
                int bucketNum = (int)Math.Ceiling((double)(item * numOfbucket) / max);
                ListOfBucket[bucketNum-1].Add(item);
            }
            // sorting the bucket and concating the bucket
            foreach (var bucket in ListOfBucket)
            {
                bucket.Sort();
                foreach(var item in bucket)
                {
                    arr[index] = item;
                    index++;
                }
                
            }
            return arr;



        }
    }
    public class MergeSort
    {
        public static int[] MergeBreak(int[] arr, int left, int right)
        {
            if(right > left)
            {
                var mid = right + left / 2;
                MergeBreak(arr, left, mid);
                MergeBreak(arr, mid + 1, right);
            }
            return arr;
        }
    }
}
