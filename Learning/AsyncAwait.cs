using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class AsyncAwait
    {
        public AsyncAwait() { }

        public static async Task TestAsyncAwait() {
            AsyncMethod1(50);
            SyncMethod2(25);

            await CheckException();
        }

        public static async Task CheckException()
        {
            try
            {
                await ThrowException();
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex);
            }
        }
        public static async Task ThrowException() { 
            throw new Exception("Throwing custom exception");
        }
        public static async Task<int> AsyncMethod1(int inp)
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < inp; i++)
                { 
                    Console.WriteLine("M1: "+i.ToString());
                    count++;
                    Task.Delay(100).Wait();
                }
            });
            return count;
        }

        public static void SyncMethod2(int inp)
        {
            for (int i = 0; i < inp; i++)
            { 
                Console.WriteLine("M2: "+i);
                Task.Delay(100).Wait();
            }
        }
    }
}
