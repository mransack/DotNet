using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class TupleLearn
    {
        public static void DesignTupple()
        {
            Console.WriteLine("Tuple is a data structure tht gives you the easiest way to represent a data set which has multiple values that may or may not be related to each other.");
            CreateTuple();

            var tuple = CreateComplexTuple();
            Console.WriteLine(tuple.Item7.name);
        }

        public static void CreateTuple()
        {
            var basic = Tuple.Create("Basic");
            Console.WriteLine(basic);
        }

        public class Testclass 
        {
            public string name { get; }
            public Testclass(string name)
            {
                this.name = name;
            }
        }
        public static Tuple<string, int, bool, string, int, bool,  Testclass> CreateComplexTuple() {
            Tuple<string, int, bool, string, int, bool,  Testclass> tuple = new Tuple<string, int, bool, string, int, bool,  Testclass>("Hello", 007, true, "Bond", 007, true, new Testclass("Bond"));
            Console.WriteLine(tuple);
            return tuple;
        }
    }
}
