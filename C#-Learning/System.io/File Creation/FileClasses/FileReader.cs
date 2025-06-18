using C__Learning.System.io.File_Creation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.System.io.File_Creation.FileClasses
{
    public class FileReader : IFileReader
    {
        public void ReadFile(string path)
        {
            try
            {
                string content = File.ReadAllText(path);
                Console.WriteLine("content: " + content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("IO Error while reading: " + ex.Message);
            }
        }
    }
}
