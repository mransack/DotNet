using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    #region Interface
    interface IAccount {
        void GetInfo();
        void Print() {
            Console.WriteLine("Print Interface");
        }
    }
    class CheckingAccount : IAccount 
    {
        public void GetInfo()
        {
            Console.WriteLine("Print child info"+ typeof(CheckingAccount));
        }
    }
    class SavingAccount : IAccount 
    {
        public void GetInfo()
        {
            Console.WriteLine("Print child info"+ typeof(SavingAccount));
        }
        public void Print() { Console.WriteLine($"Print {typeof(SavingAccount)}"); }
    }
    #endregion

    #region Abstract
    abstract class Account
    {
        private int _acccountno;
        public int AccountNumber
        {
            get { return _acccountno; }
            set { _acccountno = value; }
        }
        public abstract void GetInfo();
    }

    class SavAccount : Account
    {
        public override void GetInfo()
        {
            Console.WriteLine($"Need to print: {AccountNumber}");
        }
    }
    
    class CheckAccount : Account
    {
        public override void GetInfo()
        {
            Console.WriteLine($"Need to print: {AccountNumber}, {typeof(CheckAccount)}");
        }
    }
    #endregion

    public class Polimorphism
    {
        public void DemoPoliMorphism() {
            
            //DemoPoliMorphismThroughInterface();
            //DemoPolimorphismViaAbstract();

            Account accnt = new CheckAccount();
            accnt.GetInfo();
        }
        private void DemoPoliMorphismThroughInterface() 
        {
            Console.WriteLine("\n\nPolimorphism through interface! ");

            List<IAccount> accounts = new List<IAccount>
            {
                new CheckingAccount(),
                new SavingAccount()
            };
            foreach (var account in accounts)
            { 
                account.GetInfo();
                account.Print();
            }
        }

        private void DemoPolimorphismViaAbstract() {
            Console.WriteLine("\n\nPolimorphism via abstract!!");
            List<Account> accounts = new List<Account>();
            SavAccount acc = new SavAccount();
            acc.AccountNumber = 100;
            CheckAccount acc1 = new CheckAccount();
            acc1.AccountNumber = 200;
            accounts.Add(acc);
            accounts.Add(acc1);

            foreach (var account in accounts)
            {
                account.GetInfo();
            }
        }
    }
}
