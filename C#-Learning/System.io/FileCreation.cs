using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.System.io
{
    public class FileCreation : ILearnInterface
    {
        public void Run()
        {
            string path = @"D:\SampleFolder\SampleTestFile.txt";
            string initialText = "First Word";
            string updatedText = " Second Word";


            // 1. Creating Directory
            try
            {
                DirectoryInfo dir = new DirectoryInfo(@"D:\SampleFolder\");
                if (!dir.Exists)
                {
                    dir.Create();
                    Console.WriteLine("Directory created Successfully");
                }
                else
                {
                    Console.WriteLine("Directory already exists");
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Access denied: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }
            // 2. Create and Write - textfile
            try
            {
                if (!File.Exists(path))
                {
                    File.WriteAllText(path, initialText);
                    Console.WriteLine("File created and text written successfully.");
                }
                else
                {
                    Console.WriteLine("File already exists.");
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Access denied: " + ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Directory not found: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("IO Error: " + ex.Message);
            }

            // 3. Read and verify initial text
            try
            {
                string content = File.ReadAllText(path);
                Console.WriteLine("Initial content: " + content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("IO Error while reading: " + ex.Message);
            }

            // 4. Append file (add)
            try
            {
                File.AppendAllText(path, updatedText); // Append content
                Console.WriteLine("File updated successfully.");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Access denied on update: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("IO Error on update: " + ex.Message);
            }

            // 5. Read and verify updated text
            try
            {
                string updatedContent = File.ReadAllText(path);
                Console.WriteLine("Updated content: " + updatedContent);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("IO Error while reading updated text: " + ex.Message);
            }

            // 6. Delete the File
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                    Console.WriteLine("File deleted successfully.");
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }

            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Access denied on File Delete: " + ex.Message);
            }
        }
    }
}
