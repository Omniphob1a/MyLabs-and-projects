using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсовая_сиаод
{
    internal static class sorter
    {
        public static long ShellSortingMethodOfDividingInHalf(DynamicArray array)
        {
            var gap = array.Length / 2;
            var sw = new Stopwatch();
            sw.Start();
            while (gap >= 1)
            {
                for (int i = gap; i < array.Length; i++)
                {
                    int value = array.GetElement(i);
                    int j;
                    for (j = i - gap; j >= 0 && array.GetElement(j) > value; j -= gap)
                    {
                        array.Swap(j + gap, j);
                    }
                    array.SetElement(j + gap, value);
                }
                gap = gap / 2;
            }
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }
        public static long ShellSortingMethodVirt(DynamicArray array)
        {
            int gap = array.Length / 2;
            var sw = new Stopwatch();
            sw.Start();
            while (gap >= 1)
            {
                for (int i = gap; i < array.Length; i++)
                {
                    int value = array.GetElement(i);
                    int j;
                    for (j = i - gap; j >= 0 && array.GetElement(j) > value; j -= gap)
                    {
                        array.SetElement(j + gap, array.GetElement(j));
                    }
                    array.SetElement(j + gap, value);
                }
                gap = (gap - 1) / 3;
            }
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }
        public static long ShellSortingMethodKnyt(DynamicArray array)
        {
            int gap = (int)Math.Pow(3, (int)Math.Log(array.Length, 3));
            var sw = new Stopwatch();
            sw.Start();
            while (gap >= 1)
            {
                for (int i = gap; i < array.Length; i++)
                {
                    int value = array.GetElement(i);
                    int j;
                    for (j = i - gap; j >= 0 && array.GetElement(j) > value; j -= gap)
                    {
                        array.SetElement(j + gap, array.GetElement(j));
                    }
                    array.SetElement(j + gap, value);
                }
                gap = gap / 3;
            }
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }

        public static long ShellSortingMethodOfDividingInHalf(SinglyLlinkedList list)
        {
            var gap = list.Length / 2;
            var sw = new Stopwatch();
            sw.Start();
            while (gap >= 1)
            {
                int i, j;
                for ( i = gap; i < list.Length; i++)
                {
                    int value = list.GetNode(i).data;
                    for (j = i - gap; (j >= 0) && (list.GetNode(j).data > value); j -= gap)
                        list.GetNode(j + gap).data = list.GetNode(j).data;
                    list.GetNode(j + gap).data= value;
                }
                gap = gap / 2;
            }
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }
        public static long ShellSortingMethodVirt(SinglyLlinkedList list)
        {
            int gap = list.Length / 2;
            var sw = new Stopwatch();
            sw.Start();
            while (gap >= 1)
            {
                int i, j;
                for (i = gap; i < list.Length; i++)
                {
                    int value = list.GetNode(i).data;
                    for (j = i - gap; (j >= 0) && (list.GetNode(j).data > value); j -= gap)
                        list.GetNode(j + gap).data = list.GetNode(j).data;
                    list.GetNode(j + gap).data = value;
                }
                gap = (gap - 1) / 3;
            }
            sw.Stop();
            //return array;
            return sw.ElapsedMilliseconds;

        }
        public static long ShellSortingMethodKnyt(SinglyLlinkedList list)
        {
            int gap =(int)Math.Pow(3, (int)Math.Log(list.Length, 3));
            var sw = new Stopwatch();
            sw.Start();
            while (gap >= 1)
            {
                int i, j;
                for (i = gap; i < list.Length; i++)
                {
                    int value = list.GetNode(i).data;
                    for (j = i - gap; (j >= 0) && (list.GetNode(j).data > value); j -= gap)
                        list.GetNode(j + gap).data = list.GetNode(j).data;
                    list.GetNode(j + gap).data = value;
                }
                gap = gap / 3;
            }
            sw.Stop();
            //return array;
            return sw.ElapsedMilliseconds;

        }
        public static long ShellSortingMethodOfDividingInHalf(DoublyLinkedList list)
        {
            var gap = list.Length / 2;
            var sw = new Stopwatch();
            sw.Start();
            while (gap >= 1)
            {
                int i, j;
                for (i = gap; i < list.Length; i++)
                {
                    int value = list.GetNode(i).data;
                    for (j = i - gap; (j >= 0) && (list.GetNode(j).data > value); j -= gap)
                        list.GetNode(j + gap).data = list.GetNode(j).data;
                    list.GetNode(j + gap).data = value;
                }
                gap = gap / 2;
            }
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }
        public static long ShellSortingMethodVirt(DoublyLinkedList list)
        {
            int gap = list.Length / 2;
            var sw = new Stopwatch();
            sw.Start();
            while (gap >= 1)
            {
                int i, j;
                for (i = gap; i < list.Length; i++)
                {
                    int value = list.GetNode(i).data;
                    for (j = i - gap; (j >= 0) && (list.GetNode(j).data > value); j -= gap)
                        list.GetNode(j + gap).data = list.GetNode(j).data;
                    list.GetNode(j + gap).data = value;
                }
                gap = (gap - 1) / 3;
            }
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }
        public static long ShellSortingMethodKnyt(DoublyLinkedList list)
        {
            int gap = (int)Math.Pow(3, (int)Math.Log(list.Length, 3));
            var sw = new Stopwatch();
            sw.Start();
            while (gap >= 1)
            {
                int i, j;
                for (i = gap; i < list.Length; i++)
                {
                    int value = list.GetNode(i).data;
                    for (j = i - gap; (j >= 0) && (list.GetNode(j).data > value); j -= gap)
                        list.GetNode(j + gap).data = list.GetNode(j).data;
                    list.GetNode(j + gap).data = value;
                }
                gap = gap / 3;
            }
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }

    }
}
