using System;

namespace CalculatorV2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Calculator V2");

            start:
            Console.WriteLine("Enter Opperation code: ");
            Console.WriteLine("For [+] enter 1 ; For [-] enter 2 ; For [*] enter 3 ; For [/] enter 4");

            int opNum = Convert.ToInt32(Console.ReadLine());

            if(opNum <= 0 && opNum > 4)
            {
                goto start;
            }

            double getop1 = Convert.ToDouble(Console.ReadLine());

            double getop2 = Convert.ToDouble(Console.ReadLine());

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
                    goto start;
                default:
                    Console.WriteLine("Unknown Symbol");
                    break;
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
}
