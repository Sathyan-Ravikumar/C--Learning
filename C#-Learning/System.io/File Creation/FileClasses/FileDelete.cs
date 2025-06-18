using C__Learning.System.io.File_Creation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.System.io.File_Creation.FileClasses
{
    public class FileDelete : IFileDelete
    {
        public void DeleteFile(string path)
        {
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
