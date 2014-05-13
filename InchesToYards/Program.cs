using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InchesToYards
{
    class Program
    {

        public static int InchesToFeet(int a)
        {
            return (a % 36) / 12;



        }

        public static int InchesToInches(int a)
        {
            return a % 12;



        }

        public static int InchesToYards(int a)
        {
            return a / 36;
        }




        static void Main(string[] args)
        {
            int inches = 67;

            InchesToFeet(inches);
            InchesToYards(inches);
            InchesToInches(inches);
          



            int ans = InchesToYards(inches);
            int ans1 = InchesToFeet(inches);
            int ans2 = InchesToInches(inches);

            Console.WriteLine("{0} Yards {1} Feet {2} Inches", ans,ans1,ans2);



        }
    }
}
