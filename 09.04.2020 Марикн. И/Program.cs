using System;

namespace _09._04._2020_Марикн._И
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] one = new byte[5];
            one[0] = 56;
            one[2] = 200;

            Console.WriteLine(one[2]);

            string[] two = new string[] { "Bob", "Jeb", "Iliya", "I" };

            Console.WriteLine(two[1]);

            short[,] nums = new short[5, 2];

            int[,] nubmers = 
            {
             { 13, 10, 235 },
             { 1, 300, 6},
             {7, 0, 82 }
            } ;

            nubmers[1, 1] = 500;

            Console.WriteLine(nubmers[1, 1]);

            int len = two.Length;
            Console.WriteLine(len);

            Console.WriteLine(two[1]);

            string[] copynew = new string[len];

            two.CopyTo(copynew, 0);

            Console.WriteLine(copynew[1]);

        }
    }
}