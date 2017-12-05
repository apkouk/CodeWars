using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Classes.WeightSort
{
    public class WeightSorter
    {
        public WeightSorter(string originalWeights)
        {
            OriginalWeights = originalWeights;
            weigths = CreateWeights(originalWeights);
            SortedWeights = SortWeightd(weigths);
        }

        private string SortWeightd(SortedList<int, string> weigths)
        {
            string result = string.Empty;
            foreach (var weight in weigths)
            {
                result += Convert.ToString(weight.Value) + " ";
            }
            return result.TrimEnd(' ');
        }

        private SortedList<int, string> CreateWeights(string originalWeights)
        {
            SortedList<int, string> tempList = new SortedList<int, string>();
            string[] weightsSplitted = originalWeights.Split(' ');

            for (int i = 0; i < weightsSplitted.Length; i++)
            {
                Weight weight = new Weight(weightsSplitted[i]);

                if(!tempList.ContainsKey(weight.SumDigitsWeight))
                {
                    tempList.Add(weight.SumDigitsWeight, weight.OriginalWeight);
                }
                else
                {
                    duplicates.Add(weight);
                }                                
            }
            return tempList;
        }
        public ArrayList duplicates =new ArrayList();
        public SortedList<int, string> weigths;
        public string OriginalWeights { get; set; }
        public int SumOfItsDigits { get; set; }
        public string SortedWeights { get; set; }

    }
}
