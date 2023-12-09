using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsTask
{
    class Program
    {
        
        static void Main(string[] args)
        {
            savepoint:
            Console.Clear();
            Console.WriteLine("Chouse task: ");
            Console.WriteLine("1 - Stack");
            Console.WriteLine("2 - Queue");
            Console.WriteLine("3 - List");
            Console.WriteLine("0 - Exit");
            int key = Int32.Parse(Console.ReadLine());
            switch (key)
            { 
                case 1: StackTask.Task(); goto savepoint;
                case 2: QueueTask.Task(); goto savepoint;
                case 3: ListTask.Task(); goto savepoint;
                case 0: break;
                default: break;
            }
        }
    }
}
