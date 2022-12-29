using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,i, sum;
            Console.WriteLine("enter the first number");
            int mn = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int mx = int.Parse(Console.ReadLine());

            for(n=mn; n<=mx;n++)
            {
                i = 1;  sum=0;
                while(i<n)
                {
                    if (n%i==0)
                        sum += i;
                        i++;
                }
                if (sum == n)
                    Console.WriteLine(n);
            }
            Console.WriteLine(" ");

        }
       
    }
}
