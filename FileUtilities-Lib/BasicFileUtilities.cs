using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileUtilities_Lib
{
    public class BasicFileUtilities
    {
        /// <summary>
        /// Add content to a file.
        /// This method deletes existing content in a file and place new content.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="content"></param>
        public static void AddContent(string path, string content)
        {
            File.WriteAllText(path, content);
        }

        /// <summary>
        /// Add content to a file.
        /// This method appends the content to existing content of the file.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="content"></param>
        public static void AppendContent(string path, string content)
        {
            File.AppendAllText(path, content);
        }

        public static bool CreateFile(string path, bool overwriteIfExists = false)
        {
            var fileCreated = false;
            if ((File.Exists(path) && overwriteIfExists) || !File.Exists(path))
            {
                var stream = File.Create(path);
                stream.Close();
                fileCreated = true;
            }
            return fileCreated;
        }

        public static bool DeleteFile(string path)
        {
            File.Delete(path);
            return !File.Exists(path);
        }

        public static string[] ReadFileAsArrayOfStrings(string path)
        {
            return File.ReadAllLines(path);
        }

        public static string ReadFileAsString(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
