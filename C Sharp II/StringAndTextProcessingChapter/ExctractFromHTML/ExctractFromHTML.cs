//(task 25)Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExctractFromHTML
{
    class ExctractFromHTML
    {
        static void Main()
        {
            if (File.Exists("input.txt"))
            {
                string html = File.ReadAllText("input.txt");
                PrintTitleAndBody(html);
            }
        }

        static string GetContent(string htmlTag)
        {
            StringBuilder content = new StringBuilder();
            for (int i = 0; i < htmlTag.Length; i++)
            {
                StringBuilder text = new StringBuilder();
                if (htmlTag[i] == '>')
                {
                    for (int j = i + 1; j < htmlTag.Length; j++)
                    {
                        if (htmlTag[j] != '<')
                        {
                            text.Append(htmlTag[j]);
                        }
                        else if (htmlTag[j] == '<')
                        {
                            i = j + 1;
                            break;
                        }
                    }
                }
                if (!string.IsNullOrWhiteSpace(text.ToString()))
                {
                    content.AppendLine(text.ToString().Trim());
                }
            }
            return content.ToString();
        }

        static void PrintTitleAndBody(string html)
        {
            int startTitle = html.IndexOf("<title>");
            int endTitle = html.IndexOf("</title>") + "</title>".Length;
            string title = html.Substring(startTitle, endTitle - startTitle);
            int startBody = html.IndexOf("<body>");
            int endBody = html.IndexOf("</body>") + "</body>".Length;
            string body = html.Substring(startBody, endBody - startBody);

            Console.WriteLine("Title : {0}", GetContent(title));
            Console.WriteLine("Body : {0}", GetContent(body));
        }
    }
}
