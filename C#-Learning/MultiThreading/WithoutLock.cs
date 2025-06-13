

namespace C__Learning.MultiThreading
{
    public class WithoutLock : ILearnInterface
    {
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
                File.WriteAllText(path, "");// it also create the file if not exists
                Console.WriteLine("Writing the file without lock: ");
                Thread t1 = new Thread(() => AccessFileWithoutLock(path));
                Thread t2 = new Thread(() => AccessFileWithoutLock(path));

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
