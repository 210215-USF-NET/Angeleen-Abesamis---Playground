using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class BasicMath
    {
        public int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        public int Subtract(int n1, int n2)
        {
            return n1 - n2;
        }

        public int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }

        public int Division(int n1, int n2)
        {
            if (n2 == 0)
                return 0;
            return n1 / n2;
        }
    }
}
