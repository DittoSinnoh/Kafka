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

        int cost;

        private void button1_Click(object sender, EventArgs e)
        {
            string rey = $"{comboBox1.SelectedItem} - {comboBox2.SelectedItem}";
            reys.Text = rey;
            DateTime chosenDate = dateTimePicker1.Value;
            bool rev;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            comboType.Visible = true;
            comboVzr.Visible = true;
            comboKid.Visible = true;
            comboOld.Visible = true;
            checkBel.Visible = true;
            checkFood.Visible = true;
            checkBag.Visible = true;
            button2.Visible = true;
            if (chosenDate.Day % 2 == 0)
            {
                rev = true;
            }
            else
            {
                rev = false;
            }
            if (rey == "Москва - Санкт-Петербург")
            {
                label5.Text = "C620/C619 Москва - Санкт-Петербург";
                label6.Text = dateTimePicker1.Value.ToShortDateString();
                label9.Text = "14:20 (МСК)";
                cost = 1700;
                label11.Text = $"{cost.ToString()} руб";
            }
            else if (rey == "Москва - Екатеринбург")
            {
                label5.Text = "E110/E109 Москва - Екатеринбург";
                label6.Text = dateTimePicker1.Value.ToShortDateString();
                label9.Text = "08:55 (МСК)";
                cost = 3200;
                label11.Text = $"{cost.ToString()} руб";
            }
            else if (rev == true && rey == "Москва - Анапа")
            {
                label5.Text = "A55/A54 Москва - Анапа";
                label6.Text = dateTimePicker1.Value.ToShortDateString();
                label9.Text = "22:34 (МСК)";
                cost = 4480;
                label11.Text = $"{cost.ToString()} руб";
            }
            else if (rev == false && rey == "Анапа - Москва")
            {
                label5.Text = "A54/A55 Анапа - Москва";
                label6.Text = dateTimePicker1.Value.ToShortDateString();
                label9.Text = "10:34 (МСК)";
                cost = 4480;
                label11.Text = $"{cost.ToString()} руб";
            }
            else if (rev == false && rey == "Москва - Сочи")
            {
                label5.Text = "C865/C864 Москва - Сочи";
                label6.Text = dateTimePicker1.Value.ToShortDateString();
                label9.Text = "11:07 (МСК)";
                cost = 6840;
                label11.Text = $"{cost.ToString()} руб";
            }
            else if (rev == true && rey == "Сочи - Москва")
            {
                label5.Text = "C864/C865 Сочи - Москва";
                label6.Text = dateTimePicker1.Value.ToShortDateString();
                label9.Text = "20:11 (МСК)";
                cost = 6840;
                label11.Text = $"{cost.ToString()} руб";
            }
            else if (rey == "Екатеринбург - Москва")
            {
                label5.Text = "E109/E110 Екатеринбург - Москва";
                label6.Text = dateTimePicker1.Value.ToShortDateString();
                label9.Text = "22:36 (МСК)";
                cost = 3200;
                label11.Text = $"{cost.ToString()} руб";
            }
            else if (rev == true && rey == "Екатеринбург - Сочи")
            {
                label5.Text = "C430/C429 Екатеринбург - Сочи";
                label6.Text = dateTimePicker1.Value.ToShortDateString();
                label9.Text = "12:28 (МСК)";
                cost = 8970;
                label11.Text = $"{cost.ToString()} руб";
            }
            else if (rev == false && rey == "Сочи - Екатеринбург")
            {
                label5.Text = "С429/С430 Сочи - Екатеринбург";
                label6.Text = dateTimePicker1.Value.ToShortDateString();
                label9.Text = "15:53 (МСК)";
                cost = 8970;
                label11.Text = $"{cost.ToString()} руб";
            }
            else if (rev == false && rey == "Екатеринбург - Санкт-Петербург")
            {
                label5.Text = "C75/C74 Екатеринбург - Санкт-Петербург";
                label6.Text = dateTimePicker1.Value.ToShortDateString();
                label9.Text = "08:33 (МСК)";
                cost = 4840;
                label11.Text = $"{cost.ToString()} руб";
            }
            else if (rev == false && rey == "Санкт-Петербург - Екатеринбург")
            {
                label5.Text = "C74/C75 Санкт-Петербур - Екатеринбург";
                label6.Text = dateTimePicker1.Value.ToShortDateString();
                label9.Text = "11:47 (МСК)";
                cost = 4840;
                label11.Text = $"{cost.ToString()} руб";
            }
            else if (rey == "Санкт-Петербург - Москва")
            {
                label5.Text = "C619/C620 Санкт-Петербург - Москва";
                label6.Text = dateTimePicker1.Value.ToShortDateString();
                label9.Text = "18:45 (МСК)";
                cost = 1700;
                label11.Text = $"{cost.ToString()} руб";
            }
            else if (rev == false && rey == "Санкт-Петербург - Анапа")
            {
                label5.Text = "A155/A154 Санкт-Петербург - Анапа";
                label6.Text = dateTimePicker1.Value.ToShortDateString();
                label9.Text = "10:04 (МСК)";
                cost = 4717;
                label11.Text = $"{cost.ToString()} руб";
            }
            else if (rev == false && rey == "Анапа - Санкт-Петербург")
            {
                label5.Text = "A154/A155 Анапа - Санкт-Петербург";
                label6.Text = dateTimePicker1.Value.ToShortDateString();
                label9.Text = "21:28 (МСК)";
                cost = 4717;
                label11.Text = $"{cost.ToString()} руб";
            }
            else
            {
                reys.Text = "Ничего не найдено";
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                comboType.Visible = false;
                comboVzr.Visible = false;
                comboKid.Visible = false;
                comboOld.Visible = false;
                checkBel.Visible = false;
                checkFood.Visible = false;
                checkBag.Visible = false;
                button2.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            dateTimePicker2.Visible = true;   
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < DateTime.Today)
            {
                dateTimePicker1.Value = DateTime.Today;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime Date = dateTimePicker1.Value;
            DateTime minDate = Date.AddDays(2);
            if (dateTimePicker2.Value < minDate)
            {
                dateTimePicker2.Value = minDate;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboType.SelectedItem == null || comboKid.SelectedItem == null || comboVzr.SelectedItem == null || comboOld.SelectedItem == null)
            {
                MessageBox.Show("Вы заполнили не все поля!");
            }
            else
            {
                double costed;
                string type = comboType.SelectedItem.ToString();
                double sale;
                if (type == "Плацкарт")
                {
                    sale = cost;
                }
                else if (type == "Купе")
                {
                    sale = cost + cost * 0.3;
                }
                else if (type == "СВ")
                {
                    sale = cost + cost * 0.5;
                }
                else
                {
                    sale = cost * 0.5;
                }
                int vzr = Convert.ToInt32(comboVzr.SelectedItem);
                int kid = Convert.ToInt32(comboKid.SelectedItem);
                int old = Convert.ToInt32(comboOld.SelectedItem);
                double salevzr = vzr * (sale);
                double salekid = kid * (sale - sale * 0.05);
                double saleold = old * (sale - sale * 0.05);
                int kol = vzr + kid + old;
                int bel = 0;
                if (checkBel.Checked)
                {
                    bel = kol * 188;
                }
                double food = 0;
                if (checkFood.Checked)
                {
                    food = kol * (sale * 0.30);
                }
                double bag = 0;
                if (checkBag.Checked)
                {
                    bag = kol * (sale * 0.01);
                }
                costed = salevzr + salekid + saleold + bel + food + bag;
                string off = "нет";
                if (checkBox1.Checked)
                {
                    costed = costed * 2;
                    off = "да";
                }
                string end = $"Стоимость билета: {cost} \n" +
                    $"Билет туда-обратно: {off} \n" +
                    $"Тип вагона: {type} \n"+
                    $"Кол-во человек: {kol} \n" +
                    $"Взрослые: {vzr} чел. ({salevzr} руб.) \n" +
                    $"Дети: {kid} чел. ({salekid} руб.) \n" +
                    $"Пенсионеры: {old} чел. ({saleold} руб.) \n" +
                    $"Бельё: {bel} руб. \n" +
                    $"Еда: {food} руб. \n" +
                    $"Багаж: {bag} руб. \n" +
                    $"Итого к оплате: {costed.ToString()} руб. \n" +
                    $"\n" +
                    $"При посадке обязательно предъявляются \n" +
                    $"все соответствующие документы!";
                MessageBox.Show(end, "Итог");
            }
        }
    }
}
