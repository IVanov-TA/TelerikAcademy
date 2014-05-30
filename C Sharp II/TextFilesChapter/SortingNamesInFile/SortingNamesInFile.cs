/*(task 6)Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. Example:
	Ivan			George
	Peter			Ivan
	Maria			Maria
	George			Peter
*/
namespace SortingNamesInFile
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    class SortingNamesInFile
    {
        static void Main()
        {
            using (StreamReader sr = new StreamReader(@"..\..\files\unsortedNames.txt"))
            {
                string[] names = sr.ReadToEnd().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                Array.Sort(names);

                using (StreamWriter sw = new StreamWriter(@"..\..\files\sortedNames.txt"))
                {
                    foreach (var name in names)
                    {
                        sw.WriteLine(name);
                    }
                }
            }
        }
    }
}
