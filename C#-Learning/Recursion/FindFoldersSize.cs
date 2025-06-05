namespace C__Learning.Recursion
{
    public class FindFoldersSize : ILearnInterface
    {
        public void Run()
        {
            Console.WriteLine("Enter the Folder path");
            var path1 = Console.ReadLine();

            if (Directory.Exists(path1))
            {
                Console.WriteLine($"\nCalculating sizes for: {path1}\n");
                var totalSize = GetFoldersSize(path1, 0);
                Console.WriteLine($"\nTotal Size: {ConvertBytesToMB(totalSize)} MB");
            }
            else
            {
                Console.WriteLine("The given directory does not exist.");
            }
        }

        private static long GetFoldersSize(string path, int depth)
        {
            long folderSize = 0;
            string indent = new string(' ', depth * 2); // 2 spaces per level

            try
            {
                foreach (var file in Directory.GetFiles(path))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    folderSize += fileInfo.Length;
                }

                foreach (var dir in Directory.GetDirectories(path))
                {
                    folderSize += GetFoldersSize(dir, depth + 1); // recursion with deeper level
                }

                Console.WriteLine($"{indent}- {new DirectoryInfo(path).Name} - {ConvertBytesToMB(folderSize)} MB");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"{indent}- [Access Denied] {new DirectoryInfo(path).Name} - {ex.Message}");
            }

            return folderSize;
        }

        static double ConvertBytesToMB(long bytes)
        {
            return Math.Round(bytes / (1024.0 * 1024.0), 2);
        }
    }
}
