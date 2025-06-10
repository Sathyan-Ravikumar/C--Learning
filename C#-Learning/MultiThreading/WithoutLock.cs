

namespace C__Learning.MultiThreading
{
    public class WithoutLock : ILearnInterface
    {
        public void Run() 
        {
            string path = @"D:\SampleFolder\SampleTextDocument.txt";
            File.WriteAllText(path, "");
            Console.WriteLine("Writing the file without lock: ");
            Thread t1 = new Thread(() => AccessFileWithoutLock(path));
            Thread t2 = new Thread(() => AccessFileWithoutLock(path));

            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

           Console.ReadKey();

        }

        static void AccessFileWithoutLock(string filePath)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} writes line {i}");
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} writes line {i}");
                }
            }
        }
    }
}
