namespace Kafka
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.garch = new System.Windows.Forms.PictureBox();
            this.ditto = new System.Windows.Forms.PictureBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ditto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.LocationChanged += new System.EventHandler(this.pictureBox1_LocationChanged_1);
            // 
            // garch
            // 
            this.garch.Image = ((System.Drawing.Image)(resources.GetObject("garch.Image")));
            this.garch.Location = new System.Drawing.Point(10, 100);
            this.garch.Name = "garch";
            this.garch.Size = new System.Drawing.Size(185, 178);
            this.garch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.garch.TabIndex = 1;
            this.garch.TabStop = false;
            this.garch.Visible = false;
            this.garch.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ditto
            // 
            this.ditto.Image = ((System.Drawing.Image)(resources.GetObject("ditto.Image")));
            this.ditto.Location = new System.Drawing.Point(270, 10);
            this.ditto.Name = "ditto";
            this.ditto.Size = new System.Drawing.Size(155, 149);
            this.ditto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ditto.TabIndex = 2;
            this.ditto.TabStop = false;
            this.ditto.Visible = false;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(134, 100);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(193, 63);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "Начать";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Visible = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2.Location = new System.Drawing.Point(270, 208);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(116, 32);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "Атака";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(445, 293);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.ditto);
            this.Controls.Add(this.garch);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Pokemon Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ditto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox garch;
        private System.Windows.Forms.PictureBox ditto;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
    }
}

