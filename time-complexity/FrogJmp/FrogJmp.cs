

namespace FrogJmp
{
    public  static class Program

    {

        public class FrogJump()
        {
            public static int CountJumps(int X, int Y, int D)
            {

                //********* First Way *********
                /*int steps = 0; // counter for number of jumps/ steps

                while (X < Y) //loop while the starting position is less than the position the frog wants to get to
                {

                    X += D; // Add the units per jump to the starting position;
                    steps++; // add a counter to the jumps
                }

                return steps; //return the amount of jumps when starting position is greater than destination*/

                //********* Second Way *********
                if (X >= Y) return 0; // if starting position is >= destination exit function
                int diff = Y - X; //get total distance to cover
                int jumps = (diff + D - 1) / D; // formula to find number of jumps, using - 1 as an edge case for a more robust output
                return jumps; // return the amount of jumps needed


            }
        }

        public static void Main(String[] args)
        {
            int jumps = FrogJump.CountJumps(10, 85, 30);
            Console.WriteLine($"The number of jumps it took was: {jumps} ");
        }
    }

    
}
