using System;

namespace Calculator
{
    public class ScientificCalculator
    {
        /// <summary>
        /// adds two numbers 
        /// </summary>
        /// <param name="a">integer value </param> 
        /// <param name="b">integer value</param>
        /// <returns> returns integer value ie sum of a and b</returns>
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
        public float Division(float a, float b)
        {
            return a / b;
        }
        public float Percentile(float a, float b)
        {
            return (a / b) * 100;
        }
    }
}