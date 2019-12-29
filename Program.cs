using System;
using System.Collections.Generic;
using System.Linq;

namespace TallOrShort
{
    public class Program
    {
        static void Main(string[] args)
        {
            var heightArray = new List<double> { 5.5, 6, 6.6, 4.5, 5, 3.0, 2.5, 2.9 };
            Console.WriteLine($"Count of Tallest People: {FindTall(heightArray)}");
            Console.WriteLine($"Count of Shortest People: {FindShort(heightArray)}");
            Console.ReadLine();
        }
        
        /// <summary>
        /// Returns count of people whose height greater or equal to 6
        /// </summary>
        /// <param name="heightArray"></param>
        public static int FindTall(List<double> heightArray)
        {
            return heightArray.Where(item => item >= 6).ToArray().Length;
        }
        
        /// <summary>
        /// Returns count of people whose height lesser or equal to 3
        /// </summary>
        /// <param name="heightArray"></param>
        public static int FindShort(List<double> heightArray)
        {
            return heightArray.Where(item => item <= 3).ToArray().Length;
        }
    }
}
