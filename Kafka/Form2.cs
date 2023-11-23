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
    public partial class Lab6_2 : Form
    {
        public Lab6_2()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int counter = 0; // Количество слагаемых
            double sum = 0; // Сумма
            double summand = 0.0; // Слагаемые
            double x;
            double precision;
            bool f = false;
            if (double.TryParse(txtPrecision.Text, out precision))
            {
                f = true;
            }
            do
            {
                counter++;
                if (double.TryParse(txtX.Text, out x))
                {
                    summand = double.Parse(txtX.Text) / counter;
                }
                sum += summand;
            }
            while (f && Math.Abs(summand) > precision);
            lblResult.Text = "сумма = " + sum + ", количество = " + counter;
            if (f)
            {
                lblResult.Text = "сумма = " + sum + ", количество = " + counter;
            }
            else
            {
                MessageBox.Show("Введите числовое значение!");
            }
        }
    }
}
