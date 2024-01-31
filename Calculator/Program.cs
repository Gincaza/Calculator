﻿class Program
{

}
class Calculator
{
    public static double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN;

        switch (op)
        {
            case "a":
                result = num1 + num2;
                break;
            case "s":
                result = num1 - num2;
                break;
            case "m":
                result = num1 * num2;
                break;
            case "d":
                //Se preencher zero ele nao aceita
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                break;
        }
        return result;
    }
}