using System;
using System.Linq.Expressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numb; 
            string arithmicOp, number, numb1, numb2;
            int num1, num2;
         
            Console.WriteLine("Please capture the expression");
            number = Console.ReadLine();
            Console.WriteLine(number);

            string[] words = number.Split(' ');

            numb1 = words[0];
            arithmicOp = words[1];
            numb2 = words[2];

            num1 = getNumber(numb1);
            num2 = getNumber(numb2);

        }

        public static int getNumber(string number)
        {
            int returnedNumber = 0;
            number = number.ToLower();

            switch (number)
            {
                case "one":
                    returnedNumber = 1;
                    break;
                case "two":
                    returnedNumber = 2;
                    break;
                case "three":
                     returnedNumber = 3;
                    break;
                case "four":
                    returnedNumber = 4;
                    break;
                case "five":
                    returnedNumber = 5;
                    break;
                case "six":
                    returnedNumber = 6;
                    break;
                case "seven":
                    returnedNumber = 7;
                    break;
                case "eight":
                    returnedNumber = 8;
                    break;
                case "nine":
                    returnedNumber = 9;
                    break;
                case "ten":
                    returnedNumber = 10;
                    break;
                default:
                    returnedNumber = 0;
                    break;
            } 

            return returnedNumber;
        }


        public static string getOperator(string arthOperator)
        {
            arthOperator = arthOperator.ToLower();
            string arithOperator = "";

            switch (arthOperator)
            {
                case "add":
                    arithOperator = "+";
                    break;
                case "plus":
                    arithOperator = "+";
                    break;
                case "minus":
                    arithOperator = "-";
                    break;
                case "subtract":
                    arithOperator = "-";
                    break;
                case "less":
                    arithOperator = "-";
                    break;
                default:
                    arithOperator = "";
                    break;
            }
                

            return arithOperator;
        }
       
    }
}
