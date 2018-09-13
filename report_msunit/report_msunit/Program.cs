using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace report_msunit
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            try
            {
                Console.WriteLine(cal.Division(2, 10));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
    public class Calculator
    { 
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
                return a - b;           
        }
        public int Mult(int a, int b)
        {
            return a * b;
        }
        public double Division(double a, double b)
        {

            if (b != 0)
            {
                return a / b;
            }
            else
            {
                throw new Exception("sasas");
            }
          
        }

    }
}
