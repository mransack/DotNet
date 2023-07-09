using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class Classes
    {

    }

    static class StaticClass
    {
        public static void teststatic() {
            Console.WriteLine("static");
        }
    }

    class NonStatic
    {
        public void nonstatic() 
        {
            Console.WriteLine("Non Static");
        }
        public static void staticmethod() {
            Console.WriteLine("Static Method");
        }
    }
    class NonstaticChildClass : NonStatic {
        public NonstaticChildClass() {
            staticmethod();
            nonstatic();
        }
        public void testmethod() {
            staticmethod();
        }
    }
}
