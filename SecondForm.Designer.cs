namespace Подбор_регулирующего_клапана
{
    partial class SecondForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecondForm));
            this.Environment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pressBefore = new System.Windows.Forms.TextBox();
            this.pressAfter = new System.Windows.Forms.TextBox();
            this.temp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.density = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.consumption = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ManualCalculate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.resultKv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Environment
            // 
            this.Environment.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.Environment.FormattingEnabled = true;
            this.Environment.Items.AddRange(new object[] {
            "Жидкость (L)",
            "Газ (G)",
            "Водяной пар (S)"});
            this.Environment.Location = new System.Drawing.Point(190, 9);
            this.Environment.Name = "Environment";
            this.Environment.Size = new System.Drawing.Size(161, 31);
            this.Environment.TabIndex = 0;
            this.Environment.TextChanged += new System.EventHandler(this.Environment_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Состояние среды";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "Рабочее давление перед клапаном";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 54);
            this.label3.TabIndex = 3;
            this.label3.Text = "Рабочее давление после клапана";
            // 
            // pressBefore
            // 
            this.pressBefore.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.pressBefore.Location = new System.Drawing.Point(190, 54);
            this.pressBefore.Name = "pressBefore";
            this.pressBefore.Size = new System.Drawing.Size(161, 29);
            this.pressBefore.TabIndex = 1;
            this.pressBefore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockingInput);
            // 
            // pressAfter
            // 
            this.pressAfter.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.pressAfter.Location = new System.Drawing.Point(190, 108);
            this.pressAfter.Name = "pressAfter";
            this.pressAfter.Size = new System.Drawing.Size(161, 29);
            this.pressAfter.TabIndex = 2;
            this.pressAfter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockingInput);
            // 
            // temp
            // 
            this.temp.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.temp.Location = new System.Drawing.Point(190, 218);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(161, 29);
            this.temp.TabIndex = 4;
            this.temp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockingInput);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.label4.Location = new System.Drawing.Point(12, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 54);
            this.label4.TabIndex = 6;
            this.label4.Text = "Рабочая температура";
            // 
            // density
            // 
            this.density.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.density.Location = new System.Drawing.Point(190, 272);
            this.density.Name = "density";
            this.density.Size = new System.Drawing.Size(161, 29);
            this.density.TabIndex = 5;
            this.density.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockingInput);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.label5.Location = new System.Drawing.Point(12, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 54);
            this.label5.TabIndex = 8;
            this.label5.Text = "Плотность при рабочих условиях";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.label6.Location = new System.Drawing.Point(357, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "МПа";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.label7.Location = new System.Drawing.Point(357, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "МПа";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.label8.Location = new System.Drawing.Point(357, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "°С";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.label9.Location = new System.Drawing.Point(357, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 29);
            this.label9.TabIndex = 13;
            this.label9.Text = "кг/мᶟ";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.label10.Location = new System.Drawing.Point(357, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 29);
            this.label10.TabIndex = 16;
            this.label10.Text = "м3/ч";
            // 
            // consumption
            // 
            this.consumption.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.consumption.Location = new System.Drawing.Point(190, 164);
            this.consumption.Name = "consumption";
            this.consumption.Size = new System.Drawing.Size(161, 29);
            this.consumption.TabIndex = 3;
            this.consumption.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockingInput);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.label11.Location = new System.Drawing.Point(12, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 54);
            this.label11.TabIndex = 14;
            this.label11.Text = "Максимальный расход";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(408, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 206);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // ManualCalculate
            // 
            this.ManualCalculate.BackColor = System.Drawing.Color.LightCyan;
            this.ManualCalculate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ManualCalculate.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.ManualCalculate.Location = new System.Drawing.Point(478, 252);
            this.ManualCalculate.Name = "ManualCalculate";
            this.ManualCalculate.Size = new System.Drawing.Size(139, 40);
            this.ManualCalculate.TabIndex = 6;
            this.ManualCalculate.Text = "Рассчитать";
            this.ManualCalculate.UseVisualStyleBackColor = false;
            this.ManualCalculate.Click += new System.EventHandler(this.ManualCalculate_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.label12.Location = new System.Drawing.Point(12, 315);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(263, 33);
            this.label12.TabIndex = 19;
            this.label12.Text = "Результат рассчета:  Kv =";
            // 
            // resultKv
            // 
            this.resultKv.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.resultKv.Location = new System.Drawing.Point(207, 315);
            this.resultKv.Name = "resultKv";
            this.resultKv.Size = new System.Drawing.Size(77, 33);
            this.resultKv.TabIndex = 20;
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(702, 349);
            this.Controls.Add(this.resultKv);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ManualCalculate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.consumption);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.density);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pressAfter);
            this.Controls.Add(this.pressBefore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Environment);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SecondForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ручной рассчет пропускной способности клапана";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Environment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pressBefore;
        private System.Windows.Forms.TextBox pressAfter;
        private System.Windows.Forms.TextBox temp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox density;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox consumption;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ManualCalculate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label resultKv;
    }
}