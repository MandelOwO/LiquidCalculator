using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquidCalculator
{
    public class Calculator
    {
        public DataStorage Data { get; set; } = new DataStorage();
        private double totalVolume;
        private double baseConcentration;
        private double shotConcentration;
        private double strength;


        public double Calculate()
        {
            GetValues();
            double result = Calculation();
            return result;

        }

        public void GetValues()
        {
            totalVolume = Data.TotalVolume;
            baseConcentration = Data.BaseConcentration;
            shotConcentration = Data.ShotConcentration;
            strength = Data.Strength;
        }

        public double Calculation()
        {
            double baseVolume = ((strength / 100 * totalVolume) - (shotConcentration / 100 * totalVolume)) / (baseConcentration / 100 - shotConcentration / 100);
            double result = Math.Round(totalVolume - baseVolume, 1);
            return result;
        }
    }
}
