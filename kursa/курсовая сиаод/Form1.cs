using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace курсовая_сиаод
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void buttonSort_Click(object sender, EventArgs e)
        {

            string value = "";
            if (radioButton1.Checked)
                value = radioButton1.Text;
            else if (radioButton2.Checked)
                value = radioButton2.Text;
            else if (radioButton3.Checked)
                value = radioButton3.Text;
            else if (radioButton4.Checked)
                value = radioButton4.Text;
            else value = "error";
            string value2 = "";
            if (radioButton6.Checked)
                value2 = radioButton6.Text;
            else if (radioButton7.Checked)
                value2 = radioButton7.Text;
            else if (radioButton8.Checked)
                value2 = radioButton8.Text;
            else value = "error";
            this.dataGridView1.Columns.Clear();
            this.dataGridView1.Columns.Add("NameOfAlgoritm", "Название алгоритма");
            this.dataGridView1.Columns[0].Width = 340;
            for (int i = 0; i < 10; i++)
            {
                this.dataGridView1.Columns.Add(Convert.ToString(Convert.ToInt64(numericUpDownSizeList.Value) / 10 * (i + 1)), Convert.ToString(Convert.ToInt64(numericUpDownSizeList.Value) / 10 * (i + 1)));
                this.dataGridView1.Columns[i+1].Width = 50;
            }
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows[0].Cells[0].Value = "Сортировка Шелла методом нахождения шага Кнут";
            this.dataGridView1.Rows[1].Cells[0].Value = "Сортировка Шелла методом нахождения шага Вирт";
            this.dataGridView1.Rows[2].Cells[0].Value = "Сортировка Шелла методом нахождения шага деление пополам";

            if (value == "Неупорядоченый")
            {
                if (value2 == "Односвязный список")
                {
                    for (int i = 1; i < 11; i++)
                    {
                        this.dataGridView1.Rows[0].Cells[i].Value = (int)sorter.ShellSortingMethodKnyt(SinglyLlinkedList.GetRandomUnorderedList(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i));
                        this.dataGridView1.Rows[1].Cells[i].Value = sorter.ShellSortingMethodVirt(SinglyLlinkedList.GetRandomUnorderedList(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i));
                        this.dataGridView1.Rows[2].Cells[i].Value = sorter.ShellSortingMethodOfDividingInHalf(SinglyLlinkedList.GetRandomUnorderedList(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i));
                    }
                }
                if (value2 == "Двусвязный список")
                {
                    for (int i = 1; i < 11; i++)
                    {
                        this.dataGridView1.Rows[0].Cells[i].Value = (int)sorter.ShellSortingMethodKnyt(DoublyLinkedList.GetRandomUnorderedList(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i));
                        this.dataGridView1.Rows[1].Cells[i].Value = sorter.ShellSortingMethodVirt(DoublyLinkedList.GetRandomUnorderedList(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i));
                        this.dataGridView1.Rows[2].Cells[i].Value = sorter.ShellSortingMethodOfDividingInHalf(DoublyLinkedList.GetRandomUnorderedList(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i));
                    }
                }
                if (value2 == "Массив")
                {
                    for (int i = 1; i < 11; i++)
                    {
                        this.dataGridView1.Rows[0].Cells[i].Value = (int)sorter.ShellSortingMethodKnyt(DynamicArray.GetRandomUnorderedArray(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i));
                        this.dataGridView1.Rows[1].Cells[i].Value = sorter.ShellSortingMethodVirt(DynamicArray.GetRandomUnorderedArray(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i));
                        this.dataGridView1.Rows[2].Cells[i].Value = sorter.ShellSortingMethodOfDividingInHalf(DynamicArray.GetRandomUnorderedArray(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i));
                    }
                }
            }

            else if (value == "Упорядоченый")
            {
                if (value2 == "Односвязный список")
                {
                    for (int i = 1; i < 11; i++)
                    {
                        this.dataGridView1.Rows[0].Cells[i].Value = (int)sorter.ShellSortingMethodKnyt(SinglyLlinkedList.GetRandomOrderedList(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i));
                        this.dataGridView1.Rows[1].Cells[i].Value = sorter.ShellSortingMethodVirt(SinglyLlinkedList.GetRandomOrderedList(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i));
                        this.dataGridView1.Rows[2].Cells[i].Value = sorter.ShellSortingMethodOfDividingInHalf(SinglyLlinkedList.GetRandomOrderedList(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i));
                    }
                }

                if (value2 == "Двусвязный список")
                {
                    for (int i = 1; i < 11; i++)
                    {
                        this.dataGridView1.Rows[0].Cells[i].Value = (int)sorter.ShellSortingMethodKnyt(DoublyLinkedList.GetRandomOrderedList(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i));
                        this.dataGridView1.Rows[1].Cells[i].Value = sorter.ShellSortingMethodVirt(DoublyLinkedList.GetRandomOrderedList(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i));
                        this.dataGridView1.Rows[2].Cells[i].Value = sorter.ShellSortingMethodOfDividingInHalf(DoublyLinkedList.GetRandomOrderedList(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i));
                    }
                }
                if (value2 == "Массив")
                {
                    for (int i = 1; i < 11; i++)
                    {
                        this.dataGridView1.Rows[0].Cells[i].Value = (int)sorter.ShellSortingMethodKnyt(DynamicArray.GetRandomOrderedArray(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i));
                        this.dataGridView1.Rows[1].Cells[i].Value = sorter.ShellSortingMethodVirt(DynamicArray.GetRandomOrderedArray(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i));
                        this.dataGridView1.Rows[2].Cells[i].Value = sorter.ShellSortingMethodOfDividingInHalf(DynamicArray.GetRandomOrderedArray(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i));
                    }
                }
            }

            else if (value == "Упорядоченный в обратном порядке")
            {
                if (value2 == "Односвязный список")
                {
                    for (int i = 1; i < 11; i++)
                    {
                        this.dataGridView1.Rows[0].Cells[i].Value = (int)sorter.ShellSortingMethodKnyt(SinglyLlinkedList.GetRandomOrderedInReverseOrderList(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i));
                        this.dataGridView1.Rows[1].Cells[i].Value = sorter.ShellSortingMethodVirt(SinglyLlinkedList.GetRandomOrderedInReverseOrderList(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i));
                        this.dataGridView1.Rows[2].Cells[i].Value = sorter.ShellSortingMethodOfDividingInHalf(SinglyLlinkedList.GetRandomOrderedInReverseOrderList(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i));
                    }
                }

                if (value2 == "Двусвязный список")
                {
                    for (int i = 1; i < 11; i++)
                    {
                        this.dataGridView1.Rows[0].Cells[i].Value = (int)sorter.ShellSortingMethodKnyt(DoublyLinkedList.GetRandomOrderedInReverseOrderList(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i));
                        this.dataGridView1.Rows[1].Cells[i].Value = sorter.ShellSortingMethodVirt(DoublyLinkedList.GetRandomOrderedInReverseOrderList(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i));
                        this.dataGridView1.Rows[2].Cells[i].Value = sorter.ShellSortingMethodOfDividingInHalf(DoublyLinkedList.GetRandomOrderedInReverseOrderList(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i));
                    }
                }
                if (value2 == "Массив")
                {
                    for (int i = 1; i < 11; i++)
                    {
                        this.dataGridView1.Rows[0].Cells[i].Value = (int)sorter.ShellSortingMethodKnyt(DynamicArray.GetRandomOrderedInReverseOrderArray(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i));
                        this.dataGridView1.Rows[1].Cells[i].Value = sorter.ShellSortingMethodVirt(DynamicArray.GetRandomOrderedInReverseOrderArray(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i));
                        this.dataGridView1.Rows[2].Cells[i].Value = sorter.ShellSortingMethodOfDividingInHalf(DynamicArray.GetRandomOrderedInReverseOrderArray(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i));
                    }
                }
            }

            else
            {
                if (value2 == "Односвязный список")
                {
                    for (int i = 1; i < 11; i++)
                    {
                        this.dataGridView1.Rows[0].Cells[i].Value = (int)sorter.ShellSortingMethodKnyt(SinglyLlinkedList.GetRandomPartlyOrderedList(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i, (int)numericUpDownPercentOfFill.Value));
                        this.dataGridView1.Rows[1].Cells[i].Value = sorter.ShellSortingMethodVirt(SinglyLlinkedList.GetRandomPartlyOrderedList(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i, (int)numericUpDownPercentOfFill.Value));
                        this.dataGridView1.Rows[2].Cells[i].Value = sorter.ShellSortingMethodOfDividingInHalf(SinglyLlinkedList.GetRandomPartlyOrderedList(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i, (int)numericUpDownPercentOfFill.Value));
                    }
                }
                if (value2 == "Двусвязный список")
                {
                    for (int i = 1; i < 11; i++)
                    {
                        this.dataGridView1.Rows[0].Cells[i].Value = (int)sorter.ShellSortingMethodKnyt(DoublyLinkedList.GetRandomPartlyOrderedList(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i, (int)numericUpDownPercentOfFill.Value));
                        this.dataGridView1.Rows[1].Cells[i].Value = sorter.ShellSortingMethodVirt(DoublyLinkedList.GetRandomPartlyOrderedList(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i, (int)numericUpDownPercentOfFill.Value));
                        this.dataGridView1.Rows[2].Cells[i].Value = sorter.ShellSortingMethodOfDividingInHalf(DoublyLinkedList.GetRandomPartlyOrderedList(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i, (int)numericUpDownPercentOfFill.Value));
                    }
                }
                if (value2 == "Массив")
                {
                    for (int i = 1; i < 11; i++)
                    {
                        this.dataGridView1.Rows[0].Cells[i].Value = (int)sorter.ShellSortingMethodKnyt(DynamicArray.GetRandomPartlyOrderedList(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i, (int)numericUpDownPercentOfFill.Value));
                        this.dataGridView1.Rows[1].Cells[i].Value = sorter.ShellSortingMethodVirt(DynamicArray.GetRandomPartlyOrderedList(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i, (int)numericUpDownPercentOfFill.Value));
                        this.dataGridView1.Rows[2].Cells[i].Value = sorter.ShellSortingMethodOfDividingInHalf(DynamicArray.GetRandomPartlyOrderedList(Convert.ToInt32(numericUpDownSizeList.Value) / 10 * i, (int)numericUpDownPercentOfFill.Value));
                    }
                }
            }
            
            chartGrafics.Series.Clear();
            for (int i = 0; i < 3; i++)
            {
                chartGrafics.Series.Add((string)this.dataGridView1.Rows[i].Cells[0].Value);
                chartGrafics.Series[i].ChartType = SeriesChartType.Spline;
                for (int j = 1; j < 11; j++)
                    chartGrafics.Series[i].Points.AddXY(this.dataGridView1.Columns[j].HeaderText, dataGridView1.Rows[i].Cells[j].Value);
            }
            chartGrafics.Series[0].Color = Color.Green;
            chartGrafics.Series[1].Color = Color.Red;
            chartGrafics.Series[2].Color = Color.Blue;
        }

    }
}
