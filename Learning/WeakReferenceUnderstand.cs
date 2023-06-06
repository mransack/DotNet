using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class WeakReferenceUnderstand
    {
        private WeakReference _weakReference;

        private SumDelegate? _sumDelegate;

        public delegate int SumDelegate(int a, int b);

        internal void test()
        { 
            Initialize();
            TestWeaKReference();
            GC.Collect(); //When the above Function's scope get finish the GC collects the object and clear the memory
            Console.WriteLine("Final:"+_weakReference.IsAlive);
        }
        public void TestWeaKReference()
        {
            Console.WriteLine(_weakReference.IsAlive);
            Console.WriteLine(_sumDelegate(10, 20));
            GC.Collect();
            Console.WriteLine(_weakReference.IsAlive);
            _sumDelegate = null;
            GC.Collect();
            Console.WriteLine(_weakReference.IsAlive);

        }
        public void Initialize()
        {
            Calculator calculator = new Calculator();
            _weakReference = new WeakReference(calculator);
            _sumDelegate = calculator.Sum;
        }

    }
    public class Calculator
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

    }
    //public class Delagates
    //{
        
    //}
}
