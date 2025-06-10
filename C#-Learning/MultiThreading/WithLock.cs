using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.MultiThreading
{
    public class WithLock : ILearnInterface
    {
        static readonly object fileLock = new object();
        public void Run()
        {
            string path = @"D:\SampleFolder\SampleTextDocument.txt";
            File.WriteAllText(path, "");
            Console.WriteLine("Writing the file with lock: ");
            Thread t1 = new Thread(() => AccessFileWithLock(path));
            Thread t2 = new Thread(() => AccessFileWithLock(path));

            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            Console.ReadKey();
        }
        static void AccessFileWithLock(string filePath)
        {
            lock (fileLock)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} writes line {i}");
                    File.AppendAllText(filePath,$"Thread {Thread.CurrentThread.ManagedThreadId} writes line {i}\n");
                }
            }
            
        }
    }
}
