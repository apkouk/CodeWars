using CodeWars.Classes.WeightSort;
using System.Collections.Generic;

namespace CodeWars
{
    public class WeightSort
    {
        public static string orderWeight(string original)
        {
            WeightSorter weightSorter = new WeightSorter(original);
            return weightSorter.SortedWeights;
        }
    }
}
