

namespace FrogJmp
{
    public  static class Program

    {

        public class FrogJump()
        {
            public static int CountJumps(int X, int Y, int D)
            {

                // 2 WAYS TO COMPLETE

                int steps = 0;

                while (X < Y)
                {

                    X = X + D;
                    steps++;
                }

                return steps;


            }
        }

        public static void Main(String[] args)
        {
            int jumps = FrogJump.CountJumps(10, 85, 30);
            Console.WriteLine($"The number of jumps it took was: {jumps} ");
        }
    }

    
}
