﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* https://projecteuler.net/problem=67 */
namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle mytree = new Triangle();
            Console.WriteLine("Sum best path is {0}", mytree.SumTriangle());
            Console.ReadLine();

        }
    }
}
