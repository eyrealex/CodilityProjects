namespace NumberPalindrome
{
    public class Program
    {

        public static bool Palindrome(int X) {

            int reversed = 0; //init reverse to 0
            int original = X;

            if(X < 0) // check for negative numbers
            {
                return false;
            }

            while(X != 0) // keep looping while X is not equal to 0
            {
                int remainder = X % 10; // get the very last digit of the number using a modulus
                reversed = reversed * 10 + remainder; // start adding this number to the reversed varaible without overriting the variable
                X /= 10; // remove last digit from X to reset it for the next iteration
            }

            return original == reversed; //return true if both numbers are equal meaning a palindrome was found

        }


        static void Main(string[] args)
        {
            int num = 101;
            Console.WriteLine(Palindrome(num));
            Console.ReadLine();
        }
    }
}
