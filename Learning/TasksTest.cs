using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class TasksTest
    {
        public TasksTest()
        {
            
        }
        public void DemoTasks()
        {
            Task taskA = new Task(() =>
            {
                for (int i = 0; i < 5; i++)
                { 
                    Console.WriteLine("Iteration: {0}",i);
                    Task.Delay(1000);
                }
                Console.WriteLine("Completed A");
            });

            Task taskB = new Task(() =>
            {
                Console.WriteLine("Completed B");
            });

            taskA.Start();
            taskB.Start();

            Task.WaitAny(taskA, taskB); //return after any of the task completes
            //Task.WaitAll(taskA, taskB); //Returns when all the task are completed
        }


        public void DemoTaskWhenAll()
        {
            Console.WriteLine("Start {0}", DateTime.Now.ToString());
            List<Task> listTask = new List<Task>();
            listTask.Add(func1());
            listTask.Add(func2());
            Task final = Task.WhenAll(listTask);

            foreach (var item in listTask)
            {
                Console.WriteLine(((Task<int>)item).Result.ToString());
            }
            Console.WriteLine("End {0}", DateTime.Now.ToString());
        }

        public async Task<int> func1()
        {
            await Task.Delay(4000);
            return 1;
        }
        public async Task<int> func2()
        {
            await Task.Delay(2000);
            return 2;
        }
    }
}
