using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Подбор_регулирующего_клапана
{
    public partial class SecondForm : Form
    {
        private void ManualCalculate_Click(object sender, EventArgs e)
        {
            double pressBeforeValve, pressAfterValve, deltaPress, workingTemp, cons, manualDensity;
            pressBeforeValve = Convert.ToDouble(pressBefore.Text);
            pressAfterValve = Convert.ToDouble(pressAfter.Text);
            deltaPress = pressAfterValve - pressBeforeValve;
            workingTemp = Convert.ToDouble(temp.Text);
            cons = Convert.ToDouble(consumption.Text);
            manualDensity = Convert.ToDouble(density.Text);
            
            if (Environment.SelectedIndex == 0)
            {
                 resultKv.Text = (cons * Math.Sqrt(manualDensity / 1000 * deltaPress)).ToString();
            } 
            else if (Environment.SelectedIndex == 1)
            {
                if (deltaPress<= pressBeforeValve/2)
                {
                    resultKv.Text = Math.Round(cons/514 * Math.Sqrt((manualDensity * (workingTemp + 273)/deltaPress * pressAfterValve)),2).ToString();
                } else
                {
                    resultKv.Text = Math.Round(cons/(257 * pressBeforeValve) * Math.Sqrt(manualDensity * (workingTemp + 273)),2).ToString();
                }
            } else if (Environment.SelectedIndex == 2)
            {
                if (deltaPress <= pressBeforeValve / 2)
                {
                    resultKv.Text = Math.Round((cons / 461) * Math.Sqrt((workingTemp + 273)/(deltaPress * pressAfterValve)),2).ToString();
                } else
                {
                    resultKv.Text = Math.Round(cons/(230 * pressBeforeValve) * Math.Sqrt(workingTemp + 273),2).ToString();
                }
            }
        }
        public SecondForm()
        {
            InitializeComponent();
            Environment.SelectedIndex = 0;
        }
        private void Environment_TextChanged(object sender, EventArgs e)
        {
            switch (Environment.SelectedIndex)
            {
                case 0:
                    label5.Text = "Плотность при рабочих условиях";
                    label9.Text = "кг/м3";
                    label10.Text = "м3/ч";
                    break;
                case 1:
                    label5.Text = "Плотность при нормальных условиях";
                    label9.Text = "нм3/ч";
                    label10.Text = "м3/ч";
                    break;
                case 2:
                    label5.Text = "Плотность при рабочих условиях";
                    label9.Text = "кг/м3";
                    label10.Text = "т/ч";
                    break;
            }
        }
        private void BlockingInput(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 127 && number != 44) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }



    }
}
