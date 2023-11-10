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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Участок кода для добавления введённого в поле txtName имени в список lstNames.
            if (!string.IsNullOrWhiteSpace(txtName.Text) // Эта часть отвечает за то, чтобы поле
                                                         // не было пустое или не содержало в себе только пробелы.
                && !lstNames.Items.Contains(txtName.Text))
                lstNames.Items.Add(txtName.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверка, является ли нажатая клавиша цифрой от 0 до 9.
            if (e.KeyChar >= 48 && e.KeyChar <= 57) 
            {
                // Выводится сообщение о том, какая клавиша была нажата.
                MessageBox.Show($"Form.KeyPress: ‘{e.KeyChar}' pressed."); // 'нажатый'

                switch (e.KeyChar) // переключение по нажатой клавише.
                { 
                    case (char)49: // 1 в Unicode
                    case (char)52: // 4
                    case (char)55: // 7
                        MessageBox.Show($"Form.KeyPress: ‘{e.KeyChar}' consumed."); // 'употребляемый'
                        e.Handled = true; // Дальнейшая обработка этой клавиши прекращается.
                        break;
                } 
            }
        }
        private void Button1_MouseEnter(object sender, EventArgs e) 
        {
            Cursor.Hide(); // При наведении на кнопку курсор исчезает.
        }
        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show(); // При уведении с кнопки курсор появляется.
        }
        private void Button1_Click(object sender, EventArgs e)  
        {
            // При нажатии на кнопку курсор перемещается на место
            // второй кнопки, а текст нажатой кнопки сменится на "Print".
            Cursor.Position = PointToScreen(button2.Location);
            button1.Text = "&Print";
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            // Короче, тут просто наоботор с перемещением - со второй на первую.
            // А при наведении на вторую кнопку курсор меняется на руку.
            Cursor.Position = PointToScreen(button1.Location);
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
            button2.Text = "Print && Close"; // При нажатии на кнопку текст изменится.
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // При нажатии текст метки изменится. Так же меняется индекс,
            // который определяет порядок фокусировки при нажатии клавиши Tab -
            // теперь сначала фокус будет на метке, а потом на кнопке.
            label1.Text = "&Print";
            label1.TabIndex = 9;
            button1.TabIndex = 10;
        }
    }
}
