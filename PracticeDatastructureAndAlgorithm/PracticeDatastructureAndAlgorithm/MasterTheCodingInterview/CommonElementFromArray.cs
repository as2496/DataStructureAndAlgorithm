using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeDatastructureAndAlgorithm.MasterTheCodingInterview
{
    public static class CommonElementFromArray
    {
        public static bool findCommonElementFromArray<T,U>(T[] arr1, U[] arr2)// O(m*n)
        {
            if (IsEqualTo(arr1.GetType(), arr2))
            {
                foreach (var ele1 in arr1)//O(n)
                {
                    foreach (var ele2 in arr2)//O(m)
                    {
                        if (ele1.Equals(ele2))
                        {
                            return true;
                        }
                    }
                }
            }
            
            return false;
        }
        public static bool findCommonElementFromArrayUsingList<T>(T[] arr1, T[] arr2)// O(m+(n*m))
        {

                var arrayList = arr1.ToList();// O(m)
                foreach (var el in arr2)//O(n)
                {
                    if (arrayList.Contains(el))//O(p)
                        return true;
                }

            return false;
        }

        public static bool findCommonElementFromArrayUsingHashSet<T>(T[] arr1, T[] arr2)// O(n+m)
        {

                var hash = new HashSet<T>();
                foreach(var el in arr1) //O(n)
                {
                    hash.Add(el); //O(1)
                }
                
                foreach (var el in arr2)//O(m)
                {
                    if (hash.Contains(el))//O(1)
                        return true;
                }

            return false;
        }
        private static bool IsEqualTo(Type t, Object inst)
        {
            Type t2 = inst.GetType();
            if (t == t2)
            {
                Console.WriteLine("{0} = {1}: {2}", t.Name, t2.Name,
                                  t.Equals(t2));
                return true;
            }   
            else
                Console.WriteLine("Cannot cast the argument to a type.");
            return false;
        }
    }
}
