//(task 3)Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadContentsFromFile
{
    class ReadContentsFromFile
    {
        static void Main()
        {
            Console.WriteLine("Enter path and filename: ");
            Console.Write("dir:>");
            string path = Console.ReadLine();
            path = path.Replace('\\', Path.DirectorySeparatorChar);

            try
            {
                Console.WriteLine(File.ReadAllText(path));
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Invalid directory");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("{0} don't exist in this file directory: {1}", path.Substring(path.LastIndexOf(Path.DirectorySeparatorChar) + 1), path.Substring(0, path.LastIndexOf(Path.DirectorySeparatorChar) + 1));
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("This directory is only for only administrators");
            }

        }
    }
}
