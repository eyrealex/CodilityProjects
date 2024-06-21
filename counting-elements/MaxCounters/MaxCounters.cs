using System;
using System.Reflection;

namespace MaxCounters
{
    public static class MaxCounters
    {

        public static int[] GetMaxCounter(int N, int[] A)
        {

            // take N counters = 5
            // intitialize N to 0
            // given the array list A with M integers, e.g. array = {3, 4, 4, 6, 1, 4, 4}
            // increase counter by 1 in N of array value <=N otherwise reset all counters value to counter with the maximum value
            // return the value of all counters as array of integers

            int[] counters = new int[N];
            int current = 0;
            int maxCounter = 0;

            foreach (var X in A) // Loop through each element in the array A, treating each element as X
            {

                if (X >= 1 && X <= N) // If X is between 1 and N (inclusive), proceed with updating counters
                {
                    int index = X - 1; // Convert the one-based value X to a zero-based index

                    if (counters[index] < maxCounter) // If the current counter value is less than the maxCounter
                    {
                        counters[index] = maxCounter; // Set the counter value to maxCounter to catch up with the last update
                    }
                    counters[index]++; // Increment the counter at the current index

                    if (counters[index] > current) // If the updated counter value is greater than the current max
                    {
                        current = counters[index];  // Update the current max to this new counter value
                    }
                }
                else if (X > N) // If X is larger than N, it falls outside our condition
                {
                    maxCounter = current;  // Set maxCounter to the current max value for future updates
                }
            }


            for (int i = 0; i < N; i++) // loop over array again to make sure no counters were missed
            {
                if (counters[i] < maxCounter) //if a counter is less than the max
                {
                    counters[i] = maxCounter;  // update it to equal the max
                }
            }

            return counters; //return the values stored in counters which will be in array form

        }


        static void Main(string[] args)
        {

            int N = 5;
            int[] A = { 3, 4, 4, 6, 1, 4, 4 };
            int[] result = GetMaxCounter(N, A);
            Console.WriteLine(string.Join(", ", result)); // Output: 3, 2, 2, 4, 2

        }

    }

}
