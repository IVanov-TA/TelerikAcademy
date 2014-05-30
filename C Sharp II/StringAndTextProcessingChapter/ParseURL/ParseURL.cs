/*(task 12) Write a program that parses an URL address given in the format:

		and extracts from it the [protocol], [server] and [resource] elements. For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
		[protocol] = "http"
		[server] = "www.devbg.org"
		[resource] = "/forum/index.php"
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseURL
{
    class ParseURL
    {
        static void Main()
        {
            string strURL = "http://www.devbg.org/forum/index.php";
            Console.WriteLine("[protocol] = {0}", GetProtocol(strURL));
            Console.WriteLine("[server] = {0}", GetServer(strURL));
            Console.WriteLine("[resource] = {0}",GetResource(strURL));
        }

        static string GetProtocol(string URL)
        {
            string protocol = URL.Substring(0, URL.IndexOf("//") - 1);
            return protocol;
        }

        static string GetServer(string URL)
        {
            string server = URL.Substring(URL.IndexOf("//") + 2, URL.Length - (URL.IndexOf("//") + 2));
            server = server.Substring(0, server.IndexOf("/"));
            return server;
        }

        static string GetResource (string URL)
        {
            string resource = URL.Substring(URL.IndexOf("//") + 2, URL.Length - (URL.IndexOf("//") + 2));
            resource = resource.Substring(resource.IndexOf("/"), resource.Length - resource.IndexOf("/"));
            return resource;
        }
    }
}
