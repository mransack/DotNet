using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        protected void protectedMethod()
        {
            Console.WriteLine("Protected parent");
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
        public new void Print(int a)
        {
            Console.WriteLine($"Hello Child: {a}");
        }

        public void protectedMethodTest()
        {
            Console.WriteLine("Protected child");
            protectedMethod();
        }
    }
    public interface TestInterface
    {
        void print();
    }
    public abstract class BaseClass {
        public virtual void Deposit()
        {
            Console.WriteLine("Baase Deposit");
        }
    }

    public class ChildClass : BaseClass, TestInterface {
        public override void Deposit()
        {
            base.Deposit();
            Console.WriteLine("Child Deposit");
        }

        public void print() 
        {
        
        }
    }

}
