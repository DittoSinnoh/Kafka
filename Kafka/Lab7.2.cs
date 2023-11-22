using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafka
{
    public partial class Lab7 : Form
    {
        public Lab7()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // В список добавляется введённая строка из txt.
            // После ввода поле очищается.
            lst.Items.Add(txt.Text);
            txt.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Путь, введённый в поле, присвается переменной.
            string fileName = txtFileName.Text;
            // Если файл в ведённом пути уже
            // сущесвует, то он удаляется.
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (FileStream fs = File.Create(fileName, 1024)) // Класс для работы с файлами.
                                                                // Создаёт файл с указанным именем.
                                                                // 1024 - размер буфера.
            using (BinaryWriter bw = new BinaryWriter(fs)) // Файл для работы с данными в двоичном виде
            {
                for (var i = 0; i < lst.Items.Count; i++) // Пока не конец списка
                {
                    bw.Write(lst.Items[i].ToString()); // Записывает в файл каждый пункт.
                }
                // Закрывает все потоки.
                bw.Close();
                fs.Close();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text;
            lstFromfile.Items.Clear(); // Список очищается.
            using (FileStream fs = new FileStream(fileName, FileMode.Open)) // Открывает файл
            using (BinaryReader br = new BinaryReader(fs))
            {
                // PeekChar возвращает следующий прочитанный символ.
                // Если символов нет - возвращается -1
                while (br.PeekChar() != -1)
                {
                    // Добавляем в список прочитанную строку
                    lstFromfile.Items.Add(br.ReadString());
                }
                // Закрыть потоки
                br.Close();
                fs.Close();
            }
        }
    }
}
