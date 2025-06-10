using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.MultiThreading
{
    public class Threading : ILearnInterface
    {
        public void Run() 
        {
            Main().GetAwaiter().GetResult();
        }
        static async Task Main()
        {
            Console.WriteLine($"[Main Thread] ID: {Thread.CurrentThread.ManagedThreadId}");

            await AnotherThread();
            await Task.Run(() => Thread2());
            //tpl- Task Parallel Library
            //sleep, lock - file based(error in shared resourse)
        }

        static async Task AnotherThread()
        {
            Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}");

             Thread.Sleep(2000); // blocks the current thread and resumes execution on the same thread after the time completes

            Console.WriteLine($"[Another Thread] Thread ID: {Thread.CurrentThread.ManagedThreadId}");
        }

            static async void Thread2()
            {
                Console.WriteLine($"New Thread ID: {Thread.CurrentThread.ManagedThreadId}");
                await Task.Delay(1000); //is non-blocking; it delays asynchronously and may resume on the same or a different thread from the thread pool.
            Console.WriteLine($"After Await New Thread ID: {Thread.CurrentThread.ManagedThreadId}");
            }

        
        
    }
}
