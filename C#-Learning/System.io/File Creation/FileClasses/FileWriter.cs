using C__Learning.System.io.File_Creation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.System.io.File_Creation.FileClasses
{
    public class FileWriter : IFileWriter
    {
       
        public void CreateFile(string path, string content)
        {
            try
            {
                if (!File.Exists(path))
                {
                    File.WriteAllText(path, content);
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
        }
        public void AppendToFile(string path, string content)
        {
            try
            {
                File.AppendAllText(path, content); // Append content
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
        }
    }
}
