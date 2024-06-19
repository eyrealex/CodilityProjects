using System;

namespace binary_gap
{
    public static class BinaryGap
    {

        public class BinaryGapFinder
        {
            public int longestBinaryGap(int N)
            {

                // Initialize variables
                int current = 0;   // used to get the longest gap
                int maxCount = 0; // used to get maximum gap
                bool found = false;  // used to check if were inside a gap

                while (N > 0)
                {
                    if ((N & 1) == 0) // Check if the least significant bit (LSB) of N is 0 when comparing N & 1
                    {
                        if (found) //count zeros after finding the first 1
                        {
                            current++;
                        }
                    }
                    else
                    {
                        // The LSB is 1, marking the end of the current gap
                        maxCount = Math.Max(maxCount, current); // Update maxCount if current gap is larger
                        current = 0; // Reset count for the next potential gap
                        found = true; // Mark that we have encountered a 1
                    }

                    N>>=1; // Right shift N by 1 bit to process the next bit
                }

                return maxCount; //return the value which stores the max lenght of the binary gap
            }
        }

        public static void Main(String[] args)
        {
            BinaryGapFinder finder = new BinaryGapFinder();

            int[] numbers = { 1041, 32, 15 }; //values we are using to check the binary gaps of
            foreach (int num in numbers)
            {
                string binary = Convert.ToString(num, 2); // Convert number to binary string

                //Print the results using string interpolation and passing the binary number into the Binary Gap method
                Console.WriteLine($"The number {num} in binary is: {binary}, and its largest gap is: {finder.longestBinaryGap(num)}");

            }
        }
    }
}

