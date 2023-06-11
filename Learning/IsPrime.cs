using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class PrimeClass
    {

        public bool IsPrime(int number)
        {

            if (number < 2) return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("Not a Prime");
                    return false;
                }
            }
            Console.WriteLine("Prime");
            return true;
        }
    }
}
