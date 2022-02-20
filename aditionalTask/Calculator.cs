using System;

namespace aditionalTask
{
    static class Calculator
    {
        public static double Add(double a, double b)
            => a + b;
        public static double Sub(double a, double b)
            => a - b;
        public static double Mul(double a, double b)
            => a * b;
        public static double Div(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Вы пытались поделить число на ноль!");
            return a / b;
        }
        public static bool TryParse(string str, out double result)
        {
            string[] elements = str.Split(" ");
            double a, b;
            result = 0;

            if (elements.Length != 3)
                return false;
            if (elements[1] != "+" && elements[1] != "-"
                && elements[1] != "/" && elements[1] != "*")
                return false;

            if (!double.TryParse(elements[0], out a) || !double.TryParse(elements[2], out b))
                return false;

            switch (elements[1])
            {
                case "+":
                    result = Add(a, b);
                    break;
                case "-":
                    result = Sub(a, b);
                    break;
                case "*":
                    result = Mul(a, b);
                    break;
                case "/":
                    result = Div(a, b);
                    break;
            }

            return true;
        }
    }
}
