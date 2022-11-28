using System;

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

        // TODO
        private static double computeAverage(int[] array)
        {
            return 0.0;
        }

        // TODO
        private static double? computeMode(int[] array)
        {
            return null;
        }
    }
}
