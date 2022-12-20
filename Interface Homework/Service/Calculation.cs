using Interface_Homework.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Homework.Service
{
    internal class Calculation : ICalculation
    {

        public string Calculate(int num1, int num2, string operation)
        {

            double result = 0;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    return result.ToString();
                    
                case "-":
                    result = num1 - num2;
                    return result.ToString();
                   
                case "*":
                    result = num1 * num2;
                    return result.ToString();
                   
                case "/":
                    result = num1 / num2;
                    return result.ToString();
                   

                default:

                    return "Plase add correct operation";
            }
        }







    }
}
