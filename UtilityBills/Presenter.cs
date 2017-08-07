using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityBills
{
    class Presenter
    {
        CalculateBill calculate;
        MainWindow mainWindow;
        public Presenter(MainWindow main)
        {
            calculate = new CalculateBill();
            mainWindow = main;
            calculate.counterEnergyLast = Convert.ToInt32(mainWindow.counterEnergyLast);
            calculate.counterEnergyNow = Convert.ToInt32(mainWindow.counterEnergyNow);
            calculate.counterWaterLast = Convert.ToInt32(mainWindow.counterWaterLast);
        }
    }
}
