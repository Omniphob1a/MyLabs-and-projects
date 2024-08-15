using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba12
{
    public partial class Form1 : Form
    {
        private int comp;
        private int swaps;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            InitializeDataGridView();

        }

        private void InitializeDataGridView()
        {

            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            dataGridView1.AllowUserToAddRows = false;


            dataGridView1.RowCount = 7;
            dataGridView1.ColumnCount = 6;


            dataGridView1.Columns[1].Name = "Название";
            dataGridView1.Columns[2].Name = "Сравнение";
            dataGridView1.Columns[3].Name = "Перестановки";
            dataGridView1.Columns[4].Name = "Время";
            dataGridView1.Columns[5].Name = "Отсортировано?";


            string[] rowNames = { "Обмен", "Выбор", "Включение", "Шелла", "Быстрая", "Линейная", "Встроенная" };
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[1].Value = rowNames[i];
            }



            AddCheckBoxes();
        }

        private void AddCheckBoxes()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                var checkBoxCell = new DataGridViewCheckBoxCell();
                checkBoxCell.ReadOnly = false;

                dataGridView1[0, i] = checkBoxCell;
                dataGridView1[0, i].Value = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int arraySize = (int)numericUpDown1.Value;
            int[] array = GenerateRandomArray(arraySize);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ((bool)row.Cells[0].Value)
                {
                    string sortMethodName = row.Cells["Название"].Value.ToString();
                    switch (sortMethodName)
                    {
                        case "Обмен":
                            RunSort(sortMethodName, BubbleSort, array);
                            break;
                        case "Выбор":
                            RunSort(sortMethodName, SelectionSort, array);
                            break;
                        case "Включение":
                            RunSort(sortMethodName, InsertionSort, array);
                            break;
                        case "Быстрая":
                            RunSort(sortMethodName, QuickSort, array); break;
                        case "Шелла":
                            RunSort(sortMethodName, ShellVirt, array); break;
                        case "Линейная":
                            RunSort(sortMethodName, LinearSort, array); break;
                        case "Встроенная":
                            RunSort(sortMethodName, BuiltInSort, array); break;

                    }
                }
            }
        }


        private void RunSort(string methodName, Func<int[], (int, int, int, bool)> sortMethod, int[] array)
        {

            int[] arrayCopy = (int[])array.Clone();
            (int comparisons, int swaps, int time, bool isSorted) = sortMethod(arrayCopy);
            DisplayResults(methodName, comparisons, swaps, time, isSorted);
        }

        private (int, int, int, bool) BubbleSort(int[] array)
        {
            int startTime = Environment.TickCount;
            int numComparisons = 0;
            int numSwaps = 0;
            int n = array.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    numComparisons++;
                    if (array[j] > array[j + 1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                        numSwaps++;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }

            int endTime = Environment.TickCount;
            bool isSort = isSorted(array);
            return (numComparisons, numSwaps, endTime - startTime, isSort);
        }

        private (int, int, int, bool) SelectionSort(int[] array)
        {
            int startTime = Environment.TickCount;
            int numComparisons = 0;
            int numSwaps = 0;
            int n = array.Length;

            for (int last = n - 1; last > 0; last--)
            {
                int maxIdx = 0;
                for (int j = 1; j <= last; j++)
                {
                    numComparisons++;
                    if (array[j] > array[maxIdx])
                    {
                        maxIdx = j;
                    }
                }

                (array[last], array[maxIdx]) = (array[maxIdx], array[last]);
                numSwaps++;

            }

            int endTime = Environment.TickCount;
            bool isSort = isSorted(array);
            return (numComparisons, numSwaps, endTime - startTime, isSort);
        }

        private void DisplayResults(string sortMethod, int comparisons, int swaps, int time, bool isSorted)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Название"].Value.ToString() == sortMethod)
                {
                    row.Cells["Сравнение"].Value = comparisons;
                    row.Cells["Перестановки"].Value = swaps;
                    row.Cells["Время"].Value = time;
                    row.Cells["Отсортировано?"].Value = isSorted ? "Да" : "Нет";
                    break;
                }
            }
        }

        private int[] GenerateRandomArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1000);
            }
            return array;
        }

        public bool isSorted(int[] arr)
        {
            bool isSorted = true;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    isSorted = false; break;
                }
            }
            return isSorted;
        }
        private (int, int, int, bool) InsertionSort(int[] array)
        {

            int startTime = Environment.TickCount;

            int n = array.Length;
            int compare = 0;
            int swap = 0;

            for (int i = 1; i < n; i++)
            {
                int current = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > current)
                {
                    array[j + 1] = array[j];
                    j--;
                    compare++;
                    swap++;
                }
                array[j + 1] = current;
                swap++;
            }

            int endTime = Environment.TickCount;
            bool isSort = isSorted(array);
            return (compare, swap, endTime - startTime, isSort);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private (int, int, int, bool) QuickSort(int[] array)
        {
            int comp = 0;
            int swap = 0;
            int startTime = Environment.TickCount;
            (comp, swap) = QuickSort(array, 0, array.Length - 1, 0, 0);
            int end = Environment.TickCount - startTime;

            return (comp, swap, end, isSorted(array));
        }

        private (int, int) QuickSort(int[] arr, int low, int high, int compare, int swaps)
        {
            if (low >= high) return (compare, swaps);
            var pivot = arr[low];
            var k = high;

            for (int i = high; i > low; i--)
            {
                compare++;
                if (arr[i] > pivot)
                {                            
                    swaps++; 
                    (arr[i], arr[k]) = (arr[k], arr[i]);
                    k--;
                }
            }
            swaps++;
            (arr[low], arr[k]) = (arr[k], arr[low]);
            (compare, swaps) = QuickSort(arr, low, k - 1, compare, swaps);
            (compare, swaps) = QuickSort(arr, k + 1, high, compare, swaps);
            return (compare, swaps);
        }
              
        public (int, int, int, bool) ShellVirt(int[] arr)
        {
            int comp = 0;
            int start = Environment.TickCount;
            int shift = 0;
            int j;
            int step = 1;
            while (step <= arr.Length / 9) step = 3 * step + 1;
            while (step > 0)
            {
                for (int i = 0; i < (arr.Length - step); i++)
                {
                    comp++;
                    j = i;
                    while ((j >= 0) && (arr[j] > arr[j + step]))
                    {
                        comp++;
                        int temp = arr[j + step];
                        for (int k = j + step; k > j; k -= step) 
                        {
                            arr[k] = arr[k - step];
                            shift++;
                        }
                        arr[j] = temp;  
                        j -= step;
                    }
                }
                step = step / 3;
            }

            int end = Environment.TickCount - start;
            return (comp, shift, end, isSorted(arr));
        }
        private (int, int, int, bool) LinearSort(int[] array)
        {
            int startTime = Environment.TickCount;
            int comparisons = 0;
            int assignments = 0;

            int min = array[0];
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                min = Math.Min(min, array[i]);
                max = Math.Max(max, array[i]);
            }

            int range = max - min + 1;
            int[] counts = new int[range];
            for (int i = 0; i < array.Length; i++)
            {
                comparisons++;
                int index = array[i] - min;
                counts[index]++;
                assignments++;
            }

            int j = 0;
            for (int i = 0; i < range; i++)
            {
                for (int count = 0; count < counts[i]; count++)
                {
                    array[j++] = min + i;
                    assignments++;
                }
            }

            int endTime = Environment.TickCount - startTime;
            return (comparisons, assignments, endTime, isSorted(array));
        }

        private (int, int, int, bool) BuiltInSort(int[] array)
        {
            int comparisons = 0;
            int assignments = 0;
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Array.Sort(array);
            stopwatch.Stop();
            return (comparisons, assignments, (int)stopwatch.ElapsedMilliseconds, isSorted(array));
        }



    }

}
