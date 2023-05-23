using System;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace Подбор_регулирующего_клапана
{
    public partial class FirstForm : Form
    {
        double pressBeforeValve, pressAfterValve, deltaPress, workingTemp, waterCons, gasCons, waterVaporCons, waterDensity, gasDensity;

        private void ManualEntry_Click(object sender, EventArgs e)
        {
            SecondForm ManualEntryForm = new SecondForm();
            ManualEntryForm.ShowDialog();
        }

        public FirstForm()
        {
            InitializeComponent();
        }
        void Calculatoin_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook excelAppWorkbook;
            Excel.Worksheet excelWorksheet, currentWorksheet;
            Excel.Sheets excelSheets;
            excelApp.Visible = false;
            OpenFileDialog connectionString = new OpenFileDialog
            {
                InitialDirectory = @"% USERPROFILE %\Desktop", //C:\Users\KrasilnikovAV\Desktop
                Title = "Выберите ваш ОЛ-51",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "xlsm",
                Filter = "Office files (*.xlsx)|*.xlsm",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            connectionString.ShowDialog();
            Link.Text = connectionString.FileName;
            excelAppWorkbook = excelApp.Workbooks.Open(connectionString.FileName);
            excelSheets = excelAppWorkbook.Worksheets;
            excelWorksheet = excelSheets.get_Item("Перечень позиций");

            int startPoint = excelWorksheet.Index + 1;
            int count = 0;
            for (int i = startPoint; i <= excelSheets.Count; i++)
            {
                currentWorksheet = excelSheets.get_Item(i);
                pressBeforeValve = Convert.ToDouble(currentWorksheet.Cells[10, 21].Value); // Рабочее давление перед клапаном
                pressAfterValve = Convert.ToDouble(currentWorksheet.Cells[11, 21].Value); // Рабочее давление после клапана
                deltaPress = pressAfterValve - pressBeforeValve;
                workingTemp = Convert.ToDouble(currentWorksheet.Cells[14, 21].Value); // Рабочая температура

                if (currentWorksheet.Cells[8, 21].Value == "L") // Жидкость
                {
                    waterCons = Convert.ToDouble(currentWorksheet.Cells[15, 32].Value); // Расход максимальный
                    waterDensity = Convert.ToDouble(currentWorksheet.Cells[20, 21].Value); // Плотность жидкости
                    currentWorksheet.Cells[26, 21].Value = Math.Round(waterCons * (Math.Sqrt(waterDensity / 1000 * deltaPress)),3); // рассчет Kv 
                }
                else if (currentWorksheet.Cells[8, 21].Value == "G") // Газы
                {
                    gasCons = Convert.ToDouble(currentWorksheet.Cells[15, 32].Value); // Расход максимальный
                    gasDensity = Convert.ToDouble(currentWorksheet.Cells[20, 21].Value); //  Плотность газов при Н.У.
                    if (deltaPress <= (pressBeforeValve / 2))
                    {
                        currentWorksheet.Cells[26, 21].Value = Math.Round(gasCons / 514 * Math.Sqrt(gasDensity * (workingTemp + 273) / deltaPress * pressAfterValve),3); // рассчет Kv 
                    }
                    else
                    {
                        currentWorksheet.Cells[26, 21].Value = Math.Round(gasCons / (257 * pressBeforeValve) * Math.Sqrt(gasDensity * (workingTemp + 273)),3); // рассчет Kv 
                    }
                }
                else if (currentWorksheet.Cells[8, 21].Value == "S") // Водяной пар
                {
                    waterVaporCons = Convert.ToDouble(currentWorksheet.Cells[20, 21].Value); // Расход максимальный
                    if (deltaPress <= (pressBeforeValve / 2))
                    {
                        currentWorksheet.Cells[26, 21].Value = Math.Round(waterVaporCons / 461 * Math.Sqrt((workingTemp + 273) / deltaPress * pressAfterValve),3);
                    }
                    else
                    {
                        currentWorksheet.Cells[26, 21].Value = Math.Round(waterVaporCons / (230 * pressBeforeValve) * Math.Sqrt(workingTemp + 273));
                    }
                }
                count++;
                }
                excelAppWorkbook.Close(true);
                excelApp.Quit();
                MessageBox.Show($"Выполнен рассчет Kv для {count} регулирующих клапанов");
        }
    }
}
