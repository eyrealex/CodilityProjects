using System;
using System.Reflection.Metadata.Ecma335;

namespace CyclicRotation
{
    public static class Program
    {

        public class RotateArray()
        {

            public int[] startRotation(int[] A, int k)
            {

                int n = A.Length;
                if(n > 1) //check array has more than 1 element
                {
                    k = k % n; // handle edge case where k is greater than array length so we dont perform unnecessary rotations

                    for (int j = 0; j < k; j++) //perform k rotations
                    {
                        int last = A[n - 1]; // temporarily store the last element
                        for(int i = n - 1; i > 0; i--) // shift elements to the right by 1 
                        {                   
                            A[i] = A[i - 1]; //after shift right complete, second last element becomes last element
                        }
                        A[0] = last; //temporarily stored last element should then be moved to the very first element
                    }
                }
                return A;
    
            } 

        }

        public static void Main(String[] args)
        {

            RotateArray array = new RotateArray();

            int[] A = { 3, 8, 9, 7, 6 };
            int[] rotatedArray = array.startRotation(A, 3); //call the array with arguements of array list and amount of times to rotate

            //print the array list
            foreach(int nums in rotatedArray)
            {
                Console.Write(nums + ", ");
            }


        }
    }

    
}
