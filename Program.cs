using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblemUsingOops_Day_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("... Welcome to Line Comparison Computation ... ");
            LineComparison Linecom = new LineComparison();
            Linecom.length_line();
           
            Console.ReadKey();
        }
    }
}
