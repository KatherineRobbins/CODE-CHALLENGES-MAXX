using static System.Console;

namespace LargestElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's find the largest element in an array of 3 numbers");

            int[] num = new int[3];

            
                WriteLine("1st number");
                num[0] = Convert.ToInt32(Console.ReadLine());

                WriteLine("2nd number");
                num[1] = Convert.ToInt32(Console.ReadLine());

                WriteLine("3rd number");
                num[2] = Convert.ToInt32(Console.ReadLine());

            int largest = num[0];

            for (int x = 1; x < num.Length; x++)
            {
                if (num[x] > largest)
                {
                    largest = num[x];
                }
            }
            WriteLine("the largest number in the array is " + largest);

        }
    }
}