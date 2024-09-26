using static System.Console;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)


        {

            string toReverse;
            string stringReverse = "";

            
            WriteLine("Please enter your string you would like reversed:");
            toReverse = Console.ReadLine();

            

            for ( int i = toReverse.Length -1; i >=1; i--)
            {
                stringReverse += toReverse[i];
            }
            WriteLine("Your string in reverse is: " + stringReverse);



        }
    }
}