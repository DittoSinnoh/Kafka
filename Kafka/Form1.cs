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
        int x = 100;
        int y = 100;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            //PictureBox player = new PictureBox();
            //player.Image = Properties.Resources.arrow;
            pictureBox1.Location = new System.Drawing.Point(x, y);
            this.Controls.Add(pictureBox1);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    y -= 10;
                    break;
                case Keys.Down:
                    y += 10; 
                    break;
                case Keys.Left:
                    x -= 10;
                    break;
                case Keys.Right: 
                    x += 10;
                    break;
            }
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox)
                {
                    control.Location = new System.Drawing.Point(x, y);
                }
            }
        }

        private void pictureBox1_LocationChanged_1(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X == 90 && pictureBox1.Location.Y == 100)
            {
                this.BackgroundImage = null;
                pictureBox1.Visible = false;
                garch.Visible = true;
                ditto.Visible = true;
                btn1.Visible = true;
                garch.Location = new System.Drawing.Point(10, 100);
                ditto.Location = new System.Drawing.Point(270, 10);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
