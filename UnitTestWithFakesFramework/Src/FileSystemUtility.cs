using System.IO;

namespace CSharpTutorials.UnitTestWithFakesFramework
{
    public static class FileSystemUtility
    {
        public static bool FileExists(string filePath)
        {
            return File.Exists(filePath);
        }
    }
}
