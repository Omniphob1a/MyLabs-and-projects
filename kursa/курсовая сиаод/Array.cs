using System;
using System.Diagnostics;

namespace курсовая_сиаод
{
    public class DynamicArray
    {
        private int[] array;
        private int length;

        public DynamicArray()
        {
            array = new int[0];
            length = 0;
        }

        public void AddLast(int value)
        {
            Array.Resize(ref array, length + 1);
            array[length] = value;
            length++;
        }

        public void AddAfter(int index, int value)
        {
            if (index < 0 || index >= length) throw new ArgumentException(nameof(index));

            Array.Resize(ref array, length + 1);

            for (int i = length - 1; i > index; i--)
            {
                array[i] = array[i - 1];
            }

            array[index + 1] = value;
            length++;
        }

        public void Swap(int index1, int index2)
        {
            if (index1 < 0 || index1 >= length) throw new ArgumentException(nameof(index1));
            if (index2 < 0 || index2 >= length) throw new ArgumentException(nameof(index2));

            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        public int Remove(int index)
        {
            if (index < 0 || index >= length) throw new ArgumentException(nameof(index));

            int removedValue = array[index];

            for (int i = index; i < length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            Array.Resize(ref array, length - 1);
            length--;

            return removedValue;
        }

        public int GetElement(int index)
        {
            if (index < 0 || index >= length) throw new ArgumentException(nameof(index));

            return array[index];
        }

        public void SetElement(int index, int value)
        {
            if (index < 0 || index >= length) throw new ArgumentException(nameof(index));

            array[index] = value;
        }

        public int Length
        {
            get { return length; }
        }

        public static DynamicArray GetRandomUnorderedArray(int size)
        {
            DynamicArray tmp = new DynamicArray();
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                tmp.AddLast(rnd.Next(0, size));
            }
            return tmp;
        }

        public static DynamicArray GetRandomOrderedArray(int size)
        {
            DynamicArray tmp = new DynamicArray();
            Random rnd = new Random();
            int last = 0;
            for (int i = 0; i < size; i++)
            {
                int current = last + rnd.Next(0, 5);
                tmp.AddLast(current);
                last = current;
            }
            return tmp;
        }

        public static DynamicArray GetRandomOrderedInReverseOrderArray(int size)
        {
            DynamicArray tmp = DynamicArray.GetRandomOrderedArray(size);
            for (int i = 0; i < size / 2; i++)
            {
                int tmpInt = tmp.GetElement(i);
                tmp.Swap(i, size - i - 1);
            }
            return tmp;
        }

        public static DynamicArray GetRandomPartlyOrderedList(int size, int PercentOfOrder)
        {
            DynamicArray tmp = new DynamicArray();
            Random rnd = new Random();
            int last = 0;
            for (int i = 0; i < size * PercentOfOrder / 100; i++)
            {
                int current = last + rnd.Next(0, 5);
                tmp.AddLast(current);
                last = current;
            }
            for (int i = size * PercentOfOrder / 100; i < size; i++)
                tmp.AddLast(rnd.Next(0, size));
            return tmp;
        }
    }
}
   