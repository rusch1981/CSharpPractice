using CSharpPractice.Practices;
using CSharpPractice.Practices.Impl;
using System;
using System.Collections.Generic;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var demos = new List<IDemoable>()
            {
                new MajorityUnsortedArray(),
                new CycleDetectionLinkedList(),
                new RecursiveFibonacciSeries()
            };

            foreach (var demo in demos)
            {
                demo.Run();
                Console.WriteLine("\n------------------------------------\n");
            }
        }
    }
}
