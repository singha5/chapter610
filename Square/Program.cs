﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Square
{
    class Program
    {
        public static int exponent(int c)
        {
            Console.WriteLine(c*c);
            return c;
        }

        
        static void Main(string[] args)
        {

            Console.Write("Enter an Integer:");
            String input = Console.ReadLine();

            int n = Convert.ToInt32(input);

            exponent(n);
            

            int squ = exponent(n);

           

            Console.WriteLine("{0} = squared", squ);
        }
    }
}
