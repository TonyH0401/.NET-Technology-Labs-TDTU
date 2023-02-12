using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Xml.XPath;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool valueIndicator = true;
            BasicCalculator bc = new BasicCalculator();
            
            while (valueIndicator == true)
            {
                Console.WriteLine("Please enter the equation with multiple is * and division is /:");
                String userInput = Console.ReadLine();
                bc = new BasicCalculator(userInput);
                if(bc.containLetter(bc.getUserInput()) == true)
                {
                    valueIndicator = true;
                    Console.Clear();
                    Console.WriteLine("Please try again, there were letters");
                }
                else
                {
                    valueIndicator = false;
                }
            }
            bc.infixToPostfix(bc.getUserInput());
            bc.expression();
            Console.WriteLine(bc.answer);
        }
        
        public static bool valueEqualCheck(int val1, int val2)
        {
            return val1 == val2 ? true : false;
        }
        public static String isEvenOdd(int val)
        {
            return ((val % 2) == 0) ? "Even" : "Odd";
        }
        public static bool isPositive(int val)
        {
            return ((val >= 0 )) ? true : false;
        }
        public static bool isLeapYear(int yearval)
        {
            return ((yearval % 4) == 0) ? true : false;
        }
        public static bool isEligibleVote(int userAge)
        {
            return ((userAge >= 18)) ? true : false;
        }
        public static int findLargest(int val1, int val2, int val3)
        {
            return Math.Max(val1, Math.Max(val2, val3));
        }
        public static String calculateQuadraticEquation(int val1, int val2, int val3)
        {
            int delta = val2 * val2 - 4 * (val3 * val1);
            if(delta < 0)
            {
                return "null";
            }
            else if (delta == 0)
            {
                double x = -val2 / (2 * val1);
                return "x1=x2=" + x.ToString();
            }
            else
            {
                double x1 = (-val2 + Math.Sqrt(delta)) / (2 * val1);
                double x2 = (-val2 - Math.Sqrt(delta)) / (2 * val1);
                return "x1 = " + x1.ToString() + ", x2 = " + x2.ToString();
            }
        }
        public static String checkTriangle(double val1, double val2, double val3)
        {
            if ((val1 == val2) && (val2 == val3) && (val1 == val3))
            {
                return "Equilateral";
            } 
            else if ((val1 == val2) || (val2 == val3) || (val1 == val3))
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }
        public static String SimpleCalculation(double val1, double val2)
        {
            Console.WriteLine("--Please choose a number for the operations--\n1.Addition\nSubtraction\nMultiplication\nDivision");
            String inputNumber = Console.ReadLine().Trim();
            //check if value selected is a number
            int n;
            bool isNumeric = int.TryParse(inputNumber, out n);
            double result = 0;
            if(isNumeric == true)
            {
                switch (n)
                {
                    case 1:
                        result = val1 + val2;
                        break;
                    case 2:
                        result = val1 - val2;
                        break;
                    case 3:
                        result = val1 * val2;
                        break;
                    case 4:
                        result = val1 / val2;
                        break;
                    default:
                        Console.WriteLine("The number you have chosen is not in the list. Please try again");
                        result = 0;
                        break;
                }
            }
            else
            {
                Console.WriteLine("The value you have inserted is not a number. Please try again");
                return "null";
            }
            return result.ToString();
        }
        public static String monthConverter(int monthValue)
        {
            if((monthValue <= 0) || (monthValue > 12))
            {
                return "error try again";
            }
            else
            {
                if((monthValue == 1) || (monthValue == 3) || (monthValue == 5) || (monthValue == 7) || (monthValue == 8) || (monthValue == 10) || (monthValue == 12))
                {
                    return "The month of " + monthValue + " has 31 days";
                }
                else if (monthValue == 2)
                {
                    return "The month of " + monthValue + " has 28-29 days";
                }
                else
                {
                    return "The month of " + monthValue + " has 30 days";
                }
            }
        }
        public static bool isPrime(int val)
        {
            bool flag = false;
            for (int i = 2; i <= val / 2; ++i)
            {
                if (val % i == 0)
                {
                    flag = true;
                    break;
                }
            }

            if(!flag)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static String listPrime(int val1, int val2)
        {
            if(val1 > val2)
            {
                int temp = val1;
                val1 = val2;
                val2 = temp;
            }
            String result = "";
            for (int i = val1; val1 <= val2; ++i)
            {
                if(isPrime(i) == true)
                {
                    result = result + i.ToString() + " ";
                }
            }
            return result.Trim();
        }
        public static int[] selectionSort(int[] val)
        {
            int[] arr = new int[val.Length];
            val.CopyTo(arr, 0);
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }
        public static bool isSquare(int val)
        {
            double pre_val = (double)val;
            if((double) val == (Math.Sqrt(pre_val) * Math.Sqrt(pre_val)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static double equationOne(int value)
        {
            double sum = 0;
            for(int i = 0; i < value; i++)
            {
                sum = sum + (2 * i + 1);
            }
            return sum;
        }
    }
}