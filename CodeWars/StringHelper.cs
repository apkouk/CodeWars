using System;
using System.Collections;
using System.Linq;
namespace CodeWarsUT
{
    public class StringHelper
    {
        //KATA Shortest Word
        public static int FindShortestWordIn(string phrase)
        {
            return phrase.Split(' ').Min(x => x.Length);
        }

        public static string[] WhichAreIn(string[] array1, string[] array2)
        {
            SortedList sortedList = new SortedList();
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array2[j].Contains(array1[i]))
                    {
                        if (!sortedList.ContainsKey(array1[i]))
                            sortedList.Add(array1[i], j);
                    }
                }
            }

            string[] result = new string[sortedList.Count];

            int count = 0;
            foreach (var item in sortedList.Keys)
            {
                result[count] = item.ToString();
                count++;
            }
            return result;

            //BEST FROM CODEWARS
            //return array1.Distinct()
            //                 .Where(s1 => array2.Any(s2 => s2.Contains(s1)))
            //                 .OrderBy(s => s)
            //                 .ToArray();

        }
    }
}