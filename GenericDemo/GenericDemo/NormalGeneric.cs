using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class NormalGeneric
    {
        public static void IntNum(int[] array)
        {
            foreach(var num in array)
            {
                Console.WriteLine(num);
            }
        }
        public static void IntNum(double[] array)
        {
            foreach(double num in array)
            {
                Console.WriteLine(num);
            }
        }
        public static void IntNum(char[] array)
        {
            foreach (char num in array)
            {
                Console.WriteLine(num);
            }
        }
    }
}
