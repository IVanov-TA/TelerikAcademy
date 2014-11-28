namespace TelerikAcademyForumRSS
{
    using System;
    using Newtonsoft;
    using Newtonsoft.Json;
    using System.Net;
    using System.Xml.Linq;
    using System.Linq;
    using Newtonsoft.Json.Linq;
    using System.Collections.Generic;
    using System.Diagnostics;

    class EntryPoint
    {
        const string RssFeed = "http://forums.academy.telerik.com/feed/qa.rss";
        const string RssPathFile = @"../../qa.xml";
        const string JsonPathFile = @"../../qa.json";
        const string HtmlPathFile = @"..\..\qa.html";

        // REMINDER: PLEASE UNCOMMENT THE NECESSARY

        static void Main()
        {
            // 2) download (TelerikAcademy)Rss feed
            WebClient wc = new WebClient();
            wc.DownloadFile(RssFeed, RssPathFile);


            // 3) Parse XML to Json
            XDocument doc = XDocument.Load(RssPathFile);
            var json = JsonConvert.SerializeXNode(doc, Formatting.Indented);
            FIleUtility.CreateFile(json, JsonPathFile);

            // 4) Select All Question Titles
            var jsonObject = JObject.Parse(json);
            var titles = jsonObject["rss"]["channel"]["item"].Select(t => t["title"]);
            Console.WriteLine(string.Join(Environment.NewLine, titles));

            // 5) Convert Json To POCO
            var jsonItem = jsonObject["rss"]["channel"]["item"].ToString();
            var items = JsonConvert.DeserializeObject<IList<Item>>(jsonItem);
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            // 6) Generate Html file from parsed json objects
            GenerateHtml(items);
        }

        private static void GenerateHtml(IList<Item> items)
        {
            var html = new HtmlCreator();
            var file = html.GenerateHtmlFile(items);

            FIleUtility.CreateFile(file, HtmlPathFile);

            Process.Start(HtmlPathFile);
        }


    }
}
