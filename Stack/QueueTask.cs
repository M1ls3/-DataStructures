// Create a queue of words read from a text file.
// Perform queue inversion and outputting a given number of queue elements.
// Display the results on the screen transformation of the input queue.

using System;
using System.Linq;
using System.Collections;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace CollectionsTask
{
    class QueueTask
    {   
        static Queue<string> ReadData(string path_)
        {
            string[] data = File.ReadAllLines(path_);
            Queue<string> queueData = new Queue<string>();
            for (int i = 0; i < data.Length; i++)
                queueData.Enqueue(data[i]);
            return queueData;
        }
        static Queue<string> ReverseQueue(Queue<string> queue_)
        {
            string[] line = new string[queue_.Count()];
            Queue<string> queueCopy = new Queue<string>(queue_);
            int length = queue_.Count();
            Queue<string> palindrome = new Queue<string>();
            for (int i = 0; i < length; i++)
                line[i] = queueCopy.Dequeue();
            for (int i = length - 1; i > -1; i--)
                palindrome.Enqueue(line[i]);
            return palindrome;
        }
        static string Output(Queue<string> queue_, int amountOfElement) // Поліморфізм
        {
            if (amountOfElement <= queue_.Count())
            {
                string returns = null;
                for (int i = 0; i < amountOfElement; i++)
                {
                    returns = returns + queue_.Dequeue() + ' ';
                }
                return returns;
            }
            else return "Out of bounds";
        }
        static string Output(Queue<string> queue_) 
        {
            string returns = null;
            int length = queue_.Count();
            for (int i = 0; i < length; i++)
            {
                returns = returns + queue_.Dequeue() + ' ';
            }
            return returns;
        }
        static public void Task()
        {
            Queue<string> queue = new Queue<string>(ReadData("data.txt"));
            Queue<string> reverseQueue = new Queue<string>(ReverseQueue(queue));
            Console.WriteLine("Input amount of elements: ");
            string amount = Console.ReadLine();
            Console.WriteLine($"\nPrimary Queue: {Output(queue)}\n");
            if (amount == "all" || amount == "All")
                Console.WriteLine($"Final Queue: {Output(reverseQueue)}");
            else
                Console.WriteLine($"Final Queue: {Output(reverseQueue, Convert.ToInt32(amount))}");
            Console.ReadKey();
        }
    }
}
