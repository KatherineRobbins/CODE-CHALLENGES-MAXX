using static System.Console;

namespace LargestElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter the number of elements in your array:");
            int a = Convert.ToInt32(Console.ReadLine());


            int[] num = new int[a];

            
                WriteLine("enter your elements of the array");

            for(int x = 0; x < a; x++)
            {
                num[x] = Convert.ToInt32(Console.ReadLine());
            }
               

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