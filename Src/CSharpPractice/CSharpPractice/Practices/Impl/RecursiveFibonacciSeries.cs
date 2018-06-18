using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice.Practices.Impl
{
    class RecursiveFibonacciSeries : IDemoable
    {
        private const string _initMessage = "Beginning RecursiveFibonacciSeries Practice Demo... \nInitializing Series with the following length:";
        private const string _runMessage = "Running Demo...  \nThe Fibonacci Series is: \n";
        private const string _explanation = "Explanation:  \n" +
            "Set a length\n" +
            "Loop by the length\n" +
            "Within each loop a method is called that can call itself\n" +
            "That method can return a one, zero or call itself with a\n" +
            "\t length of minus one added to another call to itself\n" +
            "\t with a length of minus 2\n" +
            "If mapped to a tree all of the ending branch tips will be zero or 1\n" +
            "The sum of the branch tips is the number that corresponds to a given\n" +
            "\t position in the Fibonacci Series";
        private const int _length = 4;

        public void Run()
        {
            Console.WriteLine(_initMessage);
            Console.WriteLine(_length);
            Console.Write("\n" + _runMessage);
            WriteFibonacciSeries();
            Console.WriteLine("\n");
            Console.WriteLine(_explanation);
        }

        private void WriteFibonacciSeries()
        {
            for (int i = 0; i < _length; i++)
            {
                Console.Write("{0} ", FibonacciSeries(i));
            }
        }

        private int FibonacciSeries(int i)
        {
            if (i == 0) return 0; //To return the first Fibonacci number   
            if (i == 1) return 1; //To return the second Fibonacci number   
            return FibonacciSeries(i - 1) + FibonacciSeries(i - 2);
        }
    }
}
