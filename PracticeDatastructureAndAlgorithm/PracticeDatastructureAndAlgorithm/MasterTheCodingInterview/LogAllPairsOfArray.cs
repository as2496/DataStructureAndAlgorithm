using System;
namespace PracticeDatastructureAndAlgorithm
{
    public class LogAllPairsOfArray
    {
        public static void logAllPairsOfArrayElements<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    Console.WriteLine("Pair: {0},{1}", array[i], array[j]);
                }
            }
        }
    }

}