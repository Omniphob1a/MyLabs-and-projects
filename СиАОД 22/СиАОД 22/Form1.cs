using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СиАОД_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public String is_sorted(int[] Array)
        {
            for (int i = 1; i < Array.Length; i++)
            {
                if (Array[i - 1] > Array[i])
                {
                    return "Нет";
                }
            }
            return "Да";
        }
        private ulong comp;
        private ulong swaps;
        private long result;
        public void Sort2F(int[] Array)
        {
            // Создаем два вспомогательных массива для сортировки слиянием
            int[] B = new int[Array.Length];
            int[] C = new int[Array.Length];

            // Объявляем переменные для индексов и счетчиков
            int i, j, aLength, bLength, cLength, bIndex, cIndex;
            comp = 0; // Счетчик сравнений
            swaps = 0; // Счетчик обменов
            result = 0; // Время выполнения сортировки

            // Запускаем таймер для измерения времени сортировки
            var time = new Stopwatch();
            time.Start();

            // Внешний цикл устанавливает длину серий для слияния
            for (int seriesLength = 1; seriesLength < Array.Length; seriesLength *= 2)
            {
                // Инициализируем индексы для начала новой серии
                int aIndex = bLength = cLength = 0;

                // Разделяем массив на серии и копируем их в массивы B и C
                while (aIndex < Array.Length)
                {
                    // Копируем элементы в массив B
                    for (i = 0; i < seriesLength && aIndex < Array.Length; i++)
                    {
                        B[bLength++] = Array[aIndex++];
                        swaps++; // Увеличиваем счетчик обменов
                    }
                    // Копируем элементы в массив C
                    for (i = 0; i < seriesLength && aIndex < Array.Length; i++)
                    {
                        C[cLength++] = Array[aIndex++];
                        swaps++; // Увеличиваем счетчик обменов
                    }
                }

                // Сбрасываем индекс aLength для начала слияния
                aLength = 0;
                // Инициализируем индексы для массивов B и C
                bIndex = cIndex = 0;

                // Сливаем серии обратно в исходный массив
                while (bIndex < bLength && cIndex < cLength)
                {
                    // Сливаем элементы, пока не достигнем конца серии в обоих массивах
                    for (i = j = 0; bIndex < bLength && cIndex < cLength && i < seriesLength && j < seriesLength;)
                    {
                        comp++; // Увеличиваем счетчик сравнений
                                // Выбираем меньший элемент из двух массивов
                        if (B[bIndex] < C[cIndex])
                        {
                            Array[aLength++] = B[bIndex++];
                            i++;
                            swaps++; // Увеличиваем счетчик обменов
                        }
                        else
                        {
                            Array[aLength++] = C[cIndex++];
                            j++;
                            swaps++; // Увеличиваем счетчик обменов
                        }
                    }
                    // Если остались элементы в массиве B, копируем их
                    while (bIndex < bLength && i < seriesLength)
                    {
                        Array[aLength++] = B[bIndex++];
                        i++;
                        swaps++; // Увеличиваем счетчик обменов
                    }
                    // Если остались элементы в массиве C, копируем их
                    while (cIndex < cLength && j < seriesLength)
                    {
                        Array[aLength++] = C[cIndex++];
                        j++;
                        swaps++; // Увеличиваем счетчик обменов
                    }
                }
                // Если остались элементы только в одном из массивов, копируем их
                while (bIndex < bLength)
                {
                    Array[aLength++] = B[bIndex++];
                    swaps++; // Увеличиваем счетчик обменов
                }
            }
            // Останавливаем таймер и сохраняем результат
            time.Stop();
            result = time.ElapsedMilliseconds;
        }
        public void Sort1F(int[] Array)
        {
            int[] B = new int[Array.Length];
            int[] C = new int[Array.Length];
            int[] D = new int[Array.Length];
            int[] E = new int[Array.Length];
            int i, j, k, l, bLength, cLength, dLength, eLength, bINdex, cIndex;
            comp = 0;
            swaps = 0;
            result = 0;
            var time = new Stopwatch();
            time.Start();
            int aIndex = bLength = cLength = 0;
            int seriesLength = 1;
            while (aIndex < Array.Length)
            {
                for (i = 0; i < seriesLength && aIndex < Array.Length; i++)
                {
                    B[bLength++] = Array[aIndex++];
                    swaps++;
                }
                for (i = 0; i < seriesLength && aIndex < Array.Length; i++)
                {
                    C[cLength++] = Array[aIndex++];
                    swaps++;
                }
            }
            for (seriesLength = 1; seriesLength < Array.Length; seriesLength *= 2)
            {
                dLength = eLength = 0;
                bINdex = cIndex = 0;
                while (bINdex < bLength && cIndex < cLength)
                {
                    for (i = j = 0; bINdex < bLength && cIndex < cLength && i < seriesLength && j < seriesLength;)
                    {
                        comp++;
                        if (B[bINdex] < C[cIndex])
                        {
                            D[dLength++] = B[bINdex++];
                            i++;
                            swaps++;
                        }
                        else
                        {
                            D[dLength++] = C[cIndex++];
                            j++;
                            swaps++;
                        }
                    }
                    while (bINdex < bLength && i < seriesLength)
                    {
                        D[dLength++] = B[bINdex++];
                        i++;
                        swaps++;
                    }
                    while (cIndex < cLength && j < seriesLength)
                    {
                        D[dLength++] = C[cIndex++];
                        j++;
                        swaps++;
                    }
                    for (k = l = 0; bINdex < bLength && cIndex < cLength && k < seriesLength && l < seriesLength;)
                    {
                        comp++;
                        if (B[bINdex] < C[cIndex])
                        {
                            E[eLength++] = B[bINdex++];
                            k++;
                            swaps++;
                        }
                        else
                        {
                            E[eLength++] = C[cIndex++];
                            l++;
                            swaps++;
                        }
                    }
                    while (bINdex < bLength && k < seriesLength)
                    {
                        E[eLength++] = B[bINdex++];
                        k++;
                        swaps++;
                    }
                    while (cIndex < cLength && l < seriesLength)
                    {
                        E[eLength++] = C[cIndex++];
                        l++;
                        swaps++;
                    }
                }
                while (bINdex < bLength)
                {
                    D[dLength++] = B[bINdex++];
                    swaps++;
                }
                (B, D) = (D, B);
                bLength = dLength;
                (C, E) = (E, C);
                cLength = eLength;
            }
            for (int a = 0; a < bLength; a++)
            {
                Array[a] = B[a];
            }
            time.Stop();
            result = time.ElapsedMilliseconds;
        }
        public void Natural2F(int[] Array)
        {
            int[] B = new int[Array.Length];
            int[] C = new int[Array.Length];
            int aLength, bLength, cLength, aIndex, bIndex, cIndex, SerB, SerC;
            comp = 0;
            swaps = 0;
            result = 0;
            var time = new Stopwatch();
            time.Start();
            do
            {
                aIndex = bLength = cLength = 0;
                while (aIndex < Array.Length)
                {
                    while (aIndex < Array.Length)
                    {
                        B[bLength++] = Array[aIndex++];
                        swaps++;
                        comp++;
                        if (aIndex < Array.Length && Array[aIndex] < Array[aIndex - 1]) break;
                    }
                    while (aIndex < Array.Length)
                    {
                        C[cLength++] = Array[aIndex++];
                        swaps++;
                        comp++;
                        if (aIndex < Array.Length && Array[aIndex] < Array[aIndex - 1]) break;
                    }
                }
                aLength = bIndex = cIndex = 0;
                while (bIndex < bLength && cIndex < cLength)
                {
                    for (SerB = bIndex; SerB < bLength;)
                    {
                        if (B[SerB] <= B[SerB + 1]) SerB++;
                        else break;
                    }
                    for (SerC = cIndex; SerC < cLength;)
                    {
                        if (C[SerC] <= C[SerC + 1]) SerC++;
                        else break;
                    }
                    while (bIndex <= SerB && cIndex <= SerC && bIndex < bLength && cIndex < cLength)
                    {
                        comp++;
                        if (B[bIndex] < C[cIndex])
                        {
                            swaps++;
                            Array[aLength++] = B[bIndex++];
                        }
                        else
                        {
                            swaps++;
                            Array[aLength++] = C[cIndex++];
                        }
                    }
                    while (bIndex <= SerB && bIndex < bLength)
                    {
                        swaps++;
                        Array[aLength++] = B[bIndex++];
                    }
                    while (cIndex <= SerC && cIndex < cLength)
                    {
                        swaps++;
                        Array[aLength++] = C[cIndex++];
                    }
                }
                while (bIndex < bLength)
                {
                    swaps++;
                    Array[aLength++] = B[bIndex++];
                }
                while (cIndex < cLength)
                {
                    swaps++;
                    Array[aLength++] = C[cIndex++];
                }
            }
            while (bLength != 0 && cLength != 0);
            time.Stop();
            result = time.ElapsedMilliseconds;
        }
        public void Natural1F(int[] Array)
        {
            comp = 0;
            swaps = 0;
            result = 0;
            Stopwatch time = new Stopwatch();
            time.Start();
            int[] B = new int[Array.Length];
            int[] C = new int[Array.Length];
            int[] D = new int[Array.Length];
            int[] E = new int[Array.Length];
            int AInd = 0; int BLength = 0; int CLength = 0; int SerB; int SerC;
            while (AInd < Array.Length)
            {
                while (AInd < Array.Length)
                {
                    B[BLength++] = Array[AInd++];
                    swaps++;
                    comp++;
                    if (AInd < Array.Length && Array[AInd] < Array[AInd - 1]) break;
                }
                while (AInd < Array.Length)
                {
                    C[CLength++] = Array[AInd++];
                    swaps++;
                    comp++;
                    if (AInd < Array.Length && Array[AInd] < Array[AInd - 1]) break;
                }
            }
            do
            {
                int Bindex = 0;
                int Cindex = 0;
                int DLength = 0;
                int ELength = 0;
                while (Bindex < BLength || Cindex < CLength)
                {
                    for (SerB = Bindex; SerB < BLength;)
                    {
                        if (B[SerB] <= B[SerB + 1]) SerB++;
                        else break;
                    }
                    for (SerC = Cindex; SerC < CLength;)
                    {
                        if (C[SerC] <= C[SerC + 1]) SerC++;
                        else break;
                    }
                    while (Bindex <= SerB && Cindex <= SerC && Bindex < BLength && Cindex < CLength)
                    {
                        comp++;
                        if (B[Bindex] < C[Cindex])
                        {
                            swaps++;
                            D[DLength++] = B[Bindex++];
                        }
                        else
                        {
                            swaps++;
                            D[DLength++] = C[Cindex++];
                        }
                    }
                    while (Cindex < CLength && Cindex <= SerC)
                    {
                        swaps++;
                        D[DLength++] = C[Cindex++];
                    }
                    while (Bindex < BLength && Bindex <= SerB)
                    {
                        swaps++;
                        D[DLength++] = B[Bindex++];
                    }
                    for (SerB = Bindex; SerB < BLength;)
                    {
                        if (B[SerB] <= B[SerB + 1]) SerB++;
                        else break;
                    }
                    for (SerC = Cindex; SerC < CLength;)
                    {
                        if (C[SerC] <= C[SerC + 1]) SerC++;
                        else break;
                    }
                    while (Bindex <= SerB && Cindex <= SerC && Bindex < BLength && Cindex < CLength)
                    {
                        comp++;
                        if (B[Bindex] < C[Cindex])
                        {
                            swaps++;
                            E[ELength++] = B[Bindex++];
                        }
                        else
                        {
                            swaps++;
                            E[ELength++] = C[Cindex++];
                        }
                    }
                    while (Cindex < CLength && Cindex <= SerC)
                    {
                        swaps++;
                        E[ELength++] = C[Cindex++];
                    }
                    while (Bindex < BLength && Bindex <= SerB)
                    {
                        swaps++;
                        E[ELength++] = B[Bindex++];
                    }
                }
                (B, D) = (D, B);
                BLength = DLength;
                (C, E) = (E, C);
                CLength = ELength;
            }
            while (BLength != 0 && CLength != 0);
            for (int i = 0; i < BLength; i++)
            {
                Array[i] = B[i];
            }
            time.Stop();
            result = time.ElapsedMilliseconds;
        }
        public void AbsorbtionSort(int[] array)
        {
            comp = 0;
            swaps = 0;
            result = 0;
            var time = new Stopwatch();
            time.Start();
            int OPLength = array.Length * Convert.ToInt32(numericUpDownPercent.Value) / 100;
            int[] arr_copy = (int[])array.Clone();
            int[] OPArray = new int[OPLength];
            int OPInd, arrayInd, curInd;
            Array.Sort(array, array.Length - OPLength, OPLength);
            int ind = array.Length - OPLength - 1;
            while (ind >= 0)
            {
                OPInd = 0;
                for (int j = ind - OPLength; ind > j && ind >= 0;)
                {
                    OPArray[OPInd++] = array[ind--];
                }
                Array.Sort(OPArray);
                OPInd = 0;
                arrayInd = ind + OPLength + 1;
                curInd = ind + 1;
                while (OPInd < OPLength && arrayInd < array.Length)
                {
                    if (OPArray[OPInd] < array[arrayInd])
                    {
                        array[curInd++] = OPArray[OPInd++];
                    }
                    else
                    {
                        array[curInd++] = array[arrayInd++];
                    }
                }
                while (OPInd < OPLength)
                {
                    array[curInd++] = OPArray[OPInd++];
                }
                while(arrayInd < array.Length)
                {
                    array[curInd++] = array[arrayInd++];
                }
            }

            /*int curInd = array.Length - len - 1;
            int indTmpArray, indSort, Ind, sInd;
            for (int i = 1; i < array.Length / len; i++)
            {
                indTmpArray = 0;
                while (curInd > array.Length - (i + 1) * len - 1)
                {
                    swaps++;
                    tmpArray[indTmpArray++] = array[curInd--];
                }
                Array.Sort(tmpArray);
                indSort = 0;
                Ind = curInd + 1;
                sInd = curInd + len + 1;

                while (indSort < indTmpArray && sInd < array.Length)
                {
                    comp++;
                    array[Ind++] = tmpArray[indSort] < array[sInd] ? tmpArray[indSort++] : array[sInd++];
                    swaps++;
                }
                while (indSort < indTmpArray)
                {
                    swaps++;
                    array[Ind++] = tmpArray[indSort++];
                }
                while (sInd < array.Length)
                {
                    swaps++;
                    array[Ind++] = array[sInd++];
                }
            }
            indTmpArray = 0;
            while (curInd >= 0)
            {
                swaps++;
                tmpArray[indTmpArray++] = array[curInd--];
            }
            Array.Sort(tmpArray, 0, indTmpArray + 1);
            indSort = 0;
            Ind = curInd + 1;
            sInd = indTmpArray;
            while (indSort < indTmpArray && sInd < array.Length)
            {
                comp++;
                array[Ind++] = tmpArray[indSort] < array[sInd] ? tmpArray[indSort++] : array[sInd++];
                swaps++;
            }
            while (indSort < indTmpArray)
            {
                swaps++;
                array[Ind++] = tmpArray[indSort++];
            }
            while (sInd < array.Length)
            {
                swaps++;
                array[Ind++] = array[sInd++];
            }*/
            time.Stop();
            result = time.ElapsedMilliseconds;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            String[] headers = { "Простое 2ф", "Простое 1ф", "Естественное 2ф", "Естественное 1ф", "Поглощение" };
            dataGridView.RowCount = headers.Length;
            for (int i = 0; i < dataGridView.RowCount; i++) {
                dataGridView.Rows[i].Cells[1].Value = headers[i];
            }
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                dataGridView.Rows[i].Cells[0].Value = true;
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 2; j < dataGridView.ColumnCount; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = "";
                }
            }
            bool is_checked = false;
            for (int i = 0; i < dataGridView.Rows.Count; i++) //i < dataGridView.Rows.Count
            {
                if (dataGridView.Rows[i].Cells[0].Value.Equals(true))
                {
                    is_checked = true;
                    break;
                }
            }
            if (is_checked == false)
            {
                MessageBox.Show("Ошибка: выберите сортировку");
                return;
            }
            int[] arr = new int[Convert.ToInt32(numericUpDownSize.Value)];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, arr.Length);
            }
            if (dataGridView.Rows[0].Cells[0].Value.Equals(true))
            {
                int[] arr_copy = (int[])arr.Clone();
                Sort2F(arr_copy);
                dataGridView.Rows[0].Cells[2].Value = comp;
                dataGridView.Rows[0].Cells[3].Value = swaps;
                dataGridView.Rows[0].Cells[4].Value = result;
                dataGridView.Rows[0].Cells[5].Value = is_sorted(arr_copy);
            }
            if (dataGridView.Rows[1].Cells[0].Value.Equals(true))
            {
                int[] arr_copy = (int[])arr.Clone();
                Sort1F(arr_copy);
                dataGridView.Rows[1].Cells[2].Value = comp;
                dataGridView.Rows[1].Cells[3].Value = swaps;
                dataGridView.Rows[1].Cells[4].Value = result;
                dataGridView.Rows[1].Cells[5].Value = is_sorted(arr_copy);
            }
            if (dataGridView.Rows[2].Cells[0].Value.Equals(true))
            {
                int[] arr_copy = (int[])arr.Clone();
                Natural2F(arr_copy);
                dataGridView.Rows[2].Cells[2].Value = comp;
                dataGridView.Rows[2].Cells[3].Value = swaps;
                dataGridView.Rows[2].Cells[4].Value = result;
                dataGridView.Rows[2].Cells[5].Value = is_sorted(arr_copy);
            }
            if (dataGridView.Rows[3].Cells[0].Value.Equals(true))
            {
                int[] arr_copy = (int[])arr.Clone();
                Natural1F(arr_copy);
                dataGridView.Rows[3].Cells[2].Value = comp;
                dataGridView.Rows[3].Cells[3].Value = swaps;
                dataGridView.Rows[3].Cells[4].Value = result;
                dataGridView.Rows[3].Cells[5].Value = is_sorted(arr_copy);
            }
            if (dataGridView.Rows[4].Cells[0].Value.Equals(true))
            {
                int[] arr_copy = (int[])arr.Clone();
                AbsorbtionSort(arr_copy);
                dataGridView.Rows[4].Cells[2].Value = comp;
                dataGridView.Rows[4].Cells[3].Value = swaps;
                dataGridView.Rows[4].Cells[4].Value = result;
                dataGridView.Rows[4].Cells[5].Value = is_sorted(arr_copy);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
