using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityBills
{
    class Presenter
    {
        System.Windows.Threading.DispatcherTimer timer;
        CalculateBill calculate;
        MainWindow mainWindow;
        public Presenter(MainWindow main)
        {
            timer = new System.Windows.Threading.DispatcherTimer();
            InitTimer();
            timer.Tick += Timer_Tick;
            calculate = new CalculateBill();
            mainWindow = main;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            InitializeCalculateBillValues();
            InitDifference();
            InitCost();
            TotalCost();
        }

        void InitializeCalculateBillValues()
        {
            calculate.counterEnergyLast = Convert.ToInt32(mainWindow.counterEnergyLast.Text);
            calculate.counterEnergyNow = Convert.ToInt32(mainWindow.counterEnergyNow.Text);
            calculate.counterWaterLast = Convert.ToInt32(mainWindow.counterWaterLast.Text);
            calculate.counterWaterNow = Convert.ToInt32(mainWindow.counterWaterNow.Text);
            calculate.counterSewageLast = Convert.ToInt32(mainWindow.counterWaterLast.Text);
            calculate.counterSewageNow = Convert.ToInt32(mainWindow.counterWaterNow.Text);
            calculate.counterGasLast = Convert.ToInt32(mainWindow.couterGasLast.Text);
            calculate.counterGasNow = Convert.ToInt32(mainWindow.counterGasNow.Text);
            calculate.tariffEnergyNorm = Convert.ToDouble(mainWindow.tariffEnergyNorm.Content);
            calculate.tariffEnergyOverNorm = Convert.ToDouble(mainWindow.tariffEnergyOverNorm.Content);
            calculate.tariffWaterNorm = Convert.ToDouble(mainWindow.tariffWaterNorm.Content);
            calculate.tariffSewage = Convert.ToDouble(mainWindow.tariffSewage.Content);
            calculate.tariffGas = Convert.ToDouble(mainWindow.tariffGas.Content);
        }

        void InitDifference()
        {
            calculate.DiffEnergy();
            calculate.DiffWater();
            calculate.DiffSewage();
            calculate.DiffGas();
            mainWindow.differenceEnergy.Content = calculate.differenceEnergy.ToString();
            mainWindow.differenceWater.Content = calculate.differenceWater.ToString();
            mainWindow.differenceGas.Content = calculate.differenceGas.ToString();
        }

        void InitCost()
        {
            mainWindow.costEnergy.Content = calculate.EnergyBill().ToString();
            mainWindow.costWater.Content = calculate.WaterBill().ToString();
            mainWindow.costSewage.Content = calculate.SewageBill().ToString();
            mainWindow.costGas.Content = calculate.GasBill().ToString();
        }

        void TotalCost()
        {
            mainWindow.totalBill.Content = (calculate.energyBill + calculate.waterBill + calculate.sewageBill + calculate.gasBill).ToString();
        }

        void InitTimer()
        {
            timer.IsEnabled = true;
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }


    }
}
