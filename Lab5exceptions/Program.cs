using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Circle circle1 = new Circle(10);
                Console.WriteLine(circle1.ToString()); 
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Circle circle2 = new Circle(-5); 
                Console.WriteLine(circle2.ToString()); 
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Circle circle3 = new Circle(0); 
                Console.WriteLine(circle3.ToString()); 
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}