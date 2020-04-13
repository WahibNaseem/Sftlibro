using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sftCalculatorlib
{
    public static class StfCalculator
    {
        public static double ExpressionEvaluate(char[] expression)
        {
            int x = 0;
            return covertPlusSub(expression, ref x);
        }

        private static double covertPlusSub(char[] expression, ref int index)
        {
            double x = convertMulti(expression, ref index);
            while (true)
            {
                char op = expression[index];
                if (op != '+' && op != '-')
                    return x;
                index++;
                double y = convertMulti(expression, ref index);
                if (op == '+')
                    x += y;
                else
                    x -= y;
            }
        }

        private static double convertMulti(char[] expression, ref int index)
        {
            double x = DoubleGet(expression, ref index);
            while (true)
            {
                char op = expression[index];
                if (op != '/' && op != '*')
                    return x;
                index++;
                double y = DoubleGet(expression, ref index);
                if (op == '/')
                    x /= y;
                else
                    x *= y;
            }
        }


        private static double DoubleGet(char[] expression, ref int index)
        {
            string dlb = "";
            while (((int)expression[index] >= 48 && (int)expression[index] <= 57) || expression[index] == 48)
            {
                dlb = dlb + expression[index].ToString();
                index++;
                if (index == expression.Length)
                {
                    index--;
                    break;
                }
            }
            return double.Parse(dlb);
        }
    }
}
