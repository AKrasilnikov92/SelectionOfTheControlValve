namespace Подбор_регулирующего_клапана
{
    partial class FirstForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstForm));
            this.AutoCalculation = new System.Windows.Forms.Button();
            this.ManualEntry = new System.Windows.Forms.Button();
            this.FileAdress = new System.Windows.Forms.Label();
            this.Link = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AutoCalculation
            // 
            this.AutoCalculation.BackColor = System.Drawing.Color.LemonChiffon;
            this.AutoCalculation.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoCalculation.Location = new System.Drawing.Point(12, 12);
            this.AutoCalculation.Name = "AutoCalculation";
            this.AutoCalculation.Size = new System.Drawing.Size(154, 62);
            this.AutoCalculation.TabIndex = 0;
            this.AutoCalculation.Text = "Рассчет значения Kv из файла";
            this.AutoCalculation.UseVisualStyleBackColor = false;
            this.AutoCalculation.Click += new System.EventHandler(this.Calculatoin_Click);
            // 
            // ManualEntry
            // 
            this.ManualEntry.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ManualEntry.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.ManualEntry.Location = new System.Drawing.Point(181, 12);
            this.ManualEntry.Name = "ManualEntry";
            this.ManualEntry.Size = new System.Drawing.Size(155, 62);
            this.ManualEntry.TabIndex = 1;
            this.ManualEntry.Text = "Ручной ввод параметров Kv";
            this.ManualEntry.UseVisualStyleBackColor = false;
            this.ManualEntry.Click += new System.EventHandler(this.ManualEntry_Click);
            // 
            // FileAdress
            // 
            this.FileAdress.AutoSize = true;
            this.FileAdress.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.FileAdress.Location = new System.Drawing.Point(12, 77);
            this.FileAdress.Name = "FileAdress";
            this.FileAdress.Size = new System.Drawing.Size(112, 23);
            this.FileAdress.TabIndex = 2;
            this.FileAdress.Text = "Адрес файла:";
            // 
            // Link
            // 
            this.Link.AutoSize = true;
            this.Link.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.Link.Location = new System.Drawing.Point(12, 100);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(0, 23);
            this.Link.TabIndex = 3;
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(348, 128);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.FileAdress);
            this.Controls.Add(this.ManualEntry);
            this.Controls.Add(this.AutoCalculation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirstForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подбор регулирующего клапана";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AutoCalculation;
        private System.Windows.Forms.Button ManualEntry;
        private System.Windows.Forms.Label FileAdress;
        private System.Windows.Forms.Label Link;
    }
}

