using System;
using System.Collections;

namespace PracticeDatastructureAndAlgorithm.MasterTheCodingInterview
{
    public static class DataStructureArray
    {
        public static void TestArrayOperation()
        {
            var arr = new ArrayList{ "a", "b", "c" } ;

            arr.Add("d");//O(1)
            foreach (var el in arr)
            {
                Console.Write(el);
            }
            arr.RemoveAt(0);//O(1)
            foreach (var el in arr)
            {
                Console.Write(el);
            }
            arr.Insert(0, "j");// O(n)

            foreach(var el in arr)
            {
                Console.Write(el);
            }
            Console.ReadLine(); ;
        }
        

    }
}
