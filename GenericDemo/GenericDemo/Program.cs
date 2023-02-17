using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
            char[] charArray = { 'a', 'b', 'c', 'd', 'e' };
            //Normal Generic   // We can call direct Class name 
            NormalGeneric.IntNum(intArray);
            NormalGeneric.IntNum(doubleArray);
            NormalGeneric.IntNum(charArray);
            Console.WriteLine("-------------------------");

        }
    }
}
