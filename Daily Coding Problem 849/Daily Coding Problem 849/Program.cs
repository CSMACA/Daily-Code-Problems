//A Collatz sequence in mathematics can be defined as follows. Starting with any positive integer:

//if n is even, the next number in the sequence is n / 2
//if n is odd, the next number in the sequence is 3n + 1
//It is conjectured that every such sequence eventually reaches the number 1. Test this conjecture.

//Bonus: What input n <= 1000000 gives the longest sequence?

using System;

namespace Daily_Coding_Problem_849
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uncomment below if using from IDE and not EXE.
            Console.Write("Set starting value: ");
            double answer = Double.Parse(Console.ReadLine());
            Console.WriteLine(collatzSeq(answer));

            //Comment out below line if using from IDE and not EXE
            //Console.WriteLine(collatzSeq(Double.Parse(args[0])));

            Console.ReadKey();
        }

        static string collatzSeq(double num)
        {
            int runNum=0;
            do
            {
                Console.WriteLine("-----------------Start Step------------------");
                Console.WriteLine("Value of num at start: " + num);
                if (num % 2 == 0)
                {
                    num = num / 2;
                }
                else
                {
                    num = (3 * num) + 1;
                }
                runNum++;
                Console.WriteLine("Value of num at end: " + num);
                Console.WriteLine("-----------------End Step------------------");

            } while (num != 1);
            return string.Format("Reached 1 after {0} steps.", runNum);
        }
    }
}
