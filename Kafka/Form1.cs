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
            // Вводим переменную для подсчета символов.
            int k = 0;
            // Проходимся по каждому символу в строке.
            for (int i = 0; i < stroka.Length; i++)
            {
                // Если символ в строке равен symbol, то плюс 1.
                if (stroka[i] == symbol)
                {
                    k += 1;
                }
            }
            // Возврат цикла.
            return k;
        }
        private int NumberSlog(string stroka)
        {
            // Вводим переменную для счёта "ма".
            int m = 0;
            // Проходимся по каждому символу в строке, пока она не закончится.
            for (int i = 0; i < stroka.Length - 1; i++)
            {
                // Переменная увеличивается на 1, если следующий символ после "м" - "а".
                if (stroka[i] == 'м' && stroka[i + 1] == 'а')
                {
                    m++;
                }
            }
            // Возврат цикла.
            return m;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // если в поле введена "а" или оно пустое, то
            if (textBox3.Text == "а" || textBox3.Text == "")
            {
                // в поле выведится количество букв а. ToString для преобразование в строковое значение.
                textBox2.Text = NumberSymbols(textBox1.Text, 'а').ToString();
            }
            // Если будет МА, то выведится количество слогов МА.
            else if (textBox3.Text == "ма")
            {
                textBox2.Text = NumberSlog(textBox1.Text).ToString();
            }
            // Если вообще ничего из перечисленного, то вывод сообщения и возврат цикла.
            else
            {
                MessageBox.Show("Введите либо 'а', либо 'ма'.");
                return;
            }
        }
    }
}
