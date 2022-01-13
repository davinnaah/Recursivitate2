using System;

namespace Recursivitate2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[] { 5, 6, 7, 8, 9 };
            Console.WriteLine(recursiv.Maxim(vector, vector.Length - 1, int.MinValue));
        }
    }
}
