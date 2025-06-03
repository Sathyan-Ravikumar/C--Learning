using System;
using System.IO;

namespace C__Learning.System.io
{
    public class FileExceptions : ILearnInterface
    {
        public void Run()
        {
            // 1. UnauthorizedAccessException
            try
            {
                var unauthorizedPath = @"C:\Windows\System32\SecretFolder";
                DirectoryInfo dir1 = new DirectoryInfo(unauthorizedPath);
                dir1.Create(); // Trigger read to cause access denial
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Access denied: " + ex.Message);
            }

            // 2. DirectoryNotFoundException
            try
            {
                var invalidDrivePath = @"Z:\NonExistingDrive\SomeFolder";
                DirectoryInfo dir2 = new DirectoryInfo(invalidDrivePath);
                var files = dir2.GetFiles(); // Accessing non-existent drive
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Directory not found: " + ex.Message);
            }

            // 3. IOException (e.g., path is a file, not a directory)
            try
            {
                var filePath = @"D:\SampleFolder\TestAsFile";
                if (File.Exists(filePath)) // check it's a file
                {
                    DirectoryInfo dir3 = new DirectoryInfo(filePath);
                    var files = dir3.GetFiles(); // Treating file as folder → IOException
                }
               
            }
            catch (IOException ex)
            {
                Console.WriteLine("IO Error: " + ex.Message);
            }

            // 4. General Exception 
            try
            {
                string nullPath = null;
                DirectoryInfo dir4 = new DirectoryInfo(nullPath); // Throws ArgumentNullException
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Exception: " + ex.Message);
            }

            // 5. File not found exception
            try
            {
                string filePath = @"D:\SampleFolder\DoesNotExist.txt";
                string content = File.ReadAllText(filePath);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found: " + ex.Message);
            }
        }

    }
}
