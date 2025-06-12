using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.MultiThreading
{

    public class TPL : ILearnInterface
    {
        public async void Run()
        {
            Console.WriteLine("Parallel For : ");
            int[] arr ={1,2,3,4,5};
            

            Parallel.For(0, arr.Length, i =>
            {
                Console.WriteLine($"Thread:[{Thread.CurrentThread.ManagedThreadId}], Array Value [{arr[i]}]");  
            });

            //await Task.Delay(1000);
            Task task = new Task(() => SumOfAllElements(arr));
            task.Start();
         }


        static void SumOfAllElements(int[] arr)
        {
            int sum = 0;

            foreach (int element in arr)
            {
                sum += element;
            }
            Console.WriteLine("Sum of all elements in the array is {0}",sum);

        }
    }
}


/*
Task Parallel Library (TPL) - Summary:

- TPL is a part of .NET for writing concurrent and parallel code using tasks.
- It simplifies multithreading by abstracting thread creation and management.
- Key Classes: Task, Task<T>, Parallel, CancellationToken, TaskFactory.
- TPL improves performance by utilizing available CPU cores efficiently.
- TPL automatically manages thread pooling and scheduling.
- Supports cancellation, continuation, exception handling, and coordination.

Use TPL for:
- Running code in the background without blocking UI/main thread.
- Performing parallel operations on collections (e.g., Parallel.For).
- Asynchronously chaining operations (e.g., ContinueWith).
- Handling long-running tasks in a scalable and readable way.
*/
