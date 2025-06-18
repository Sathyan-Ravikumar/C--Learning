using C__Learning.System.io.File_Creation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.System.io.File_Creation.FileClasses
{
    public class ManageDirectory : IManageDirectory
    {
        public void CreateDirectory(string path)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);
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
        }
    }
}
