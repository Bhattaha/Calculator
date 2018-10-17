using System;

namespace Calculator
{
    public class ScientificCalculator
    {
     
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