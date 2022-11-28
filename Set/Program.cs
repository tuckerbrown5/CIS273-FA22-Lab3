using System;

namespace Set
{
    class Program
    {
        static void Main(string[] args)
        {
            Set<int> set = new Set<int>();

            set.Add(1);
            set.Add(2);
            set.Add(3);


            foreach(var i in set)
            {
                Console.WriteLine(i);
            }
        }
    }
}
