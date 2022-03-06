using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2._2.Models
{
    public class Calc
    {
        public double first { get; set; }
        public double second { get; set; }
        public string operations { get; set; }

        public Calc() { }

        public Calc(double first_, double second_, string operation)
        {
            first = first_;
            second = second_;
            operations = operation;
        }

        public double Calculate()
        {
            double result;

            switch (operations)
            {
                case "+":
                    result = first + second;
                    break;
                case "-":
                    result = first - second;
                    break;
                case "*":
                    result = first * second;
                    break;
                case "/":
                    result = first / second;
                    break;
                default:
                    result = 0;
                    break;
            }

            return result;
        }
    }
}
