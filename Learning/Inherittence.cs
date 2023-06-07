using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class Parent
    {
        public void Print()
        {
            Console.WriteLine("Hello Parent");            
        }
    }

    public class Child : Parent
    {
        public Child() 
        {
            
        }
        public new void Print()
        {
            Console.WriteLine("Hello Child");
        }
    }

}
