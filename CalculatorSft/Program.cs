using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSft
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "5 + 2 - 3 * 2 / 3 ";
            do
            {
                Console.WriteLine("Enter Maths Expression to calculate");
                value = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Answer is :{0} ", sftCalculatorlib.StfCalculator.ExpressionEvaluate(value.ToCharArray()));
                
            }
            while (true);
        }
    }
}
