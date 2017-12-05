using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Classes.WeightSort
{
    public class Weight
    {
        public Weight(string originalWeight)
        {
            OriginalWeight = originalWeight;
            SumDigitsWeight = SumWeightDigits(originalWeight);
        }

        private int SumWeightDigits(string originalWeight)
        {
            int totalSum = 0;
            for (int i = 0; i < originalWeight.Length; i++)
            {
                int number = Convert.ToInt32(originalWeight[i].ToString());
                totalSum += number;
            }
            return totalSum;
        }

        public string OriginalWeight { get; set; }
        public int SumDigitsWeight { get; set; }
    }
}
