//Alan Roach
//4/18/2021

//Compute the running median of a sequence of numbers. That is, given a stream of numbers, print out the median of the list so far on each new element.

//Recall that the median of an even-numbered list is the average of the two middle numbers.

//For example, given the sequence [2, 1, 5, 7, 2, 0, 5], your algorithm should print out:

//2
//1.5
//2
//3.5
//2
//2
//2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DailyCodingProblem858
{
    class Program
    {
        static void Main(string[] args)
        {
            //Switch between 10 and 100 integers.
            //string filePath = @"C:\Users\arsci\Documents\GitHub\Daily-Code-Problems\Daily Coding Problem #858\DailyCodingProblem858\DailyCodingProblem858\10Ints.txt";
            string filePath = @"C:\Users\arsci\Documents\GitHub\Daily-Code-Problems\Daily Coding Problem #858\DailyCodingProblem858\DailyCodingProblem858\100Ints.txt";

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                
                using (StreamReader sr = new StreamReader(fs))
                {
                    List<double> a = new List<double>();

                    while (!sr.EndOfStream)
                    {
                        //Console.WriteLine(Double.Parse(sr.ReadLine()));
                        double current = Double.Parse(sr.ReadLine());
                        a.Add(current);
                        double result = findMean(a, a.Count);
                        Console.WriteLine(result);
                    }
                }
            }
            Console.ReadKey();
        }

        public static double findMean(List<double> a, double n)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
                sum += a[i];

            return sum / n;
        }
    }
}
