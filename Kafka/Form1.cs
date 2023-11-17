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
            file1.Filter = "(*.jng)|*.jpg";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            // Создаём перпеменнную, которая используется
            // для сохранения имени файла и загрузки файла в элемент PictureBox
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
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.jng)|*.jpg";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName == "")
            {
                string filename = saveFileDialog.FileName;
                string extension = Path.GetExtension(filename);
                switch(extension)
                {
                    case ".jpg":
                        pct.Image.Save(filename, ImageFormat.Jpeg);
                        break;
                }
            }
        }
    }
}
