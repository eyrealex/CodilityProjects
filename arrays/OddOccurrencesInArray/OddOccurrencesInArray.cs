using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace OddOccurrencesInArray
{
    public static class Program
    {

        public class OddOccurrences()
        {
            public int FindUnpairedElement(int[] A)
            {
                int N = A.Length;

                if(N > 1) {
                    int xor = A[0]; // set the first element to the exclusive or 

                    for (int i = 1; i < N; i++) //loop through the length of the array
                    {
                        xor = xor ^ A[i]; //use exclusive or operator to compare the 2 values and store unpaired value in xor. 
                    }

                    return xor; //return the unpaired element
                }
                else
                {
                    return A[0]; //edge case to return a result
                }

            }
        }

        public static void Main(String[] args)
        {

            int[] A = { 9, 3, 9, 3, 9, 7, 9 };
            OddOccurrences odd = new OddOccurrences();
            int unpairedNum = odd.FindUnpairedElement(A);
            Console.Write($"This is the unpaired number: {unpairedNum}");
        }
    }
}
