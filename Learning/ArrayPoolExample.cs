using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class ArrayPoolExample
    {
        public static void DemoArrayPool()
        { 
            ArrayPool<int> pool  = ArrayPool<int>.Shared;
            int[] arr = pool.Rent(50); //initialize the array and use
            pool.Return(arr); //once the use is done..we can return the array to pool. Imprtant to return to prevent memory leak
        }
    }
}
