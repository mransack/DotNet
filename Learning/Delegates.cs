using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Learning.DelegateSample;

namespace Learning
{
    public class Delegates
    {
        //private static WeakReference _weakReference;
        public Delegates()
        {
            Console.WriteLine("Learning Delegates");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("'Delegate' is a type-safe method pointer");
            Console.WriteLine("'Delegation and actual method signature should be same");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void TestMethod()
        {
            SumDelegate method = Sum;
            Console.WriteLine(method(10, 20));
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
    public class DelegateSample
    {
        public delegate int SumDelegate(int num1, int num2);
    }
}
