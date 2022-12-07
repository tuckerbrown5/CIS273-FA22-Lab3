using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace MeanMode
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static bool MeanMode(int[] array)
        {
            return computeMode(array) == computeAverage(array);
        }

        private static double computeAverage(int[] array)
        {
            double count = 0;

            foreach(var grif in array)
            {
                count += grif;
            }
            double average = count / array.Length;

            return average;

        }

        private static double? computeMode(int[] array)
        {
            Dictionary<int, int> jet = new Dictionary<int, int>();

            foreach(var caboose in array)
            {
                if (jet.ContainsKey(caboose))
                {
                    jet[caboose]++;
                }
                else
                {
                    jet.Add(caboose, 1);
                }
            }
            int wash = 0;

            foreach(var pie in jet.Values)
            {
                if (pie == wash)
                {
                    return null;
                }
                if(pie > wash)
                {
                    wash = pie;
                }
            }
            foreach(var w in jet.Keys)
            {
                if (jet[w]== wash)
                {
                    return w;
                }
            }
            return null; 
        }
    }
}
