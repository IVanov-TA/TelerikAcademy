//(task 4)Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory. Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the finally block.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace DownloadFileFromInternet
{
    class DownloadFileFromInternet
    {
        static void Main()
        {
            Console.Write("Enter site: ");
            string site = Console.ReadLine();
            site = site.Replace('\\', Path.AltDirectorySeparatorChar);
            Console.Write("Enter system location: ");
            string directory = Console.ReadLine();

            //create the full path to download the file with filename equal to the filename in webadress
            directory = string.Concat(directory.Replace('\\', Path.DirectorySeparatorChar), Path.DirectorySeparatorChar, site.Substring(site.LastIndexOf(Path.AltDirectorySeparatorChar) + 1));

            WebClient client = new WebClient();

            try
            {
                using (client)
                {
                    client.DownloadFile(site, directory);
                }

            }
            catch (WebException we)
            {
                Console.WriteLine("Smothing gone wrong with the web {0}", we.Message);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Invalid Directory");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something Gone Bad: {0}", ex.Message);
            }

        }
    }
}