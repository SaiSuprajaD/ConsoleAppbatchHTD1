using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppbatchHTD1
{
    internal class GreatestofthreeNum
    {
        public static void great()
        {
            
                Console.WriteLine("enter first number");
                int firstnumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter second number");
                int secondnumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter third number ");
                int thirdnumber = Convert.ToInt32(Console.ReadLine());
                if (firstnumber > secondnumber && firstnumber > thirdnumber)
                {
                    Console.WriteLine("the greatest of all three numbers is :" + firstnumber);
                }
                else if (secondnumber > thirdnumber && secondnumber > firstnumber)
                {
                    Console.WriteLine("the greatest of all numbers is : " + secondnumber);
                }
                else if (thirdnumber > firstnumber && thirdnumber > secondnumber)
                {
                    Console.WriteLine("the greatest of all numbers is :" + thirdnumber);
                }
            }
        }
    }


}
    }
}
