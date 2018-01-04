using System.IO;
using System.Linq;

namespace MSIBootstrapperDecompiler.Helpers
{
    public static class FileHelper
    {
        /// <summary>
        /// Deletes folder anf its content recursively
        /// </summary>
        /// <param name="currentPath">String:Path to delete</param>
        public static void DeleteFolderContent(string currentPath)
        {
            var di = new DirectoryInfo(currentPath);

            if (di.GetFiles().Any())
            {
                foreach (var file in di.GetFiles())
                {
                    file.Delete();
                }
            }

            if (di.GetDirectories().Any())
            {
                foreach (var dir in di.GetDirectories())
                {
                    DeleteFolderContent(dir.FullName);
                }
            }
            Directory.Delete(currentPath);
        }
    }
}
