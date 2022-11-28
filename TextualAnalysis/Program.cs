using System;
using System.Collections.Generic;

namespace TextualAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            var wc = TextualAnalysis.ComputeWordFrequencies("All, the    faith - he    had had    had     had no effect!!!!!??.");

            foreach(var keyValuePair in wc)
            {
                Console.WriteLine(keyValuePair.Key + " -> " + keyValuePair.Value);
            }

        }
    }
}
