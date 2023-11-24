using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // Добавляем фильтр, чтобы открывать изображения только в формате .jpg.
            file1.Filter = "(*.jpg)|*.jpg";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            // Создаём перпеменнную, которая используется
            // для сохранения имени файла и загрузки файла в элемент PictureBox.
            string fname;
            file1.ShowDialog();
            fname = file1.FileName;
            pct.Image = Image.FromFile(fname);
            textBox1.Text = fname;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // Открывается диалоговое окто для сохранения файла
            // и задаётся фильтр формата.
            saveFile.Filter = "(*.jpg)|*.jpg";
            saveFile.ShowDialog();
            if (textBox1.Text != "")
            {
                if (saveFile.FileName != "")
                {
                    // System.IO импользуется для создания файла и записи в него двнных.
                    // FileStream получает поток данных для записи в файл.
                    // Конкретно тут происходит открытие потока fs.
                    System.IO.FileStream fs = (System.IO.FileStream)saveFile.OpenFile();
                    // Эта строка отвечает за сохранение изображения в формате .png.
                    pct.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                    // Закрывает поток.
                    fs.Close();
                }
            }
            else
            {
                MessageBox.Show("Изображение отсутствует!");
            }
        }

        private void clean_Click(object sender, EventArgs e)
        {
            pct.Image = null;
            textBox1.Text = null;
        }
    }
}
