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
        }

        static async Task AnotherThread()
        {
            Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}");

            await Task.Delay(2000);

            Console.WriteLine($"[Another Thread] Thread ID: {Thread.CurrentThread.ManagedThreadId}");
        }

        
            static async void Thread2()
            {
                Console.WriteLine($"New Thread ID: {Thread.CurrentThread.ManagedThreadId}");
                await Task.Delay(1000);
                Console.WriteLine($"After Await New Thread ID: {Thread.CurrentThread.ManagedThreadId}");
            }

        
        
    }
}
