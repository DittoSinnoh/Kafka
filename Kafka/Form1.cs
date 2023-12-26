using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kafka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string file; // Переменная для хранения имени файла
        List<string> wordBase = new List<string>(); // Список для хранения слов
        private string topic;
        int a; // Переменная для подсчёта очнов Игрока 1
        int b;

        // В зависимости от выбранной темы переменной topic заносится соответствующее значение
        private void SetTopic()
        {
            if (radioTown.Checked)
            {
                topic = "town";
            }
            if (radioAnim.Checked)
            {
                topic = "animals";
            }
            if (radioColor.Checked)
            {
                topic = "color";
            }
        }

        // Проверка, существует ли слово в файле по выбранноё теме
        private bool CheckIfWordExistsInFile(string word)
        {
            string[] lines = File.ReadAllLines(topic + ".txt"); // Чтение всех строк из файла
            file = (topic + ".txt"); // Сохранение имени файла

            // Проверка наличия слова в файле
            foreach (string line in lines)
            {
                if (line.ToLower() == word.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        private void start_Click(object sender, EventArgs e)
        {
            SetTopic();
            label5.Text = "Тема: " + topic;
            radioAnim.Enabled = false;
            radioColor.Enabled = false;
            radioTown.Enabled = false;
            start.Enabled = false;
            ent.Enabled = true;
        }

        private void ent_Click(object sender, EventArgs e)
        {
            SetTopic(); // Устанавливает текущую тему
            if (player2.Enabled == false)
            {
                string wordToCheck = player1.Text; // получить введённое слово от Игрока 1
                bool wordExistsInFile = CheckIfWordExistsInFile(wordToCheck); // Проверка наличия слова в файле

                if (label2.Text == "") // Если до этого не вводилось слово, то первый игрок пишет слово на любую букву
                {
                    if (wordExistsInFile) // Если слово существует в файле
                    {
                        label2.Text = wordToCheck;
                        player2.Enabled = true;
                        player1.Enabled = false;
                        label4.Visible = false;
                        a++;
                    }
                    else
                    {
                        label3.Visible = true;
                        btnYes.Visible = true;
                        btnNo.Visible = true;
                    }
                }
                else
                {
                    // Если новое слово начинается на последнюю букву предыдущего слова
                    if (wordToCheck.StartsWith(label2.Text.Substring(label2.Text.Length - 1))) 
                    {
                        if (wordExistsInFile) // Если слово существует в файле
                        {
                            label2.Text = wordToCheck;
                            player2.Enabled = true;
                            player1.Enabled = false;
                            label4.Visible = false;
                            a++; // Счёт игрока 1
                        }
                        else
                        {
                            label3.Visible = true;
                            btnYes.Visible = true;
                            btnNo.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Слово должно начинаться на последнюю букву предыдущего");
                    }
                }
            }
            else if (player1.Enabled == false) // Если поле ввода для первого слова недоступно
            {
                string wordToCheck = player2.Text; // получить введённое слово от Игрока 2
                bool wordExistsInFile = CheckIfWordExistsInFile(wordToCheck); // Проверка наличия слова в файле

                // Если новое слово начинается на последнюю букву предыдущего слова
                if (wordToCheck.StartsWith(label2.Text.Substring(label2.Text.Length - 1)))
                {
                    if (wordExistsInFile) // Если слово существует в файле
                    {
                        label2.Text = wordToCheck;
                        player2.Enabled = false;
                        player1.Enabled = true;
                        label4.Visible = false;
                        b++; // Счёт игрока 1
                    }
                    else
                    {
                        label3.Visible = true;
                        btnYes.Visible = true;
                        btnNo.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Слово должно начинаться на последнюю букву предыдущего");
                }
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (player2.Enabled == false)
            {
                string wordToAdd = player1.Text; // получить введённое слово от Игрока 1
                File.AppendAllText(file, Environment.NewLine + wordToAdd); // Добавить слово в файл. Environment представляет сведения о текущей среде
                label2.Text = wordToAdd;
                label3.Visible = false;
                btnYes.Visible = false;
                btnNo.Visible = false;
                player2.Enabled = true;
                player1.Enabled = false;
            }
            else if (player1.Enabled == false)
            {
                string wordToAdd = player2.Text; // получить введённое слово от Игрока 2
                File.AppendAllText(file, Environment.NewLine + wordToAdd); // Добавить слово в файл
                label2.Text = wordToAdd;
                label3.Visible = false;
                btnYes.Visible = false;
                btnNo.Visible = false;
                player2.Enabled = false;
                player1.Enabled = true;
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if (player2.Enabled == false)
            {
                label3.Visible = false;
                btnYes.Visible = false;
                btnNo.Visible = false;
                label4.Visible = true;
            }
            else if (player1.Enabled == false)
            {
                label3.Visible = false;
                btnYes.Visible = false;
                btnNo.Visible = false;
                label4.Visible = true;
            }
        }

        private void end_Click(object sender, EventArgs e)
        {
            string message1 = "Игрок 1: \n" + a;
            string message2 = "Игрок 2: " + b;
            string message = message1 + message2;
            MessageBox.Show(message, "СЧЁТ");
            label5.Text = "Тема: ";
            radioAnim.Enabled = true;
            radioColor.Enabled = true;
            radioTown.Enabled = true;
            start.Enabled = true;
            ent.Enabled = false;
            player1.Enabled = true;
            player2.Enabled = false;
        }
        //double result = Math.Pow((8 + Math.Pow(Math.Abs(x - y), 2) + 1, 1.0 / 3.0) / (Math.Pow(x, 2) + Math.Pow(y, 2) + 2)) - (Math.Pow(Math.E, Math.Abs(x - y)) * Math.Pow(Math.Pow(Math.Tan(z), 2) + 1, x));
    }
}
