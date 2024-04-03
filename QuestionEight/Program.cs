using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionEight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#8 Write a Promgram to find circumference of a circle");
            Console.WriteLine("=====================================================");
            Console.WriteLine("User input:->");
            Console.WriteLine("+++++++++++++");

            double radius = 0;
            Console.WriteLine("Enter the Radius:->");
            double.TryParse(Console.ReadLine(), out radius);
           

            Console.WriteLine("Result:->");
            Console.WriteLine("*********");
            Console.WriteLine(string.Format("Circumference={0}", (2*Math.PI*radius)));
            Console.ReadKey();
        }
    }
}
