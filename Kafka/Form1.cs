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

        private int NumberSymbols(string stroka, char symbol)
        {
            // 
            int k = 0;
            // 
            for (int i = 0; i < stroka.Length; i++)
            {
                if (stroka[i] == symbol)
                {
                    k += 1;
                }
            }
            // 
            return k;
        }
        private int NumberSlog(string stroka)
        {
            // Переменная которая хранит кол-во символов
            int m = 0;
            // Затем переходит при помощи цикла по каждому символу в строке
            for (int i = 0; i < stroka.Length - 1; i++)
            {
                // Если в строке символ равен М и А значение ma увеличивается на 1
                if (stroka[i] == 'м' && stroka[i + 1] == 'а')
                {
                    m++;
                }
            }
            return m;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "а" || textBox3.Text == "")
            {
                textBox2.Text = NumberSymbols(textBox1.Text, 'а').ToString();
            }    
            else if (textBox3.Text == "ма")
            {
                textBox2.Text = NumberSlog(textBox1.Text).ToString();
            }
            else
            {
                MessageBox.Show("Введите либо 'а', либо 'ма'.");
                return;
            }
        }
    }
}
