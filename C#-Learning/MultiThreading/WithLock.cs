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
            try
            {
                string path = @"D:\SampleFolder\SampleTextDocument.txt";
                string directory = Path.GetDirectoryName(path);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                File.WriteAllText(path, ""); // create file if not exists.
                Console.WriteLine("Writing the file with lock: ");
                Thread t1 = new Thread(() => AccessFileWithLock(path));
                Thread t2 = new Thread(() => AccessFileWithLock(path));

                t1.Start();
                t2.Start();
                t1.Join();
                t2.Join();
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine($"Directory not found: {ex.Message}");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Access denied: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
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
