using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10.Homework
{
    public interface ICalculateable
    {
        double Add(double num1, double num2);
        double Subtract(double num1, double num2);
        double Multiply(double num1, double num2);
        double Divide(double num1, double num2);
    }
    public class Calculator : ICalculateable
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public double Divide(double num1, double num2)
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return double.NaN; // NaN represents "Not a Number"
            }
        }
    }
    public class SimpleCalculator : ICalculateable
    {
        public double Add(double num1, double num2)
        {
            double result = num1 + num2;
            PrintResult(num1, num2, "+", result);
            return result;
        }
        public double Subtract(double num1, double num2)
        {
            double result = num1 - num2;
            PrintResult(num1, num2, "-", result);
            return result;
        }
        public double Multiply(double num1, double num2)
        {
            double result = num1 * num2;
            PrintResult(num1, num2, "*", result);
            return result;
        }
        public double Divide(double num1, double num2)
        {
            if (num2 != 0)
            {
                double result = num1 / num2;
                PrintResult(num1, num2, "/", result);
                return result;
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return double.NaN; // NaN represents "Not a Number"
            }
        }
        private void PrintResult(double num1, double num2, string operation, double result)
        {
            Console.WriteLine($"{num1} {operation} {num2} = {result}");
        }
    }
    public class AdvancedCalculator : ICalculateable
    {
        public double Add(double num1, double num2)
        {
            double result = num1 + num2;
            PrintResult(num1, num2, "+", result);
            return result;
        }

        public double Subtract(double num1, double num2)
        {
            double result = num1 - num2;
            PrintResult(num1, num2, "-", result);
            return result;
        }

        public double Multiply(double num1, double num2)
        {
            double result = num1 * num2;
            PrintResult(num1, num2, "*", result);
            return result;
        }

        public double Divide(double num1, double num2)
        {
            if (num2 != 0)
            {
                double result = num1 / num2;
                PrintResult(num1, num2, "/", result);
                return result;
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return double.NaN; // NaN represents "Not a Number"
            }
        }

        public double Exponentiation(double baseNumber, double exponent)
        {
            double result = Math.Pow(baseNumber, exponent);
            PrintResult(baseNumber, exponent, "^", result);
            return result;
        }

        public double SquareRoot(double num)
        {
            if (num >= 0)
            {
                double result = Math.Sqrt(num);
                PrintResult(num, 0.5, "sqrt", result);
                return result;
            }
            else
            {
                Console.WriteLine("Error: Cannot calculate the square root of a negative number.");
                return double.NaN;
            }
        }

        private void PrintResult(double num1, double num2, string operation, double result)
        {
            Console.WriteLine($"{num1} {operation} {num2} = {result}");
        }
    }

    class Program
    {
        static void Main()
        {
            SimpleCalculator simpleCalculator = new SimpleCalculator();

            Console.WriteLine("=== Simple Calculator ===");
            double resultAddSimple = simpleCalculator.Add(5, 7);
            double resultSubtractSimple = simpleCalculator.Subtract(4, 9);
            double resultMultiplySimple = simpleCalculator.Multiply(4, 7);
            double resultDivideSimple = simpleCalculator.Divide(2, 3);

            AdvancedCalculator advancedCalculator = new AdvancedCalculator();

            Console.WriteLine("\n=== Advanced Calculator ===");
            double resultAddAdvanced = advancedCalculator.Add(6, 4);
            double resultSubtractAdvanced = advancedCalculator.Subtract(2, 5);
            double resultMultiplyAdvanced = advancedCalculator.Multiply(3, 1);
            double resultDivideAdvanced = advancedCalculator.Divide(8, 2);
            double resultExponentiationAdvanced = advancedCalculator.Exponentiation(3, 2);
            double resultSquareRootAdvanced = advancedCalculator.SquareRoot(27);

            Console.WriteLine("\n=== Results ===");
            Console.WriteLine($"Simple Calculator - Add: {resultAddSimple}");
            Console.WriteLine($"Simple Calculator - Subtract: {resultSubtractSimple}");
            Console.WriteLine($"Simple Calculator - Multiply: {resultMultiplySimple}");
            Console.WriteLine($"Simple Calculator - Divide: {resultDivideSimple}");

            Console.WriteLine($"Advanced Calculator - Add: {resultAddAdvanced}");
            Console.WriteLine($"Advanced Calculator - Subtract: {resultSubtractAdvanced}");
            Console.WriteLine($"Advanced Calculator - Multiply: {resultMultiplyAdvanced}");
            Console.WriteLine($"Advanced Calculator - Divide: {resultDivideAdvanced}");
            Console.WriteLine($"Advanced Calculator - Exponentiation: {resultExponentiationAdvanced}");
            Console.WriteLine($"Advanced Calculator - Square Root: {resultSquareRootAdvanced}");

        }
    }



}