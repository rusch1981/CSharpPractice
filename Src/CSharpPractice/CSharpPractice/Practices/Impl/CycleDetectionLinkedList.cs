using System;

namespace CSharpPractice.Practices.Impl
{
    public class CycleDetectionLinkedList : IDemoable
    {

        private const string _initMessage = "Beginning CycleDetectionLinkedList Practice Demo... \nInitializing a LinkedList with the following items:";
        private const string _runMessage = "Running Demo...  \nThe LinkedList is a cycle:  ";
        private const string _explanation = "Explanation:  \n" +
            "Set lag and lead pointers\n" +
            "Loop moving the pointers at a constant but varied speed\n" +
            "For instance move the lead pointer by two\n\tand lag pointer by one for each interation\n" +
            "They will eventually point to the same item or LinkedList will end";
        private Node[] _nodes;

        public void Run()
        {
            Console.WriteLine(_initMessage);
            CreateCycle();

            foreach (var item in _nodes)
            {
                Console.Write(item.data + " ");
            }
            Console.Write("\n\n" + _runMessage);
            Console.WriteLine(DetectCycle() + "\n");
            Console.WriteLine(_explanation);
        }
        private void CreateCycle()
        {
            _nodes = new Node[] 
            {
                new Node() { data = "first" },
                new Node() { data = "second" },
                new Node() { data = "third" },
                new Node() { data = "fourth" }
            };

            for(var i = 0; i < _nodes.Length; i++)
            {
                if(i == _nodes.Length - 1)
                {
                    _nodes[i].Next = _nodes[0];
                }
                else
                {
                    _nodes[i].Next = _nodes[i + 1];
                }
            }
        }

        private bool DetectCycle()
        {
            Node lag = _nodes[0];
            Node lead = lag.Next;

            while (lead.Next != null)
            {
                if (lag == lead)
                    return true;
                lag = lag.Next;
                for (int i = 0; i < 2; i++)
                {
                    if (lead.Next == null)
                        return false;
                    lead = lead.Next;
                }
            }
            return false;
        }
    }

    internal class Node
    {
        public Node Next;
        public Object data;
    }
}