using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dr_samir_prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("please enter the first number");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the second number");
            int secondnumber = int.Parse(Console.ReadLine());

            int sum = 0;
            
            for (int i =firstnumber ; i <= secondnumber; i++)
            {
                for (int x = 1; x <= i; x++)
                {
                    if (i % x == 0)
                        sum++;
                }
                if (sum == 2)
                {
                    Console.WriteLine(i);
                    sum = 0;
                }
                else
                {
                    sum = 0;
                    
                        }
            }
        }
    }
}
