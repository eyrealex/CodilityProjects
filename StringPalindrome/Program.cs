
using System.Text.RegularExpressions;

namespace StringPalindrome
{
    public class Program
    {

        public static string Palindrome(string str)
        {

            str = str.ToLower(); //convert the string to all lower case
            str = Regex.Replace(str, "[^a-z]", ""); //remove all characters that are not lowercase a-z, replaces anything else with a blank string

            int valLength = str.Length;
            int end = valLength - 1;
            int counter = 0;

            for (int i = 0; i < valLength / 2; i++) //loop through half of the array
            {
                if (str[i] != str[valLength - i - 1]) //if value at the start does not match the value at the end
                {
                    return "Not Palindrome"; //no palindrome found
                }
            }

            return "Palindrome"; //otherwise it worked
        



        }


        static void Main(string[] args)
        {
            string str = "Han!nah";
            Console.WriteLine(Palindrome(str));
        }
    }
}
