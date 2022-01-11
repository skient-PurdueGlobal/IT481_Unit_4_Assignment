using System;

namespace IT481_Unit_4_Assignment
{
    public class UnitExamples
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unit 4 Assignment Main Program Running...");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("");

            //Console.Read();
        }

        #region Pseudocode Funtions
        //Given an array of integers and a number of times to look, return the minimum value.
        public int Example_One(int[] arr, int n)
        {
            int min = 999;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }

            return min;
        }

        //Given an array of integers, print out each value.
        public bool Example_Two(int[] arr)
        {
            bool isComplete = false;

            if (arr[0] != 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                isComplete = true;
            }

            return isComplete;
        }

        //Given two integers, search values if they are equal to the values in the array.
        public bool Example_Three(int[] arr)
        {
            int a = 81;
            int b = 15;
            bool isFound = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (a == arr[i])
                {
                    Console.WriteLine("The value, " + a.ToString() + ", was found in the array.");
                    isFound = true;
                } else if (b == arr[i])
                {
                    Console.WriteLine("The value, " + b.ToString() + ", was found in the array.");
                    isFound = true;
                }
            }
            if (!isFound)
                Console.WriteLine("Neither of the search values were found");

            return isFound;
        }
        #endregion
    }
}
