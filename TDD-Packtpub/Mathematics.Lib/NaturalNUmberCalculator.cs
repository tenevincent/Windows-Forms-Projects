using System;

namespace Mathematics.Lib
{
    public class NaturalNUmberCalculator : INaturalNUmberCalculator
    {
        public NaturalNUmberCalculator()
        {
        }

        public int Add(int v1, int v2)
        {
            return v1 + v2;
        }

        public int Substract(int v1, int v2)
        {
            return (v1 > v2) ? 0 : v1 - v2;
        }

        public int Divide(int v1, int v2)
        {
            return v1 / v2;
        }

        public int Multiply(int v1, int v2)
        {
            return v1 * v2;
        }
    }
}