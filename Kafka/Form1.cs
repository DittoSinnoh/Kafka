using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Объявляем массив с 10 элементами.
        private int[] Arr = new int[10];

        // При помощи функции Insertion создаём алгоритм для
        // выполнения сортировки массива методом вставки.
        // Функция InsertionSort проходится по массиву, начиная со
        // второго элемента, и на каждом шаге вставляет текущий элемент
        // на подходящее место в уже упорядоченную часть массива.
        private void InsertionSort(int[] Arr)
        {
            // Начина со второго элемента, проходимся по всем элемнтам массива.
            // Length используется для возвращения колличества элементов в массиве.
            for (int i = 1; i < Arr.Length; i++)
            {
                int tea = Arr[i];  // Текущий элемент массива для вставки
                                   // в упорядоченную часть массива.
                int val = i - 1;
                // Происходит до тех пор, пока не выполнится условие.
                while (val >= 0 && tea < Arr[val])
                {
                    Arr[val + 1] = Arr[val];
                    val--;
                }
                Arr[val + 1] = tea;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnNewArr_Click(object sender, EventArgs e)
        {
            ClearFields();
            // a из поля мин, b из поля макс. r рандом
            int n = 10;
            int a = int.Parse(txtMin.Text);
            int b = int.Parse(txtMax.Text);
            Random r = new Random();
            // пока i меньше n, массив будет заполняться числами
            for(int i =0; i < n; i++)
            {
                Arr[i] = r.Next(a, b);
                lblArr.Text += Arr[i];
                if (i!=n) lblArr.Text += ", ";
            }
            // После цикла кнопка сортировки станет доступной.
            btnSort.Enabled = true;
            ClearTxt();
        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {

        }
        /*private int MinNumber(int [] x, int m)
        {
            int min = x[m];
            int MinN = m;
            for (int i = m; i < x.Length; i++)
            {
                if (x[i] < min)
                {
                    min = x[i];
                    MinN = i;
                }
            }
            return MinN;
        }    */

        private void btnSort_Click(object sender, EventArgs e)
        {
            // Вызов метода с аргументом массива.
            InsertionSort(Arr);
            // При помощи Join объединяем элементы массива и разделяем их.
            lblResult.Text = string.Join(", ", Arr);
            /*int k, t;
            for (int i = 0; i < Arr.Length; i++)
            {
                k = MinNumber(Arr, i);
                t = Arr[i];
                Arr[i] = Arr[k];
                Arr[k] = t;
                lblResult.Text += Arr[i];
                if (i != Arr.Length - 1)
                {
                    lblResult.Text += ", ";
                }
            }*/
            btnSort.Enabled = false;
        }
        private void ClearFields()
        {
            lblArr.Text = "";
            lblResult.Text = "";
            btnSort.Enabled = false;
        }
        private void ClearTxt()
        {
            txtMin.Text = "";
            txtMax.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
