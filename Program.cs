using System;

namespace CalculatorV2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Calculator V2");

            bool answer = true;
            int opNum;
        start:
            for (; answer == true;)
            {

                {
                    Console.WriteLine("Enter Opperation code: ");
                    Console.WriteLine("For [+] enter 1 ; For [-] enter 2 ; For [*] enter 3 ; For [/] enter 4");
                    try
                    {
                        opNum = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        goto start;
                    }

                    if (opNum < 1 || opNum > 4)
                    {
                        Console.WriteLine("Incorrect Symbol, reset programm!");
                        goto start;
                    }
                    Converter converter = new Converter();

                    Console.WriteLine("Enter first opperand:");
                    double getop1 = converter.GetDouble();

                    Console.WriteLine("Enter second opperand:");
                    double getop2 = converter.GetDouble();

                    if(getop1 == 0 & getop2 == 0)
                    {
                        Console.WriteLine("Incorrect Symbols, reset programm!");
                        goto start;
                    }
                    Calc calc = new Calc();

                    switch (opNum)
                    {
                        case 1:
                            Console.WriteLine($"{getop1} + {getop2} = " + calc.GetSum(getop1, getop2));
                            break;
                        case 2:
                            Console.WriteLine($"{getop1} - {getop2} = " + calc.GetSub(getop1, getop2));
                            break;
                        case 3:
                            Console.WriteLine($"{getop1} * {getop2} = " + calc.GetMul(getop1, getop2));
                            break;
                        case 4:
                            Console.WriteLine($"{getop1} / {getop2} = " + calc.GetDiv(getop1, getop2));
                            break;
                        default:
                            Console.WriteLine("Unknown Symbol, programm reset!");
                            goto start;
                    }

                    Console.WriteLine("Need another operation? y/n ");
                    char userAnswer = Convert.ToChar(Console.ReadLine());
                    switch (userAnswer)
                    {
                        case 'y':
                            answer = true;
                            break;
                        case 'n':
                            answer = false;
                            break;
                        default:
                            Console.WriteLine("Incorrect Symbol");
                            break;
                    }
                }
            }
        }

    }

    class Calc
    {
        public double GetSum(double op1, double op2)
        {
            return op1 + op2;
        }

        public double GetSub(double op1, double op2)
        {
            return op1 - op2;
        }

        public double GetMul(double op1, double op2)
        {
            return op1 * op2;
        }

        public double GetDiv(double op1, double op2)
        {
            return op1 / op2;
        }

    }

    class Converter
    {
        public double GetDouble()
        {
        anotherTry:
            try
            {
                
                double dDouble = Convert.ToDouble(Console.ReadLine());
                return dDouble;
            }
            catch (FormatException)
            {
                Console.WriteLine("Input string was not in a correct format, try again!");
                goto anotherTry;
            }
        }
    }
}
