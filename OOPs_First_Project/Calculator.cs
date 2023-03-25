using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_First_Project
{
    
    public class Calculator
    {
        public double Divide(double a,double b) {

            
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }
          public double muliply(int a, int b)
        {

        return a * b;
        }   
        public double add(int a, int b)
        {
            return a + b;
        }
        public double subtract(int a, int b)
        {
            return a - b;
        }

          

        
    }
}
