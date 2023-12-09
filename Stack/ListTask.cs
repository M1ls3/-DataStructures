// Given two sequences of integers and real numbers. Build a singly linked list,
// which number of sequences alternate. If the last element of the list is an integer
// number, move it to the beginning of the list. Print the lists before and after the change.


using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CollectionsTask
{
    class ListTask
    {
        static List<string> Merge(int[] intArray_, double[] doubleArray_)
        {
            List<string> list = new List<string>();
            if (intArray_.Length > doubleArray_.Length)
            {
                for (int i = doubleArray_.Length; i < intArray_.Length; i++)
                {
                    list.Add(Convert.ToString(intArray_[i]));
                }
                for (int i = 0; i < doubleArray_.Length; i++)
                {
                    list.Add(Convert.ToString(intArray_[i]));
                    list.Add(Convert.ToString(doubleArray_[i]));
                }              
            }
            else if (intArray_.Length < doubleArray_.Length)
            {
                for (int i = 0; i < intArray_.Length; i++)
                {
                    list.Add(Convert.ToString(intArray_[i]));
                    list.Add(Convert.ToString(doubleArray_[i]));
                }
                for (int i = intArray_.Length; i < doubleArray_.Length; i++)
                {
                    list.Add(Convert.ToString(doubleArray_[i]));
                }
            }
            else
            {
                for (int i = 0; i < intArray_.Length; i++)
                {
                    list.Add(Convert.ToString(intArray_[i]));
                    list.Add(Convert.ToString(doubleArray_[i]));
                }
            }
            return list;
        }

        static List<string> Reverse(List<string> list_)
        {
            int length = list_.Count();
            List<string> list = new List<string>();
            for (int i = 0; i < length; i++)
            {
                list.Add(list_.Last());
                list_.Remove(list_.Last());
            }
            return list;
        }

        static string Output(List<string> list_)
        {
            string returns = null;
            int length = list_.Count();
            List<string> reversedList = Reverse(list_);
            for (int i = 0; i < length; i++)
            {
                returns = returns + reversedList.Last() + ' ';
                reversedList.Remove(reversedList.Last());
            }
            return returns;
        }
        static public void Task()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Console.WriteLine("Input sequence of integers: ");
            string[] value = Console.ReadLine().Trim().Split();
            int[] intNum = new int[value.Length];
            List<string> primaryList = new List<string>();
            for (int i = 0; i < value.Length; i++)
            {
                intNum[i] = Convert.ToInt32(value[i]);
                primaryList.Add(value[i]);
            }

            Console.WriteLine("Input sequence of fictitious: ");
            value = Console.ReadLine().Trim().Split();
            double[] doubleNum = new double[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                doubleNum[i] = Convert.ToDouble(value[i]);
                primaryList.Add(value[i]);
            }


            List<string> list = Merge(intNum, doubleNum);

            Console.WriteLine($"Primary List: {Output(primaryList)}");
            Console.WriteLine($"Finaly List: {Output(list)}");
            Console.ReadKey();
        }
    }
}
