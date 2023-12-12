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
            this.radioTown = new System.Windows.Forms.RadioButton();
            this.radioAnim = new System.Windows.Forms.RadioButton();
            this.radioColor = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.TextBox();
            this.player1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ent = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // radioTown
            // 
            this.radioTown.AutoSize = true;
            this.radioTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioTown.Location = new System.Drawing.Point(12, 37);
            this.radioTown.Name = "radioTown";
            this.radioTown.Size = new System.Drawing.Size(72, 20);
            this.radioTown.TabIndex = 0;
            this.radioTown.TabStop = true;
            this.radioTown.Text = "Города";
            this.radioTown.UseVisualStyleBackColor = true;
            // 
            // radioAnim
            // 
            this.radioAnim.AutoSize = true;
            this.radioAnim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioAnim.Location = new System.Drawing.Point(90, 37);
            this.radioAnim.Name = "radioAnim";
            this.radioAnim.Size = new System.Drawing.Size(94, 20);
            this.radioAnim.TabIndex = 1;
            this.radioAnim.TabStop = true;
            this.radioAnim.Text = "Животные";
            this.radioAnim.UseVisualStyleBackColor = true;
            // 
            // radioColor
            // 
            this.radioColor.AutoSize = true;
            this.radioColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioColor.Location = new System.Drawing.Point(194, 37);
            this.radioColor.Name = "radioColor";
            this.radioColor.Size = new System.Drawing.Size(65, 20);
            this.radioColor.TabIndex = 2;
            this.radioColor.TabStop = true;
            this.radioColor.Text = "Цвета";
            this.radioColor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите тему";
            // 
            // player2
            // 
            this.player2.Enabled = false;
            this.player2.Location = new System.Drawing.Point(12, 171);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(172, 20);
            this.player2.TabIndex = 4;
            // 
            // player1
            // 
            this.player1.Location = new System.Drawing.Point(12, 96);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(172, 20);
            this.player1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // ent
            // 
            this.ent.Enabled = false;
            this.ent.Location = new System.Drawing.Point(184, 129);
            this.ent.Name = "ent";
            this.ent.Size = new System.Drawing.Size(75, 23);
            this.ent.TabIndex = 7;
            this.ent.Text = "Ответить";
            this.ent.UseVisualStyleBackColor = true;
            this.ent.Click += new System.EventHandler(this.ent_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(265, 37);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 8;
            this.start.Text = "Выбрать";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Вы правильно указали слово?";
            this.label3.Visible = false;
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(9, 228);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(47, 23);
            this.btnYes.TabIndex = 10;
            this.btnYes.Text = "Да";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Visible = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(62, 228);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(47, 23);
            this.btnNo.TabIndex = 11;
            this.btnNo.Text = "Нет";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Visible = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Введите правильное слово";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Тема: ";
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(72, 257);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(134, 23);
            this.end.TabIndex = 14;
            this.end.Text = "Закончить игру";
            this.end.UseVisualStyleBackColor = true;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(366, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Правила \"Игры в слова\"";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "1) Выберите одну из трёх представленных";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "тем;";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(367, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "2) Нажмите кнопку \"Выбрать\";";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(367, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "3) Игрок 1 первым вводит слово по";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(367, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "выбранной теме;";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(367, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(205, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "4) Второй игрок вводит слово, которое";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(367, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(182, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "которое было названо Игроком 1;";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(367, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "кнопку \"Закончить игру\".";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(367, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(208, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "начинается на последнюю букву слова,";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(367, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(181, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "5) Для завершения игры нажмите";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(362, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 192);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 289);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.end);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.start);
            this.Controls.Add(this.ent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioColor);
            this.Controls.Add(this.radioAnim);
            this.Controls.Add(this.radioTown);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioTown;
        private System.Windows.Forms.RadioButton radioAnim;
        private System.Windows.Forms.RadioButton radioColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox player2;
        private System.Windows.Forms.TextBox player1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ent;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button end;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

