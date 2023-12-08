namespace Kafka
{
    partial class Lab6_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtPrecision = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.labels = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(15, 227);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Вычислить";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(226, 111);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 1;
            // 
            // txtPrecision
            // 
            this.txtPrecision.Location = new System.Drawing.Point(39, 111);
            this.txtPrecision.Name = "txtPrecision";
            this.txtPrecision.Size = new System.Drawing.Size(100, 20);
            this.txtPrecision.TabIndex = 2;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 175);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "label1";
            // 
            // labels
            // 
            this.labels.AutoSize = true;
            this.labels.Location = new System.Drawing.Point(12, 48);
            this.labels.Name = "labels";
            this.labels.Size = new System.Drawing.Size(114, 13);
            this.labels.TabIndex = 4;
            this.labels.Text = "x + x/2 + x/3 + x/4 +...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "x =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Точность =";
            // 
            // Lab6_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 311);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labels);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtPrecision);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.btnCalc);
            this.Name = "Lab6_2";
            this.Text = "Cумма ряда";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtPrecision;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label labels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}