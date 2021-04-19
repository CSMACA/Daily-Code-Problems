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
            string filePath = @"C:\Users\arsci\Documents\GitHub\Daily-Code-Problems\Daily Coding Problem #858\DailyCodingProblem858\DailyCodingProblem858\10Ints.txt";
            //string filePath = "100Ints.txt";

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
