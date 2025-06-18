using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.System.io.File_Creation.Interfaces
{
    public interface IFileWriter
    {
        void CreateFile(string path, string content);
        void AppendToFile(string path, string content);
    }
}
