using C__Learning.System.io.File_Creation.Interfaces;
using C__Learning.System.io.File_Creation.FileClasses;

namespace C__Learning.System.io
{
    public class FileCreation : ILearnInterface
    {
        private readonly IManageDirectory _dirManager = new ManageDirectory();
        private readonly IFileWriter _fileWriter = new FileWriter();
        private readonly IFileReader _fileReader = new FileReader();
        private readonly IFileDelete _fileDeleter = new FileDelete();

        public void Run()
        {
            string dirPath = @"D:\SampleFolder\";
            string filePath = Path.Combine(dirPath, "SampleTestFile.txt");
            string initial = "First Word";
            string updated = " Second Word";

            Console.WriteLine("\n- Directory Creation: ");
            _dirManager.CreateDirectory(dirPath);

            Console.WriteLine("\n- File Creation and Initial Write: ");
            _fileWriter.CreateFile(filePath, initial);


            Console.WriteLine("\n- Read File: ");
            _fileReader.ReadFile(filePath);

            Console.WriteLine("\n- Append: ");
            _fileWriter.AppendToFile(filePath, updated);

            Console.WriteLine("\n- Read File After Append: ");
            _fileReader.ReadFile(filePath);

            Console.WriteLine("\n- File Delete: ");
            _fileDeleter.DeleteFile(filePath);


        }
    }
}
