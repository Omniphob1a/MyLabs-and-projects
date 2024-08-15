using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace СиАОД_18
{
    public partial class Form1 : Form
    {
        int[] arr = new int[15];
        int sizeArr = 0;
        int[] resArr = new int[15];
        int sizeResArr = 0;
        public Form1()
        {
            InitializeComponent();
        }

        void Clear_Tab()
        {
            for (int i = 0; i < dataGridViewArray.Rows[0].Cells.Count; i++)
            {
                dataGridViewArray.Rows[0].Cells[i].Value = "";
            }
            for (int i = 0; i < dataGridViewTree.Rows[0].Cells.Count; i++)
            {
                for (int j = 0; j < dataGridViewTree.Rows.Count; j++)
                {
                    dataGridViewTree.Rows[j].Cells[i].Value = "";   
                }
            }
            for (int i = 0; i < dataGridViewResult.Rows[0].Cells.Count; i++)
            {
                dataGridViewResult.Rows[0].Cells[i].Value = "";
            }
        }
        private void ClearQueue_Click(object sender, EventArgs e)
        {
            Clear_Tab();
            Array.Clear(arr, 0, arr.Length);
            Array.Clear(resArr, 0, resArr.Length);
            sizeArr = 0;
            sizeResArr = 0;
        }
        void Print()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0) continue;
                dataGridViewArray.Rows[0].Cells[i].Value = arr[i];
            }
            for (int i = 0; i < resArr.Length; i++)
            {
                if (resArr[i] == 0) continue;
                dataGridViewResult.Rows[0].Cells[i].Value = resArr[i];
            }
            int first_pos = arr.Length / 2;
            int col = first_pos;
            int row = 0;
            int elements_in_row = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0) dataGridViewTree.Rows[row].Cells[col].Value = "";
                else dataGridViewTree.Rows[row].Cells[col].Value = arr[i];
                int step = first_pos * 2;
                if (col != first_pos) col+= step;
                else col = first_pos;
                elements_in_row--;
                if (elements_in_row == 0)
                {
                    row++;
                    first_pos = arr.Length / (int)Math.Pow(2, row + 1) + 1;
                    col = first_pos - 1;
                    elements_in_row = (int)Math.Pow(2, row);
                }
            }
        }
        private void insert(int[] Array, int index, int value)
        {
            Array[index] = value;
            FixUp(Array, index);
            sizeArr++;
        }
        private void FixUp(int[] Array, int index)
        {
            while (Array[index] > Array[(index - 1) / 2])
            {
                (Array[index], Array[(index - 1) / 2]) = (Array[(index - 1) / 2], Array[index]);
                index = (index - 1) / 2;
            }
        }
        private void FixDown(int[] Array, int index)
        {
            while (2 * index + 1 <= sizeArr)
            {
                int j = 2 * index + 1;
                if (j < sizeArr && Array[j] < Array[j + 1]) j++;
                if (Array[index] >= Array[j]) break;
                (Array[index], Array[j]) = (Array[j], Array[index]);
                index = j;
            }
        }
        private void CreateQueue_Click(object sender, EventArgs e)
        {
            ClearQueue_Click(sender, e);
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                insert(arr, i, rnd.Next(10, 99));
            }
            Print();
        }

        private void LargestElement_Click(object sender, EventArgs e)
        {
            if (sizeArr == 0)
            {
                MessageBox.Show("Очередь пуста");
                return;
            }
            if (sizeResArr == resArr.Length)
            {
                MessageBox.Show("Результирующий массив заполнен");
                return;
            }
            resArr[sizeResArr] = arr[0];
            sizeResArr++;
            arr[0] = arr[sizeArr - 1];
            arr[sizeArr - 1] = 0;
            FixDown(arr, 0);
            sizeArr--;
            Clear_Tab();
            Print();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (sizeArr == arr.Length)
            {
                MessageBox.Show("Очередь заполнена");
                return;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    insert(arr, i, Convert.ToInt32(numericUpDownNew.Value));
                    break;
                }
            }
            Clear_Tab();
            Print();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (sizeArr == 0)
            {
                MessageBox.Show("Очередь пуста");
                return;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == Convert.ToInt32(numericUpDownBefore.Value))
                {
                    int old_elem = arr[i];
                    arr[i] = Convert.ToInt32(numericUpDownTo.Value);
                    if (old_elem < arr[i]) FixUp(arr, i);
                    else FixDown(arr, i);
                    Clear_Tab();
                    Print();
                    return;
                }
            }
            MessageBox.Show("Значения нет в очереди");
            return;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewArray.RowCount = 1;
            dataGridViewArray.ColumnCount = 15;
            dataGridViewTree.RowCount = 4;
            dataGridViewTree.ColumnCount = 15;
            dataGridViewResult.RowCount = 1;
            dataGridViewResult.ColumnCount = 15;
            for (int i = 0; i < 15; i++)
            {
                dataGridViewArray.Columns[i].Width = 60;
                dataGridViewTree.Columns[i].Width = 60;
                dataGridViewResult.Columns[i].Width = 60;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
