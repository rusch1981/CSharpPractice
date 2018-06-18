using System;
using System.Collections.Generic;

namespace CSharpPractice.Practices.Impl
{
    public class MajorityUnsortedArray : IDemoable
    {
        private const string _initMessage = "Beginning MajorityUnsortedArray Practice Demo... \nInitializing array with the following items:";
        private const string _runMessage = "Running Demo...  \nThe majority item is:  ";
        private const string _explanation = "Explanation:  \n" +
            "Acuire the length that would be the majority (half of the total array length)\n" +
            "Create a Dictionary to store the items and count of each item as you loop\n" +
            "While Looping fill the dictionary\n" +
            "Return the item that has count that exceeds the majority length";
        private int[] _numbers;
        public void Run()
        {
            Console.WriteLine(_initMessage);
            _numbers = new int[] { 1, 2, 3, 4, 5, 2, 2, 2, 2 };

            foreach (var item in _numbers)
            {
                Console.Write(item.ToString() + " ");
            }

            Console.Write("\n\n" + _runMessage);
            Console.WriteLine(GetMajorityElement() + "\n");
            Console.WriteLine(_explanation);
        }
        
        private int GetMajorityElement()
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            int majority = _numbers.Length / 2;

            foreach (int i in _numbers)
                if (d.ContainsKey(i))
                {
                    d[i]++;
                    if (d[i] > majority)
                        return i;
                }
                else
                    d.Add(i, 1);

            throw new Exception("No majority element in array");
        }
    }
}
