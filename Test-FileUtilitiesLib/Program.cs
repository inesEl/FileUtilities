using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileUtilities_Lib;

namespace Test_FileUtilitiesLib
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\hello_world.txt";

            // Create the file
            BasicFileUtilities.CreateFile(path);


            // Add content
            var content = "Hello World\n";
            BasicFileUtilities.AddContent(path, content);


            // Read the file & display in the console
            Console.WriteLine("First content added to the file : \n");
            Console.WriteLine(BasicFileUtilities.ReadFileAsString(path));
            Console.WriteLine("Added content to the file : \n");


            // Append some more content
            var username = "Hello, John Doe !\n";
            BasicFileUtilities.AppendContent(path, username);


            // Read the file & display in the console
            foreach (var line in BasicFileUtilities.ReadFileAsArrayOfStrings(path))
            {
                Console.WriteLine(line);
            }


            // Delete the file
            //var isFileDeleted = BasicFileUtilities.DeleteFile(path);
            //var msg = isFileDeleted ? "deleted successfully" : "not deleted";
            //Console.WriteLine("The file is "+ msg);
        }
    }
}
