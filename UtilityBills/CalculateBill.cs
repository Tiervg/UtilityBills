using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UtilityBills
{
    class CalculateBill
    {
        const int constEnergyNorm = 100;
        public int counterEnergyLast, counterEnergyNow, counterWaterLast, counterWaterNow, counterSewageLast, 
            counterSewageNow, counterGasLast, counterGasNow,differenceEnergy, differenceWater, differenceSewage, differenceGas;

        public double tariffEnergyNorm, tariffEnergyOverNorm, tariffWaterNorm, tariffSewage, tariffGas,energyBill,waterBill,sewageBill,gasBill;


        /// <summary>
        /// calculate energy diffrence 
        /// </summary>
        /// <returns>int</returns>
        public int DiffEnergy()
        {
            return differenceEnergy = counterEnergyNow - counterEnergyLast;
        }

        /// <summary>
        /// calculate water diffenrence
        /// </summary>
        /// <returns></returns>
        public int DiffWater()
        {
            return differenceWater = counterWaterNow - counterWaterLast;
        }

        /// <summary>
        /// calculate sewage difference
        /// </summary>
        /// <returns></returns>
        public int DiffSewage()
        {
            return differenceSewage = counterSewageNow - counterSewageLast;
        }

        /// <summary>
        /// calculate gas difference
        /// </summary>
        /// <returns></returns>
        public int DiffGas()
        {
            return differenceGas = counterGasNow - counterGasLast;
        }

        /// <summary>
        /// calculate energy bill
        /// </summary>
        /// <returns></returns>
        public double EnergyBill()
        {
            if (differenceEnergy <= 100)
            {
                energyBill = differenceEnergy * tariffEnergyNorm;
            }
            else
            {
                int diffEnergyOverNorm = differenceEnergy - constEnergyNorm;
                energyBill = constEnergyNorm * tariffEnergyNorm + diffEnergyOverNorm * tariffEnergyOverNorm; 
            }
            return energyBill;
        }

        public double WaterBill()
        {
            return waterBill = differenceWater * tariffWaterNorm;
        }

        public double SewageBill()
        {
            return sewageBill = differenceSewage * tariffSewage;
        }

        public double GasBill()
        {
            return gasBill = differenceGas * tariffGas;
        }


    }
}
