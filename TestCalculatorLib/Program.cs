﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.SimpleCalculator.GetFactorial(5));
            Console.WriteLine(Calculator.SimpleCalculator.Elevate(4, 5));
            Console.ReadKey();
        }
    }
}
